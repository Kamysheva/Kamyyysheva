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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            label1.Text = "Свойства и методы progressBar: \n\nMinimum - наименьшее значение этого элемента \nMaximum - наибольшее значение этого элемента \nStep - число-ход, на которое увеличивается значение прогрессбара \nPerformStep() - увеличение значения на шаг \nValue - возвращает или задаёт текущее значение";
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void progressBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            label1.Text = "Свойства и методы progressBar: \n\nMinimum - наименьшее значение этого элемента \nMaximum - наибольшее значение этого элемента \nStep - число-ход, на которое увеличивается значение прогрессбара \nPerformStep() - увеличение значения на шаг \nValue - возвращает или задаёт текущее значение";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Свойства и методы Button: \n\nDialogResult - задаёт или возвращает значение, применяемое к родительской форме\nEnabled - доступа ли кнопка пользователю\nClick - событие клика на кнопку";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "Свойства и методы TextBox: \n\nMultiline - задаёт или возвращает многострочный ли элемент \nScrollBars - задаёт или возвращает полосы прокрутки \nOnKeyDown() - событие нажатия кнопки (для проверки ввода) \nAutoCompleteMode - параметр, управляющий возможностью автоматически заполнить элемент";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            label1.Text = "Свойства и методы TextBox: \n\n";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            label1.Text = "Свойства и методы comboBox : \n\nItems - свойство, с помощью которого можно обращаться к элементами комбобокса \nSelectedItem - свойство, возвращающе выбранный элемент \nMaxDropDownItems - количество отображаемых за раз элементов \nSelectedIndexChanged - событие выбора элемента";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //label2.Text = "Свойства и методы TabControl: \n\nTabPages - коллекция вкладок";
            label1.Text = "Свойства и методы Label: \n\nName - имя, с помощью которого можно обратиться к лейблу в программе  \nText - текст лейбла \nTextAlign - выравнивание текста";
            maskedTextBox1.Click += new EventHandler(this.mackedTextBox1_Click); //магия, чтобы по клику на маскедбокс происходило событие
            groupBox1.Click += new EventHandler(this.groupBox1_Click);
            numericUpDown1.Click += new EventHandler(this.numericUpDown1_Click);
            textBox1.Click += new EventHandler(this.textBox1_Click);
            panel1.Click += new EventHandler(this.panel1_Click);
            label2.Text = "Свойства и методы TabControl: \n\n";
        }
        void mackedTextBox1_Click(Object sender, EventArgs e)
        {
            label1.Text = "Свойства и методы maskedTextBox: \n\nMask - маска, которой проверяется правильность ввода \nMaskInputRejected - событие, которое вызывается при вводе, который не соответсвует маске";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Свойства и методы checkBox: \n\nAutoCheck - выбран ли чекбокс по умолчанию \nChecked - возвращает значение чекбокса (выбран или нет, true или false)";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Свойства и методы radioButton: \n\nCheckedChanged - событие изменения состояния элемента \nChecked - выбран ли элемент";
        }

        private void groupBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "Свойства и методы groupTextBox: \n\nText - текст над формой \nAutoSize - будет ли размер формы зависеть от содержимого \nSize - размер элемента";
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDown1_Click(object sender, EventArgs e)
        {
            label1.Text = "Свойства и методы numericUpDown: \n\nValue - текущее значение элемента \nMaximum - максимальное число, которое можно выбрать \nMinimum - минимальное число, которое можно выбрать \nThousandsSeparator - будет ли отображаться разделитель между разрядами \nReadOnly - может ли пользователь вводить своё значение \nDecimalPlaces - сколько знаков после запятой будет отображаться";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = "Свойства и методы dateTimePicker: \n\nFormat - формат отображения даты \nMinDate - минимальная дата, которую можно выбрать \nMaxDate - максимальная дата, которую можно выбрать \nValue - значение выбранной даты";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "Свойства и методы listBox: \n\nItems - свойство-коллекция элементов \nSelectedIndex - выбранный элемент списка \nSelectedIndices - набор выбранных элементов \nSelectedIndexChanged - событие изменения выбора ";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           label1.Text = "Свойства и методы pictureBox: \n\nImage - устанавливает объект типа image \nImageLocation - путь к изображению \nSizeMode - свойство, задающее размер и соотношение сторон изображения";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel1_Click(object sender, EventArgs e)
        {
            label1.Text = "Свойства и методы panel: \n\nSize - размер панели \nLocation - положение панели\nBorderStyle - стиль границы";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = "Свойства и методы dataGridView: \n\nColumns - набор столбцов таблицы";
        }

        private void новаяФормаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label1.Text = "Свойства и методы Form: \n\n";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Свойства и методы openFileDialog: \n\nCheckFileExists - проверить, существует ли файл \nInitialDirectory - исходный каталог, с которого начинается поиск \nFileName - возвращает имя выбранного файла \nPerformClick() - событие клика";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
        }

        private void saveFileDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Свойства и методы saveFileDialog: \n\nDefaultExt - расширение файлов по умолчанию \nCreatePrompt - диалоговое окно-подтверждение создания файла \nOverwritePrompt - диалоговое окно-подтверждение замены файла";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
        }

        private void folderBrowseDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Свойства и методы folderBrowseFileDialog: \n\nShowDialog() - события показа диалогового окна \nSelectedPath - значение выбранного пути \nRootFolder - корневая папка, с которой начинается выбор пути";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;
        }

        private void menuStripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Свойства и методы MenuStrip: \n\nDock - прикрепить меню к одной из сторон окна \nCheckState - проверка, выбран ли пункт меню \nShortcutKeys - задать горячие клавиши для пункта меню \nDisplayStyle - будет ли на элементе отображаться текст или изображение";
        }
    }
 }

