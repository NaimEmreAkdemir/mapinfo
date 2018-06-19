namespace MyProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnPan = new System.Windows.Forms.Button();
            this.btnClick = new System.Windows.Forms.Button();
            this.btnCizgiCiz = new System.Windows.Forms.Button();
            this.btnNoktaKoy = new System.Windows.Forms.Button();
            this.btnKapalıAlan = new System.Windows.Forms.Button();
            this.btnBilgi = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.comboboxIller = new System.Windows.Forms.ComboBox();
            this.comboboxIlceler = new System.Windows.Forms.ComboBox();
            this.labelIller = new System.Windows.Forms.Label();
            this.labelIlceler = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(44, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 244);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomIn.Image")));
            this.btnZoomIn.Location = new System.Drawing.Point(224, 12);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(39, 39);
            this.btnZoomIn.TabIndex = 1;
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomOut.Image")));
            this.btnZoomOut.Location = new System.Drawing.Point(269, 12);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(39, 39);
            this.btnZoomOut.TabIndex = 2;
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnPan
            // 
            this.btnPan.Image = ((System.Drawing.Image)(resources.GetObject("btnPan.Image")));
            this.btnPan.Location = new System.Drawing.Point(89, 12);
            this.btnPan.Name = "btnPan";
            this.btnPan.Size = new System.Drawing.Size(39, 39);
            this.btnPan.TabIndex = 3;
            this.btnPan.UseVisualStyleBackColor = true;
            this.btnPan.Click += new System.EventHandler(this.btnPan_Click);
            // 
            // btnClick
            // 
            this.btnClick.Image = ((System.Drawing.Image)(resources.GetObject("btnClick.Image")));
            this.btnClick.Location = new System.Drawing.Point(44, 12);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(39, 39);
            this.btnClick.TabIndex = 4;
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // btnCizgiCiz
            // 
            this.btnCizgiCiz.Image = ((System.Drawing.Image)(resources.GetObject("btnCizgiCiz.Image")));
            this.btnCizgiCiz.Location = new System.Drawing.Point(134, 12);
            this.btnCizgiCiz.Name = "btnCizgiCiz";
            this.btnCizgiCiz.Size = new System.Drawing.Size(39, 39);
            this.btnCizgiCiz.TabIndex = 5;
            this.btnCizgiCiz.UseVisualStyleBackColor = true;
            this.btnCizgiCiz.Click += new System.EventHandler(this.btnCizgiCiz_Click);
            // 
            // btnNoktaKoy
            // 
            this.btnNoktaKoy.AccessibleDescription = "Nokta At";
            this.btnNoktaKoy.AccessibleName = "Nokta At";
            this.btnNoktaKoy.Image = ((System.Drawing.Image)(resources.GetObject("btnNoktaKoy.Image")));
            this.btnNoktaKoy.Location = new System.Drawing.Point(314, 12);
            this.btnNoktaKoy.Name = "btnNoktaKoy";
            this.btnNoktaKoy.Size = new System.Drawing.Size(39, 39);
            this.btnNoktaKoy.TabIndex = 6;
            this.btnNoktaKoy.Tag = "Nokta At";
            this.btnNoktaKoy.UseVisualStyleBackColor = true;
            this.btnNoktaKoy.Click += new System.EventHandler(this.btnNoktaKoy_Click);
            // 
            // btnKapalıAlan
            // 
            this.btnKapalıAlan.Image = ((System.Drawing.Image)(resources.GetObject("btnKapalıAlan.Image")));
            this.btnKapalıAlan.Location = new System.Drawing.Point(179, 12);
            this.btnKapalıAlan.Name = "btnKapalıAlan";
            this.btnKapalıAlan.Size = new System.Drawing.Size(39, 39);
            this.btnKapalıAlan.TabIndex = 7;
            this.btnKapalıAlan.UseVisualStyleBackColor = true;
            this.btnKapalıAlan.Click += new System.EventHandler(this.btnKapalıAlan_Click);
            // 
            // btnBilgi
            // 
            this.btnBilgi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBilgi.Image = ((System.Drawing.Image)(resources.GetObject("btnBilgi.Image")));
            this.btnBilgi.Location = new System.Drawing.Point(359, 12);
            this.btnBilgi.Name = "btnBilgi";
            this.btnBilgi.Size = new System.Drawing.Size(39, 39);
            this.btnBilgi.TabIndex = 8;
            this.btnBilgi.UseVisualStyleBackColor = true;
            this.btnBilgi.Click += new System.EventHandler(this.btnBilgi_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(404, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(39, 39);
            this.btnCikis.TabIndex = 9;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // comboboxIller
            // 
            this.comboboxIller.FormattingEnabled = true;
            this.comboboxIller.Location = new System.Drawing.Point(507, 8);
            this.comboboxIller.Name = "comboboxIller";
            this.comboboxIller.Size = new System.Drawing.Size(215, 21);
            this.comboboxIller.TabIndex = 10;
            this.comboboxIller.SelectedIndexChanged += new System.EventHandler(this.comboboxIller_SelectedIndexChanged);
            // 
            // comboboxIlceler
            // 
            this.comboboxIlceler.FormattingEnabled = true;
            this.comboboxIlceler.Location = new System.Drawing.Point(507, 35);
            this.comboboxIlceler.Name = "comboboxIlceler";
            this.comboboxIlceler.Size = new System.Drawing.Size(215, 21);
            this.comboboxIlceler.TabIndex = 11;
            this.comboboxIlceler.SelectedIndexChanged += new System.EventHandler(this.comboboxIlceler_SelectedIndexChanged);
            // 
            // labelIller
            // 
            this.labelIller.AutoSize = true;
            this.labelIller.Location = new System.Drawing.Point(466, 11);
            this.labelIller.Name = "labelIller";
            this.labelIller.Size = new System.Drawing.Size(23, 13);
            this.labelIller.TabIndex = 14;
            this.labelIller.Text = "İller";
            // 
            // labelIlceler
            // 
            this.labelIlceler.AutoSize = true;
            this.labelIlceler.Location = new System.Drawing.Point(466, 38);
            this.labelIlceler.Name = "labelIlceler";
            this.labelIlceler.Size = new System.Drawing.Size(35, 13);
            this.labelIlceler.TabIndex = 15;
            this.labelIlceler.Text = "İlceler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 318);
            this.Controls.Add(this.labelIlceler);
            this.Controls.Add(this.labelIller);
            this.Controls.Add(this.comboboxIlceler);
            this.Controls.Add(this.comboboxIller);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnBilgi);
            this.Controls.Add(this.btnNoktaKoy);
            this.Controls.Add(this.btnKapalıAlan);
            this.Controls.Add(this.btnCizgiCiz);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.btnPan);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnPan;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnCizgiCiz;
        private System.Windows.Forms.Button btnNoktaKoy;
        private System.Windows.Forms.Button btnKapalıAlan;
        private System.Windows.Forms.Button btnBilgi;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ComboBox comboboxIller;
        private System.Windows.Forms.ComboBox comboboxIlceler;
        private System.Windows.Forms.Label labelIller;
        private System.Windows.Forms.Label labelIlceler;
    }
}

