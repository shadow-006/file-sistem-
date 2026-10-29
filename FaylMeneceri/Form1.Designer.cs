using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FaylMeneceri
{
    partial class Form1
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnQovluq = new Button();
            txtYol = new TextBox();
            grpFayllar = new GroupBox();
            lstFayllar = new ListBox();
            lblMelumat = new Label();
            btnAc = new Button();
            btnSaxla = new Button();
            btnSil = new Button();
            txtMetn = new TextBox();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblTarix = new ToolStripStatusLabel();
            grpFayllar.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();

            btnQovluq.Location = new Point(12, 12);
            btnQovluq.Name = "btnQovluq";
            btnQovluq.Size = new Size(120, 32);
            btnQovluq.TabIndex = 0;
            btnQovluq.Text = "Qovluq seç";
            btnQovluq.UseVisualStyleBackColor = true;
            btnQovluq.Click += btnQovluq_Click;

            txtYol.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtYol.Location = new Point(142, 14);
            txtYol.Name = "txtYol";
            txtYol.PlaceholderText = "Qovluq seçilməyib";
            txtYol.ReadOnly = true;
            txtYol.Size = new Size(706, 23);
            txtYol.TabIndex = 1;

            grpFayllar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpFayllar.Controls.Add(lstFayllar);
            grpFayllar.Location = new Point(12, 56);
            grpFayllar.Name = "grpFayllar";
            grpFayllar.Padding = new Padding(10, 25, 10, 10);
            grpFayllar.Size = new Size(300, 400);
            grpFayllar.TabIndex = 2;
            grpFayllar.TabStop = false;
            grpFayllar.Text = "Fayllar (*.txt)";

            lstFayllar.Dock = DockStyle.Fill;
            lstFayllar.FormattingEnabled = true;
            lstFayllar.IntegralHeight = false;
            lstFayllar.Location = new Point(10, 25);
            lstFayllar.Name = "lstFayllar";
            lstFayllar.Size = new Size(280, 365);
            lstFayllar.TabIndex = 0;
            lstFayllar.SelectedIndexChanged += lstFayllar_SelectedIndexChanged;

            lblMelumat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMelumat.AutoEllipsis = true;
            lblMelumat.Location = new Point(12, 462);
            lblMelumat.Name = "lblMelumat";
            lblMelumat.Size = new Size(300, 20);
            lblMelumat.TabIndex = 3;
            lblMelumat.Text = "Fayl seçilməyib";
            lblMelumat.TextAlign = ContentAlignment.MiddleLeft;

            btnAc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAc.Location = new Point(12, 490);
            btnAc.Name = "btnAc";
            btnAc.Size = new Size(92, 34);
            btnAc.TabIndex = 4;
            btnAc.Text = "Aç";
            btnAc.UseVisualStyleBackColor = true;
            btnAc.Click += btnAc_Click;

            btnSaxla.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSaxla.Location = new Point(112, 490);
            btnSaxla.Name = "btnSaxla";
            btnSaxla.Size = new Size(92, 34);
            btnSaxla.TabIndex = 5;
            btnSaxla.Text = "Yadda saxla";
            btnSaxla.UseVisualStyleBackColor = true;
            btnSaxla.Click += btnSaxla_Click;

            btnSil.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSil.Location = new Point(212, 490);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(92, 34);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;

            txtMetn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMetn.Font = new Font("Consolas", 10F);
            txtMetn.Location = new Point(324, 56);
            txtMetn.Multiline = true;
            txtMetn.Name = "txtMetn";
            txtMetn.ScrollBars = ScrollBars.Vertical;
            txtMetn.Size = new Size(524, 468);
            txtMetn.TabIndex = 7;

            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus, lblTarix });
            statusStrip1.Location = new Point(0, 538);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(860, 22);
            statusStrip1.TabIndex = 8;

            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 17);
            lblStatus.Text = "Hazırdır";

            lblTarix.Name = "lblTarix";
            lblTarix.Size = new Size(160, 17);
            lblTarix.Spring = true;
            lblTarix.Text = "Yaranma tarixi:";
            lblTarix.TextAlign = ContentAlignment.MiddleRight;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 560);
            Controls.Add(btnQovluq);
            Controls.Add(txtYol);
            Controls.Add(grpFayllar);
            Controls.Add(lblMelumat);
            Controls.Add(btnAc);
            Controls.Add(btnSaxla);
            Controls.Add(btnSil);
            Controls.Add(txtMetn);
            Controls.Add(statusStrip1);
            MinimumSize = new Size(720, 540);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fayl Meneceri";
            grpFayllar.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnQovluq;
        private TextBox txtYol;
        private GroupBox grpFayllar;
        private ListBox lstFayllar;
        private Label lblMelumat;
        private Button btnAc;
        private Button btnSaxla;
        private Button btnSil;
        private TextBox txtMetn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel lblTarix;
    }
}
