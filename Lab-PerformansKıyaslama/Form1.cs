using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_PerformansKıyaslama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Üç mimaride bağlamıcaz süreleri texboxa yazdıracağız
         * OrdersID orderstan listboxa getireceğiz
         * text boxta butona basınca süreleri yazıcak
         * siharbaz kullanarak yapıcaz
         * süre butona basılınca başlicak
         * en son ıd gelince süre biticek*/

        NorthwindEntities db = new NorthwindEntities();
        private void btnConnected_Click(object sender, EventArgs e)
        {
            DateTime Once = DateTime.Now;
             SqlConnection connection = new SqlConnection(@"Data Source=ALICAKIR\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True"); //NEREYE BAĞLANCAĞINI SÖYLEYEN YER

            SqlCommand cmd = new SqlCommand("select OrderID from Orders", connection);

            if (connection.State == ConnectionState.Closed)
                connection.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(dr);
            connection.Close();//DataReader kullanıyorsak connection'ı kapatmak kullanıcıya aittir.

           lstconnected.DataSource = dt;
           lstconnected.DisplayMember = "OrderID";

            DateTime Sonra = DateTime.Now;

            TimeSpan gecenSure = Sonra-Once;
            txtConnected.Text = gecenSure.TotalSeconds.ToString();
            

        }

        private void btnDisconnected_Click(object sender, EventArgs e)
        {
            DateTime Once = DateTime.Now;
            SqlDataAdapter dap = new SqlDataAdapter("select OrderID from Orders", @"Data Source=ALICAKIR\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");

            DataTable dt = new DataTable();

            dap.Fill(dt);

            lstDisconnected.DataSource = dt;
            lstDisconnected.DisplayMember = "OrderID";

            DateTime Sonra = DateTime.Now;

            TimeSpan gecenSure =Sonra-Once;
            txtDisconnected.Text = gecenSure.TotalSeconds.ToString();
        }

        private void btnEntityFramwork_Click(object sender, EventArgs e)
        {
            DateTime Once = DateTime.Now;

            lstEntity.DataSource = db.Orders.Select(x => new
            {
              x.OrderID
            }).ToList();

            lstEntity.DisplayMember = "OrderID";


            DateTime Sonra = DateTime.Now;

            TimeSpan gecenSure = Sonra-Once;
            txtEntity.Text = gecenSure.TotalSeconds.ToString();

        }
    }
}
