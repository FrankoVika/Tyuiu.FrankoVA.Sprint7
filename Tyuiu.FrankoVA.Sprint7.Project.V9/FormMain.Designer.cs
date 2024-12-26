namespace Tyuiu.FrankoVA.Sprint7.Project.V9
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonDown_VA = new Button();
            buttonPoisk_VA = new Button();
            labelTema_VA = new Label();
            buttonSave_VA = new Button();
            buttonMenu_VA = new Button();
            dataGridGlav_VA = new DataGridView();
            saveFileDialogMain_VA = new SaveFileDialog();
            openFileDialogMain_VA = new OpenFileDialog();
            toolTipMain_VA = new ToolTip(components);
            buttonGuide_VA = new Button();
            buttonOProg_VA = new Button();
            pictureBoxGuide_VA = new PictureBox();
            pictureBoxOProg_VA = new PictureBox();
            pictureBoxDown_VA = new PictureBox();
            pictureBoxSave_VA = new PictureBox();
            pictureBoxGraf_VA = new PictureBox();
            buttonGraf_VA = new Button();
            toolStripDropDownButtonTema_VA = new ToolStripDropDownButton();
            textBoxPoisk_VA = new TextBox();
            labelStrana_VA = new Label();
            buttonSbros_VA = new Button();
            comboBoxGenre = new ComboBox();
            comboBoxCountry = new ComboBox();
            buttonEdit_VA = new Button();
            pictureBoxEdit_VA = new PictureBox();
            radioButtonVoz_VA = new RadioButton();
            radioButtonYb_VA = new RadioButton();
            groupBoxSort_VA = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridGlav_VA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGuide_VA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOProg_VA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDown_VA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSave_VA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGraf_VA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEdit_VA).BeginInit();
            groupBoxSort_VA.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDown_VA
            // 
            buttonDown_VA.BackColor = Color.SeaGreen;
            buttonDown_VA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonDown_VA.Location = new Point(283, 557);
            buttonDown_VA.Name = "buttonDown_VA";
            buttonDown_VA.Size = new Size(169, 44);
            buttonDown_VA.TabIndex = 7;
            buttonDown_VA.Text = "Открыть файл";
            toolTipMain_VA.SetToolTip(buttonDown_VA, "Открывает файл формата CVS");
            buttonDown_VA.UseVisualStyleBackColor = false;
            buttonDown_VA.Click += buttonDown_VA_Click;
            // 
            // buttonPoisk_VA
            // 
            buttonPoisk_VA.BackColor = Color.SeaGreen;
            buttonPoisk_VA.Image = (Image)resources.GetObject("buttonPoisk_VA.Image");
            buttonPoisk_VA.Location = new Point(864, 87);
            buttonPoisk_VA.Name = "buttonPoisk_VA";
            buttonPoisk_VA.Size = new Size(51, 40);
            buttonPoisk_VA.TabIndex = 13;
            toolTipMain_VA.SetToolTip(buttonPoisk_VA, "Осуществляет поиск по таблице");
            buttonPoisk_VA.UseVisualStyleBackColor = false;
            buttonPoisk_VA.Click += buttonPoisk_VA_Click;
            // 
            // labelTema_VA
            // 
            labelTema_VA.AutoSize = true;
            labelTema_VA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTema_VA.Location = new Point(12, 69);
            labelTema_VA.Name = "labelTema_VA";
            labelTema_VA.Size = new Size(50, 23);
            labelTema_VA.TabIndex = 14;
            labelTema_VA.Text = "Тема";
            // 
            // buttonSave_VA
            // 
            buttonSave_VA.BackColor = Color.SeaGreen;
            buttonSave_VA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonSave_VA.Location = new Point(103, 557);
            buttonSave_VA.Name = "buttonSave_VA";
            buttonSave_VA.Size = new Size(126, 44);
            buttonSave_VA.TabIndex = 23;
            buttonSave_VA.Text = "Сохранить";
            toolTipMain_VA.SetToolTip(buttonSave_VA, "Сохраняет файл");
            buttonSave_VA.UseVisualStyleBackColor = false;
            buttonSave_VA.Click += buttonSave_VA_Click;
            // 
            // buttonMenu_VA
            // 
            buttonMenu_VA.BackColor = Color.SeaGreen;
            buttonMenu_VA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonMenu_VA.Location = new Point(845, 4);
            buttonMenu_VA.Name = "buttonMenu_VA";
            buttonMenu_VA.Size = new Size(126, 44);
            buttonMenu_VA.TabIndex = 24;
            buttonMenu_VA.Text = "Выход";
            toolTipMain_VA.SetToolTip(buttonMenu_VA, "Выходит из программы");
            buttonMenu_VA.UseVisualStyleBackColor = false;
            buttonMenu_VA.Click += buttonMenu_VA_Click;
            // 
            // dataGridGlav_VA
            // 
            dataGridGlav_VA.BackgroundColor = SystemColors.ButtonShadow;
            dataGridGlav_VA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridGlav_VA.Location = new Point(11, 129);
            dataGridGlav_VA.Name = "dataGridGlav_VA";
            dataGridGlav_VA.RowHeadersWidth = 51;
            dataGridGlav_VA.Size = new Size(960, 413);
            dataGridGlav_VA.TabIndex = 27;
            // 
            // openFileDialogMain_VA
            // 
            openFileDialogMain_VA.FileName = "openFileDialog1";
            // 
            // buttonGuide_VA
            // 
            buttonGuide_VA.BackColor = Color.SeaGreen;
            buttonGuide_VA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonGuide_VA.Location = new Point(68, 7);
            buttonGuide_VA.Name = "buttonGuide_VA";
            buttonGuide_VA.Size = new Size(126, 44);
            buttonGuide_VA.TabIndex = 28;
            buttonGuide_VA.Text = "Руководство";
            toolTipMain_VA.SetToolTip(buttonGuide_VA, "Открывает инструкцю по пользованию программой");
            buttonGuide_VA.UseVisualStyleBackColor = false;
            buttonGuide_VA.Click += buttonGuide_VA_Click;
            // 
            // buttonOProg_VA
            // 
            buttonOProg_VA.BackColor = Color.SeaGreen;
            buttonOProg_VA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonOProg_VA.Location = new Point(260, 7);
            buttonOProg_VA.Name = "buttonOProg_VA";
            buttonOProg_VA.Size = new Size(126, 44);
            buttonOProg_VA.TabIndex = 29;
            buttonOProg_VA.Text = "О програме";
            toolTipMain_VA.SetToolTip(buttonOProg_VA, "Открывает окно о создателе");
            buttonOProg_VA.UseVisualStyleBackColor = false;
            buttonOProg_VA.Click += buttonOProg_VA_Click;
            // 
            // pictureBoxGuide_VA
            // 
            pictureBoxGuide_VA.Image = (Image)resources.GetObject("pictureBoxGuide_VA.Image");
            pictureBoxGuide_VA.Location = new Point(12, 4);
            pictureBoxGuide_VA.Name = "pictureBoxGuide_VA";
            pictureBoxGuide_VA.Size = new Size(50, 51);
            pictureBoxGuide_VA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGuide_VA.TabIndex = 31;
            pictureBoxGuide_VA.TabStop = false;
            // 
            // pictureBoxOProg_VA
            // 
            pictureBoxOProg_VA.Image = (Image)resources.GetObject("pictureBoxOProg_VA.Image");
            pictureBoxOProg_VA.Location = new Point(204, 4);
            pictureBoxOProg_VA.Name = "pictureBoxOProg_VA";
            pictureBoxOProg_VA.Size = new Size(50, 51);
            pictureBoxOProg_VA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxOProg_VA.TabIndex = 32;
            pictureBoxOProg_VA.TabStop = false;
            // 
            // pictureBoxDown_VA
            // 
            pictureBoxDown_VA.Image = (Image)resources.GetObject("pictureBoxDown_VA.Image");
            pictureBoxDown_VA.Location = new Point(252, 555);
            pictureBoxDown_VA.Name = "pictureBoxDown_VA";
            pictureBoxDown_VA.Size = new Size(50, 51);
            pictureBoxDown_VA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDown_VA.TabIndex = 33;
            pictureBoxDown_VA.TabStop = false;
            // 
            // pictureBoxSave_VA
            // 
            pictureBoxSave_VA.Image = (Image)resources.GetObject("pictureBoxSave_VA.Image");
            pictureBoxSave_VA.Location = new Point(65, 555);
            pictureBoxSave_VA.Name = "pictureBoxSave_VA";
            pictureBoxSave_VA.Size = new Size(50, 51);
            pictureBoxSave_VA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSave_VA.TabIndex = 34;
            pictureBoxSave_VA.TabStop = false;
            // 
            // pictureBoxGraf_VA
            // 
            pictureBoxGraf_VA.Image = (Image)resources.GetObject("pictureBoxGraf_VA.Image");
            pictureBoxGraf_VA.Location = new Point(681, 555);
            pictureBoxGraf_VA.Name = "pictureBoxGraf_VA";
            pictureBoxGraf_VA.Size = new Size(50, 51);
            pictureBoxGraf_VA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGraf_VA.TabIndex = 36;
            pictureBoxGraf_VA.TabStop = false;
            // 
            // buttonGraf_VA
            // 
            buttonGraf_VA.BackColor = Color.SeaGreen;
            buttonGraf_VA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonGraf_VA.Location = new Point(718, 557);
            buttonGraf_VA.Name = "buttonGraf_VA";
            buttonGraf_VA.Size = new Size(126, 44);
            buttonGraf_VA.TabIndex = 35;
            buttonGraf_VA.Text = "График";
            toolTipMain_VA.SetToolTip(buttonGraf_VA, "Открывает окно с графиком");
            buttonGraf_VA.UseVisualStyleBackColor = false;
            buttonGraf_VA.Click += buttonGraf_VA_Click;
            // 
            // toolStripDropDownButtonTema_VA
            // 
            toolStripDropDownButtonTema_VA.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButtonTema_VA.Image = (Image)resources.GetObject("toolStripDropDownButtonTema_VA.Image");
            toolStripDropDownButtonTema_VA.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButtonTema_VA.Name = "toolStripDropDownButtonTema_VA";
            toolStripDropDownButtonTema_VA.Size = new Size(34, 24);
            toolStripDropDownButtonTema_VA.Text = "toolStripDropDownButton1";
            // 
            // textBoxPoisk_VA
            // 
            textBoxPoisk_VA.BackColor = SystemColors.HighlightText;
            textBoxPoisk_VA.Location = new Point(633, 86);
            textBoxPoisk_VA.Multiline = true;
            textBoxPoisk_VA.Name = "textBoxPoisk_VA";
            textBoxPoisk_VA.Size = new Size(223, 37);
            textBoxPoisk_VA.TabIndex = 40;
            textBoxPoisk_VA.Text = "Поиск";
            textBoxPoisk_VA.Click += textBoxPoisk_VA_TextChanged;
            textBoxPoisk_VA.Enter += textBoxPoisk_VA_TextChanged;
            textBoxPoisk_VA.Leave += textBoxPoisk_VA_Leave;
            // 
            // labelStrana_VA
            // 
            labelStrana_VA.AutoSize = true;
            labelStrana_VA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelStrana_VA.Location = new Point(167, 70);
            labelStrana_VA.Name = "labelStrana_VA";
            labelStrana_VA.Size = new Size(68, 23);
            labelStrana_VA.TabIndex = 43;
            labelStrana_VA.Text = "Страна";
            // 
            // buttonSbros_VA
            // 
            buttonSbros_VA.BackgroundImage = (Image)resources.GetObject("buttonSbros_VA.BackgroundImage");
            buttonSbros_VA.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSbros_VA.Location = new Point(921, 87);
            buttonSbros_VA.Name = "buttonSbros_VA";
            buttonSbros_VA.Size = new Size(48, 40);
            buttonSbros_VA.TabIndex = 44;
            toolTipMain_VA.SetToolTip(buttonSbros_VA, "Сбрасывает выбранные критерии");
            buttonSbros_VA.UseVisualStyleBackColor = true;
            buttonSbros_VA.Click += buttonSbros_VA_Click;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(11, 96);
            comboBoxGenre.Margin = new Padding(3, 4, 3, 4);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(138, 28);
            comboBoxGenre.TabIndex = 46;
            comboBoxGenre.SelectedIndexChanged += comboBoxGenre_SelectedIndexChanged;
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.Location = new Point(167, 96);
            comboBoxCountry.Margin = new Padding(3, 4, 3, 4);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(138, 28);
            comboBoxCountry.TabIndex = 47;
            comboBoxCountry.SelectedIndexChanged += comboBoxCountry_SelectedIndexChanged;
            // 
            // buttonEdit_VA
            // 
            buttonEdit_VA.BackColor = Color.SeaGreen;
            buttonEdit_VA.BackgroundImageLayout = ImageLayout.Stretch;
            buttonEdit_VA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonEdit_VA.Location = new Point(508, 555);
            buttonEdit_VA.Margin = new Padding(0);
            buttonEdit_VA.Name = "buttonEdit_VA";
            buttonEdit_VA.Size = new Size(151, 44);
            buttonEdit_VA.TabIndex = 45;
            buttonEdit_VA.Text = "Редактировать";
            toolTipMain_VA.SetToolTip(buttonEdit_VA, "Позволяет редактировать таблицу в приложении");
            buttonEdit_VA.UseVisualStyleBackColor = false;
            buttonEdit_VA.Click += buttonEdit_VA_Click;
            // 
            // pictureBoxEdit_VA
            // 
            pictureBoxEdit_VA.Image = (Image)resources.GetObject("pictureBoxEdit_VA.Image");
            pictureBoxEdit_VA.Location = new Point(468, 555);
            pictureBoxEdit_VA.Name = "pictureBoxEdit_VA";
            pictureBoxEdit_VA.Size = new Size(50, 51);
            pictureBoxEdit_VA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxEdit_VA.TabIndex = 48;
            pictureBoxEdit_VA.TabStop = false;
            // 
            // radioButtonVoz_VA
            // 
            radioButtonVoz_VA.AutoSize = true;
            radioButtonVoz_VA.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButtonVoz_VA.Location = new Point(5, 30);
            radioButtonVoz_VA.Name = "radioButtonVoz_VA";
            radioButtonVoz_VA.Size = new Size(149, 24);
            radioButtonVoz_VA.TabIndex = 51;
            radioButtonVoz_VA.TabStop = true;
            radioButtonVoz_VA.Text = "По возрастанию";
            radioButtonVoz_VA.UseVisualStyleBackColor = true;
            radioButtonVoz_VA.CheckedChanged += radioButtonVoz_VA_CheckedChanged;
            // 
            // radioButtonYb_VA
            // 
            radioButtonYb_VA.AutoSize = true;
            radioButtonYb_VA.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButtonYb_VA.Location = new Point(157, 30);
            radioButtonYb_VA.Name = "radioButtonYb_VA";
            radioButtonYb_VA.Size = new Size(131, 24);
            radioButtonYb_VA.TabIndex = 52;
            radioButtonYb_VA.TabStop = true;
            radioButtonYb_VA.Text = "По убыванию";
            radioButtonYb_VA.UseVisualStyleBackColor = true;
            radioButtonYb_VA.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // groupBoxSort_VA
            // 
            groupBoxSort_VA.Controls.Add(radioButtonYb_VA);
            groupBoxSort_VA.Controls.Add(radioButtonVoz_VA);
            groupBoxSort_VA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxSort_VA.Location = new Point(311, 70);
            groupBoxSort_VA.Name = "groupBoxSort_VA";
            groupBoxSort_VA.Size = new Size(316, 57);
            groupBoxSort_VA.TabIndex = 53;
            groupBoxSort_VA.TabStop = false;
            groupBoxSort_VA.Text = "Сортировка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(983, 624);
            Controls.Add(groupBoxSort_VA);
            Controls.Add(pictureBoxEdit_VA);
            Controls.Add(buttonEdit_VA);
            Controls.Add(comboBoxCountry);
            Controls.Add(comboBoxGenre);
            Controls.Add(buttonSbros_VA);
            Controls.Add(labelStrana_VA);
            Controls.Add(textBoxPoisk_VA);
            Controls.Add(pictureBoxGraf_VA);
            Controls.Add(buttonGraf_VA);
            Controls.Add(pictureBoxSave_VA);
            Controls.Add(pictureBoxDown_VA);
            Controls.Add(pictureBoxOProg_VA);
            Controls.Add(pictureBoxGuide_VA);
            Controls.Add(buttonOProg_VA);
            Controls.Add(buttonGuide_VA);
            Controls.Add(dataGridGlav_VA);
            Controls.Add(buttonMenu_VA);
            Controls.Add(buttonSave_VA);
            Controls.Add(labelTema_VA);
            Controls.Add(buttonPoisk_VA);
            Controls.Add(buttonDown_VA);
            Name = "FormMain";
            Text = "Каталог видео";
            ((System.ComponentModel.ISupportInitialize)dataGridGlav_VA).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGuide_VA).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOProg_VA).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDown_VA).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSave_VA).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGraf_VA).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEdit_VA).EndInit();
            groupBoxSort_VA.ResumeLayout(false);
            groupBoxSort_VA.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonDown_VA;
        private Button buttonPoisk_VA;
        private Label labelTema_VA;
        private Label labelDate_VA;
        private Button buttonSave_VA;
        private Button buttonMenu_VA;
        private ComboBox comboBoxTema_VA;
        private ComboBox comboBoxDate_VA;
        private DataGridView dataGridGlav_VA;
        private SaveFileDialog saveFileDialogMain_VA;
        private OpenFileDialog openFileDialogMain_VA;
        private ToolTip toolTipMain_VA;
        private Button buttonGuide_VA;
        private Button buttonOProg_VA;
        private PictureBox pictureBoxGuide_VA;
        private PictureBox pictureBoxOProg_VA;
        private PictureBox pictureBoxDown_VA;
        private PictureBox pictureBoxSave_VA;
        private PictureBox pictureBoxGraf_VA;
        private Button buttonGraf_VA;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripDropDownButton toolStripDropDownButtonTema_VA;
        private TextBox textBoxPoisk_VA;
        private Label labelStrana_VA;
        private Button buttonSbros_VA;
        private ComboBox comboBoxGenre;
        private ComboBox comboBoxCountry;
        private Button buttonEdit_VA;
        private PictureBox pictureBoxEdit_VA;
        private Label labelSort_VA;
        private RadioButton radioButtonVoz_VA;
        private RadioButton radioButtonYb_VA;
        private GroupBox groupBoxSort_VA;
    }
}
