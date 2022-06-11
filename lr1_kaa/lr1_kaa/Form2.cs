using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr1_kaa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Свойства и методы Form: \n\nText - текст в заголовке ";
            label2.Text = "Взаимодействие между формами: \n\nShow() - показать форму из другой формы \nOwner - форма, владеющая текущей формой";
        }
    }
}
