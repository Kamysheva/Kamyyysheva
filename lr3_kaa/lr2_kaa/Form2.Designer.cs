
namespace lr2_kaa
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.doi = new System.Windows.Forms.MaskedTextBox();
            this.pageAm = new System.Windows.Forms.NumericUpDown();
            this.citate = new System.Windows.Forms.NumericUpDown();
            this.publisher = new System.Windows.Forms.ComboBox();
            this.source = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.udc = new System.Windows.Forms.ComboBox();
            this.artName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pageAm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOI код";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Издательство";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Дата публикации";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Источник";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество страниц";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Цитируемость";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "UDC";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // doi
            // 
            this.doi.Location = new System.Drawing.Point(15, 38);
            this.doi.Mask = "0000000000";
            this.doi.Name = "doi";
            this.doi.Size = new System.Drawing.Size(107, 20);
            this.doi.TabIndex = 11;
            // 
            // pageAm
            // 
            this.pageAm.Location = new System.Drawing.Point(15, 165);
            this.pageAm.Name = "pageAm";
            this.pageAm.Size = new System.Drawing.Size(107, 20);
            this.pageAm.TabIndex = 13;
            // 
            // citate
            // 
            this.citate.Location = new System.Drawing.Point(152, 165);
            this.citate.Name = "citate";
            this.citate.Size = new System.Drawing.Size(107, 20);
            this.citate.TabIndex = 14;
            // 
            // publisher
            // 
            this.publisher.FormattingEnabled = true;
            this.publisher.Location = new System.Drawing.Point(152, 38);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(121, 21);
            this.publisher.TabIndex = 15;
            this.publisher.SelectedIndexChanged += new System.EventHandler(this.publisher_SelectedIndexChanged);
            // 
            // source
            // 
            this.source.FormattingEnabled = true;
            this.source.Location = new System.Drawing.Point(152, 97);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(121, 21);
            this.source.TabIndex = 16;
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(329, 38);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 17;
            // 
            // udc
            // 
            this.udc.FormattingEnabled = true;
            this.udc.Location = new System.Drawing.Point(329, 97);
            this.udc.Name = "udc";
            this.udc.Size = new System.Drawing.Size(121, 21);
            this.udc.TabIndex = 18;
            // 
            // artName
            // 
            this.artName.Location = new System.Drawing.Point(15, 97);
            this.artName.Name = "artName";
            this.artName.Size = new System.Drawing.Size(107, 20);
            this.artName.TabIndex = 19;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 217);
            this.Controls.Add(this.artName);
            this.Controls.Add(this.udc);
            this.Controls.Add(this.date);
            this.Controls.Add(this.source);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.citate);
            this.Controls.Add(this.pageAm);
            this.Controls.Add(this.doi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Новая публикация";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pageAm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox doi;
        private System.Windows.Forms.NumericUpDown pageAm;
        private System.Windows.Forms.NumericUpDown citate;
        private System.Windows.Forms.ComboBox publisher;
        private System.Windows.Forms.ComboBox source;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox udc;
        private System.Windows.Forms.TextBox artName;
    }
}