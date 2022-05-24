using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProCommerce.BL;
using MySql.Data.MySqlClient;
using ProCommerce.GUI;

namespace ProCommerce
{
    public partial class Form1 : Form
    {
        Commerce commerce = new Commerce();
        MySqlDataReader row;
        List<Produkt> produkter = new List<Produkt>();
        List<double> prislist = new List<double>();
        Produkt p;
        int indeks;

        public Form1()
        {
            InitializeComponent();
        }

        private int TilfoejBillede()
        {
            int j = 0;
            string varenr = row["Varenummer"].ToString();
            for (int i = 0; i < imgBilleder.Images.Count; i++)
            {
                string billede = imgBilleder.Images.Keys[i];
                if (billede.Contains(varenr))
                {
                    j = i;
                    break;
                }
            }
            return j;
        }
        private void VisProdukter()
        {
            produkter.Clear();
            if (row.HasRows)
            {
                while (row.Read())
                {
                    p = new Produkt(row["Adresse"].ToString(), row["Postnr"].ToString(), row["Bynavn"].ToString(), row["Telefon"].ToString(), row["Varenummer"].ToString(), row["Produktnavn"].ToString(), row["Antal"].ToString(), row["Pris"].ToString(), row["Lokation"].ToString(), row["Reolnr"].ToString(), row["Hyldenr"].ToString(), row["Status"].ToString());
                    produkter.Add(p);
                    lstvButik.Items.Add(row["Produktnavn"].ToString(), TilfoejBillede());
                }
            }
            else
            {
                MessageBox.Show("Ingen produkter fundet");
            }
            row.Close();
        }

        private void LavKolonner()
        {
            lstvKurv.View = View.Details;
            lstvKurv.Columns.Add("Varenummer", -2, HorizontalAlignment.Left);
            lstvKurv.Columns.Add("Produkt", -2, HorizontalAlignment.Left);
            lstvKurv.Columns.Add("Antal", -2, HorizontalAlignment.Left);
            lstvKurv.Columns.Add("Pris", -2, HorizontalAlignment.Left);
        }

        private void TilfoejAfd()
        {
            row = commerce.HentAfdAdresser();
            if (row.HasRows)
            {
                while (row.Read())
                {
                    cmbButik.Items.Add(row["Adresse"].ToString() + ", " + row["Postnr"].ToString() + ", " + row["Bynavn"].ToString());
                }
            }
            row.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TilfoejAfd();
            rdbUdvalgt.Checked = true;
            LavKolonner();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                if (rdbUdvalgt.Checked)
                {
                    if (cmbButik.SelectedIndex < 0)
                    {
                        MessageBox.Show("Du har ikke valgt en Butik!");
                    }
                    else
                    {
                        lstvButik.Items.Clear();
                        int c = cmbButik.SelectedIndex;
                        c++;
                        row = commerce.HentAfdeling(txtSearch.Text, c);
                        VisProdukter();
                    }
                }
                else
                {
                    lstvButik.Items.Clear();
                    row = commerce.HentAlt(txtSearch.Text);
                    VisProdukter();
                }
            }
        }

        private void lstvButik_SelectedIndexChanged(object sender, EventArgs e)
        {
            indeks = lstvButik.FocusedItem.Index;
            lblAdresse.Text = produkter[indeks].adresse;
            lblPostnrby.Text = produkter[indeks].postnr + " " + produkter[indeks].bynavn;
            lblTelefon.Text = "Tlf.: " + produkter[indeks].telefon;
            lblVarenr.Text = produkter[indeks].varenummer;
            lblAntal.Text = produkter[indeks].antal;
            lblPris.Text = produkter[indeks].pris + " pr. stk";
            lblStatus.Text = produkter[indeks].status;
            lblLokation.Text = produkter[indeks].lokation;
            lblReolnr.Text = produkter[indeks].reolnr;
            lblHyldenr.Text = produkter[indeks].hyldenr;
            btnKurv.Enabled = true;
            nudButik.Enabled = true;
            nudButik.Value = 1;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double totalpris = Convert.ToDouble(produkter[indeks].pris) * Convert.ToInt32(nudButik.Value);
            ListViewItem item1 = new ListViewItem(new[] { produkter[indeks].varenummer, produkter[indeks].produktnavn, nudButik.Value.ToString(), Math.Round(totalpris, 2).ToString("c2") });
            lstvKurv.Items.Add(item1);
            prislist.Add(totalpris);
            lblSamletpris.Text = prislist.Sum().ToString("c2");
        }

        private void nudButik_ValueChanged(object sender, EventArgs e)
        {
            if (nudButik.Value < 1)
            {
                nudButik.Value = 1;
            }
        }

        private void lstvKurv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvButik.SelectedItems.Count > 0)
            {
                btnSletvare.Enabled = true;
            }
            else
            {
                btnSletvare.Enabled = false;
            }
        }

        private void btnSletvare_Click(object sender, EventArgs e)
        {
            if (lstvKurv.SelectedItems.Count > 0)
            {
                int prisindeks = lstvKurv.FocusedItem.Index;
                lstvKurv.Items.RemoveAt(lstvKurv.FocusedItem.Index);
                prislist.RemoveAt(prisindeks);
                lblSamletpris.Text = prislist.Sum().ToString("c2");
            }
                btnSletvare.Enabled = false;
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
