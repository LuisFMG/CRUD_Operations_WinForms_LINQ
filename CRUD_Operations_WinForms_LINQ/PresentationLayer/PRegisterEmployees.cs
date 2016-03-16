using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using CRUD_Operations.Business;
using CRUD_Operations.Entities;

namespace CRUD_Operations.Presentation
{
    public partial class PRegisterEmployees : Form
    {
        public PRegisterEmployees()
        {
            InitializeComponent();
        }

        int IdEmployee;
        byte[] Photo;
        bool StatusWebCam = false;

        private void PRegisterEmployee_Load(object sender, EventArgs e)
        {
            BEmployees BEmployees = new BEmployees();

            BEmployees.SearchAndLoadIdEmployee(out IdEmployee);
            IdEmployee++;
            TxtIdEmployee.Text = IdEmployee.ToString();

            Rectangle R = this.ClientRectangle;
            int C = R.Width / 2;

            LblDateOfHire.Text = DateTime.Now.ToLongDateString();
            LblDateOfHire.Location = new Point(C - LblDateOfHire.Width / 2, LblDateOfHire.Location.Y);

            StartWebCam();

            DtpDateOfBirth.MaxDate = DateTime.Now;
            DtpDateOfBirth.MinDate = new DateTime(1940, 01, 01);
        }

        private void BtnRegisterEmployee_Click(object sender, EventArgs e)
        {
            BEmployees BEmployees = new BEmployees();
            EEmployees EmployeeData = new EEmployees();
            Validations Validate = new Validations();

            if (PbPhotoEmployee.Visible)
            {
                EmployeeData.IdEmployee = int.Parse(TxtIdEmployee.Text);
                EmployeeData.DateOfHire = DateTime.Parse(LblDateOfHire.Text);
                EmployeeData.PhotoEmployee = Photo;
                EmployeeData.Username = TxtUsername.Text.ToUpper();
                EmployeeData.UserPassword = TxtUserPassword.Text;
                EmployeeData.EmployeeName = TxtEmployeeName.Text.ToUpper();
                EmployeeData.EmployeeFamilyName = TxtEmployeeFamilyName.Text.ToUpper();
                EmployeeData.DateOfBirth = DtpDateOfBirth.Value;
                EmployeeData.Age = int.Parse(TxtAge.Text);
                EmployeeData.Email = TxtEmail.Text.ToUpper();

                if (Validate.ValidateEmptyFields(EmployeeData))
                {
                    if (BEmployees.RegisterEmployee(EmployeeData))
                    {
                        MessageBox.Show("Empleado registrado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        BEmployees.SearchAndLoadIdEmployee(out IdEmployee);
                        IdEmployee++;
                        TxtIdEmployee.Text = IdEmployee.ToString();
                        TxtUsername.Clear();
                        TxtUserPassword.Clear();
                        TxtEmployeeName.Clear();
                        TxtEmployeeFamilyName.Clear();
                        TxtAge.Text = "0";
                        TxtEmail.Clear();
                        RestartWebCam();
                    }
                    else
                    {
                        MessageBox.Show("Empleado no registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(Validate.SB.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }             
            }
            else
            {
                MessageBox.Show("Capture la foto del empleado para contrinuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnExitRegisterEmployee_Click(object sender, EventArgs e)
        {
            PMainMenu OpenMainMenu = new PMainMenu();

            VspPhotoEmployee.SignalToStop();
            Close();
            OpenMainMenu.Show();
        }

        private void BtnCapturePhoto_Click(object sender, EventArgs e)
        {
            CapturePhoto();
        }

        private void BtnRestarWebCam_Click(object sender, EventArgs e)
        {
            RestartWebCam();
        }

        private void TxtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.RemoveSpace(e);
        }

        private void TxtUserPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.RemoveSpace(e);
        }

        private void TxtEmployeeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.OnlyLetters(e);
        }

        private void TxtEmployeeFamilyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.OnlyLetters(e);
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.RemoveSpace(e);
        }

        private void DtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            TxtAge.Text = (DateTime.Today.AddTicks(-DtpDateOfBirth.Value.Ticks).Year - 1).ToString();
        }

        private void StartWebCam()
        {
            FilterInfoCollection Devices;
            VideoCaptureDevice VideoSource;

            Devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo X in Devices)
            {
                CbDevicesWebCam.Items.Add(X.Name);
            }

            CbDevicesWebCam.SelectedIndex = 0;
            VideoSource = new VideoCaptureDevice(Devices[CbDevicesWebCam.SelectedIndex].MonikerString);
            VspPhotoEmployee.VideoSource = VideoSource;
            VspPhotoEmployee.Start();
        }

        private void RestartWebCam()
        {
            if (StatusWebCam == false)
            {
                StatusWebCam = true;
                PbPhotoEmployee.Visible = false;
                PbPhotoEmployee.Image = null;
                Photo = null;
                StartWebCam();
            }
        }

        private void CapturePhoto()
        {
            MemoryStream MS = new MemoryStream();

            PbPhotoEmployee.Image = VspPhotoEmployee.GetCurrentVideoFrame();
            PbPhotoEmployee.Image.Save(MS, ImageFormat.Jpeg);
            PbPhotoEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
            PbPhotoEmployee.Visible = true;
            Photo = MS.GetBuffer();
            VspPhotoEmployee.SignalToStop();
            StatusWebCam = false;
        }
    }
}