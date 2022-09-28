namespace Library
{
    partial class AdminFunctions
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
            this.returnBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.dayText = new System.Windows.Forms.TextBox();
            this.monthText = new System.Windows.Forms.TextBox();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.isbnText = new System.Windows.Forms.TextBox();
            this.yearText = new System.Windows.Forms.TextBox();
            this.publisherText = new System.Windows.Forms.TextBox();
            this.authorText = new System.Windows.Forms.TextBox();
            this.titleText = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.add2Btn = new System.Windows.Forms.Button();
            this.genreText = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.sucLabel = new System.Windows.Forms.Label();
            this.rtrnBtn = new System.Windows.Forms.Button();
            this.error2Label = new System.Windows.Forms.Label();
            this.isbn2Label = new System.Windows.Forms.Label();
            this.title2Label = new System.Windows.Forms.Label();
            this.title2Text = new System.Windows.Forms.TextBox();
            this.isbn2Text = new System.Windows.Forms.TextBox();
            this.suc2Label = new System.Windows.Forms.Label();
            this.iconLabel = new System.Windows.Forms.Label();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returnBtn
            // 
            this.returnBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.returnBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.returnBtn.Location = new System.Drawing.Point(221, 190);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(120, 45);
            this.returnBtn.TabIndex = 1;
            this.returnBtn.Text = "Return book";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.addBtn.Location = new System.Drawing.Point(442, 190);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(120, 45);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add new book";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dayText
            // 
            this.dayText.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dayText.Location = new System.Drawing.Point(713, 262);
            this.dayText.Name = "dayText";
            this.dayText.Size = new System.Drawing.Size(47, 23);
            this.dayText.TabIndex = 35;
            this.dayText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dayText.Visible = false;
            // 
            // monthText
            // 
            this.monthText.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthText.Location = new System.Drawing.Point(648, 262);
            this.monthText.Name = "monthText";
            this.monthText.Size = new System.Drawing.Size(49, 23);
            this.monthText.TabIndex = 34;
            this.monthText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.monthText.Visible = false;
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.BackColor = System.Drawing.Color.Transparent;
            this.isbnLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.isbnLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.isbnLabel.Location = new System.Drawing.Point(653, 377);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(36, 16);
            this.isbnLabel.TabIndex = 33;
            this.isbnLabel.Text = "ISBN";
            this.isbnLabel.Visible = false;
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.BackColor = System.Drawing.Color.Transparent;
            this.monthLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monthLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.monthLabel.Location = new System.Drawing.Point(654, 288);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(48, 16);
            this.monthLabel.TabIndex = 32;
            this.monthLabel.Text = "Month";
            this.monthLabel.Visible = false;
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.BackColor = System.Drawing.Color.Transparent;
            this.publisherLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.publisherLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.publisherLabel.Location = new System.Drawing.Point(640, 243);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(62, 16);
            this.publisherLabel.TabIndex = 31;
            this.publisherLabel.Text = "Publisher";
            this.publisherLabel.Visible = false;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.BackColor = System.Drawing.Color.Transparent;
            this.authorLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.authorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.authorLabel.Location = new System.Drawing.Point(646, 194);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(51, 16);
            this.authorLabel.TabIndex = 30;
            this.authorLabel.Text = "Author";
            this.authorLabel.Visible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabel.Location = new System.Drawing.Point(654, 150);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(33, 16);
            this.titleLabel.TabIndex = 29;
            this.titleLabel.Text = "Title";
            this.titleLabel.Visible = false;
            // 
            // isbnText
            // 
            this.isbnText.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isbnText.Location = new System.Drawing.Point(583, 351);
            this.isbnText.Name = "isbnText";
            this.isbnText.Size = new System.Drawing.Size(177, 23);
            this.isbnText.TabIndex = 28;
            this.isbnText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.isbnText.Visible = false;
            this.isbnText.TextChanged += new System.EventHandler(this.isbnText_TextChanged);
            // 
            // yearText
            // 
            this.yearText.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearText.Location = new System.Drawing.Point(583, 262);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(51, 23);
            this.yearText.TabIndex = 27;
            this.yearText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yearText.Visible = false;
            // 
            // publisherText
            // 
            this.publisherText.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.publisherText.Location = new System.Drawing.Point(584, 213);
            this.publisherText.Name = "publisherText";
            this.publisherText.Size = new System.Drawing.Size(177, 23);
            this.publisherText.TabIndex = 26;
            this.publisherText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.publisherText.Visible = false;
            // 
            // authorText
            // 
            this.authorText.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authorText.Location = new System.Drawing.Point(584, 168);
            this.authorText.Name = "authorText";
            this.authorText.Size = new System.Drawing.Size(177, 23);
            this.authorText.TabIndex = 25;
            this.authorText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.authorText.Visible = false;
            // 
            // titleText
            // 
            this.titleText.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleText.Location = new System.Drawing.Point(584, 126);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(177, 23);
            this.titleText.TabIndex = 24;
            this.titleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.titleText.Visible = false;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.BackColor = System.Drawing.Color.Transparent;
            this.yearLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yearLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yearLabel.Location = new System.Drawing.Point(594, 288);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 16);
            this.yearLabel.TabIndex = 36;
            this.yearLabel.Text = "Year";
            this.yearLabel.Visible = false;
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.BackColor = System.Drawing.Color.Transparent;
            this.dayLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dayLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dayLabel.Location = new System.Drawing.Point(722, 288);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(29, 16);
            this.dayLabel.TabIndex = 37;
            this.dayLabel.Text = "Day";
            this.dayLabel.Visible = false;
            // 
            // add2Btn
            // 
            this.add2Btn.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add2Btn.ForeColor = System.Drawing.Color.OrangeRed;
            this.add2Btn.Location = new System.Drawing.Point(636, 395);
            this.add2Btn.Name = "add2Btn";
            this.add2Btn.Size = new System.Drawing.Size(73, 23);
            this.add2Btn.TabIndex = 38;
            this.add2Btn.Text = "Add ";
            this.add2Btn.UseVisualStyleBackColor = true;
            this.add2Btn.Visible = false;
            this.add2Btn.Click += new System.EventHandler(this.add2Btn_Click);
            // 
            // genreText
            // 
            this.genreText.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genreText.Location = new System.Drawing.Point(583, 306);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(177, 23);
            this.genreText.TabIndex = 39;
            this.genreText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.genreText.Visible = false;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.BackColor = System.Drawing.Color.Transparent;
            this.genreLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.genreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.genreLabel.Location = new System.Drawing.Point(654, 333);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(41, 16);
            this.genreLabel.TabIndex = 40;
            this.genreLabel.Text = "Genre";
            this.genreLabel.Visible = false;
            // 
            // backBtn
            // 
            this.backBtn.ForeColor = System.Drawing.Color.Coral;
            this.backBtn.Location = new System.Drawing.Point(728, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(27, 23);
            this.backBtn.TabIndex = 42;
            this.backBtn.Text = "<-";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.ForeColor = System.Drawing.Color.Coral;
            this.exitBtn.Location = new System.Drawing.Point(761, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(27, 23);
            this.exitBtn.TabIndex = 41;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.IndianRed;
            this.errorLabel.ForeColor = System.Drawing.Color.Coral;
            this.errorLabel.Location = new System.Drawing.Point(649, 421);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(46, 15);
            this.errorLabel.TabIndex = 43;
            this.errorLabel.Text = "ERROR!\r\n";
            this.errorLabel.Visible = false;
            // 
            // sucLabel
            // 
            this.sucLabel.AutoSize = true;
            this.sucLabel.BackColor = System.Drawing.Color.IndianRed;
            this.sucLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sucLabel.ForeColor = System.Drawing.Color.Coral;
            this.sucLabel.Location = new System.Drawing.Point(649, 421);
            this.sucLabel.Name = "sucLabel";
            this.sucLabel.Size = new System.Drawing.Size(51, 16);
            this.sucLabel.TabIndex = 44;
            this.sucLabel.Text = "ADDED!\r\n";
            this.sucLabel.Visible = false;
            // 
            // rtrnBtn
            // 
            this.rtrnBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtrnBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.rtrnBtn.Location = new System.Drawing.Point(96, 270);
            this.rtrnBtn.Name = "rtrnBtn";
            this.rtrnBtn.Size = new System.Drawing.Size(71, 25);
            this.rtrnBtn.TabIndex = 50;
            this.rtrnBtn.Text = "Return";
            this.rtrnBtn.UseVisualStyleBackColor = true;
            this.rtrnBtn.Visible = false;
            this.rtrnBtn.Click += new System.EventHandler(this.rtrnBtn_Click);
            // 
            // error2Label
            // 
            this.error2Label.AutoSize = true;
            this.error2Label.BackColor = System.Drawing.Color.IndianRed;
            this.error2Label.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.error2Label.ForeColor = System.Drawing.Color.Coral;
            this.error2Label.Location = new System.Drawing.Point(67, 305);
            this.error2Label.Name = "error2Label";
            this.error2Label.Size = new System.Drawing.Size(117, 16);
            this.error2Label.TabIndex = 49;
            this.error2Label.Text = "There is no that book!";
            this.error2Label.Visible = false;
            // 
            // isbn2Label
            // 
            this.isbn2Label.AutoSize = true;
            this.isbn2Label.BackColor = System.Drawing.Color.Transparent;
            this.isbn2Label.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.isbn2Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.isbn2Label.Location = new System.Drawing.Point(82, 253);
            this.isbn2Label.Name = "isbn2Label";
            this.isbn2Label.Size = new System.Drawing.Size(106, 16);
            this.isbn2Label.TabIndex = 48;
            this.isbn2Label.Text = "Enter book ISBN";
            this.isbn2Label.Visible = false;
            // 
            // title2Label
            // 
            this.title2Label.AutoSize = true;
            this.title2Label.BackColor = System.Drawing.Color.Transparent;
            this.title2Label.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title2Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title2Label.Location = new System.Drawing.Point(82, 194);
            this.title2Label.Name = "title2Label";
            this.title2Label.Size = new System.Drawing.Size(101, 16);
            this.title2Label.TabIndex = 47;
            this.title2Label.Text = "Enter book title";
            this.title2Label.Visible = false;
            // 
            // title2Text
            // 
            this.title2Text.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title2Text.Location = new System.Drawing.Point(71, 168);
            this.title2Text.Name = "title2Text";
            this.title2Text.Size = new System.Drawing.Size(117, 23);
            this.title2Text.TabIndex = 46;
            this.title2Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.title2Text.Visible = false;
            // 
            // isbn2Text
            // 
            this.isbn2Text.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isbn2Text.Location = new System.Drawing.Point(71, 226);
            this.isbn2Text.Name = "isbn2Text";
            this.isbn2Text.Size = new System.Drawing.Size(117, 23);
            this.isbn2Text.TabIndex = 45;
            this.isbn2Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.isbn2Text.Visible = false;
            // 
            // suc2Label
            // 
            this.suc2Label.AutoSize = true;
            this.suc2Label.BackColor = System.Drawing.Color.IndianRed;
            this.suc2Label.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.suc2Label.ForeColor = System.Drawing.Color.Coral;
            this.suc2Label.Location = new System.Drawing.Point(96, 305);
            this.suc2Label.Name = "suc2Label";
            this.suc2Label.Size = new System.Drawing.Size(72, 16);
            this.suc2Label.TabIndex = 51;
            this.suc2Label.Text = "RETURNED!";
            this.suc2Label.Visible = false;
            // 
            // iconLabel
            // 
            this.iconLabel.AutoSize = true;
            this.iconLabel.BackColor = System.Drawing.Color.Transparent;
            this.iconLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconLabel.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.iconLabel.Location = new System.Drawing.Point(16, 17);
            this.iconLabel.Name = "iconLabel";
            this.iconLabel.Size = new System.Drawing.Size(151, 18);
            this.iconLabel.TabIndex = 52;
            this.iconLabel.Text = "Library system";
            this.iconLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.BackColor = System.Drawing.Color.Transparent;
            this.chooseLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chooseLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chooseLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.chooseLabel.Location = new System.Drawing.Point(282, 126);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(233, 20);
            this.chooseLabel.TabIndex = 53;
            this.chooseLabel.Text = "Choose what you want to do:";
            this.chooseLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AdminFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImage = global::Library.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.iconLabel);
            this.Controls.Add(this.suc2Label);
            this.Controls.Add(this.rtrnBtn);
            this.Controls.Add(this.error2Label);
            this.Controls.Add(this.isbn2Label);
            this.Controls.Add(this.title2Label);
            this.Controls.Add(this.title2Text);
            this.Controls.Add(this.isbn2Text);
            this.Controls.Add(this.sucLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.add2Btn);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.dayText);
            this.Controls.Add(this.monthText);
            this.Controls.Add(this.isbnLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.isbnText);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.publisherText);
            this.Controls.Add(this.authorText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.returnBtn);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "AdminFunctions";
            this.Text = "Library System";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button returnBtn;
        private Button addBtn;
        private TextBox dayText;
        private TextBox monthText;
        private Label isbnLabel;
        private Label monthLabel;
        private Label publisherLabel;
        private Label authorLabel;
        private Label titleLabel;
        private TextBox isbnText;
        private TextBox yearText;
        private TextBox publisherText;
        private TextBox authorText;
        private TextBox titleText;
        private Label yearLabel;
        private Label dayLabel;
        private Button add2Btn;
        private TextBox genreText;
        private Label genreLabel;
        private Button backBtn;
        private Button exitBtn;
        private Label errorLabel;
        private Label sucLabel;
        private Button rtrnBtn;
        private Label error2Label;
        private Label isbn2Label;
        private Label title2Label;
        private TextBox title2Text;
        private TextBox isbn2Text;
        private Label suc2Label;
        private Label iconLabel;
        private Label chooseLabel;
    }
}