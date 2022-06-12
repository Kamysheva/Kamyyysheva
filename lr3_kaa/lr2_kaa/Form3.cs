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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            education.Items.AddRange(DataBank.AllEducation.ToArray());
            work.Items.AddRange(DataBank.AllWork.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBank.AllAuthorsNames.Add(maskedTextBox1.Text);
            string[] authorInfo = { maskedTextBox1.Text, education.SelectedIndex.ToString(), work.SelectedIndex.ToString(), numericUpDown1.Value.ToString(), dateTimePicker1.Value.ToString()};
            DataBank.NewAuthor = authorInfo;
            this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
