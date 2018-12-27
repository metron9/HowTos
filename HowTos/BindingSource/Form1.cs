using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCSpecialModel;

namespace BindingSourceDemo

{
    public partial class Form1 : Form
    {
        public class EmailData
        {
            public string FirstName { set; get; }
            public string LastName { set; get; }
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerateList_Click(object sender, EventArgs e)
        {
            List<EmailData> datalist = new List<EmailData>();

            datalist.Add(new EmailData { FirstName = "John", LastName = "Smith"});
            datalist.Add(new EmailData { FirstName = "Mark", LastName = "Robin"});
            datalist.Add(new EmailData { FirstName = "Don", LastName = "Adems" });
            

            CCSpecialEntities context = new CCSpecialEntities();

            int count = context.Ecolabpos.Count();

            var ctx = new CCSpecialEntities();
            var griddata = ctx.Ecolabpos.ToList().OrderBy(n => n.SHIPTO).ThenBy(n => n.DUEDATE);
            DataTable dbdataset = new DataTable();
            dbdataset = (DataTable)griddata;

            BindingSource bSource = new BindingSource();


            dataGridView1.DataSource = dbdataset;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }
    }
}
