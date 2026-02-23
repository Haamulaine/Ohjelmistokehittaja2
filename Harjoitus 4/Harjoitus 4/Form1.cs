namespace Harjoitus_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime syntymaAika = dateTimePicker1.Value.Date;
            DateTime nyt = DateTime.Now;
            
            //tarkka laskenta
            if (syntymaAika > nyt)
            {
                MessageBox.Show("Päivämäärä ei voi olla tulevaisuudessa.");
                return;
            }

            int vuodet = nyt.Year - syntymaAika.Year;
            int kuukaudet = nyt.Month - syntymaAika.Month;
            int paivat = nyt.Day - syntymaAika.Day;

            if(paivat > 0)
            {
                kuukaudet--;
                DateTime edellinenKuukausi = nyt.AddMonths(-1);
                paivat += DateTime.DaysInMonth(edellinenKuukausi.Year, edellinenKuukausi.Month);
            }

            if (kuukaudet > 0)
            {
                vuodet--;
                kuukaudet += 12;
            }
            //kokonaisaika
            TimeSpan kokonaisAika = nyt - syntymaAika;

            double tunnit = kokonaisAika.TotalHours;
            double minuutit = kokonaisAika.TotalMinutes;
            double sekunnit = kokonaisAika.TotalSeconds;

            //tulostus
            VuodetTB.Text = $"{vuodet} vuotta";
            KuutTB.Text = $"{vuodet * 12 + kuukaudet} kuukautta";
            PaivatTB.Text = $"{(int)kokonaisAika.TotalDays} päivää";

            TunnitTB.Text = $"{(long)tunnit} tuntia";
            MinuutitTB.Text = $"{(long)minuutit} minuuttia";
            SekunnitTB.Text = $"{(long)sekunnit} sekuntia";
        }
    }
}
