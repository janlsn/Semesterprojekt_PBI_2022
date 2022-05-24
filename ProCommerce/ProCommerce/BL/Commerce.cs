using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProCommerce.DB;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProCommerce.BL
{
    class Commerce
    {
        public MySqlDataReader HentAlt(string p_search)
        {
            string query = "select Adresse, Postnr, Bynavn, Telefon, Varenummer, Navn as 'Produktnavn', Antal, replace(Enhedspris, '.', ',') as Pris, Lokationer.Lokationsnr as 'Lokation', Reoler.Reolnr as 'Reolnr', Hylder.Hyldenr as 'Hyldenr', if(Status = 'Ikke på lager', concat('Forventet på lager: ', (select DATE_FORMAT(Leveringsdato,'%d/%m/%Y') as Leveringsdato from Leveringsdatoer where Leveringsdatoer.Hylde_ID = Hylder.Hylde_ID)), Status) as 'Status' from Firmaadresse "
+ "join Firmaby on Firmaby.Bynavn_ID = firmaadresse.Bynavn_ID "
+ "join Lokationer on Lokationer.Firmaadresse_ID = Firmaadresse.Firmaadresse_ID "
+ "Join Reoler on Reoler.Lokation_ID = Lokationer.Lokation_ID "
+ "join Hylder on Hylder.Reol_ID = Reoler.Reol_ID "
+ "join Produkter on Produkter.Produkt_ID = Hylder.Produkt_ID "
+ "join Lagerstatus on Lagerstatus.Lagerstatus_ID = Hylder.Lagerstatus_ID where Navn LIKE concat('%', @search, '%')";
            //You can pass connection as parameter
            MySqlCommand selectCmd = new MySqlCommand(query, DBConnection.GetInstance().mysqlConnection);
            selectCmd.Parameters.Add("search", MySqlDbType.VarString).Value = p_search;
            MySqlDataReader reader;
            reader = selectCmd.ExecuteReader();
            return reader;
        }
        public MySqlDataReader HentAfdeling(string p_search, int p_ID)
        {
            string query = "select Adresse, Postnr, Bynavn, Telefon, Varenummer, Navn as 'Produktnavn', Antal, replace(Enhedspris, '.', ',') as Pris, Lokationer.Lokationsnr as 'Lokation', Reoler.Reolnr as 'Reolnr', Hylder.Hyldenr as 'Hyldenr', if(Status = 'Ikke på lager', concat('Forventet på lager: ', (select DATE_FORMAT(Leveringsdato,'%d/%m/%Y') as Leveringsdato from Leveringsdatoer where Leveringsdatoer.Hylde_ID = Hylder.Hylde_ID)), Status) as 'Status' from Firmaadresse "
+ "join Firmaby on Firmaby.Bynavn_ID = firmaadresse.Bynavn_ID "
+ "join Lokationer on Lokationer.Firmaadresse_ID = Firmaadresse.Firmaadresse_ID "
+ "Join Reoler on Reoler.Lokation_ID = Lokationer.Lokation_ID "
+ "join Hylder on Hylder.Reol_ID = Reoler.Reol_ID "
+ "join Produkter on Produkter.Produkt_ID = Hylder.Produkt_ID "
+ "join Lagerstatus on Lagerstatus.Lagerstatus_ID = Hylder.Lagerstatus_ID where Navn LIKE concat('%', @search, '%') and Firmaadresse.Firmaadresse_ID = @id";
            MySqlCommand selectCmd = new MySqlCommand(query, DBConnection.GetInstance().mysqlConnection);
            selectCmd.Parameters.Add("search", MySqlDbType.VarString).Value = p_search;
            selectCmd.Parameters.Add("id", MySqlDbType.Int32).Value = p_ID;
            MySqlDataReader reader;
            reader = selectCmd.ExecuteReader();
            return reader;
        }

        public MySqlDataReader HentAfdAdresser()
        {
            string query = "select adresse, Postnr, Bynavn from Firmaadresse "
+ "join Firmaby on Firmaby.Bynavn_ID = firmaadresse.Bynavn_ID order by Firmaadresse_ID";
            //You can pass connection as parameter
            MySqlCommand selectCmd = new MySqlCommand(query, DBConnection.GetInstance().mysqlConnection);
            MySqlDataReader reader;
            reader = selectCmd.ExecuteReader();
            return reader;
        }
    }
}
