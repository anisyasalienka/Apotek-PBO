using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apotek_PBO.Models;

namespace Apotek_PBO
{
    public partial class FormDataObatKeluar : Form
    {
        public FormDataObatKeluar()
        {
            InitializeComponent();
        }

        private void FormDataObatKeluar_Load(object sender, EventArgs e)
        {
            using var db = new DBMedStorageContext();

            var obatKeluarData = from c in db.ObatKeluars select c;

            if (obatKeluarData != null)
            {
                if (obatKeluarData.Count() > 0)
                {
                    dgObatKeluarData.DataSource = obatKeluarData.ToList();
                }
                else
                {
                    MessageBox.Show("Tidak ada data yang ditemukan");
                    dgObatKeluarData.DataSource = null;
                }
            }
        }

    }
}
