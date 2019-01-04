namespace Assignment
{
    partial class Form1
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
            this.combo_Starting = new System.Windows.Forms.ComboBox();
            this.combo_Destination = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_FindPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combo_Starting
            // 
            this.combo_Starting.FormattingEnabled = true;
            this.combo_Starting.Items.AddRange(new object[] {
            "Admiralty",
            "Ang Mo Kio",
            "Aljunied",
            "Bartley",
            "Bayfront",
            "Beauty World",
            "Bedok",
            "Bedok North",
            "Bedok Reservoir",
            "Bencoolen",
            "Bendemeer",
            "Bishan",
            "Boon Keng",
            "Boon Lay",
            "Botanic Gardens",
            "Bras Basah",
            "Braddell",
            "Buangkok",
            "Bugis",
            "Buona Vista",
            "Bukit Batok",
            "Bukit Brown",
            "Bukit Gombak",
            "Bukit Panjang",
            "Caldecott",
            "Cashew",
            "Chinatown",
            "Changi Airport",
            "Chinese Garden",
            "Choa Chu Kang",
            "City Hall",
            "Clarke Quay",
            "Clementi",
            "Commonwealth",
            "Dakota",
            "Dhoby Ghaut",
            "Dover",
            "Downtown",
            "Esplanade",
            "Eunos",
            "Expo",
            "Farrer Road",
            "Fort Canning",
            "Geylang Bahru",
            "Gul Circle",
            "HarbourFront",
            "Haw Par Villa",
            "Holland Village",
            "Hougang",
            "Hillview",
            "Jalan Besar",
            "Joo Koon",
            "Jurong East",
            "Kaki Bukit",
            "Kallang",
            "Kembangan",
            "Kent Ridge",
            "Khatib",
            "King Albert Park",
            "Kovan",
            "Kranji",
            "Labrador Park",
            "Lakeside",
            "Lavender",
            "Lorong Chuan",
            "Little India",
            "MacPherson",
            "Marina Bay",
            "Marina South Pier",
            "Marsiling",
            "Marymount",
            "Mattar",
            "Mountbatten",
            "Newton",
            "Nicoll Highway",
            "Novena",
            "one-north",
            "Orchard",
            "Outram Park",
            "Pasir Panjang",
            "Pasir Ris",
            "Paya Lebar",
            "Pioneer",
            "Potong Pasir",
            "Promenade",
            "Punggol",
            "Queenstown",
            "Raffles Place",
            "Redhill",
            "Rochor",
            "Sembawang",
            "Sengkang",
            "Serangoon",
            "Simei",
            "Sixth Avenue",
            "Somerset",
            "Stadium",
            "Stevens",
            "Sungei Bedok",
            "Tampines",
            "Tampines East",
            "Tampines West",
            "Tai Seng",
            "Tan Kah Kee",
            "Tanah Merah",
            "Tanjong Pagar",
            "Telok Ayer",
            "Telok Blangah",
            "Tiong Bahru",
            "Toa Payoh",
            "Tuas Crescent",
            "Tuas Link",
            "Tuas West Road",
            "Ubi",
            "Upper Changi",
            "Woodlands",
            "Woodleigh",
            "Xilin",
            "Yew Tee",
            "Yio Chu Kang",
            "Yishun"});
            this.combo_Starting.Location = new System.Drawing.Point(13, 38);
            this.combo_Starting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_Starting.Name = "combo_Starting";
            this.combo_Starting.Size = new System.Drawing.Size(237, 24);
            this.combo_Starting.TabIndex = 0;
            this.combo_Starting.Text = "--Select Station--";
            this.combo_Starting.SelectedIndexChanged += new System.EventHandler(this.combo_Starting_SelectedIndexChanged);
            // 
            // combo_Destination
            // 
            this.combo_Destination.FormattingEnabled = true;
            this.combo_Destination.Items.AddRange(new object[] {
            "Admiralty",
            "Ang Mo Kio",
            "Aljunied",
            "Bartley",
            "Bayfront",
            "Beauty World",
            "Bedok",
            "Bedok North",
            "Bedok Reservoir",
            "Bencoolen",
            "Bendemeer",
            "Bishan",
            "Boon Keng",
            "Boon Lay",
            "Botanic Gardens",
            "Bras Basah",
            "Braddell",
            "Buangkok",
            "Bugis",
            "Buona Vista",
            "Bukit Batok",
            "Bukit Brown",
            "Bukit Gombak",
            "Bukit Panjang",
            "Caldecott",
            "Cashew",
            "Chinatown",
            "Changi Airport",
            "Chinese Garden",
            "Choa Chu Kang",
            "City Hall",
            "Clarke Quay",
            "Clementi",
            "Commonwealth",
            "Dakota",
            "Dhoby Ghaut",
            "Dover",
            "Downtown",
            "Esplanade",
            "Eunos",
            "Expo",
            "Farrer Road",
            "Fort Canning",
            "Geylang Bahru",
            "Gul Circle",
            "HarbourFront",
            "Haw Par Villa",
            "Holland Village",
            "Hougang",
            "Hillview",
            "Jalan Besar",
            "Joo Koon",
            "Jurong East",
            "Kaki Bukit",
            "Kallang",
            "Kembangan",
            "Kent Ridge",
            "Khatib",
            "King Albert Park",
            "Kovan",
            "Kranji",
            "Labrador Park",
            "Lakeside",
            "Lavender",
            "Lorong Chuan",
            "Little India",
            "MacPherson",
            "Marina Bay",
            "Marina South Pier",
            "Marsiling",
            "Marymount",
            "Mattar",
            "Mountbatten",
            "Newton",
            "Nicoll Highway",
            "Novena",
            "one-north",
            "Orchard",
            "Outram Park",
            "Pasir Panjang",
            "Pasir Ris",
            "Paya Lebar",
            "Pioneer",
            "Potong Pasir",
            "Promenade",
            "Punggol",
            "Queenstown",
            "Raffles Place",
            "Redhill",
            "Rochor",
            "Sembawang",
            "Sengkang",
            "Serangoon",
            "Simei",
            "Sixth Avenue",
            "Somerset",
            "Stadium",
            "Stevens",
            "Sungei Bedok",
            "Tampines",
            "Tampines East",
            "Tampines West",
            "Tai Seng",
            "Tan Kah Kee",
            "Tanah Merah",
            "Tanjong Pagar",
            "Telok Ayer",
            "Telok Blangah",
            "Tiong Bahru",
            "Toa Payoh",
            "Tuas Crescent",
            "Tuas Link",
            "Tuas West Road",
            "Ubi",
            "Upper Changi",
            "Woodlands",
            "Woodleigh",
            "Xilin",
            "Yew Tee",
            "Yio Chu Kang",
            "Yishun"});
            this.combo_Destination.Location = new System.Drawing.Point(13, 87);
            this.combo_Destination.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_Destination.Name = "combo_Destination";
            this.combo_Destination.Size = new System.Drawing.Size(237, 24);
            this.combo_Destination.TabIndex = 1;
            this.combo_Destination.Text = "--Select Station--";
            this.combo_Destination.SelectedIndexChanged += new System.EventHandler(this.combo_Destination_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Station";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination Station";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_FindPath
            // 
            this.btn_FindPath.Location = new System.Drawing.Point(13, 135);
            this.btn_FindPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_FindPath.Name = "btn_FindPath";
            this.btn_FindPath.Size = new System.Drawing.Size(239, 38);
            this.btn_FindPath.TabIndex = 5;
            this.btn_FindPath.Text = "Generate Path(s)";
            this.btn_FindPath.UseVisualStyleBackColor = true;
            this.btn_FindPath.Click += new System.EventHandler(this.btn_FindPath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 198);
            this.Controls.Add(this.btn_FindPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_Destination);
            this.Controls.Add(this.combo_Starting);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "MRT Guide -by Yue Jun & Joseph";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_Starting;
        private System.Windows.Forms.ComboBox combo_Destination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_FindPath;
    }
}

