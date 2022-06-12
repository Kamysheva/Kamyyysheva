using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr2_kaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.FormClosed += new FormClosedEventHandler(newForm_FormClosed);
            newForm.Show();
           
        }
        void newForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridView1.Rows.Add(DataBank.NewArticle);
        }

        private void новаяПубликацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void новыйАвторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.FormClosed += new FormClosedEventHandler(newForm3_FormClosed);
            newForm.Show();
        }
        void newForm3_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataAuthors.Rows.Add(DataBank.NewAuthor);
        }

        private void новоеИздательствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 newForm4 = new Form4();
           
            newForm4.Show();
        }
        

        private void новыйИсточникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show();
        }

        private void новоеUDCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 newForm = new Form6();
            newForm.Show();
        }

        private void новыйУровеньОбразованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 newForm = new Form7();
            newForm.Show();
        }

        private void новоеМестоРаботыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 newForm = new Form8();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 newForm = new Form9();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void открытьФормуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            DataBank.CurrentTable = "dataGridView1";
            
        }

        private void всехАвторовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (dataAuthors.Visible)
            {
                dataAuthors.Visible = false;
            }
            else
            {
                dataAuthors.Visible = true;


            }
        }

        private void всеПубликацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible)
            {
                dataGridView1.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
            }
            else
            {
                dataGridView1.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
            }
        }

        private void всеМестаРаботыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataWork.Visible)
            {
                dataWork.Visible = false;
            }
            else
            {
                dataWork.Visible = true;
            }
        }

        private void всеУровниОбразованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataEducation.Visible)
            {
                dataEducation.Visible = false;
            }
            else
            {
                dataEducation.Visible = true;
            }
        }

        private void всеУДКToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataUDK.Visible)
            {
                dataUDK.Visible = false;
            }
            else
            {
                dataUDK.Visible = true;
            }
        }

        private void всеИсточникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataSource.Visible)
            {
                dataSource.Visible = false;
            }
            else
            {
                dataSource.Visible = true;
            }
        }

        private void всеИздательстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataPublisher.Visible)
            {
                dataPublisher.Visible = false;
            }
            else
            {
                dataPublisher.Visible = true;
            }
        }
    }
}
