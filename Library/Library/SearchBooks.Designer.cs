namespace Library
{
    partial class SearchBooks
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
            this.titleText = new System.Windows.Forms.TextBox();
            this.authorText = new System.Windows.Forms.TextBox();
            this.publisherText = new System.Windows.Forms.TextBox();
            this.yearText = new System.Windows.Forms.TextBox();
            this.isbnText = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.availLabel = new System.Windows.Forms.Label();
            this.titleBtn = new System.Windows.Forms.Button();
            this.authorBtn = new System.Windows.Forms.Button();
            this.pubBtn = new System.Windows.Forms.Button();
            this.dateBtn = new System.Windows.Forms.Button();
            this.isbnBtn = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.monthText = new System.Windows.Forms.TextBox();
            this.dayText = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.genreBtn = new System.Windows.Forms.Button();
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreText = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.iconLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.valLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleText
            // 
            this.titleText.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleText.Location = new System.Drawing.Point(138, 85);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(177, 23);
            this.titleText.TabIndex = 0;
            this.titleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // authorText
            // 
            this.authorText.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.authorText.Location = new System.Drawing.Point(138, 127);
            this.authorText.Name = "authorText";
            this.authorText.Size = new System.Drawing.Size(177, 23);
            this.authorText.TabIndex = 1;
            this.authorText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.authorText.TextChanged += new System.EventHandler(this.authorText_TextChanged);
            // 
            // publisherText
            // 
            this.publisherText.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.publisherText.Location = new System.Drawing.Point(138, 171);
            this.publisherText.Name = "publisherText";
            this.publisherText.Size = new System.Drawing.Size(177, 23);
            this.publisherText.TabIndex = 2;
            this.publisherText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yearText
            // 
            this.yearText.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yearText.Location = new System.Drawing.Point(138, 212);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(51, 23);
            this.yearText.TabIndex = 3;
            this.yearText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yearText.TextChanged += new System.EventHandler(this.yearText_TextChanged);
            // 
            // isbnText
            // 
            this.isbnText.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.isbnText.Location = new System.Drawing.Point(138, 254);
            this.isbnText.Name = "isbnText";
            this.isbnText.Size = new System.Drawing.Size(177, 23);
            this.isbnText.TabIndex = 4;
            this.isbnText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.isbnText.TextChanged += new System.EventHandler(this.isbnText_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabel.Location = new System.Drawing.Point(208, 109);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(33, 16);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Title";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.BackColor = System.Drawing.Color.Transparent;
            this.authorLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.authorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.authorLabel.Location = new System.Drawing.Point(203, 153);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(51, 16);
            this.authorLabel.TabIndex = 8;
            this.authorLabel.Text = "Author";
            this.authorLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.BackColor = System.Drawing.Color.Transparent;
            this.publisherLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.publisherLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.publisherLabel.Location = new System.Drawing.Point(199, 194);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(62, 16);
            this.publisherLabel.TabIndex = 9;
            this.publisherLabel.Text = "Publisher";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.BackColor = System.Drawing.Color.Transparent;
            this.monthLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monthLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.monthLabel.Location = new System.Drawing.Point(209, 238);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(48, 16);
            this.monthLabel.TabIndex = 10;
            this.monthLabel.Text = "Month";
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.BackColor = System.Drawing.Color.Transparent;
            this.isbnLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.isbnLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.isbnLabel.Location = new System.Drawing.Point(208, 280);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(36, 16);
            this.isbnLabel.TabIndex = 11;
            this.isbnLabel.Text = "ISBN";
            // 
            // availLabel
            // 
            this.availLabel.AutoSize = true;
            this.availLabel.BackColor = System.Drawing.Color.Transparent;
            this.availLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.availLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.availLabel.Location = new System.Drawing.Point(199, 367);
            this.availLabel.Name = "availLabel";
            this.availLabel.Size = new System.Drawing.Size(74, 16);
            this.availLabel.TabIndex = 12;
            this.availLabel.Text = "Availability";
            // 
            // titleBtn
            // 
            this.titleBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.titleBtn.Location = new System.Drawing.Point(333, 85);
            this.titleBtn.Name = "titleBtn";
            this.titleBtn.Size = new System.Drawing.Size(75, 23);
            this.titleBtn.TabIndex = 13;
            this.titleBtn.Text = "Search";
            this.titleBtn.UseVisualStyleBackColor = true;
            this.titleBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // authorBtn
            // 
            this.authorBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.authorBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.authorBtn.Location = new System.Drawing.Point(333, 127);
            this.authorBtn.Name = "authorBtn";
            this.authorBtn.Size = new System.Drawing.Size(75, 23);
            this.authorBtn.TabIndex = 14;
            this.authorBtn.Text = "Search";
            this.authorBtn.UseVisualStyleBackColor = true;
            this.authorBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // pubBtn
            // 
            this.pubBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pubBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.pubBtn.Location = new System.Drawing.Point(333, 171);
            this.pubBtn.Name = "pubBtn";
            this.pubBtn.Size = new System.Drawing.Size(75, 23);
            this.pubBtn.TabIndex = 15;
            this.pubBtn.Text = "Search";
            this.pubBtn.UseVisualStyleBackColor = true;
            this.pubBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateBtn
            // 
            this.dateBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.dateBtn.Location = new System.Drawing.Point(333, 212);
            this.dateBtn.Name = "dateBtn";
            this.dateBtn.Size = new System.Drawing.Size(75, 23);
            this.dateBtn.TabIndex = 16;
            this.dateBtn.Text = "Search";
            this.dateBtn.UseVisualStyleBackColor = true;
            this.dateBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // isbnBtn
            // 
            this.isbnBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.isbnBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.isbnBtn.Location = new System.Drawing.Point(333, 253);
            this.isbnBtn.Name = "isbnBtn";
            this.isbnBtn.Size = new System.Drawing.Size(75, 23);
            this.isbnBtn.TabIndex = 17;
            this.isbnBtn.Text = "Search";
            this.isbnBtn.UseVisualStyleBackColor = true;
            this.isbnBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.OrangeRed;
            this.button6.Location = new System.Drawing.Point(138, 341);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "Available";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.OrangeRed;
            this.button7.Location = new System.Drawing.Point(231, 341);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 23);
            this.button7.TabIndex = 19;
            this.button7.Text = "Unavailable";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(443, 86);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(297, 278);
            this.resultBox.TabIndex = 20;
            this.resultBox.Text = "";
            this.resultBox.TextChanged += new System.EventHandler(this.resultBox_TextChanged);
            // 
            // monthText
            // 
            this.monthText.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monthText.Location = new System.Drawing.Point(203, 212);
            this.monthText.Name = "monthText";
            this.monthText.Size = new System.Drawing.Size(49, 23);
            this.monthText.TabIndex = 22;
            this.monthText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.monthText.TextChanged += new System.EventHandler(this.monthText_TextChanged);
            // 
            // dayText
            // 
            this.dayText.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dayText.Location = new System.Drawing.Point(268, 212);
            this.dayText.Name = "dayText";
            this.dayText.Size = new System.Drawing.Size(47, 23);
            this.dayText.TabIndex = 23;
            this.dayText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dayText.TextChanged += new System.EventHandler(this.dayText_TextChanged);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.exitBtn.Location = new System.Drawing.Point(761, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(27, 23);
            this.exitBtn.TabIndex = 24;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.backBtn.Location = new System.Drawing.Point(728, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(27, 23);
            this.backBtn.TabIndex = 25;
            this.backBtn.Text = "<-";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // genreBtn
            // 
            this.genreBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.genreBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.genreBtn.Location = new System.Drawing.Point(333, 297);
            this.genreBtn.Name = "genreBtn";
            this.genreBtn.Size = new System.Drawing.Size(75, 23);
            this.genreBtn.TabIndex = 28;
            this.genreBtn.Text = "Search";
            this.genreBtn.UseVisualStyleBackColor = true;
            this.genreBtn.Click += new System.EventHandler(this.genreBtn_Click);
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.BackColor = System.Drawing.Color.Transparent;
            this.genreLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.genreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.genreLabel.Location = new System.Drawing.Point(208, 324);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(41, 16);
            this.genreLabel.TabIndex = 27;
            this.genreLabel.Text = "Genre";
            // 
            // genreText
            // 
            this.genreText.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.genreText.Location = new System.Drawing.Point(138, 298);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(177, 23);
            this.genreText.TabIndex = 26;
            this.genreText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.BackColor = System.Drawing.Color.Transparent;
            this.yearLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yearLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yearLabel.Location = new System.Drawing.Point(148, 238);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 16);
            this.yearLabel.TabIndex = 29;
            this.yearLabel.Text = "Year";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.BackColor = System.Drawing.Color.Transparent;
            this.dayLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dayLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dayLabel.Location = new System.Drawing.Point(277, 238);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(29, 16);
            this.dayLabel.TabIndex = 30;
            this.dayLabel.Text = "Day";
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
            this.iconLabel.TabIndex = 31;
            this.iconLabel.Text = "Library system";
            this.iconLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.searchLabel.Location = new System.Drawing.Point(298, 49);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(218, 24);
            this.searchLabel.TabIndex = 32;
            this.searchLabel.Text = "Search the book library";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // valLabel
            // 
            this.valLabel.AutoSize = true;
            this.valLabel.BackColor = System.Drawing.Color.IndianRed;
            this.valLabel.ForeColor = System.Drawing.Color.Coral;
            this.valLabel.Location = new System.Drawing.Point(163, 393);
            this.valLabel.Name = "valLabel";
            this.valLabel.Size = new System.Drawing.Size(124, 15);
            this.valLabel.TabIndex = 33;
            this.valLabel.Text = "It must be a number!\r\n";
            this.valLabel.Visible = false;
            // 
            // SearchBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::Library.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.valLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.iconLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.genreBtn);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.dayText);
            this.Controls.Add(this.monthText);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.isbnBtn);
            this.Controls.Add(this.dateBtn);
            this.Controls.Add(this.pubBtn);
            this.Controls.Add(this.authorBtn);
            this.Controls.Add(this.titleBtn);
            this.Controls.Add(this.availLabel);
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
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.Name = "SearchBooks";
            this.Text = "Library System";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox titleText;
        private TextBox authorText;
        private TextBox publisherText;
        private TextBox yearText;
        private TextBox isbnText;
        private Label titleLabel;
        private Label authorLabel;
        private Label publisherLabel;
        private Label monthLabel;
        private Label isbnLabel;
        private Label availLabel;
        private Button titleBtn;
        private Button authorBtn;
        private Button pubBtn;
        private Button dateBtn;
        private Button isbnBtn;
        private Button button6;
        private Button button7;
        private RichTextBox resultBox;
        private TextBox monthText;
        private TextBox dayText;
        private Button exitBtn;
        private Button backBtn;
        private Button genreBtn;
        private Label genreLabel;
        private TextBox genreText;
        private Label yearLabel;
        private Label dayLabel;
        private Label iconLabel;
        private Label searchLabel;
        private Label valLabel;
    }
}