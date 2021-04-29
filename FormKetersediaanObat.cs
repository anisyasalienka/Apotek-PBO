using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotek_PBO
{
    public partial class FormKetersediaanObat : Form
    {
        public FormKetersediaanObat()
        {
            InitializeComponent();
        }

        private void btnObatMasuk_Click(object sender, EventArgs e)
        {
            FormObatMasuk form = new FormObatMasuk();
            form.Show();
        }

        private void btnObatKeluar_Click(object sender, EventArgs e)
        {
            FormObatKeluar form1 = new FormObatKeluar();
            form1.Show();
        }
    }
}
