using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace atletikaGUI
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void Keres_Click(object sender, EventArgs e)
        {



        }

        private void GUI_Load(object sender, EventArgs e)
        {

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "atletikavb2017";
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            try
            {

                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT `nemzetek`.`Nemzet`, `versenyekszamok`.`Nem`, `versenyekszamok`.`Versenyszam`, `versenyekszamok`.`VersenyzoNev`, `versenyekszamok`.`Eredmeny`, `versenyekszamok`.`Helyezes` FROM `nemzetek` JOIN `versenyekszamok` ON `nemzetek`.`NemzetId` = `versenyekszamok`.`NemzetKod`;";

                using (MySqlDataReader dr = command.ExecuteReader())
                {

                    while (dr.Read())
                    {

                        verAdatok versenyad = new verAdatok(dr.GetString("nemzetek.Nemzet"), dr.GetString("versenyekszamok.Nem"), dr.GetInt32("versenyekszamok.Versenyszam"), dr.GetString("versenyekszamok.VersenyzoNev"), dr.GetDouble("versenyekszamok.Eredmeny"), dr.GetInt32("versenyekszamok.Helyezes"));
                        AranyermetSzerzettNem.Items.Add(versenyad);

                    }

                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!");
                Environment.Exit(0);

            }

        }


    }
}
