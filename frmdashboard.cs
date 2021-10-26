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
    public partial class frmdashboard : Form
    {
        public frmdashboard()
        {
            InitializeComponent();
           
        }
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "ZKLTdMy5kwia8gbOdBNMW0T59PN0rGP0eNbT7vCi",
            BasePath = "https://school-c893b-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frmdashboard_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("Problem in Interet Connection!!");
            }
        
        FirebaseResponse resp = client.Get("Counter/node");
        Counter get = resp.ResultAs<Counter>();
            // MessageBox.Show(get.cnt);

            // RandomID();
            //  ID.Text = RandID;
            // Teacher tch = new Teacher();
            // SetResponse response = client.Set("TeacherList/" + tch.ID, tch);
            // Teacher result = response.ResultAs<Teacher>();

            // MessageBox.Show("data inserted successfully" + result.ID);
            var obj = new Counter
            {
                cnt = get.cnt,


            };
            label8.Text = obj.cnt;
            FirebaseResponse resp1 = client.Get("Counter1/node");
            Counter1 get1 = resp1.ResultAs<Counter1>();
            // MessageBox.Show(get.cnt);

            // RandomID();
            //  ID.Text = RandID;
            // Teacher tch = new Teacher();
            // SetResponse response = client.Set("TeacherList/" + tch.ID, tch);
            // Teacher result = response.ResultAs<Teacher>();

            // MessageBox.Show("data inserted successfully" + result.ID);
            var obj1 = new Counter1
            {
                cnt = get1.cnt,


            };
            label5.Text = obj1.cnt;
        }
    }
}
