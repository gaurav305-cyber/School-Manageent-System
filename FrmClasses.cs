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
    public partial class FrmClasses : Form
    {
        public FrmClasses()
        {
            InitializeComponent();
        }
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "ZKLTdMy5kwia8gbOdBNMW0T59PN0rGP0eNbT7vCi",
            BasePath = "https://school-c893b-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void FrmClasses_Load(object sender, EventArgs e)
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
        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;
            FirebaseResponse resp1 = client.Get("Counter/node");
            Counter obj1 = resp1.ResultAs<Counter>();
            int cnt = Convert.ToInt32(obj1.cnt);
            while (true)
            {
                if (i == cnt)
                {
                    break;
                }
                i++;
                FirebaseResponse resp2 = client.Get("TeacherList/" + i);
                Teacher obj2 = resp2.ResultAs<Teacher>();
               
               

                if (obj2.ID==tID.Text)
                {
                    var cls = new ClassP
                    {
                        ClassID = cName.Text+cSection.Text,
                        ClassName = cName.Text,
                        Section = cSection.Text,
                        TeacherID = tID.Text

                    };

                    SetResponse response = client.Set("Classes/" + cls.ClassID, cls);
                    ClassP result = response.ResultAs<ClassP>();
                    cID.Text = cls.ClassID;
                    
                    MessageBox.Show("data inserted successfully" + result.ClassID);
                    
                    break;
                }
                else
                {
                    j++;
                    if (j == cnt)
                    {
                        MessageBox.Show("Teacher doesnot exist");
                    }
                }
                
            }
            

            }
        
    }
}
