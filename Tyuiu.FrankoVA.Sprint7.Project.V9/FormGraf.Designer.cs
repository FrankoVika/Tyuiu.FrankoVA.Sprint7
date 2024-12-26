namespace Tyuiu.FrankoVA.Sprint7.Project.V9
{
    partial class FormGraf
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGraf));
            buttonOProg_VA = new Button();
            buttonGuide_VA = new Button();
            buttonExit_VA = new Button();
            chartGraf_VA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            printDialog1 = new PrintDialog();
            textBoxRes_VA = new TextBox();
            menuStrip1 = new MenuStrip();
            toolStripMenuItemMax_VA = new ToolStripMenuItem();
            длительностьToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItemMin_VA = new ToolStripMenuItem();
            длительностьToolStripMenuItem1 = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)chartGraf_VA).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonOProg_VA
            // 
            buttonOProg_VA.BackColor = Color.SeaGreen;
            buttonOProg_VA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonOProg_VA.Location = new Point(767, 12);
            buttonOProg_VA.Name = "buttonOProg_VA";
            buttonOProg_VA.Size = new Size(129, 37);
            buttonOProg_VA.TabIndex = 34;
            buttonOProg_VA.Text = "О програме";
            buttonOProg_VA.UseVisualStyleBackColor = false;
            buttonOProg_VA.Click += buttonOProg_VA_Click;
            // 
            // buttonGuide_VA
            // 
            buttonGuide_VA.BackColor = Color.SeaGreen;
            buttonGuide_VA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonGuide_VA.Location = new Point(562, 12);
            buttonGuide_VA.Name = "buttonGuide_VA";
            buttonGuide_VA.Size = new Size(121, 37);
            buttonGuide_VA.TabIndex = 33;
            buttonGuide_VA.Text = "Руководство";
            buttonGuide_VA.UseVisualStyleBackColor = false;
            buttonGuide_VA.Click += buttonGuide_VA_Click;
            // 
            // buttonExit_VA
            // 
            buttonExit_VA.BackColor = Color.SeaGreen;
            buttonExit_VA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonExit_VA.Location = new Point(11, 12);
            buttonExit_VA.Name = "buttonExit_VA";
            buttonExit_VA.Size = new Size(126, 44);
            buttonExit_VA.TabIndex = 37;
            buttonExit_VA.Text = "Назад";
            buttonExit_VA.UseVisualStyleBackColor = false;
            buttonExit_VA.Click += buttonExit_VA_Click;
            // 
            // chartGraf_VA
            // 
            chartArea2.Name = "ChartArea1";
            chartGraf_VA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartGraf_VA.Legends.Add(legend2);
            chartGraf_VA.Location = new Point(14, 122);
            chartGraf_VA.Margin = new Padding(3, 4, 3, 4);
            chartGraf_VA.Name = "chartGraf_VA";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartGraf_VA.Series.Add(series2);
            chartGraf_VA.Size = new Size(957, 499);
            chartGraf_VA.TabIndex = 38;
            chartGraf_VA.Text = "chart1";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // textBoxRes_VA
            // 
            textBoxRes_VA.Location = new Point(502, 75);
            textBoxRes_VA.Multiline = true;
            textBoxRes_VA.Name = "textBoxRes_VA";
            textBoxRes_VA.Size = new Size(245, 31);
            textBoxRes_VA.TabIndex = 39;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Segoe UI", 10F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItemMax_VA, ToolStripMenuItemMin_VA });
            menuStrip1.Location = new Point(14, 75);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(447, 31);
            menuStrip1.TabIndex = 42;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemMax_VA
            // 
            toolStripMenuItemMax_VA.DropDownItems.AddRange(new ToolStripItem[] { длительностьToolStripMenuItem });
            toolStripMenuItemMax_VA.Name = "toolStripMenuItemMax_VA";
            toolStripMenuItemMax_VA.Size = new Size(222, 27);
            toolStripMenuItemMax_VA.Text = "Максимальное значение";
            // 
            // длительностьToolStripMenuItem
            // 
            длительностьToolStripMenuItem.Name = "длительностьToolStripMenuItem";
            длительностьToolStripMenuItem.Size = new Size(224, 28);
            длительностьToolStripMenuItem.Text = "Длительность";
            длительностьToolStripMenuItem.Click += длительностьToolStripMenuItem_Click;
            // 
            // ToolStripMenuItemMin_VA
            // 
            ToolStripMenuItemMin_VA.DropDownItems.AddRange(new ToolStripItem[] { длительностьToolStripMenuItem1 });
            ToolStripMenuItemMin_VA.Name = "ToolStripMenuItemMin_VA";
            ToolStripMenuItemMin_VA.Size = new Size(217, 27);
            ToolStripMenuItemMin_VA.Text = "Минимальное значение";
            // 
            // длительностьToolStripMenuItem1
            // 
            длительностьToolStripMenuItem1.Name = "длительностьToolStripMenuItem1";
            длительностьToolStripMenuItem1.Size = new Size(224, 28);
            длительностьToolStripMenuItem1.Text = "Длительность";
            длительностьToolStripMenuItem1.Click += длительностьToolStripMenuItem1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(711, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(506, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // FormGraf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(983, 624);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(textBoxRes_VA);
            Controls.Add(chartGraf_VA);
            Controls.Add(buttonExit_VA);
            Controls.Add(buttonOProg_VA);
            Controls.Add(buttonGuide_VA);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormGraf";
            Text = "График";
            ((System.ComponentModel.ISupportInitialize)chartGraf_VA).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonOProg_VA;
        private Button buttonGuide_VA;
        private Button buttonExit_VA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraf_VA;
        private PrintDialog printDialog1;
        private TextBox textBoxRes_VA;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItemMax_VA;
        private ToolStripMenuItem длительностьToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuItemMin_VA;
        private ToolStripMenuItem длительностьToolStripMenuItem1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}