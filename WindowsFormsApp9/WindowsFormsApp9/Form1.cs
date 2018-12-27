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


namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CCSpecialEntities context = new CCSpecialEntities();

            int count = context.Ecolabpos.Count();

            var ctx = new CCSpecialEntities();

            var griddata = ctx.Ecolabpos.AsEnumerable().OrderBy(n => n.SHIPTO).ThenBy(n => n.DUEDATE);

            // Insert Code to convert griddata to DataTable


            //dataGridView1.DataSource = griddata;

            List<Ecolabpo> EPO = new List<Ecolabpo>();



            foreach (Ecolabpo row in griddata)
            {
                Ecolabpo Object = new Ecolabpo();

                Object.PART = row.PART;
                EPO.Add(Object);
            }


            dataGridView1.DataSource = EPO;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            int cell = e.ColumnIndex;

            if ( row >= 0 && (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null))
            {
                this.textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }
    }
}


