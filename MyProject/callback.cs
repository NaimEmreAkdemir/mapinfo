using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using MapInfo;
namespace MyProject
{
    [ComVisible(true)]
    public class callback
    {
        Form1 anaform;
        public callback(Form1 _anaform)
        {
            anaform = _anaform;
        }
        public void cizgiciz(string cizgiciz)
        {
           anaform.draw_line();
        }
        public void noktaAt(string noktaAt)
        {
            anaform.nokta_At();
        }
        public void kapaliAlan(string kapaliAlan)
        {
            anaform.kapali_Alan();
        }
       
        public void info(string bos) // 
        {
            string x = Form1.mi.Eval("format$(commandinfo(1), \",#######.###########\")").Replace(',', '.');
            string y = Form1.mi.Eval("format$(commandinfo(2), \",#######.###########\")").Replace(',', '.');
            string tabloadi = string.Empty;
            int i_found = Convert.ToInt32(Form1.mi.Eval("SearchPoint(" + anaform.gMainWinId + "," + x + "," + y + ")"));
            string row_id;
            if (i_found > 0)//tıklanılan yerde tablo var ise
            {
                anaform.infolist_form = new infolist(anaform);
                anaform.infolist_form.listeyi_temizle();

                string _tabloadi = string.Empty;
                for (int i = 1; i <= i_found; i++)
                {
                    tabloadi = Form1.mi.Eval("SearchInfo(" + i.ToString() + ",1)");
                    row_id = Form1.mi.Eval("SearchInfo(" + i.ToString() + ",2)");
                    Form1.mi.Do("Fetch rec " + row_id + " From " + tabloadi);
                    if ((!tabloadi.StartsWith("sel")))// Haritada sel ile baslayan gecici tabloları dikkate alma
                    {
                        if (tabloadi == "line")
                            anaform.infolist_form.listeye_ekle(tabloadi, row_id, Form1.mi.Eval(tabloadi + ".adi"));
                        if (tabloadi == "point")
                            anaform.infolist_form.listeye_ekle(tabloadi, row_id, Form1.mi.Eval(tabloadi + ".adi"));
                        if (tabloadi == "region")
                            anaform.infolist_form.listeye_ekle(tabloadi, row_id, Form1.mi.Eval(tabloadi + ".adi"));
                        if (tabloadi == "Iller")
                            anaform.infolist_form.listeye_ekle(tabloadi, row_id, Form1.mi.Eval(tabloadi + ".il_adi"));
                        _tabloadi = tabloadi;
                    }
                    anaform._tabloadi = _tabloadi;
                }
                anaform.info();
            }
        }
    }
}
