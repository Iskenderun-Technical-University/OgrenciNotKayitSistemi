using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace OgrenciNotKayitSistemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            veriler();
        }


        // veriler kaydedilen ögrencileri gostermek için kullanılır.
        

        public void veriler()
        {
            dataGridView1.Columns.Clear(); 

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "Numara";
            dataGridView1.Columns[2].Name = "Adi Soyadi";
            foreach (Ogrenci ogrenci in Ogrenciler.ogrenciler)
            {
                dataGridView1.Rows.Add(ogrenci.getId(), ogrenci.getNumara(), ogrenci.getAdiSoyadi());
            }

            DataGridViewButtonColumn dgvButton = new DataGridViewButtonColumn();
            dgvButton.FlatStyle = FlatStyle.System;

            dgvButton.HeaderText = "Düzenle";
            dgvButton.Name = "Button";
            dgvButton.UseColumnTextForButtonValue = true;
            dgvButton.Text = "Not Gir";

            dataGridView1.Columns.Add(dgvButton);

            DataGridViewButtonColumn dgvButton1 = new DataGridViewButtonColumn();
            dgvButton1.FlatStyle = FlatStyle.System;

            dgvButton1.HeaderText = "Sil";
            dgvButton1.Name = "Button";
            dgvButton1.UseColumnTextForButtonValue = true;
            dgvButton1.Text = "Sil";

            dataGridView1.Columns.Add(dgvButton1);

        }

        //  ogrenciler listesini güncellemek için kullanılır(yenile)
        private void button2_Click(object sender, EventArgs e)
        {
            veriler();

        }

        //listelenen ögrencileri silmek veya ogrencilere not girişi yapmak için kullanılan butonların metodu.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 3 && Ogrenciler.ogrenciler.Count != e.RowIndex)
            {

                Form3 form3 = new Form3(Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
                form3.Show();

            }
            if (e.ColumnIndex == 4 && Ogrenciler.ogrenciler.Count != e.RowIndex)
            {

                foreach(Ogrenci ogrenci in Ogrenciler.ogrenciler)
                {
                    if(ogrenci.getId() == Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()))
                    {
                        Ogrenciler.ogrenciler.Remove(ogrenci);
                        break;
                    }
                }
                veriler();
            }
        }
        //  yeni ogrenci kaydı penceresini açma
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        
    }
}
