using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RSSOkumaUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void btngetir_Click(object sender, EventArgs e)
        {
            List<haber> kayitlar = xmlcevir();
            lstbaslik.DataSource = kayitlar;

        }
        private List<haber> xmlcevir()
        {
            List<haber> haberkayitlari = new List<haber>();

            XDocument xmlkaynak = XDocument.Load(txtrssurl.Text);
            List<XElement> rows = xmlkaynak.Descendants("item").ToList();
            foreach(XElement item in rows)
            {
                haber temp = new haber();
                temp.başlık = item.Element("title").Value;
                temp.link = item.Element("link").Value;
                temp.aciklama = item.Element("description").Value;

                haberkayitlari.Add(temp);

            }
            return haberkayitlari;

        }

        private void lstbaslik_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox secilendeger = (ListBox)sender;
            haber   secilenhaber = (haber)secilendeger.SelectedItem;
            web_browser.DocumentText = secilenhaber.aciklama;

        }
    }
}
