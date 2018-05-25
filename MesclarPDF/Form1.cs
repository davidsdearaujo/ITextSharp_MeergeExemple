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

namespace MesclarPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMesclar_Click(object sender, EventArgs e)
        {
            var utils = new PDFUtils.PDF();

            var bytes1 = System.IO.File.ReadAllBytes(txtPdf1.Text);
            var bytes2 = System.IO.File.ReadAllBytes(txtPdf2.Text);

            byte[] response = utils.MergePDFs(new[] { bytes1, bytes2 });
            File.WriteAllBytes(txtSaida.Text, response);


            MessageBox.Show("Meerge completed!");
            System.Diagnostics.Process.Start(txtSaida.Text);
        }
    }
}
