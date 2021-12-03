using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AltinFiyatlari
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void VeriCek()
        {
            var url = "https://api.genelpara.com/embed/altin.json";
            var request = WebRequest.Create(url) as HttpWebRequest;
            string jsondata;

            using (var response = request?.GetResponse() as HttpWebResponse)
            {
                var r = new StreamReader(response?.GetResponseStream() ?? throw new InvalidOperationException());
                jsondata = r.ReadToEnd();
            }

            var altin = JsonConvert.DeserializeObject<Root>(jsondata);

            if (altin != null)
            {
                lbl_value_gram_alis.Text = altin.Ga.Alis + @" ₺";
                lbl_value_gram_satis.Text = altin.Ga.Satis + @" ₺";
                lbl_value_ceyrek_alis.Text = altin.C.Alis + @" ₺";
                lbl_value_ceyrek_satis.Text = altin.C.Satis + @" ₺";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VeriCek();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            VeriCek();
        }

        public class Ga
        {
            public string Satis { get; set; }
            public string Alis { get; set; }
            public string Degisim { get; set; }
        }

        public class C
        {
            public string Satis { get; set; }
            public string Alis { get; set; }
            public string Degisim { get; set; }
        }

        public class Y
        {
            public string Satis { get; set; }
            public string Alis { get; set; }
            public string Degisim { get; set; }
        }

        public class T
        {
            public string Satis { get; set; }
            public string Alis { get; set; }
            public string Degisim { get; set; }
        }

        public class Cmr
        {
            public string Satis { get; set; }
            public string Alis { get; set; }
            public string Degisim { get; set; }
        }

        public class Xauusd
        {
            public string Satis { get; set; }
            public string Alis { get; set; }
            public string Degisim { get; set; }
        }

        public class Ata
        {
            public string Satis { get; set; }
            public string Alis { get; set; }
            public string Degisim { get; set; }
        }

        public class _14
        {
            public string Satis { get; set; }
            public string Alis { get; set; }
            public string Degisim { get; set; }
        }

        public class _18
        {
            public string Satis { get; set; }
            public string Alis { get; set; }
            public string Degisim { get; set; }
        }

        public class _22
        {
            public string Satis { get; set; }
            public string Alis { get; set; }
            public string Degisim { get; set; }
        }

        public class Gr
        {
            public string Satis { get; set; }
            public string Alis { get; set; }
            public string Degisim { get; set; }
        }

        public class Gag
        {
            public string Satis { get; set; }
            public string Alis { get; set; }
            public string Degisim { get; set; }
        }

        public class Bsl
        {
            public string Satis { get; set; }
            public string Alis { get; set; }
            public string Degisim { get; set; }
        }

        public class Ikb
        {
            public string Satis { get; set; }
            public string Alis { get; set; }
            public string Degisim { get; set; }
        }

        public class Ha
        {
            public string Satis { get; set; }
            public string Alis { get; set; }
            public string Degisim { get; set; }
        }

        public class Xaueur
        {
            public string Satis { get; set; }
            public string Alis { get; set; }
            public string Degisim { get; set; }
        }

        public class Xauxag
        {
            public string Satis { get; set; }
            public string Alis { get; set; }
            public string Degisim { get; set; }
        }

        public class Root
        {
            public Ga Ga { get; set; }
            public C C { get; set; }
            public Y Y { get; set; }
            public T T { get; set; }
            public Cmr Cmr { get; set; }

            [JsonProperty("XAU/USD")] public Xauusd Xauusd { get; set; }

            public Ata Ata { get; set; }
            public _14 _14 { get; set; }
            public _18 _18 { get; set; }
            public _22 _22 { get; set; }
            public Gr Gr { get; set; }
            public Gag Gag { get; set; }
            public Bsl Bsl { get; set; }
            public Ikb Ikb { get; set; }
            public Ha Ha { get; set; }
            public Xaueur Xaueur { get; set; }

            [JsonProperty("XAU/XAG")] public Xauxag Xauxag { get; set; }
        }
    }
}