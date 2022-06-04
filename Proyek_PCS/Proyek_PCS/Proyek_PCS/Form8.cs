using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyek_PCS
{
    public partial class Form8 : Form
    {
        public string nonota;
        public Form8()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            NotaBeli repo = new NotaBeli();
            repo.SetDatabaseLogon("root", "", "localhost", "db_proyekpcs");
            repo.SetParameterValue(0, nonota);
            crystalReportViewer1.ReportSource = repo;
            crystalReportViewer1.Refresh();
        }
    }
}
