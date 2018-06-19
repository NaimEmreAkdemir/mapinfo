using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MapInfo;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.ComponentModel;

namespace MyProject
{
    public partial class frminfoclick : Form
    {
        private ListBox lbtablolar;
        Form1 harita;
        public frminfoclick(Form1 _anaform)
        {
            InitializeComponent();
            harita = _anaform;
        }

        private void InitializeComponent()
        {
            this.lbtablolar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbtablolar
            // 
            this.lbtablolar.FormattingEnabled = true;
            this.lbtablolar.Location = new System.Drawing.Point(13, 55);
            this.lbtablolar.Name = "lbtablolar";
            this.lbtablolar.Size = new System.Drawing.Size(120, 95);
            this.lbtablolar.TabIndex = 0;
            // 
            // frminfoclick
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbtablolar);
            this.Name = "frminfoclick";
            this.Load += new System.EventHandler(this.frminfoclick_Load);
            this.ResumeLayout(false);

        }

        private void frminfoclick_Load(object sender, EventArgs e)
        {

        }
        public void listeyi_temizle()
        {
            lbtablolar.Items.Clear();
        }
        public void listeye_ekle(string tablo_adi)
        {
            lbtablolar.Items.Add(tablo_adi);
        }







    }
}
