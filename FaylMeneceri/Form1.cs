using System;
using System.IO;
using System.Windows.Forms;

namespace FaylMeneceri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblTarix.Text = "Yaranma tarixi: " + DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void btnQovluq_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Faylların olduğu qovluğu seçin";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    QovluqAc(dialog.SelectedPath);
                }
                catch (Exception xeta)
                {
                    MessageBox.Show(xeta.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void QovluqAc(string qovluq)
        {
            lstFayllar.Items.Clear();
            txtMetn.Clear();
            lblMelumat.Text = "Fayl seçilməyib";
            txtYol.Text = qovluq;

            string[] fayllar = Directory.GetFiles(qovluq, "*.txt");

            foreach (string fayl in fayllar)
            {
                lstFayllar.Items.Add(Path.GetFileName(fayl));
            }

            lblStatus.Text = "Hazırdır | Fayl sayı: " + fayllar.Length;
        }

        private void lstFayllar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFayllar.SelectedItem == null)
            {
                return;
            }

            FileInfo fayl = new FileInfo(FaylYolu());
            lblMelumat.Text = "Ad: " + fayl.Name + " | Ölçü: " + Olcu(fayl.Length);
            lblStatus.Text = "Seçildi: " + fayl.Name;
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            if (FaylSecilmeyib())
            {
                return;
            }

            try
            {
                txtMetn.Text = File.ReadAllText(FaylYolu());
                lblStatus.Text = "Fayl açıldı: " + lstFayllar.SelectedItem.ToString();
            }
            catch (Exception xeta)
            {
                MessageBox.Show(xeta.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaxla_Click(object sender, EventArgs e)
        {
            if (FaylSecilmeyib())
            {
                return;
            }

            try
            {
                File.WriteAllText(FaylYolu(), txtMetn.Text);

                FileInfo fayl = new FileInfo(FaylYolu());
                lblMelumat.Text = "Ad: " + fayl.Name + " | Ölçü: " + Olcu(fayl.Length);
                lblStatus.Text = "Yadda saxlanıldı: " + fayl.Name;
            }
            catch (Exception xeta)
            {
                MessageBox.Show(xeta.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (FaylSecilmeyib())
            {
                return;
            }

            string ad = lstFayllar.SelectedItem.ToString();
            DialogResult cavab = MessageBox.Show(
                ad + " faylı silinsin?",
                "Təsdiq",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (cavab != DialogResult.Yes)
            {
                return;
            }

            try
            {
                File.Delete(FaylYolu());
                QovluqAc(txtYol.Text);
                lblStatus.Text = "Fayl silindi: " + ad;
            }
            catch (Exception xeta)
            {
                MessageBox.Show(xeta.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FaylYolu()
        {
            return Path.Combine(txtYol.Text, lstFayllar.SelectedItem.ToString());
        }

        private bool FaylSecilmeyib()
        {
            if (lstFayllar.SelectedItem == null)
            {
                MessageBox.Show(
                    "Əvvəlcə siyahıdan fayl seçin.",
                    "Xəbərdarlıq",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private string Olcu(long bayt)
        {
            if (bayt < 1024)
            {
                return bayt + " B";
            }

            return (bayt / 1024.0).ToString("0.0") + " KB";
        }
    }
}
