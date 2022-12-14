using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotKayitSistemi
{
    public partial class Form3 : Form
    {
        int id;
        public Form3()
        {
            InitializeComponent();
            ilk();
        }

        public Form3(int id)
        {
            this.id = id;
            InitializeComponent();
            ilk();
        }

        public void ilk()
        {
            Ogrenci ogrenci = new Ogrenci();
            foreach (Ogrenci ogrenci1 in Ogrenciler.ogrenciler)
            {
                if (ogrenci1.getId() == id)
                {
                    ogrenci = ogrenci1;
                }
            }
            dataGridView1.Columns.Clear();

            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "Yarıyıl";
            dataGridView1.Columns[2].Name = "Ders Adı";
            dataGridView1.Columns[3].Name = "Ders Kredisi";
            dataGridView1.Columns[4].Name = "Ders Notu";
            int i = 0;
            foreach (Ders ders in ogrenci.getDersList())
            {
                dataGridView1.Rows.Add(i, ders.getYariYil(), ders.getDersAdi(),ders.getDersKredisi() ,ders.getNot());
                i++;
            }


            DataGridViewButtonColumn dgvButton1 = new DataGridViewButtonColumn();
            dgvButton1.FlatStyle = FlatStyle.System;

            dgvButton1.HeaderText = "Sil";
            dgvButton1.Name = "Button";
            dgvButton1.UseColumnTextForButtonValue = true;
            dgvButton1.Text = "Sil";

            dataGridView1.Columns.Add(dgvButton1);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            foreach (Ogrenci ogrenci1 in Ogrenciler.ogrenciler)
            {
                if (ogrenci1.getId() == id)
                {
                    ogrenci = ogrenci1;
                }
            }
            if(comboBox1.SelectedItem != null && comboBox2.SelectedItem!=null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null)
            {
                Ders ders = new Ders(comboBox1.Text,comboBox3.Text,comboBox2.Text,comboBox4.Text);
                bool flag = true;
                foreach (Ders ders1 in ogrenci.getDersList())
                {
                    if(ders1.getDersAdi().Equals(ders.getDersAdi()) && ders1.getYariYil().Equals(ders.getYariYil()))
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    ogrenci.getDersList().Add(ders);
                    comboBox1.SelectedIndex = -1;
                    comboBox2.SelectedIndex = -1;
                    comboBox3.SelectedIndex = -1;
                    comboBox4.SelectedIndex = -1;
                }
                
            } 

            
            ilk();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==5)
            {
                Ogrenci ogrenci = new Ogrenci();
                foreach (Ogrenci ogrenci1 in Ogrenciler.ogrenciler)
                {
                    if (ogrenci1.getId() == id)
                    {
                        ogrenci = ogrenci1;
                    }
                }
                Ders ders1 = new Ders();
                foreach (Ders ders in ogrenci.getDersList())
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells[2].Value != null && dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Equals(ders.getDersAdi())
                        && dataGridView1.Rows[e.RowIndex].Cells[1].Value != null && dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Equals(ders.getYariYil()))
                    {
                        ders1 = ders;
                    }
                   
                }
                ogrenci.getDersList().Remove(ders1);
                ilk();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            switch (comboBox1.SelectedIndex)
            {
                case 0: {
                    comboBox3.Items.Add("Ders 1");
                    comboBox3.Items.Add("Ders 2");
                        comboBox3.Items.Add("Ders 3");
                        comboBox3.Items.Add("Ders 4");
                        break;
                }
                case 1:
                    {
                        comboBox3.Items.Add("Ders 1");
                        comboBox3.Items.Add("Ders 2");
                        comboBox3.Items.Add("Ders 3");
                        comboBox3.Items.Add("Ders 4");
                        break;
                    }
                case 2:
                    {
                        comboBox3.Items.Add("Ders 1");
                        comboBox3.Items.Add("Ders 2");
                        comboBox3.Items.Add("Ders 3");
                        comboBox3.Items.Add("Ders 4");
                        break;
                    }
                case 3:
                    {
                        comboBox3.Items.Add("Ders 1");
                        comboBox3.Items.Add("Ders 2");
                        comboBox3.Items.Add("Ders 3");
                        comboBox3.Items.Add("Ders 4");
                        break;
                    }
                case 4:
                    {
                        comboBox3.Items.Add("Ders 1");
                        comboBox3.Items.Add("Ders 2");
                        comboBox3.Items.Add("Ders 3");
                        comboBox3.Items.Add("Ders 4");
                        break;
                    }
                case 5:
                    {
                        comboBox3.Items.Add("Ders 1");
                        comboBox3.Items.Add("Ders 2");
                        comboBox3.Items.Add("Ders 3");
                        comboBox3.Items.Add("Ders 4");
                        break;
                    }
                case 6:
                    {
                        comboBox3.Items.Add("Ders 1");
                        comboBox3.Items.Add("Ders 2");
                        comboBox3.Items.Add("Ders 3");
                        comboBox3.Items.Add("Ders 4");
                        break;
                    }
                case 7:
                    {
                        comboBox3.Items.Add("Ders 1");
                        comboBox3.Items.Add("Ders 2");
                        comboBox3.Items.Add("Ders 3");
                        comboBox3.Items.Add("Ders 4");
                        break;
                    }



            }
        }
    }
}
