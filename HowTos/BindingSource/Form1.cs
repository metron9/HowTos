using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingSourceDemo

{
    public partial class Form1 : Form
    {
        public class EmailData
        {
            public string FirstName { set; get; }
            public string LastName { set; get; }
        }

        BindingSource tblNamesBS = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerateList_Click(object sender, EventArgs e)
        {
            BindingList<EmailData> datalist = new BindingList<EmailData>();

            datalist.Add(new EmailData { FirstName = "John", LastName = "Smith"});
            datalist.Add(new EmailData { FirstName = "Mark", LastName = "Robin"});
            datalist.Add(new EmailData { FirstName = "Don", LastName = "Adems" });

            tblNamesBS.DataSource = datalist;

            txtFirstName.DataBindings.Add(new Binding("Text", tblNamesBS, "FirstName"));
            txtLastName.DataBindings.Add(new Binding("Text", tblNamesBS, "LastName"));
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            tblNamesBS.MoveFirst();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tblNamesBS.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tblNamesBS.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tblNamesBS.MoveLast();
        }
    }
}
