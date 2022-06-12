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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string[] articleInfo = { doi.Text, artName.Text, pageAm.Value.ToString(), date.Value.ToString(), publisher.SelectedIndex.ToString(), citate.Value.ToString(), source.SelectedIndex.ToString(), udc.SelectedIndex.ToString() };
            DataBank.NewArticle = articleInfo;
            DataBank.Flag = true;
            this.Close();
        }

        private void publisher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            publisher.Items.AddRange(DataBank.AllPublisher.ToArray());
            source.Items.AddRange(DataBank.AllSources.ToArray());
            udc.Items.AddRange(DataBank.AllUdc.ToArray());
        }
    }
}
