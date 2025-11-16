namespace GlowGenda2
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
            GetBeautiful = new Button();
            FirstName = new Label();
            LastName = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            TotalServices = new Label();
            SuspendLayout();
            // 
            // GetBeautiful
            // 
            GetBeautiful.Location = new Point(1227, 548);
            GetBeautiful.Name = "GetBeautiful";
            GetBeautiful.Size = new Size(241, 61);
            GetBeautiful.TabIndex = 0;
            GetBeautiful.Text = "Get Beautiful";
            GetBeautiful.UseVisualStyleBackColor = true;
            GetBeautiful.Click += GetBeautiful_Click;
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Location = new Point(49, 91);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(160, 41);
            FirstName.TabIndex = 1;
            FirstName.Text = "First Name";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Location = new Point(49, 183);
            LastName.Name = "LastName";
            LastName.Size = new Size(157, 41);
            LastName.TabIndex = 2;
            LastName.Text = "Last Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(245, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 47);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(245, 193);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 47);
            textBox2.TabIndex = 4;
            // 
            // TotalServices
            // 
            TotalServices.AutoSize = true;
            TotalServices.Location = new Point(287, 301);
            TotalServices.Name = "TotalServices";
            TotalServices.Size = new Size(195, 41);
            TotalServices.TabIndex = 5;
            TotalServices.Text = "Total Services";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.IMG_3472;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1514, 662);
            Controls.Add(TotalServices);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(LastName);
            Controls.Add(FirstName);
            Controls.Add(GetBeautiful);
            Name = "FormMain";
            Text = "GlowGenda Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GetBeautiful;
        private Label FirstName;
        private Label LastName;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label TotalServices;
    }
}
