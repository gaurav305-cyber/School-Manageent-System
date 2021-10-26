using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;
using System.IO;

namespace SMS
{
   
    public partial class Rstudent : Form
    {
        string gender;
        public Rstudent()
        {
            InitializeComponent();
        }
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "ZKLTdMy5kwia8gbOdBNMW0T59PN0rGP0eNbT7vCi",
            BasePath = "https://school-c893b-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void Rstudent_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("Problem in Interet Connection!!");
            }
        
    }
       

       

        private void btnMale_CheckedChanged_1(object sender, EventArgs e)
        {
            gender = "Male";

        }

        private void btnFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Image files(*.jpg,*.png,*.jpeg,*.bmp)| *.jpg;*.jpeg;*.bmp;*.png| All files (*.*)|*.*";
            if (od.ShowDialog() == DialogResult.OK)
            {
                profilePic.Load(od.FileName);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FirebaseResponse resp = client.Get("Counter1/node");
            Counter1 get = resp.ResultAs<Counter1>();
            // MessageBox.Show(get.cnt);

            // RandomID();
            //  ID.Text = RandID;
            var std = new Student
            {
                ID = (Convert.ToInt32(get.cnt) + 1).ToString(),
                FullName = fName.Text,
                Phone = phone.Text,
                PermanentAddress = pAddress.Text,
                CurrentAddress = cAddress.Text,
                Gender = gender,
                DOB = dob.Text,
                Class = comboBox1.Text,
                Section=comboBox2.Text,
                FatherName=textBox1.Text,
                Occupation=comboBox3.Text,
                Roll=textBox2.Text,
                ImgString = ImageIntoBase64String(profilePic)

            };
            SetResponse response = client.Set("StudentList/" + std.ID, std);
            Student result = response.ResultAs<Student>();

            MessageBox.Show("data inserted successfully" + result.ID);
            var obj = new Counter1
            {
                cnt = std.ID

            };
            SetResponse response1 = client.Set("Counter/node", obj);

        }
        public static string ImageIntoBase64String(PictureBox pbox)
        {
            MemoryStream ms = new MemoryStream();
            pbox.Image.Save(ms, pbox.Image.RawFormat);
            return Convert.ToBase64String(ms.ToArray());

        }
    }
}
