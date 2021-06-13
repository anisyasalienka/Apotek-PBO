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
    public partial class FormDataObatMasuk : Form
    {
        public FormDataObatMasuk()
        {
            InitializeComponent();
        }

        private void FormDataObatMasuk_Load(object sender, EventArgs e)
        {
            using var db = new DBMedStorageContext();

            var obatMasukData = from c in db.ObatMasuks select c;

            if (obatMasukData != null)
            {
                if (obatMasukData.Count() > 0)
                {
                    dgObatMasukData.DataSource = obatMasukData.ToList();
                }
                else
                {
                    MessageBox.Show("Tidak ada data yang ditemukan");
                    dgObatMasukData.DataSource = null;
                }
            }
        }

    }
}
