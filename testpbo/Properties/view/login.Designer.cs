namespace testpbo
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            TBpass = new TextBox();
            TBuser = new TextBox();
            Btn = new Button();
            SuspendLayout();
            // 
            // TBpass
            // 
            TBpass.Location = new Point(157, 428);
            TBpass.Name = "TBpass";
            TBpass.Size = new Size(258, 27);
            TBpass.TabIndex = 0;
            // 
            // TBuser
            // 
            TBuser.Location = new Point(157, 339);
            TBuser.Name = "TBuser";
            TBuser.Size = new Size(258, 27);
            TBuser.TabIndex = 1;
            // 
            // Btn
            // 
            Btn.BackColor = Color.OliveDrab;
            Btn.FlatStyle = FlatStyle.Flat;
            Btn.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn.ForeColor = Color.White;
            Btn.Location = new Point(233, 478);
            Btn.Name = "Btn";
            Btn.Size = new Size(126, 50);
            Btn.TabIndex = 2;
            Btn.Text = "Login";
            Btn.UseVisualStyleBackColor = false;
            Btn.Click += button1_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1083, 613);
            Controls.Add(Btn);
            Controls.Add(TBuser);
            Controls.Add(TBpass);
            DoubleBuffered = true;
            Name = "login";
            Text = "BuahKita";
            Load += login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBpass;
        private TextBox TBuser;
        private Button Btn;
    }
}
