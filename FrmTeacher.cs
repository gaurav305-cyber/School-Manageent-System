using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class FrmTeacher : Form
    {
        string gender;
       
        public FrmTeacher()
        {
            InitializeComponent();
        }


        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "ZKLTdMy5kwia8gbOdBNMW0T59PN0rGP0eNbT7vCi",
            BasePath= "https://school-c893b-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
       // private string RandID;

        private void FrmTeacher_Load(object sender, EventArgs e)
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
        private void btnMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
            // btnFemale.Enabled = false;
        }

        private void btnFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
            // btnMale.Enabled = false;
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
      /*  public void RandomID()
        {
            Random ran = new Random();
            int number = ran.Next();
            RandID= Convert.ToString("TH" + number);
            
        }*/
        private  void btn_add_Click(object sender, EventArgs e)
        {
            FirebaseResponse resp =  client.Get("Counter/node");
            Counter get = resp.ResultAs<Counter>();
           // MessageBox.Show(get.cnt);
            
           // RandomID();
          //  ID.Text = RandID;
            var tch = new Teacher
            {
                ID = (Convert.ToInt32(get.cnt) + 1).ToString(),
                FullName = fName.Text+" "+mName.Text+" "+ lName.Text,
                Phone = phone.Text,
                PermanentAddress = pAddress.Text,
                CurrentAddress = cAddress.Text,
                Gender = gender,
                DOB = dob.Text,
                ImgString=ImageIntoBase64String(profilePic)
                
            };
            SetResponse response = client.Set("TeacherList/"+tch.ID,tch);
            Teacher result = response.ResultAs<Teacher>();
            
            MessageBox.Show("data inserted successfully"+result.ID);
            var obj = new Counter
            {
                cnt = tch.ID
                
            };
            SetResponse response1 = client.Set("Counter/node", obj);
            
            


          
        }
        public static string ImageIntoBase64String(PictureBox pbox)
        {
            MemoryStream ms = new MemoryStream();
            pbox.Image.Save(ms, pbox.Image.RawFormat);
            return Convert.ToBase64String(ms.ToArray());

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        
    }
}
