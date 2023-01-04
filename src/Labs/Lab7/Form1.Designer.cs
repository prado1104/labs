namespace Lab7
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxHidden = new System.Windows.Forms.CheckBox();
            this.checkBoxReadOnly = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.textBoxNewPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCopyTo = new System.Windows.Forms.Button();
            this.buttonMoveTo = new System.Windows.Forms.Button();
            this.textBoxLastAccessTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLastWriteTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCreationTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFileSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxFolders = new System.Windows.Forms.ListBox();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.buttonUp = new System.Windows.Forms.Button();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отобразитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вверхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.созданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перемещениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuListBoxFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuListBoxFolders = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.созданиеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.перемещениеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.копированиеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вверхToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.созданиеToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.перемещениеToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.копированиеToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuListBoxFiles.SuspendLayout();
            this.contextMenuListBoxFolders.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 45);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(327, 20);
            this.textBoxInput.TabIndex = 0;
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(347, 45);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(106, 20);
            this.buttonDisplay.TabIndex = 1;
            this.buttonDisplay.Text = "Отобразить";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.OnDisplayButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите имя файла или папки и нажмите \"Отобразить\"";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBoxFolders);
            this.groupBox1.Controls.Add(this.listBoxFiles);
            this.groupBox1.Controls.Add(this.buttonUp);
            this.groupBox1.Controls.Add(this.textBoxFolder);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 557);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Путь папки";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxHidden);
            this.groupBox2.Controls.Add(this.checkBoxReadOnly);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.textBoxLastAccessTime);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxLastWriteTime);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxCreationTime);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxFileSize);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 330);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Детальная информация о выделенном файле или папке";
            // 
            // checkBoxHidden
            // 
            this.checkBoxHidden.Location = new System.Drawing.Point(219, 161);
            this.checkBoxHidden.Name = "checkBoxHidden";
            this.checkBoxHidden.Size = new System.Drawing.Size(83, 24);
            this.checkBoxHidden.TabIndex = 19;
            this.checkBoxHidden.Text = "Скрыт";
            this.checkBoxHidden.UseVisualStyleBackColor = true;
            // 
            // checkBoxReadOnly
            // 
            this.checkBoxReadOnly.Location = new System.Drawing.Point(83, 161);
            this.checkBoxReadOnly.Name = "checkBoxReadOnly";
            this.checkBoxReadOnly.Size = new System.Drawing.Size(127, 24);
            this.checkBoxReadOnly.TabIndex = 18;
            this.checkBoxReadOnly.Text = "Только для чтения";
            this.checkBoxReadOnly.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Атрибуты:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonCreate);
            this.groupBox3.Controls.Add(this.textBoxNewPath);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.buttonDelete);
            this.groupBox3.Controls.Add(this.buttonCopyTo);
            this.groupBox3.Controls.Add(this.buttonMoveTo);
            this.groupBox3.Location = new System.Drawing.Point(6, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 87);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Перемещение, удаление и копирование файла";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(6, 19);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(98, 23);
            this.buttonCreate.TabIndex = 5;
            this.buttonCreate.Text = "Создание";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.OnCreateButtonClick);
            // 
            // textBoxNewPath
            // 
            this.textBoxNewPath.Location = new System.Drawing.Point(53, 55);
            this.textBoxNewPath.Name = "textBoxNewPath";
            this.textBoxNewPath.Size = new System.Drawing.Size(358, 20);
            this.textBoxNewPath.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Новый";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(318, 19);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(94, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удаление";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.OnDeleteButtonClick);
            // 
            // buttonCopyTo
            // 
            this.buttonCopyTo.Location = new System.Drawing.Point(214, 19);
            this.buttonCopyTo.Name = "buttonCopyTo";
            this.buttonCopyTo.Size = new System.Drawing.Size(98, 23);
            this.buttonCopyTo.TabIndex = 1;
            this.buttonCopyTo.Text = "Копирование";
            this.buttonCopyTo.UseVisualStyleBackColor = true;
            this.buttonCopyTo.Click += new System.EventHandler(this.OnCopyToButtonClick);
            // 
            // buttonMoveTo
            // 
            this.buttonMoveTo.Location = new System.Drawing.Point(110, 19);
            this.buttonMoveTo.Name = "buttonMoveTo";
            this.buttonMoveTo.Size = new System.Drawing.Size(98, 23);
            this.buttonMoveTo.TabIndex = 0;
            this.buttonMoveTo.Text = "Перемещение";
            this.buttonMoveTo.UseVisualStyleBackColor = true;
            this.buttonMoveTo.Click += new System.EventHandler(this.OnMoveToButtonClick);
            // 
            // textBoxLastAccessTime
            // 
            this.textBoxLastAccessTime.Location = new System.Drawing.Point(219, 133);
            this.textBoxLastAccessTime.Name = "textBoxLastAccessTime";
            this.textBoxLastAccessTime.ReadOnly = true;
            this.textBoxLastAccessTime.Size = new System.Drawing.Size(204, 20);
            this.textBoxLastAccessTime.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Время последнего доступа";
            // 
            // textBoxLastWriteTime
            // 
            this.textBoxLastWriteTime.Location = new System.Drawing.Point(6, 133);
            this.textBoxLastWriteTime.Name = "textBoxLastWriteTime";
            this.textBoxLastWriteTime.ReadOnly = true;
            this.textBoxLastWriteTime.Size = new System.Drawing.Size(204, 20);
            this.textBoxLastWriteTime.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Время последней модификации";
            // 
            // textBoxCreationTime
            // 
            this.textBoxCreationTime.Location = new System.Drawing.Point(219, 84);
            this.textBoxCreationTime.Name = "textBoxCreationTime";
            this.textBoxCreationTime.ReadOnly = true;
            this.textBoxCreationTime.Size = new System.Drawing.Size(204, 20);
            this.textBoxCreationTime.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Время создания";
            // 
            // textBoxFileSize
            // 
            this.textBoxFileSize.Location = new System.Drawing.Point(6, 84);
            this.textBoxFileSize.Name = "textBoxFileSize";
            this.textBoxFileSize.ReadOnly = true;
            this.textBoxFileSize.Size = new System.Drawing.Size(204, 20);
            this.textBoxFileSize.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Размер";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(38, 22);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(385, 20);
            this.textBoxName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Имя";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(222, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Папки";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Файлы";
            // 
            // listBoxFolders
            // 
            this.listBoxFolders.ContextMenuStrip = this.contextMenuListBoxFolders;
            this.listBoxFolders.FormattingEnabled = true;
            this.listBoxFolders.Location = new System.Drawing.Point(222, 78);
            this.listBoxFolders.Name = "listBoxFolders";
            this.listBoxFolders.Size = new System.Drawing.Size(213, 121);
            this.listBoxFolders.TabIndex = 3;
            this.listBoxFolders.Click += new System.EventHandler(this.OnListBoxFoldersClicked);
            this.listBoxFolders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnListBoxFoldersSelected);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.ContextMenuStrip = this.contextMenuListBoxFiles;
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(6, 78);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(210, 121);
            this.listBoxFiles.TabIndex = 2;
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.OnListBoxFilesSelected);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(335, 19);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(100, 20);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.Text = "Вверх";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.OnUpButtonClick);
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Location = new System.Drawing.Point(6, 19);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.ReadOnly = true;
            this.textBoxFolder.Size = new System.Drawing.Size(321, 20);
            this.textBoxFolder.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отобразитьToolStripMenuItem,
            this.вверхToolStripMenuItem,
            this.действиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(465, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // отобразитьToolStripMenuItem
            // 
            this.отобразитьToolStripMenuItem.Name = "отобразитьToolStripMenuItem";
            this.отобразитьToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.отобразитьToolStripMenuItem.Text = "Отобразить";
            this.отобразитьToolStripMenuItem.Click += new System.EventHandler(this.OnDisplayButton);
            // 
            // вверхToolStripMenuItem
            // 
            this.вверхToolStripMenuItem.Name = "вверхToolStripMenuItem";
            this.вверхToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.вверхToolStripMenuItem.Text = "Вверх";
            this.вверхToolStripMenuItem.Click += new System.EventHandler(this.OnUpButtonClick);
            // 
            // действиеToolStripMenuItem
            // 
            this.действиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.созданиеToolStripMenuItem,
            this.перемещениеToolStripMenuItem,
            this.копированиеToolStripMenuItem,
            this.удалениеToolStripMenuItem});
            this.действиеToolStripMenuItem.Name = "действиеToolStripMenuItem";
            this.действиеToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действиеToolStripMenuItem.Text = "Действие";
            // 
            // созданиеToolStripMenuItem
            // 
            this.созданиеToolStripMenuItem.Name = "созданиеToolStripMenuItem";
            this.созданиеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.созданиеToolStripMenuItem.Text = "Создание";
            this.созданиеToolStripMenuItem.Click += new System.EventHandler(this.OnCreateButtonClick);
            // 
            // перемещениеToolStripMenuItem
            // 
            this.перемещениеToolStripMenuItem.Name = "перемещениеToolStripMenuItem";
            this.перемещениеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.перемещениеToolStripMenuItem.Text = "Перемещение";
            this.перемещениеToolStripMenuItem.Click += new System.EventHandler(this.OnMoveToButtonClick);
            // 
            // копированиеToolStripMenuItem
            // 
            this.копированиеToolStripMenuItem.Name = "копированиеToolStripMenuItem";
            this.копированиеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.копированиеToolStripMenuItem.Text = "Копирование";
            this.копированиеToolStripMenuItem.Click += new System.EventHandler(this.OnCopyToButtonClick);
            // 
            // удалениеToolStripMenuItem
            // 
            this.удалениеToolStripMenuItem.Name = "удалениеToolStripMenuItem";
            this.удалениеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалениеToolStripMenuItem.Text = "Удаление";
            this.удалениеToolStripMenuItem.Click += new System.EventHandler(this.OnDeleteButtonClick);
            // 
            // contextMenuListBoxFiles
            // 
            this.contextMenuListBoxFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.созданиеToolStripMenuItem1,
            this.перемещениеToolStripMenuItem1,
            this.копированиеToolStripMenuItem1,
            this.удалениеToolStripMenuItem1});
            this.contextMenuListBoxFiles.Name = "contextMenuListBoxFiles";
            this.contextMenuListBoxFiles.Size = new System.Drawing.Size(155, 92);
            // 
            // contextMenuListBoxFolders
            // 
            this.contextMenuListBoxFolders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вверхToolStripMenuItem1,
            this.созданиеToolStripMenuItem2,
            this.перемещениеToolStripMenuItem2,
            this.копированиеToolStripMenuItem2,
            this.удалениеToolStripMenuItem2});
            this.contextMenuListBoxFolders.Name = "contextMenuListBoxFolders";
            this.contextMenuListBoxFolders.Size = new System.Drawing.Size(181, 136);
            // 
            // созданиеToolStripMenuItem1
            // 
            this.созданиеToolStripMenuItem1.Name = "созданиеToolStripMenuItem1";
            this.созданиеToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.созданиеToolStripMenuItem1.Text = "Создание";
            this.созданиеToolStripMenuItem1.Click += new System.EventHandler(this.OnCreateButtonClick);
            // 
            // перемещениеToolStripMenuItem1
            // 
            this.перемещениеToolStripMenuItem1.Name = "перемещениеToolStripMenuItem1";
            this.перемещениеToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.перемещениеToolStripMenuItem1.Text = "Перемещение";
            this.перемещениеToolStripMenuItem1.Click += new System.EventHandler(this.OnMoveToButtonClick);
            // 
            // копированиеToolStripMenuItem1
            // 
            this.копированиеToolStripMenuItem1.Name = "копированиеToolStripMenuItem1";
            this.копированиеToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.копированиеToolStripMenuItem1.Text = "Копирование";
            this.копированиеToolStripMenuItem1.Click += new System.EventHandler(this.OnCopyToButtonClick);
            // 
            // удалениеToolStripMenuItem1
            // 
            this.удалениеToolStripMenuItem1.Name = "удалениеToolStripMenuItem1";
            this.удалениеToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.удалениеToolStripMenuItem1.Text = "Удаление";
            this.удалениеToolStripMenuItem1.Click += new System.EventHandler(this.OnDeleteButtonClick);
            // 
            // вверхToolStripMenuItem1
            // 
            this.вверхToolStripMenuItem1.Name = "вверхToolStripMenuItem1";
            this.вверхToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.вверхToolStripMenuItem1.Text = "Вверх";
            this.вверхToolStripMenuItem1.Click += new System.EventHandler(this.OnUpButtonClick);
            // 
            // созданиеToolStripMenuItem2
            // 
            this.созданиеToolStripMenuItem2.Name = "созданиеToolStripMenuItem2";
            this.созданиеToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.созданиеToolStripMenuItem2.Text = "Создание";
            this.созданиеToolStripMenuItem2.Click += new System.EventHandler(this.OnCreateButtonClick);
            // 
            // перемещениеToolStripMenuItem2
            // 
            this.перемещениеToolStripMenuItem2.Name = "перемещениеToolStripMenuItem2";
            this.перемещениеToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.перемещениеToolStripMenuItem2.Text = "Перемещение";
            this.перемещениеToolStripMenuItem2.Click += new System.EventHandler(this.OnMoveToButtonClick);
            // 
            // копированиеToolStripMenuItem2
            // 
            this.копированиеToolStripMenuItem2.Name = "копированиеToolStripMenuItem2";
            this.копированиеToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.копированиеToolStripMenuItem2.Text = "Копирование";
            this.копированиеToolStripMenuItem2.Click += new System.EventHandler(this.OnCopyToButtonClick);
            // 
            // удалениеToolStripMenuItem2
            // 
            this.удалениеToolStripMenuItem2.Name = "удалениеToolStripMenuItem2";
            this.удалениеToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.удалениеToolStripMenuItem2.Text = "Удаление";
            this.удалениеToolStripMenuItem2.Click += new System.EventHandler(this.OnDeleteButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 625);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuListBoxFiles.ResumeLayout(false);
            this.contextMenuListBoxFolders.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button buttonCreate;

        private System.Windows.Forms.CheckBox checkBoxHidden;

        private System.Windows.Forms.CheckBox checkBoxReadOnly;

        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFileSize;
        private System.Windows.Forms.TextBox textBoxCreationTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLastAccessTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLastWriteTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonMoveTo;
        private System.Windows.Forms.Button buttonCopyTo;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNewPath;

        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.ListBox listBoxFolders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuListBoxFolders;
        private System.Windows.Forms.ToolStripMenuItem вверхToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem созданиеToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem перемещениеToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem копированиеToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem удалениеToolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuListBoxFiles;
        private System.Windows.Forms.ToolStripMenuItem созданиеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem перемещениеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem копированиеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалениеToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отобразитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вверхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem созданиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перемещениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалениеToolStripMenuItem;
    }
}