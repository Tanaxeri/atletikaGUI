using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using K4os.Compression.LZ4.Internal;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;

namespace atletikaGUI
{
    public partial class GUI : Form
    {
        MySqlConnection connection = null;
        MySqlCommand command = null;
        public GUI()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            connection.Open();
            command.CommandText = "SELECT DISTINCT nemzetek.NemzetID, nemzetek.Nemzet FROM nemzetek, versenyekszamok WHERE nemzetek.NemzetId = versenyekszamok.NemzetKod AND versenyekszamok.Helyezes=1 AND versenyekszamok.Nem = 'F';";
            AranyermetSzerzettNem.Items.Clear();

            using (MySqlDataReader dr1 = command.ExecuteReader())
            {

                while (dr1.Read())
                {

                    Nemzet versenyad1 = new Nemzet(dr1.GetInt32("NemzetID"), dr1.GetString("Nemzet"));
                    AranyermetSzerzettNem.Items.Add(versenyad1);
                }

            }
            button1.Visible = false;
            connection.Close();
        }

        private void Keres_Click(object sender, EventArgs e)
        {

            if (ValaszVersenySzam.SelectedIndex < 0)
            {

                MessageBox.Show("Nem választott ki versenyszámot!");
                return;

            }
            //MessageBox.Show(ValaszVersenySzam.SelectedItem.ToString());
            connection.Open();
            command.CommandText = $"SELECT versenyekszamok.VersenyzoNev, versenyekszamok.Eredmeny, nemzetek.Nemzet FROM versenyekszamok JOIN nemzetek ON versenyekszamok.NemzetKod = nemzetek.NemzetId WHERE versenyekszamok.Versenyszam = '{ValaszVersenySzam.SelectedItem.ToString()}' AND versenyekszamok.Helyezes = '{ValaszErmesHely.Value.ToString()}' AND versenyekszamok.Nem = 'F';";
            using (MySqlDataReader dr1 = command.ExecuteReader())
            {

                while (dr1.Read())
                {

                    nevtext.Text = dr1.GetString("VersenyzoNev");
                    eredmenytext.Text = dr1.GetString("Eredmeny");
                    nemzettext.Text = dr1.GetString("Nemzet");

                }

            }

            connection.Close();
        }

        private void GUI_Load(object sender, EventArgs e)
        {

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "atletikavb2017";
            connection = new MySqlConnection(builder.ConnectionString);
            try
            {

                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT DISTINCT versenyekszamok.Versenyszam FROM `versenyekszamok`";

                using (MySqlDataReader dr = command.ExecuteReader())
                {

                    while (dr.Read())
                    {

                        ValaszVersenySzam.Items.Add(dr.GetString("Versenyszam"));

                    }

                }
                connection.Close();

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!");
                Environment.Exit(0);

            }

        }


    }
}
