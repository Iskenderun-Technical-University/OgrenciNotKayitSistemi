namespace OgrenciNotKayitSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            int ogrenciNo;
            bool flag = true;

            if (textBox2.Text.Equals("") && textBox1.Text.Equals(""))
            {

                label3.Text = "Ögrenci adi soyadi ve numarasi bos birakilamaz";
                flag = false;

            }
            else if (textBox2.Text.Equals(""))
            {

                label3.Text = "Ögrenci numarasi bo? birakilamaz";
                flag = false;

            }
            else if (textBox1.Text.Equals(""))
            {

                label3.Text = "Ögrenci adi soyadi bos birakilamaz";
                flag = false;

            }
            else if (!int.TryParse(textBox2.Text, out ogrenciNo))
            {
                label3.Text = "Ögrenci numarasi hatali";

                flag = false;

            }
            else
            {
                foreach (Ogrenci 
                    ogrenci1 in Ogrenciler.ogrenciler)
                {
                    if (ogrenci1.getNumara().Equals(ogrenciNo.ToString()))
                    {
                        label3.Text = "Ögrenci numarasi kayitli";
                        flag = false;
                    }
                }
                if (flag)
                {
                    ogrenci.setNumara(textBox2.Text);
                    ogrenci.setAdiSoyadi(textBox1.Text);
                    Ogrenciler.ogrenciEkle(ogrenci);
                    Close();
                }
            }

               
            

        }
    }
}