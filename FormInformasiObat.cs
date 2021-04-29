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

    public partial class FormInformasiObat : Form
    {
        public FormInformasiObat()
        {
            InitializeComponent();
        }

        private void btnTambahObat_Click(object sender, EventArgs e)
        {
            FormKetersediaanObat form = new FormKetersediaanObat();
            form.Show();
        }

        private void FormInformasiObat_Load(object sender, EventArgs e)
        {

        }

        private void btn_InformasiObat_Click(object sender, EventArgs e)
        {
            FormTambahInfoObat form1 = new FormTambahInfoObat();
            form1.Show();
        }
    }
}
