namespace calculator_DeskApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txt_username = new TextBox();
            txt_password = new TextBox();
            lbl_username = new Label();
            lbl_password = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.SeaShell;
            txt_username.Font = new Font("MV Boli", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_username.Location = new Point(311, 123);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(221, 42);
            txt_username.TabIndex = 0;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.SeaShell;
            txt_password.Font = new Font("MV Boli", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(311, 175);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(221, 42);
            txt_password.TabIndex = 1;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.BackColor = Color.SeaShell;
            lbl_username.Font = new Font("Script MT Bold", 17F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_username.Location = new Point(153, 123);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(144, 35);
            lbl_username.TabIndex = 2;
            lbl_username.Text = "UserName";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.BackColor = Color.SeaShell;
            lbl_password.Font = new Font("Script MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_password.Location = new Point(153, 176);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(123, 33);
            lbl_password.TabIndex = 3;
            lbl_password.Text = "Password";
            // 
            // button1
            // 
            button1.BackColor = Color.SeaShell;
            button1.Font = new Font("Script MT Bold", 17F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(273, 235);
            button1.Name = "button1";
            button1.Size = new Size(167, 50);
            button1.TabIndex = 4;
            button1.Text = "Log-In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(753, 394);
            Controls.Add(button1);
            Controls.Add(lbl_password);
            Controls.Add(lbl_username);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Name = "Form1";
            Text = "Calculator=>Log-In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_username;
        private TextBox txt_password;
        private Label lbl_username;
        private Label lbl_password;
        private Button button1;
    }
}