
namespace lr2_kaa
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФормуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяПубликацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйАвторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новоеИздательствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйИсточникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новоеUDCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйУровеньОбразованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новоеМестоРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DOIcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountOfPages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfCreation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Citation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.articlesColsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articlesColsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьФормуToolStripMenuItem,
            this.новаяПубликацияToolStripMenuItem,
            this.новыйАвторToolStripMenuItem,
            this.новоеИздательствоToolStripMenuItem,
            this.новыйИсточникToolStripMenuItem,
            this.новоеUDCToolStripMenuItem,
            this.новыйУровеньОбразованияToolStripMenuItem,
            this.новоеМестоРаботыToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // открытьФормуToolStripMenuItem
            // 
            this.открытьФормуToolStripMenuItem.Name = "открытьФормуToolStripMenuItem";
            this.открытьФормуToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.открытьФормуToolStripMenuItem.Text = "Открыть форму";
            this.открытьФормуToolStripMenuItem.Click += new System.EventHandler(this.открытьФормуToolStripMenuItem_Click);
            // 
            // новаяПубликацияToolStripMenuItem
            // 
            this.новаяПубликацияToolStripMenuItem.Name = "новаяПубликацияToolStripMenuItem";
            this.новаяПубликацияToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.новаяПубликацияToolStripMenuItem.Text = "Новая публикация";
            this.новаяПубликацияToolStripMenuItem.Click += new System.EventHandler(this.новаяПубликацияToolStripMenuItem_Click);
            // 
            // новыйАвторToolStripMenuItem
            // 
            this.новыйАвторToolStripMenuItem.Name = "новыйАвторToolStripMenuItem";
            this.новыйАвторToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.новыйАвторToolStripMenuItem.Text = "Новый автор";
            this.новыйАвторToolStripMenuItem.Click += new System.EventHandler(this.новыйАвторToolStripMenuItem_Click);
            // 
            // новоеИздательствоToolStripMenuItem
            // 
            this.новоеИздательствоToolStripMenuItem.Name = "новоеИздательствоToolStripMenuItem";
            this.новоеИздательствоToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.новоеИздательствоToolStripMenuItem.Text = "Новое издательство";
            this.новоеИздательствоToolStripMenuItem.Click += new System.EventHandler(this.новоеИздательствоToolStripMenuItem_Click);
            // 
            // новыйИсточникToolStripMenuItem
            // 
            this.новыйИсточникToolStripMenuItem.Name = "новыйИсточникToolStripMenuItem";
            this.новыйИсточникToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.новыйИсточникToolStripMenuItem.Text = "Новый источник";
            this.новыйИсточникToolStripMenuItem.Click += new System.EventHandler(this.новыйИсточникToolStripMenuItem_Click);
            // 
            // новоеUDCToolStripMenuItem
            // 
            this.новоеUDCToolStripMenuItem.Name = "новоеUDCToolStripMenuItem";
            this.новоеUDCToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.новоеUDCToolStripMenuItem.Text = "Новое UDC";
            this.новоеUDCToolStripMenuItem.Click += new System.EventHandler(this.новоеUDCToolStripMenuItem_Click);
            // 
            // новыйУровеньОбразованияToolStripMenuItem
            // 
            this.новыйУровеньОбразованияToolStripMenuItem.Name = "новыйУровеньОбразованияToolStripMenuItem";
            this.новыйУровеньОбразованияToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.новыйУровеньОбразованияToolStripMenuItem.Text = "Новый уровень образования";
            this.новыйУровеньОбразованияToolStripMenuItem.Click += new System.EventHandler(this.новыйУровеньОбразованияToolStripMenuItem_Click);
            // 
            // новоеМестоРаботыToolStripMenuItem
            // 
            this.новоеМестоРаботыToolStripMenuItem.Name = "новоеМестоРаботыToolStripMenuItem";
            this.новоеМестоРаботыToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.новоеМестоРаботыToolStripMenuItem.Text = "Новое место работы";
            this.новоеМестоРаботыToolStripMenuItem.Click += new System.EventHandler(this.новоеМестоРаботыToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DOIcode,
            this.ArticleName,
            this.AmountOfPages,
            this.DateOfCreation,
            this.Publisher,
            this.Citation,
            this.Source,
            this.UDC});
            this.dataGridView1.Location = new System.Drawing.Point(26, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(739, 274);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DOIcode
            // 
            this.DOIcode.HeaderText = "DOI код";
            this.DOIcode.Name = "DOIcode";
            this.DOIcode.ReadOnly = true;
            // 
            // ArticleName
            // 
            this.ArticleName.HeaderText = "Название";
            this.ArticleName.Name = "ArticleName";
            this.ArticleName.ReadOnly = true;
            // 
            // AmountOfPages
            // 
            this.AmountOfPages.HeaderText = "Количество страниц";
            this.AmountOfPages.Name = "AmountOfPages";
            this.AmountOfPages.ReadOnly = true;
            // 
            // DateOfCreation
            // 
            this.DateOfCreation.HeaderText = "Дата публикации";
            this.DateOfCreation.Name = "DateOfCreation";
            this.DateOfCreation.ReadOnly = true;
            // 
            // Publisher
            // 
            this.Publisher.HeaderText = "Издательство";
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            // 
            // Citation
            // 
            this.Citation.HeaderText = "Цитируемость";
            this.Citation.Name = "Citation";
            this.Citation.ReadOnly = true;
            // 
            // Source
            // 
            this.Source.HeaderText = "Источник";
            this.Source.Name = "Source";
            this.Source.ReadOnly = true;
            // 
            // UDC
            // 
            this.UDC.HeaderText = "UDC";
            this.UDC.Name = "UDC";
            this.UDC.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить  публикацию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Удалить публикацию";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(559, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Просмотр/изменение авторов";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.articlesColsBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(790, 25);
            this.bindingNavigator1.TabIndex = 5;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // articlesColsBindingSource
            // 
            this.articlesColsBindingSource.DataSource = typeof(lr2_kaa.articlesCols);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 377);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articlesColsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьФормуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяПубликацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйАвторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новоеИздательствоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйИсточникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новоеUDCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйУровеньОбразованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новоеМестоРаботыToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOIcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountOfPages;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfCreation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Citation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn UDC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource articlesColsBindingSource;
    }
}

