namespace Library
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.signBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.signGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.signGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(216, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the library system!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtName.Location = new System.Drawing.Point(16, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 23);
            this.txtName.TabIndex = 1;
            this.txtName.Tag = "nameText";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPass.Location = new System.Drawing.Point(16, 69);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(199, 23);
            this.txtPass.TabIndex = 2;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.nameLabel.Location = new System.Drawing.Point(81, 49);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(69, 17);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Nickname";
            this.nameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.BackColor = System.Drawing.Color.Transparent;
            this.passLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.passLabel.Location = new System.Drawing.Point(81, 95);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(66, 17);
            this.passLabel.TabIndex = 4;
            this.passLabel.Text = "Password";
            // 
            // signBtn
            // 
            this.signBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signBtn.Location = new System.Drawing.Point(75, 158);
            this.signBtn.Name = "signBtn";
            this.signBtn.Size = new System.Drawing.Size(87, 34);
            this.signBtn.TabIndex = 5;
            this.signBtn.Text = "Sign in";
            this.signBtn.UseVisualStyleBackColor = true;
            this.signBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(761, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(27, 23);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.IndianRed;
            this.errorLabel.ForeColor = System.Drawing.Color.Coral;
            this.errorLabel.Location = new System.Drawing.Point(51, 128);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(133, 16);
            this.errorLabel.TabIndex = 16;
            this.errorLabel.Text = "There is no that user!\r\n";
            this.errorLabel.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.Tag = "<a href=\"https://www.flaticon.com/free-icons/library\" title=\"library icons\">Libra" +
    "ry icons created by Freepik - Flaticon</a>";
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Library.Properties.Resources.library;
            this.pictureBox1.Location = new System.Drawing.Point(345, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 103);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // signGroupBox
            // 
            this.signGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.signGroupBox.Controls.Add(this.errorLabel);
            this.signGroupBox.Controls.Add(this.signBtn);
            this.signGroupBox.Controls.Add(this.passLabel);
            this.signGroupBox.Controls.Add(this.nameLabel);
            this.signGroupBox.Controls.Add(this.txtPass);
            this.signGroupBox.Controls.Add(this.txtName);
            this.signGroupBox.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signGroupBox.Location = new System.Drawing.Point(282, 185);
            this.signGroupBox.Name = "signGroupBox";
            this.signGroupBox.Size = new System.Drawing.Size(235, 215);
            this.signGroupBox.TabIndex = 18;
            this.signGroupBox.TabStop = false;
            this.signGroupBox.Text = "Enter your name and password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::Library.Properties.Resources.loginwallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "Login";
            this.Text = "Library System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.signGroupBox.ResumeLayout(false);
            this.signGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtPass;
        private Label nameLabel;
        private Label passLabel;
        private Button signBtn;
        private Button exitBtn;
        private Label errorLabel;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox signGroupBox;
    }
}