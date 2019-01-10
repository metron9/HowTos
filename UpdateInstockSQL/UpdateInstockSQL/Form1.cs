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


namespace UpdateInstockSQL
{
    public partial class Form1 : Form
    {

        string partbasepath = @"K:\ccdataback\partbase.dbf";
        string[] PartNumber;
        string[] PartsOnShelf;
        string[] PartBin;
        string[] JobNumber;
        string[] Unit;
        string[] Desc;
        string[] Price;

        public Form1()
        {
            InitializeComponent();
        }

        public void openPartBase()
        {
            using (var context = new CCSpecialEntities())
            {
                DataTable dt = ParseDBF.ReadDBF(partbasepath);
                //grdDBF.DataSource = dt;
                JobNumber = dt.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
                Unit = dt.Rows.OfType<DataRow>().Select(k => k[1].ToString()).ToArray();
                PartNumber = dt.Rows.OfType<DataRow>().Select(k => k[2].ToString().Trim()).ToArray();
                Desc = dt.Rows.OfType<DataRow>().Select(k => k[3].ToString()).ToArray();
                Price = dt.Rows.OfType<DataRow>().Select(k => k[4].ToString()).ToArray();
                PartsOnShelf = dt.Rows.OfType<DataRow>().Select(k => k[5].ToString()).ToArray();
                PartBin = dt.Rows.OfType<DataRow>().Select(k => k[6].ToString()).ToArray();

                int Max = JobNumber.Length;

                int OnShelf_ = 0;
                float Float_ = 0;

                var partbaserecords = context.PARTBASEs.ToList();

                //List<PARTBASE> NewRecordList = new List<PARTBASE>();
                PARTBASE row = new PARTBASE();

                for (int i = 1; i < Max; i++)
                {
                    row = partbaserecords.FirstOrDefault(x => PartNumber[i] == x.PartNumber.Trim());
                    if (row != null)
                    {
                        Int32.TryParse(PartsOnShelf[i], out OnShelf_);
                        row.OnShelf = OnShelf_;
                        row.BoxNumber = PartBin[i];
                    }
                    else
                    {
                        PARTBASE NewRow = new PARTBASE();

                        float.TryParse(JobNumber[i], out Float_);
                        NewRow.JobNumber = (decimal)Float_;

                        NewRow.Unit = Unit[i];

                        NewRow.PartNumber = PartNumber[i];
                        NewRow.Description = Desc[i];

                        float.TryParse(Price[i], out Float_);
                        NewRow.Price = (decimal)Float_;

                        Int32.TryParse(PartsOnShelf[i], out OnShelf_);
                        NewRow.OnShelf = OnShelf_;

                        NewRow.PartBaseID = Guid.NewGuid();

                        NewRow.BoxNumber = PartBin[i];

                        context.AddToPARTBASEs(NewRow);
                    }
                }
                // Update changes to PARTBASE SQL Table
                context.SaveChanges();
                
            }
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            openPartBase();
        }
    }
}
