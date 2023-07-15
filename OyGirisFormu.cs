using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SecimUygulamasi
{
    public partial class OyGirisFormu : Form
    {
        public OyGirisFormu()
        {
            InitializeComponent();
        }

        public void AddData()
        {
            Ilce data = new Ilce();
            data.IlceAdi = tbxIlce.Text;
            data.AParti = Convert.ToInt32(tbxA.Text);
            data.BParti = Convert.ToInt32(tbxB.Text);
            data.CParti = Convert.ToInt32(tbxC.Text);
            data.DParti = Convert.ToInt32(tbxD.Text);
            data.EParti = Convert.ToInt32(tbxE.Text);
            using (var context = new MyDbContext())
            {
                context.tblIlce.Add(data);
                context.SaveChanges();
            }

        }

        private void btnYolla_Click(object sender, EventArgs e)
        {
            string message = "";
            try
            {
                AddData();
                message = "gönderildi";
            }
            catch (Exception error)
            {
                message = error.Message.ToString();
            }
            MessageBox.Show(message);
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            SonucFormu sonucFormu = new SonucFormu();
            sonucFormu.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class Ilce
    {
        public int Id { get; set; }
        public string IlceAdi { get; set; }
        public int AParti { get; set; }
        public int BParti { get; set; }
        public int CParti { get; set; }
        public int DParti { get; set; }
        public int EParti { get; set; }

    }
    public class MyDbContext : DbContext
    {
        public DbSet<Ilce> tblIlce { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SecimDb;");
        }
    }
}