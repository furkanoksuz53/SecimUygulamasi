using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecimUygulamasi
{
    public partial class SonucFormu : Form
    {
        public SonucFormu()
        {
            InitializeComponent();
        }
        public List<Ilce> GetData()
        {
            List<Ilce> datas = new List<Ilce>();
            using (var context = new MyDbContext())
            {
                datas = context.tblIlce.ToList();
            }
            foreach (var ilce in datas)
            {
                comboBox1.Items.Add(ilce.IlceAdi);
            }
            return datas;
        }
        public Ilce GetDataByIlceAdi()
        {
            string ilce = comboBox1.Text;
            Ilce data = new Ilce();
            using (var context = new MyDbContext())
            {
                data = context.tblIlce.ToList().Where(x => x.IlceAdi == ilce).FirstOrDefault();
            }
            return data;
        }
        public void SetProcessbar()
        {
            Ilce data = GetDataByIlceAdi();
            int ilceToplamOy = data.AParti + data.BParti + data.CParti + data.DParti + data.EParti;
            lblIlceToplam.Text = ilceToplamOy.ToString();
            progressBarA.Maximum = ilceToplamOy;
            progressBarB.Maximum = ilceToplamOy;
            progressBarC.Maximum = ilceToplamOy;
            progressBarD.Maximum = ilceToplamOy;
            progressBarE.Maximum = ilceToplamOy;

            lblA.Text = $"% {data.AParti * 100 / ilceToplamOy}";
            lblB.Text = $"% {data.BParti * 100 / ilceToplamOy}";
            lblC.Text = $"% {data.CParti * 100 / ilceToplamOy}";
            lblD.Text = $"% {data.DParti * 100 / ilceToplamOy}";
            lblE.Text = $"% {data.EParti * 100 / ilceToplamOy}";


            progressBarA.Value = data.AParti;
            progressBarB.Value = data.BParti;
            progressBarC.Value = data.CParti;
            progressBarD.Value = data.DParti;
            progressBarE.Value = data.EParti;

        }
        private void SonucFormu_Load(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int topE = 0;
            int toplamOy = 0;


            List<Ilce> datas = GetData();
            foreach (Ilce ilce in datas)
            {
                a += ilce.AParti;
                b += ilce.BParti;
                c += ilce.CParti;
                d += ilce.DParti;
                topE += ilce.EParti;
                toplamOy += a + b + c + d + topE;
            }

            progressBarToplamA.Value = a * 100 / toplamOy;
            progressBarToplamB.Value = b * 100 / toplamOy;
            progressBarToplamC.Value = c * 100 / toplamOy;
            progressBarToplamD.Value = d * 100 / toplamOy;
            progressBarToplamE.Value = topE * 100 / toplamOy;

            yuzdeA.Text = $"% {a * 100 / toplamOy}";
            yuzdeB.Text = $"% {b * 100 / toplamOy}";
            yuzdeC.Text = $"% {c * 100 / toplamOy}";
            yuzdeD.Text = $"% {d * 100 / toplamOy}";
            yuzdeE.Text = $"% {topE * 100 / toplamOy}";

            lblToplamOy.Text = toplamOy.ToString();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetProcessbar();
        }
    }
}
