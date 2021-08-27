using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml; //xml çağırdık

namespace XmlDovizKuruCekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDovizKuruCek_Click(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();//xmldöküman nesnesi oluşturduk
            xmldoc.Load(bugun); //bugunü yükledik
            DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);

            string usdUnit = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Unit").InnerXml;
            lblUnitUsd.Text = string.Format("{0}", usdUnit);
            string usdIsim = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Isim").InnerXml;
            lblUsdCurrency.Text = string.Format("{0}", usdIsim);
            string usdDövizAlis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/ForexBuying").InnerXml;
            lblBuyingUsd.Text = string.Format("{0}", usdDövizAlis);
            string usdDövizSatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/ForexSelling").InnerXml;
            lblSellingUsd.Text = string.Format("{0}", usdDövizSatis);

            string euroUnit = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/Unit").InnerXml;
            lblUnitEuro.Text = string.Format("{0}", euroUnit);
            string euroIsim = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/Isim").InnerXml;
            lblEuroCurrency.Text = string.Format("{0}", euroIsim);
            string euroDövizAlis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/ForexBuying").InnerXml;
            lblBuyingEuro.Text = string.Format("{0}", euroDövizAlis);
            string euroDövizSatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/ForexSelling").InnerXml;
            lblSellingEuro.Text = string.Format("{0}", euroDövizSatis);

            string gbpUnit = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/Unit").InnerXml;
            lblUnitGbp.Text = string.Format("{0}", gbpUnit);
            string gbpIsim = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/Isim").InnerXml;
            lblGbpCurrency.Text = string.Format("{0}", gbpIsim);
            string gbpDövizAlis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/ForexBuying").InnerXml;
            lblBuyingSter.Text = string.Format("{0}", gbpDövizAlis);
            string gbpDövizSatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/ForexSelling").InnerXml;
            lblSellingStr.Text = string.Format("{0}", gbpDövizSatis);

            string sarUnit = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SAR']/Unit").InnerXml;
            lblUnitSar.Text = string.Format("{0}", sarUnit);
            string sarIsim = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SAR']/Isim").InnerXml;
            lblSarCurrency.Text = string.Format("{0}", sarIsim);
            string sarDövizAlis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SAR']/ForexBuying").InnerXml;
            lblBuyingSar.Text = string.Format("{0}", sarDövizAlis);
            string sarDövizSatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SAR']/ForexSelling").InnerXml;
            lblSellingSar.Text = string.Format("{0}", sarDövizSatis);







        }
    }
}
