using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;
using System.IO;

namespace SMS
{
    public partial class update : Form
    {
        
        int Id;
        string FName, Pone, gender, CuAddress, PeAddress, Dob;




        Bitmap imge;
        //, ImgString;
        IFirebaseClient client;

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Image files(*.jpg,*.png,*.jpeg,*.bmp)| *.jpg;*.jpeg;*.bmp;*.png| All files (*.*)|*.*";
            if (od.ShowDialog() == DialogResult.OK)
            {
                profilePic.Load(od.FileName);
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "ZKLTdMy5kwia8gbOdBNMW0T59PN0rGP0eNbT7vCi",
            BasePath = "https://school-c893b-default-rtdb.firebaseio.com/"
        };

        private void update_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                MessageBox.Show("Problem in Interet Connection!!");
            }

            fName.Text = FName;
            dob.Text = Dob;
            pAddress.Text = PeAddress;
            cAddress.Text = CuAddress;
            if (gender == "Male")
            {
                btnMale.Checked = true;
            }
            if (gender == "Female")
            {
                btnFemale.Checked = true;
            }
            phone.Text = Pone;
            // MemoryStream ms = new MemoryStream(imge);
            // byte[] img = Convert.FromBase64String(imge);


            profilePic.Image = imge;

        }

        public update(int id, string FullName, string Phone, string Gender, string CurrentAddress, string PermanentAddress,
            string DOB, Bitmap ImgStr)
        {
            InitializeComponent();
            Id = id;
            FName = FullName;
            Pone = Phone;
            gender = Gender;
            CuAddress = CurrentAddress;
            PeAddress = PermanentAddress;
            Dob = DOB;
            imge = ImgStr;
            // ImgString = ImgString;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {

            var tch = new Teacher
            {
                // ID = (Convert.ToInt32(get.cnt) + 1).ToString(),
                ID = Id.ToString(),
                FullName = fName.Text,
                Phone = phone.Text,
                PermanentAddress = pAddress.Text,
                CurrentAddress = cAddress.Text,
                Gender = gender,
                DOB = dob.Text,
                ImgString = ImageIntoBase64String(profilePic)


            };
            
            FirebaseResponse response = client.Update("TeacherList/" + Id.ToString(), tch);
            Teacher result = response.ResultAs<Teacher>();

            MessageBox.Show("data updated successfully" + result.ID);
                fName.Text = string.Empty;
                phone.Text = string.Empty;
                pAddress.Text = string.Empty;
                cAddress.Text = string.Empty;
                gender = string.Empty;
                dob.Text = string.Empty;
                profilePic.Image = null;
        }
        public static string ImageIntoBase64String(PictureBox pbox)
        {
            MemoryStream ms = new MemoryStream();
            pbox.Image.Save(ms, pbox.Image.RawFormat);
            return Convert.ToBase64String(ms.ToArray());

        }


    }
}
