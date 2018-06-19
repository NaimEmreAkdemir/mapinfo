using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapInfo;

namespace MyProject
{
    public partial class Form1 : Form
    {
        public static MapInfoApplication mi;
        callback callb;
        public string gMainWinId;  /// 
        public Form1()
        {
            InitializeComponent();
            callb = new callback(this);
            infolist_form = new infolist(this);
           
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (System.Diagnostics.Process p in
                System.Diagnostics.Process.GetProcesses())
                if (p.ProcessName == "MapInfow" & p.MainWindowTitle == "")
                {
                    p.Kill();
                }
            mi = new MapInfoApplication();
            int h = panel1.Handle.ToInt32();
            mi.Do("Set Next Document Parent " + h.ToString() + " Style 1");
            mi.Do("set application window " + h.ToString());
            string ws_path = Application.StartupPath + "\\" + "default5.wor"; 
            mi.Do("Run Application \"" + ws_path + "\"");
            gMainWinId = mi.Eval("windowid(0)");
            mi.Do("create buttonpad \"a\" as toolbutton calling OLE \"info\" id 2001");
            mi.Do("create buttonpad \"b\" as toolbutton calling OLE \"cizgiciz\" drawmode 33 id 2003");
            mi.Do("create buttonpad \"c\" as toolbutton calling OLE \"noktaAt\" id 2004");	
            mi.Do("create buttonpad \"d\" as toolbutton calling OLE \"kapaliAlan\" drawmode 35 id 2005");

            comboboxIller.Items.Clear();
            mi.Do("select*from iller into sel noselect");
            mi.Do("fetch first from sel");
            for (int i = 0; i < Convert.ToInt16(mi.Eval("tableinfo(sel,8)")); i++)
            {
                comboboxIller.Items.Add(mi.Eval("sel.il_adi"));
                mi.Do("fetch next from sel");

            }


            mi.SetCallback(callb);

        }

        cizgiCiz cizdir = new cizgiCiz();
        noktaAt noktaAtalim = new noktaAt();
        region kapaliAlan_form = new region();
        iller iller_form = new iller();
      

        public infolist infolist_form;
        

        public string _tabloadi = string.Empty;
       
        public delegate void mapinfo_delegate();
        //-----------------------------------------------------------------------------------------------------------------
       


        public void draw_line()
        {
            mapinfo_delegate callbackdelegate = new mapinfo_delegate(cizgi_ciz);
            this.Invoke(callbackdelegate);
        }
        public void cizgi_ciz()
        {
            cizdir.yenikayit();
        }

        public void nokta_At()
        {
            mapinfo_delegate callbackdelegate = new mapinfo_delegate(noktaAt);
            this.Invoke(callbackdelegate);
        }

        public void noktaAt()
        {

            noktaAtalim.yenikayit();
        }

        public void kapaliAlan()
        {
            mapinfo_delegate callbackdelegate = new mapinfo_delegate(kapali_Alan);
            this.Invoke(callbackdelegate);
        }

        public void kapali_Alan()
        {
            kapaliAlan_form.yenikayit();
        }

        
        public void info()
        {
            mapinfo_delegate callbackdelegate = new mapinfo_delegate(getinfo);
            this.Invoke(callbackdelegate);
        }

        public void getinfo()
        {
            //tıklanılan yerde birden fazla obje var ise infolist formu ac
            //yok ise sadece bilgisini göster

            if (infolist_form.listcount() > 1)
                infolist_form.Show();
   
            else if (infolist_form.listcount() == 1)
                bilgi_goster(_tabloadi);
        }
        public void bilgi_goster(string tabloadi)
        {
            if (tabloadi == "line")
            {
                cizdir.bilgigoster();
                cizdir.ShowDialog();
            }
            if (tabloadi == "point") 
            {
                noktaAtalim.bilgigoster();
                noktaAtalim.ShowDialog();
            }
            if (tabloadi == "region")
            {
                kapaliAlan_form.bilgigoster();
                kapaliAlan_form.ShowDialog();
            }
            if (tabloadi == "Iller")
            {
                iller_form.bilgigoster();
                iller_form.ShowDialog();
            }
            infolist_form.Focus();
        }
        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            mi.Do("run menu command 1705");
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            mi.Do("run menu command 1706");
        }

        private void btnPan_Click(object sender, EventArgs e)
        {
            mi.Do("run menu command 1702");
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            mi.Do("run menu command 1701");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboboxIller_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxIlceler.Items.Clear();

            mi.Do("select*from Yerlesim where il_adi=\"" + comboboxIller.Text + "\" group by ilce_adi order by ilce_adi into sel");
            mi.Do("fetch first from sel");
            for (int i = 0; i < Convert.ToInt16(mi.Eval("tableinfo(sel,8)")); i++)
            {
                comboboxIlceler.Items.Add(mi.Eval("sel.ilce_adi"));
                mi.Do("fetch next from sel");
            }

        }

        private void comboboxIlceler_SelectedIndexChanged(object sender, EventArgs e)
        {
            mi.Do("select*from yerlesim where il_adi=\"" + comboboxIller.Text + "\" and ilce_adi=\"" + comboboxIlceler.Text + "\" into sel");
            mi.Do("add map layer sel");
            mi.Do("set map zoom entire layer sel");

        }


        private void btnCizgiCiz_Click(object sender, EventArgs e)
        {
          mi.Do("run menu command id 2003");
        }

        private void btnNoktaKoy_Click(object sender, EventArgs e)
        {
            mi.Do("run menu command id 2004");
        }

        private void btnKapalıAlan_Click(object sender, EventArgs e)
        {
            mi.Do("run menu command id 2005");
        }

        private void btnBilgi_Click(object sender, EventArgs e)
        {
            mi.Do("run menu command id 2001");

        }

    }
}
