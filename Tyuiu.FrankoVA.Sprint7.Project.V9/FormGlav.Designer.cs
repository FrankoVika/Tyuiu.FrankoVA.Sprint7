namespace Tyuiu.FrankoVA.Sprint7.Project.V9
{
    partial class FormGlav
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
            buttonGuide_VA = new Button();
            buttonOProg_VA = new Button();
            buttonOpen_VA = new Button();
            buttonExit_VA = new Button();
            SuspendLayout();
            // 
            // buttonGuide_VA
            // 
            buttonGuide_VA.BackColor = Color.SeaGreen;
            buttonGuide_VA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonGuide_VA.Location = new Point(64, 185);
            buttonGuide_VA.Name = "buttonGuide_VA";
            buttonGuide_VA.Size = new Size(202, 57);
            buttonGuide_VA.TabIndex = 29;
            buttonGuide_VA.Text = "Руководство";
            buttonGuide_VA.UseVisualStyleBackColor = false;
            buttonGuide_VA.Click += buttonGuide_VA_Click;
            // 
            // buttonOProg_VA
            // 
            buttonOProg_VA.BackColor = Color.SeaGreen;
            buttonOProg_VA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonOProg_VA.Location = new Point(385, 185);
            buttonOProg_VA.Name = "buttonOProg_VA";
            buttonOProg_VA.Size = new Size(202, 57);
            buttonOProg_VA.TabIndex = 30;
            buttonOProg_VA.Text = "О програме";
            buttonOProg_VA.UseVisualStyleBackColor = false;
            buttonOProg_VA.Click += buttonOProg_VA_Click;
            // 
            // buttonOpen_VA
            // 
            buttonOpen_VA.BackColor = Color.SeaGreen;
            buttonOpen_VA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonOpen_VA.Location = new Point(224, 86);
            buttonOpen_VA.Name = "buttonOpen_VA";
            buttonOpen_VA.Size = new Size(202, 57);
            buttonOpen_VA.TabIndex = 31;
            buttonOpen_VA.Text = "Войти";
            buttonOpen_VA.UseVisualStyleBackColor = false;
            buttonOpen_VA.Click += buttonOpen_VA_Click;
            // 
            // buttonExit_VA
            // 
            buttonExit_VA.BackColor = Color.SeaGreen;
            buttonExit_VA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonExit_VA.Location = new Point(502, 300);
            buttonExit_VA.Name = "buttonExit_VA";
            buttonExit_VA.Size = new Size(158, 57);
            buttonExit_VA.TabIndex = 32;
            buttonExit_VA.Text = "Выход";
            buttonExit_VA.UseVisualStyleBackColor = false;
            buttonExit_VA.Click += buttonExit_VA_Click;
            // 
            // FormGlav
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(672, 369);
            Controls.Add(buttonExit_VA);
            Controls.Add(buttonOpen_VA);
            Controls.Add(buttonOProg_VA);
            Controls.Add(buttonGuide_VA);
            Name = "FormGlav";
            Text = "Главная страница";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonGuide_VA;
        private Button buttonOProg_VA;
        private Button buttonOpen_VA;
        private Button buttonExit_VA;
    }
}