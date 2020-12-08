using CSVfileExample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVfileExample
{
    public partial class frmCSVbrowse : Form
    {
        public frmCSVbrowse()
        {
            InitializeComponent();
        }

        public List<Product> LoadCSv(string csvFile)
        {
            var query = from file in File.ReadAllLines(csvFile)
                        let data = file.Split(',')
                        select new Product
                        {
                            Name = data[0],
                            quntity = int.Parse(data[1])
                        };
            return query.ToList();
        }

        private void txtBrowae_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            txtBrowae.Text = dlg.FileName;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
           dgvCSVData.DataSource = LoadCSv(txtBrowae.Text);
        }
    }
}
