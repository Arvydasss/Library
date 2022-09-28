namespace Library
{
    partial class ReaderFunctions
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
            this.mainSearchBtn = new System.Windows.Forms.Button();
            this.mainBorBtn = new System.Windows.Forms.Button();
            this.borLabel = new System.Windows.Forms.Label();
            this.isbn2Label = new System.Windows.Forms.Label();
            this.title2Label = new System.Windows.Forms.Label();
            this.title2Box = new System.Windows.Forms.TextBox();
            this.isbn2Box = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.search2Btn = new System.Windows.Forms.Button();
            this.error2Label = new System.Windows.Forms.Label();
            this.iconLabel = new System.Windows.Forms.Label();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.val2Label = new System.Windows.Forms.Label();
            this.borGroupBox = new System.Windows.Forms.GroupBox();
            this.mainResBtn = new System.Windows.Forms.Button();
            this.isbnBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.resLabel = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.valLabel = new System.Windows.Forms.Label();
            this.resGroupBox = new System.Windows.Forms.GroupBox();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.borGroupBox.SuspendLayout();
            this.resGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSearchBtn
            // 
            this.mainSearchBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mainSearchBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.mainSearchBtn.Location = new System.Drawing.Point(41, 0);
            this.mainSearchBtn.Name = "mainSearchBtn";
            this.mainSearchBtn.Size = new System.Drawing.Size(120, 45);
            this.mainSearchBtn.TabIndex = 0;
            this.mainSearchBtn.Text = "Search for books";
            this.mainSearchBtn.UseVisualStyleBackColor = true;
            this.mainSearchBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainBorBtn
            // 
            this.mainBorBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mainBorBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.mainBorBtn.Location = new System.Drawing.Point(33, 4);
            this.mainBorBtn.Name = "mainBorBtn";
            this.mainBorBtn.Size = new System.Drawing.Size(120, 45);
            this.mainBorBtn.TabIndex = 2;
            this.mainBorBtn.Text = "Borrow a book";
            this.mainBorBtn.UseVisualStyleBackColor = true;
            this.mainBorBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // borLabel
            // 
            this.borLabel.AutoSize = true;
            this.borLabel.BackColor = System.Drawing.Color.IndianRed;
            this.borLabel.ForeColor = System.Drawing.Color.Coral;
            this.borLabel.Location = new System.Drawing.Point(47, 206);
            this.borLabel.Name = "borLabel";
            this.borLabel.Size = new System.Drawing.Size(76, 16);
            this.borLabel.TabIndex = 12;
            this.borLabel.Text = "BORROWED!";
            this.borLabel.Visible = false;
            this.borLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // isbn2Label
            // 
            this.isbn2Label.AutoSize = true;
            this.isbn2Label.BackColor = System.Drawing.Color.Transparent;
            this.isbn2Label.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.isbn2Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.isbn2Label.Location = new System.Drawing.Point(33, 152);
            this.isbn2Label.Name = "isbn2Label";
            this.isbn2Label.Size = new System.Drawing.Size(115, 17);
            this.isbn2Label.TabIndex = 11;
            this.isbn2Label.Text = "Enter book ISBN";
            this.isbn2Label.Visible = false;
            this.isbn2Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // title2Label
            // 
            this.title2Label.AutoSize = true;
            this.title2Label.BackColor = System.Drawing.Color.Transparent;
            this.title2Label.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title2Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title2Label.Location = new System.Drawing.Point(33, 94);
            this.title2Label.Name = "title2Label";
            this.title2Label.Size = new System.Drawing.Size(111, 17);
            this.title2Label.TabIndex = 10;
            this.title2Label.Text = "Enter book title";
            this.title2Label.Visible = false;
            this.title2Label.Click += new System.EventHandler(this.label3_Click);
            // 
            // title2Box
            // 
            this.title2Box.Location = new System.Drawing.Point(33, 68);
            this.title2Box.Name = "title2Box";
            this.title2Box.Size = new System.Drawing.Size(117, 23);
            this.title2Box.TabIndex = 9;
            this.title2Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.title2Box.Visible = false;
            this.title2Box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // isbn2Box
            // 
            this.isbn2Box.Location = new System.Drawing.Point(33, 126);
            this.isbn2Box.Name = "isbn2Box";
            this.isbn2Box.Size = new System.Drawing.Size(117, 23);
            this.isbn2Box.TabIndex = 8;
            this.isbn2Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.isbn2Box.Visible = false;
            this.isbn2Box.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.Color.Coral;
            this.exitBtn.Location = new System.Drawing.Point(761, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(27, 23);
            this.exitBtn.TabIndex = 13;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backBtn.ForeColor = System.Drawing.Color.Coral;
            this.backBtn.Location = new System.Drawing.Point(728, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(27, 23);
            this.backBtn.TabIndex = 14;
            this.backBtn.Text = "<-";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // search2Btn
            // 
            this.search2Btn.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.search2Btn.ForeColor = System.Drawing.Color.OrangeRed;
            this.search2Btn.Location = new System.Drawing.Point(52, 170);
            this.search2Btn.Name = "search2Btn";
            this.search2Btn.Size = new System.Drawing.Size(71, 25);
            this.search2Btn.TabIndex = 17;
            this.search2Btn.Text = "Search";
            this.search2Btn.UseVisualStyleBackColor = true;
            this.search2Btn.Visible = false;
            this.search2Btn.Click += new System.EventHandler(this.search2Btn_Click);
            // 
            // error2Label
            // 
            this.error2Label.AutoSize = true;
            this.error2Label.BackColor = System.Drawing.Color.IndianRed;
            this.error2Label.ForeColor = System.Drawing.Color.Coral;
            this.error2Label.Location = new System.Drawing.Point(0, 206);
            this.error2Label.Name = "error2Label";
            this.error2Label.Size = new System.Drawing.Size(192, 16);
            this.error2Label.TabIndex = 18;
            this.error2Label.Text = "There is no that book or it is reserved!\r\n";
            this.error2Label.Visible = false;
            // 
            // iconLabel
            // 
            this.iconLabel.AutoSize = true;
            this.iconLabel.BackColor = System.Drawing.Color.Transparent;
            this.iconLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconLabel.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.iconLabel.Location = new System.Drawing.Point(12, 17);
            this.iconLabel.Name = "iconLabel";
            this.iconLabel.Size = new System.Drawing.Size(151, 18);
            this.iconLabel.TabIndex = 19;
            this.iconLabel.Text = "Library system";
            this.iconLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.BackColor = System.Drawing.Color.Transparent;
            this.chooseLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chooseLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chooseLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.chooseLabel.Location = new System.Drawing.Point(250, 115);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(274, 24);
            this.chooseLabel.TabIndex = 20;
            this.chooseLabel.Text = "Choose what you want to do:";
            this.chooseLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // val2Label
            // 
            this.val2Label.AutoSize = true;
            this.val2Label.BackColor = System.Drawing.Color.IndianRed;
            this.val2Label.ForeColor = System.Drawing.Color.Coral;
            this.val2Label.Location = new System.Drawing.Point(33, 206);
            this.val2Label.Name = "val2Label";
            this.val2Label.Size = new System.Drawing.Size(128, 16);
            this.val2Label.TabIndex = 22;
            this.val2Label.Text = "ISBN must be a number!\r\n";
            this.val2Label.Visible = false;
            // 
            // borGroupBox
            // 
            this.borGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.borGroupBox.Controls.Add(this.val2Label);
            this.borGroupBox.Controls.Add(this.search2Btn);
            this.borGroupBox.Controls.Add(this.borLabel);
            this.borGroupBox.Controls.Add(this.isbn2Label);
            this.borGroupBox.Controls.Add(this.error2Label);
            this.borGroupBox.Controls.Add(this.title2Label);
            this.borGroupBox.Controls.Add(this.title2Box);
            this.borGroupBox.Controls.Add(this.isbn2Box);
            this.borGroupBox.Controls.Add(this.mainBorBtn);
            this.borGroupBox.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.borGroupBox.Location = new System.Drawing.Point(506, 169);
            this.borGroupBox.Name = "borGroupBox";
            this.borGroupBox.Size = new System.Drawing.Size(191, 222);
            this.borGroupBox.TabIndex = 24;
            this.borGroupBox.TabStop = false;
            // 
            // mainResBtn
            // 
            this.mainResBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mainResBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.mainResBtn.Location = new System.Drawing.Point(37, 4);
            this.mainResBtn.Name = "mainResBtn";
            this.mainResBtn.Size = new System.Drawing.Size(120, 45);
            this.mainResBtn.TabIndex = 1;
            this.mainResBtn.Text = "Reserve a book";
            this.mainResBtn.UseVisualStyleBackColor = true;
            this.mainResBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // isbnBox
            // 
            this.isbnBox.Location = new System.Drawing.Point(39, 126);
            this.isbnBox.Name = "isbnBox";
            this.isbnBox.Size = new System.Drawing.Size(117, 23);
            this.isbnBox.TabIndex = 3;
            this.isbnBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.isbnBox.Visible = false;
            this.isbnBox.TextChanged += new System.EventHandler(this.isbnBox_TextChanged);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.IndianRed;
            this.errorLabel.ForeColor = System.Drawing.Color.Coral;
            this.errorLabel.Location = new System.Drawing.Point(0, 206);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(201, 16);
            this.errorLabel.TabIndex = 15;
            this.errorLabel.Text = "There is no that book or it is borrowed!";
            this.errorLabel.Visible = false;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(39, 68);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(117, 23);
            this.titleBox.TabIndex = 4;
            this.titleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.titleBox.Visible = false;
            this.titleBox.TextChanged += new System.EventHandler(this.resNameBox_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabel.Location = new System.Drawing.Point(39, 94);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(111, 17);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Enter book title";
            this.titleLabel.Visible = false;
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.BackColor = System.Drawing.Color.Transparent;
            this.isbnLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.isbnLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.isbnLabel.Location = new System.Drawing.Point(39, 152);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(115, 17);
            this.isbnLabel.TabIndex = 6;
            this.isbnLabel.Text = "Enter book ISBN";
            this.isbnLabel.Visible = false;
            // 
            // resLabel
            // 
            this.resLabel.AutoSize = true;
            this.resLabel.BackColor = System.Drawing.Color.IndianRed;
            this.resLabel.ForeColor = System.Drawing.Color.Coral;
            this.resLabel.Location = new System.Drawing.Point(64, 206);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(67, 16);
            this.resLabel.TabIndex = 7;
            this.resLabel.Text = "RESERVED!";
            this.resLabel.Visible = false;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.searchBtn.Location = new System.Drawing.Point(64, 170);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(71, 25);
            this.searchBtn.TabIndex = 16;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Visible = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // valLabel
            // 
            this.valLabel.AutoSize = true;
            this.valLabel.BackColor = System.Drawing.Color.IndianRed;
            this.valLabel.ForeColor = System.Drawing.Color.Coral;
            this.valLabel.Location = new System.Drawing.Point(37, 206);
            this.valLabel.Name = "valLabel";
            this.valLabel.Size = new System.Drawing.Size(128, 16);
            this.valLabel.TabIndex = 21;
            this.valLabel.Text = "ISBN must be a number!\r\n";
            this.valLabel.Visible = false;
            this.valLabel.Click += new System.EventHandler(this.valLabel_Click);
            // 
            // resGroupBox
            // 
            this.resGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.resGroupBox.Controls.Add(this.valLabel);
            this.resGroupBox.Controls.Add(this.searchBtn);
            this.resGroupBox.Controls.Add(this.resLabel);
            this.resGroupBox.Controls.Add(this.isbnLabel);
            this.resGroupBox.Controls.Add(this.titleLabel);
            this.resGroupBox.Controls.Add(this.titleBox);
            this.resGroupBox.Controls.Add(this.errorLabel);
            this.resGroupBox.Controls.Add(this.isbnBox);
            this.resGroupBox.Controls.Add(this.mainResBtn);
            this.resGroupBox.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resGroupBox.Location = new System.Drawing.Point(285, 169);
            this.resGroupBox.Name = "resGroupBox";
            this.resGroupBox.Size = new System.Drawing.Size(203, 221);
            this.resGroupBox.TabIndex = 23;
            this.resGroupBox.TabStop = false;
            this.resGroupBox.Text = "\'";
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.searchGroupBox.Controls.Add(this.mainSearchBtn);
            this.searchGroupBox.Location = new System.Drawing.Point(63, 173);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(200, 218);
            this.searchGroupBox.TabIndex = 25;
            this.searchGroupBox.TabStop = false;
            // 
            // ReaderFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::Library.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.borGroupBox);
            this.Controls.Add(this.resGroupBox);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.iconLabel);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.exitBtn);
            this.Name = "ReaderFunctions";
            this.Text = "Library System";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.borGroupBox.ResumeLayout(false);
            this.borGroupBox.PerformLayout();
            this.resGroupBox.ResumeLayout(false);
            this.resGroupBox.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button mainSearchBtn;
        private Button mainBorBtn;
        private Label borLabel;
        private Label isbn2Label;
        private Label title2Label;
        private TextBox title2Box;
        private TextBox isbn2Box;
        private Button exitBtn;
        private Button backBtn;
        private Label error2Label;
        private Button search2Btn;
        private Label iconLabel;
        private Label chooseLabel;
        private Label val2Label;
        private GroupBox borGroupBox;
        private Button mainResBtn;
        private TextBox isbnBox;
        private Label errorLabel;
        private TextBox titleBox;
        private Label titleLabel;
        private Label isbnLabel;
        private Label resLabel;
        private Button searchBtn;
        private Label valLabel;
        private GroupBox resGroupBox;
        private GroupBox searchGroupBox;
    }
}