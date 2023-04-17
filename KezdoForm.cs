using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Konyvbolt_FT
{
    public partial class KezdoForm : Form
    {
        MySqlConnection MSCONN;
        MySqlCommand MSCOM;

        public KezdoForm()
        {
            InitializeComponent();
        }

        private void KezdoForm_Load(object sender, EventArgs e)
        {

            MySqlConnectionStringBuilder  MSCONNSB = new MySqlConnectionStringBuilder();
            MSCONNSB.Clear();
            MSCONNSB.Server = "localhost";
            MSCONNSB.UserID = "root";
            MSCONNSB.Password = "";
            MSCONNSB.Database = "konyvesbolt";

            MSCONN = new MySqlConnection(MSCONNSB.ConnectionString);

            try
            {

                MSCONN.Open();
                MSCOM = MSCONN.CreateCommand();

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                Environment.Exit(0);

            }
            VasarloBoxUpdate();
            KonyvBoxUpdate();

        }

        private void VasarloBoxUpdate()
        {

            //-adatbázis, vásárlók tábla minden adatát/rekordját betölti a ListBox-ba.
            VasarloBox.Items.Clear();
            try
            {

                MSCOM.CommandText = "SELECT * FROM vasarlo; ";
                using (MySqlDataReader MSDR = MSCOM.ExecuteReader())
                {

                    while (MSDR.Read())
                    {

                        Vasarlo ujVasarlo = new Vasarlo(MSDR.GetInt32("vasarloid"), MSDR.GetString("nev"), MSDR.GetDateTime("szuletesi_datum"), MSDR.GetString("email_cim"), MSDR.GetString("felhasznalonev"));
                        VasarloBox.Items.Add(ujVasarlo);

                    }

                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void KonyvBoxUpdate()
        {

            //-adatbázis, könyv tábla minden adatát/rekordját betölti a ListBox-ba.
            KonyvBox.Items.Clear();
            try
            {

                MSCOM.CommandText = "SELECT * FROM konyv; ";
                using (MySqlDataReader MSDR = MSCOM.ExecuteReader())
                {

                    while (MSDR.Read())
                    {

                        Konyv ujKonyv = new Konyv(MSDR.GetInt32("konyvid"), MSDR.GetString("szerzo"), MSDR.GetString("cim"), MSDR.GetInt32("megjelenesi_ev"), MSDR.GetString("megjelenes_helye"), MSDR.GetString("kiado"), MSDR.GetString("kategoria"), MSDR.GetString("nyelv"), MSDR.GetString("sorozatcim"), MSDR.GetString("isbn"), MSDR.GetInt32("ar"));
                        KonyvBox.Items.Add(ujKonyv);

                    }

                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

    }
}
