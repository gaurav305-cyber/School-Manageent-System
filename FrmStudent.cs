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
using System.Threading;

namespace SMS
{
    public partial class FrmStudent : Form
    {

        IFirebaseClient client;
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "ZKLTdMy5kwia8gbOdBNMW0T59PN0rGP0eNbT7vCi",
            BasePath = "https://school-c893b-default-rtdb.firebaseio.com/"
        };
        public FrmStudent()
        {
            InitializeComponent();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            DataTable dt = new DataTable();
           // dataGridView1.Rows.Clear();
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                MessageBox.Show("Problem in Interet Connection!!");
            }
            dt.Columns.Add("ID");
            dt.Columns.Add("Full Name");
            dt.Columns.Add("Phone");
            // dt.Columns.Add("Email");
            dt.Columns.Add("Joining Date");
            dt.Columns.Add("Permanent Address");
            dt.Columns.Add("Current Address");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Image", typeof(Image));


            //dataGridView1.DataSource = dt;
             dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 120;


            dataGridView1.AllowUserToAddRows = false;
            

            // dt.Columns.Add("EDIT", typeof(Button));
            // dt.Columns.Add("Edit", typeof(DataGridViewButtonColumn));

            //dt.Columns.Add("ID");


            int i = 0;
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
                try
                {

                    FirebaseResponse resp2 = client.Get("TeacherList/" + i);
                    Teacher obj2 = resp2.ResultAs<Teacher>();
                    DataRow row = dt.NewRow();

                    row["ID"] = obj2.ID;
                    row["Full Name"] = obj2.FullName;
                    row["Phone"] = obj2.Phone;
                    row["Joining Date"] = obj2.DOB;
                    row["Permanent Address"] = obj2.PermanentAddress;
                    row["Current Address"] = obj2.CurrentAddress;
                    row["Gender"] = obj2.Gender;
                    byte[] img = Convert.FromBase64String(obj2.ImgString);
                    MemoryStream ms = new MemoryStream(img);
                    ms.Write(img, 0, Convert.ToInt32(img.Length));
                    Bitmap bm = new Bitmap(ms, false);
                    row["Image"] = bm;


                    dt.Rows.Add(row);



                }
                catch
                {

                }
            }
            button1.Text = "Refresh";
            Button btn = (Button)sender;
           
            DataView dv = new DataView(dt);
            
            if (btn.Text == "Search")
            {
                dv.RowFilter = "[" + combosarch.Text + "]" +"Like '%" +search.Text+ "%'" ;


            }
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dv;
            DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
            imgcol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            imgcol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            edit.FlatStyle = FlatStyle.Flat;
            edit.HeaderText = "Edit";

            edit.UseColumnTextForButtonValue = true;
            edit.Text = "Edit";

            dataGridView1.Columns.Add(edit);

            // dataGridView1.Rows.Add(edit);


        }
        private void FrmStudent_Load(object sender, EventArgs e)
        {


        }
    
        
       
        private void export()
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                int id;
                string FullName, Phone, Gender, CurrentAddress, PermanentAddress, DOB; 
                Bitmap ImgStr;
               
              
                    //ImgString;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                FullName = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Full Name"].Value);
                Gender = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Gender"].Value);
                DOB = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Joining Date"].Value);
                Phone = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Phone"].Value);
                PermanentAddress = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Permanent Address"].Value);
                CurrentAddress = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Current Address"].Value);
                ImgStr =(Bitmap)dataGridView1.Rows[e.RowIndex].Cells["Image"].Value;

                
                update upt = new update(id, FullName, Phone, Gender, CurrentAddress, PermanentAddress, DOB, ImgStr);
                upt.ShowDialog();
                // MessageBox.Show(id + " Successfully deleted");
            
            }
                   
            
        }

        private void search_Click(object sender, EventArgs e)
        {

        }
    }
}
