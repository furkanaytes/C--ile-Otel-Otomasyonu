using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Atlantis_Hotel
{
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4GHJFLG\\SQLEXPRESS;Initial Catalog=AtlantisHotel;Integrated Security=True");


        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            //oda101

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglanti);
            SqlDataReader oku1=komut1.ExecuteReader();

            while (oku1.Read())
            {
                BtnOda101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda101.Text!="101")
            {
                BtnOda101.BackColor = Color.Red;
            }

            //oda102
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                BtnOda102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda102.Text !="102")
            {
                BtnOda102.BackColor = Color.Red;
            }
            //oda103
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                BtnOda103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda103.Text != "103")
            {
                BtnOda103.BackColor = Color.Red;
            }
            //oda104
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                BtnOda104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda104.Text != "104")
            {
                BtnOda104.BackColor = Color.Red;
            }
            //oda105
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                BtnOda105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda105.Text != "105")
            {
                BtnOda105.BackColor = Color.Red;
            }
            //oda106
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                BtnOda106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda106.Text != "106")
            {
                BtnOda106.BackColor = Color.Red;
            }
            //oda107
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                BtnOda107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda107.Text != "107")
            {
                BtnOda107.BackColor = Color.Red;
            }
            //oda108
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                BtnOda108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda108.Text != "108")
            {
                BtnOda108.BackColor = Color.Red;
            }
            //oda201
            baglanti.Open();
            SqlCommand komut21 = new SqlCommand("select * from Oda201", baglanti);
            SqlDataReader oku21 = komut21.ExecuteReader();
            while (oku21.Read())
            {
                BtnOda201.Text = oku21["Adi"].ToString() + " " + oku21["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda201.Text != "201")
            {
                BtnOda201.BackColor = Color.Red;
            }
            //oda202
            baglanti.Open();
            SqlCommand komut22 = new SqlCommand("select * from Oda202", baglanti);
            SqlDataReader oku22 = komut22.ExecuteReader();
            while (oku22.Read())
            {
                BtnOda202.Text = oku22["Adi"].ToString() + " " + oku22["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda202.Text != "202")
            {
                BtnOda202.BackColor = Color.Red;
            }
            //oda203
            baglanti.Open();
            SqlCommand komut23 = new SqlCommand("select * from Oda203", baglanti);
            SqlDataReader oku23 = komut23.ExecuteReader();
            while (oku23.Read())
            {
                BtnOda203.Text = oku23["Adi"].ToString() + " " + oku23["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda203.Text != "203")
            {
                BtnOda203.BackColor = Color.Red;
            }
            //oda204
            baglanti.Open();
            SqlCommand komut24 = new SqlCommand("select * from Oda204", baglanti);
            SqlDataReader oku24 = komut24.ExecuteReader();
            while (oku24.Read())
            {
                BtnOda204.Text = oku24["Adi"].ToString() + " " + oku24["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda204.Text != "204")
            {
                BtnOda204.BackColor = Color.Red;
            }
            //oda205
            baglanti.Open();
            SqlCommand komut25 = new SqlCommand("select * from Oda205", baglanti);
            SqlDataReader oku25 = komut25.ExecuteReader();
            while (oku25.Read())
            {
                BtnOda205.Text = oku25["Adi"].ToString() + " " + oku25["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda205.Text != "205")
            {
                BtnOda205.BackColor = Color.Red;
            }
            //oda206
            baglanti.Open();
            SqlCommand komut26 = new SqlCommand("select * from Oda206", baglanti);
            SqlDataReader oku26 = komut26.ExecuteReader();
            while (oku26.Read())
            {
                BtnOda206.Text = oku26["Adi"].ToString() + " " + oku26["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda206.Text != "206")
            {
                BtnOda206.BackColor = Color.Red;
            }
            //oda207
            baglanti.Open();
            SqlCommand komut27 = new SqlCommand("select * from Oda207", baglanti);
            SqlDataReader oku27 = komut27.ExecuteReader();
            while (oku27.Read())
            {
                BtnOda207.Text = oku27["Adi"].ToString() + " " + oku27["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda207.Text != "207")
            {
                BtnOda207.BackColor = Color.Red;
            }
            //oda208
            baglanti.Open();
            SqlCommand komut28 = new SqlCommand("select * from Oda208", baglanti);
            SqlDataReader oku28 = komut28.ExecuteReader();
            while (oku28.Read())
            {
                BtnOda208.Text = oku28["Adi"].ToString() + " " + oku28["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda208.Text != "208")
            {
                BtnOda208.BackColor = Color.Red;
            }
            //oda301
            baglanti.Open();
            SqlCommand komut31 = new SqlCommand("select * from Oda301", baglanti);
            SqlDataReader oku31 = komut31.ExecuteReader();
            while (oku31.Read())
            {
                BtnOda301.Text = oku31["Adi"].ToString() + " " + oku31["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda301.Text != "301")
            {
                BtnOda301.BackColor = Color.Red;
            }
            //oda302
            baglanti.Open();
            SqlCommand komut32 = new SqlCommand("select * from Oda302", baglanti);
            SqlDataReader oku32 = komut32.ExecuteReader();
            while (oku32.Read())
            {
                BtnOda302.Text = oku32["Adi"].ToString() + " " + oku32["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda302.Text != "302")
            {
                BtnOda302.BackColor = Color.Red;
            }
            //oda303
            baglanti.Open();
            SqlCommand komut33 = new SqlCommand("select * from Oda303", baglanti);
            SqlDataReader oku33 = komut33.ExecuteReader();
            while (oku33.Read())
            {
                BtnOda303.Text = oku33["Adi"].ToString() + " " + oku33["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda303.Text != "303")
            {
                BtnOda303.BackColor = Color.Red;
            }
            //oda304
            baglanti.Open();
            SqlCommand komut34 = new SqlCommand("select * from Oda304", baglanti);
            SqlDataReader oku34 = komut34.ExecuteReader();
            while (oku34.Read())
            {
                BtnOda304.Text = oku34["Adi"].ToString() + " " + oku34["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda304.Text != "304")
            {
                BtnOda304.BackColor = Color.Red;
            }
            //oda305
            baglanti.Open();
            SqlCommand komut35 = new SqlCommand("select * from Oda305", baglanti);
            SqlDataReader oku35 = komut35.ExecuteReader();
            while (oku35.Read())
            {
                BtnOda305.Text = oku35["Adi"].ToString() + " " + oku35["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda305.Text != "305")
            {
                BtnOda305.BackColor = Color.Red;
            }
            //oda306
            baglanti.Open();
            SqlCommand komut36 = new SqlCommand("select * from Oda306", baglanti);
            SqlDataReader oku36 = komut36.ExecuteReader();
            while (oku36.Read())
            {
                BtnOda306.Text = oku36["Adi"].ToString() + " " + oku36["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda306.Text != "306")
            {
                BtnOda306.BackColor = Color.Red;
            }
            //oda307
            baglanti.Open();
            SqlCommand komut37 = new SqlCommand("select * from Oda307", baglanti);
            SqlDataReader oku37 = komut37.ExecuteReader();
            while (oku37.Read())
            {
                BtnOda307.Text = oku37["Adi"].ToString() + " " + oku37["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda307.Text != "307")
            {
                BtnOda307.BackColor = Color.Red;
            }
            //oda308
            baglanti.Open();
            SqlCommand komut38 = new SqlCommand("select * from Oda308", baglanti);
            SqlDataReader oku38 = komut38.ExecuteReader();
            while (oku38.Read())
            {
                BtnOda308.Text = oku38["Adi"].ToString() + " " + oku38["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda308.Text != "308")
            {
                BtnOda308.BackColor = Color.Red;
            }
            //oda401
            baglanti.Open();
            SqlCommand komut41 = new SqlCommand("select * from Oda401", baglanti);
            SqlDataReader oku41 = komut41.ExecuteReader();
            while (oku41.Read())
            {
                BtnOda401.Text = oku41["Adi"].ToString() + " " + oku41["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda401.Text != "401")
            {
                BtnOda401.BackColor = Color.Red;
            }
            //oda402
            baglanti.Open();
            SqlCommand komut42 = new SqlCommand("select * from Oda402", baglanti);
            SqlDataReader oku42 = komut42.ExecuteReader();
            while (oku42.Read())
            {
                BtnOda402.Text = oku42["Adi"].ToString() + " " + oku42["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda402.Text != "402")
            {
                BtnOda402.BackColor = Color.Red;
            }
            //oda403
            baglanti.Open();
            SqlCommand komut43 = new SqlCommand("select * from Oda403", baglanti);
            SqlDataReader oku43 = komut43.ExecuteReader();
            while (oku43.Read())
            {
                BtnOda403.Text = oku43["Adi"].ToString() + " " + oku43["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda403.Text != "403")
            {
                BtnOda403.BackColor = Color.Red;
            }
            //oda404
            baglanti.Open();
            SqlCommand komut44 = new SqlCommand("select * from Oda404", baglanti);
            SqlDataReader oku44 = komut44.ExecuteReader();
            while (oku44.Read())
            {
                BtnOda404.Text = oku44["Adi"].ToString() + " " + oku44["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda404.Text != "404")
            {
                BtnOda404.BackColor = Color.Red;
            }
            //oda405
            baglanti.Open();
            SqlCommand komut45 = new SqlCommand("select * from Oda405", baglanti);
            SqlDataReader oku45 = komut45.ExecuteReader();
            while (oku45.Read())
            {
                BtnOda405.Text = oku45["Adi"].ToString() + " " + oku45["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda405.Text != "405")
            {
                BtnOda405.BackColor = Color.Red;
            }
            //oda406
            baglanti.Open();
            SqlCommand komut46 = new SqlCommand("select * from Oda406", baglanti);
            SqlDataReader oku46 = komut46.ExecuteReader();
            while (oku46.Read())
            {
                BtnOda406.Text = oku46["Adi"].ToString() + " " + oku46["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda406.Text != "406")
            {
                BtnOda406.BackColor = Color.Red;
            }
            //oda501
            baglanti.Open();
            SqlCommand komut51 = new SqlCommand("select * from Oda501", baglanti);
            SqlDataReader oku51 = komut51.ExecuteReader();
            while (oku51.Read())
            {
                BtnOda501.Text = oku51["Adi"].ToString() + " " + oku51["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda501.Text != "501")
            {
                BtnOda501.BackColor = Color.Red;
            }
            //oda502
            baglanti.Open();
            SqlCommand komut52 = new SqlCommand("select * from Oda502", baglanti);
            SqlDataReader oku52 = komut52.ExecuteReader();
            while (oku52.Read())
            {
                BtnOda502.Text = oku52["Adi"].ToString() + " " + oku52["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda502.Text != "502")
            {
                BtnOda502.BackColor = Color.Red;
            }
            //oda503
            baglanti.Open();
            SqlCommand komut53 = new SqlCommand("select * from Oda503", baglanti);
            SqlDataReader oku53 = komut53.ExecuteReader();
            while (oku53.Read())
            {
                BtnOda503.Text = oku53["Adi"].ToString() + " " + oku53["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda503.Text != "503")
            {
                BtnOda503.BackColor = Color.Red;
            }
            //oda504
            baglanti.Open();
            SqlCommand komut54 = new SqlCommand("select * from Oda504", baglanti);
            SqlDataReader oku54 = komut54.ExecuteReader();
            while (oku54.Read())
            {
                BtnOda504.Text = oku54["Adi"].ToString() + " " + oku54["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda504.Text != "504")
            {
                BtnOda504.BackColor = Color.Red;
            }
            //oda505
            baglanti.Open();
            SqlCommand komut55 = new SqlCommand("select * from Oda505", baglanti);
            SqlDataReader oku55 = komut55.ExecuteReader();
            while (oku55.Read())
            {
                BtnOda505.Text = oku55["Adi"].ToString() + " " + oku55["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda505.Text != "505")
            {
                BtnOda505.BackColor = Color.Red;
            }
            //oda506
            baglanti.Open();
            SqlCommand komut56 = new SqlCommand("select * from Oda506", baglanti);
            SqlDataReader oku56 = komut56.ExecuteReader();
            while (oku56.Read())
            {
                BtnOda506.Text = oku56["Adi"].ToString() + " " + oku56["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda506.Text != "506")
            {
                BtnOda506.BackColor = Color.Red;
            }
            //oda601
            baglanti.Open();
            SqlCommand komut61 = new SqlCommand("select * from Oda601", baglanti);
            SqlDataReader oku61 = komut61.ExecuteReader();
            while (oku61.Read())
            {
                BtnOda601.Text = oku61["Adi"].ToString() + " " + oku61["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda601.Text != "601")
            {
                BtnOda601.BackColor = Color.Red;
            }
            //oda602
            baglanti.Open();
            SqlCommand komut62 = new SqlCommand("select * from Oda602", baglanti);
            SqlDataReader oku62 = komut62.ExecuteReader();
            while (oku62.Read())
            {
                BtnOda602.Text = oku62["Adi"].ToString() + " " + oku62["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda602.Text != "602")
            {
                BtnOda602.BackColor = Color.Red;
            }
            //oda603
            baglanti.Open();
            SqlCommand komut63 = new SqlCommand("select * from Oda603", baglanti);
            SqlDataReader oku63 = komut63.ExecuteReader();
            while (oku63.Read())
            {
                BtnOda603.Text = oku63["Adi"].ToString() + " " + oku63["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda603.Text != "603")
            {
                BtnOda603.BackColor = Color.Red;
            }
            //oda604
            baglanti.Open();
            SqlCommand komut64 = new SqlCommand("select * from Oda604", baglanti);
            SqlDataReader oku64 = komut64.ExecuteReader();
            while (oku64.Read())
            {
                BtnOda604.Text = oku64["Adi"].ToString() + " " + oku64["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda604.Text != "604")
            {
                BtnOda604.BackColor = Color.Red;
            }
            //oda701
            baglanti.Open();
            SqlCommand komut71 = new SqlCommand("select * from Oda701", baglanti);
            SqlDataReader oku71 = komut71.ExecuteReader();
            while (oku71.Read())
            {
                BtnOda701.Text = oku71["Adi"].ToString() + " " + oku71["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda701.Text != "701")
            {
                BtnOda701.BackColor = Color.Red;
            }
            //oda702
            baglanti.Open();
            SqlCommand komut72 = new SqlCommand("select * from Oda702", baglanti);
            SqlDataReader oku72 = komut72.ExecuteReader();
            while (oku72.Read())
            {
                BtnOda702.Text = oku72["Adi"].ToString() + " " + oku72["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda702.Text != "702")
            {
                BtnOda702.BackColor = Color.Red;
            }
            //oda703
            baglanti.Open();
            SqlCommand komut73 = new SqlCommand("select * from Oda703", baglanti);
            SqlDataReader oku73 = komut73.ExecuteReader();
            while (oku73.Read())
            {
                BtnOda703.Text = oku73["Adi"].ToString() + " " + oku73["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda703.Text != "703")
            {
                BtnOda703.BackColor = Color.Red;
            }
            //oda704
            baglanti.Open();
            SqlCommand komut74 = new SqlCommand("select * from Oda704", baglanti);
            SqlDataReader oku74 = komut74.ExecuteReader();
            while (oku74.Read())
            {
                BtnOda704.Text = oku74["Adi"].ToString() + " " + oku74["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda704.Text != "704")
            {
                BtnOda704.BackColor = Color.Red;
            }
            //oda705
            baglanti.Open();
            SqlCommand komut75 = new SqlCommand("select * from Oda705", baglanti);
            SqlDataReader oku75 = komut75.ExecuteReader();
            while (oku75.Read())
            {
                BtnOda705.Text = oku75["Adi"].ToString() + " " + oku75["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda705.Text != "705")
            {
                BtnOda705.BackColor = Color.Red;
            }
            //oda801
            baglanti.Open();
            SqlCommand komut81 = new SqlCommand("select * from Oda801", baglanti);
            SqlDataReader oku81 = komut81.ExecuteReader();
            while (oku81.Read())
            {
                BtnOda801.Text = oku81["Adi"].ToString() + " " + oku81["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda801.Text != "801")
            {
                BtnOda801.BackColor = Color.Red;
            }
            //oda802
            baglanti.Open();
            SqlCommand komut82 = new SqlCommand("select * from Oda802", baglanti);
            SqlDataReader oku82 = komut82.ExecuteReader();
            while (oku82.Read())
            {
                BtnOda802.Text = oku82["Adi"].ToString() + " " + oku82["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda802.Text != "802")
            {
                BtnOda802.BackColor = Color.Red;
            }
            //oda803
            baglanti.Open();
            SqlCommand komut83 = new SqlCommand("select * from Oda803", baglanti);
            SqlDataReader oku83 = komut83.ExecuteReader();
            while (oku83.Read())
            {
                BtnOda803.Text = oku83["Adi"].ToString() + " " + oku83["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda803.Text != "803")
            {
                BtnOda803.BackColor = Color.Red;
            }
            //odaKing1
            baglanti.Open();
            SqlCommand komutkral1 = new SqlCommand("select * from OdaKing1", baglanti);
            SqlDataReader okukral1 = komutkral1.ExecuteReader();
            while (okukral1.Read())
            {
                BtnOdaKing1.Text = okukral1["Adi"].ToString() + " " + okukral1["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOdaKing1.Text != "Kral Odası1")
            {
                BtnOdaKing1.BackColor = Color.Red;
            }
            //odaKing2
            baglanti.Open();
            SqlCommand komutkral2 = new SqlCommand("select * from OdaKing2", baglanti);
            SqlDataReader okukral2 = komutkral2.ExecuteReader();
            while (okukral2.Read())
            {
                BtnOdaKing2.Text = okukral2["Adi"].ToString() + " " + okukral2["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOdaKing2.Text != "Kral Odası2")
            {
                BtnOdaKing2.BackColor = Color.Red;
            }

        }

     

        private void BtnOda308_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(BtnOda308.Text + "," + "Oda Numarası:308");
        }

        private void BtnOda107_MouseClick_1(object sender, MouseEventArgs e)
        {
            MessageBox.Show(BtnOda107.Text + "," + "Oda Numarası:107");
        }
    }
}
