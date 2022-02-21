namespace PasswordManager
{
    partial class Main
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.DomainColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.UserNameColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.ExportFromCsvButton = new System.Windows.Forms.Button();
            this.CreateNewRecordButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalResultsLabel = new System.Windows.Forms.Label();
            this.ClearSearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DomainColumnHeader,
            this.UserNameColumnHeader});
            this.listView1.Location = new System.Drawing.Point(12, 174);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(617, 506);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // DomainColumnHeader
            // 
            this.DomainColumnHeader.Text = "Domain";
            this.DomainColumnHeader.Width = 300;
            // 
            // UserNameColumnHeader
            // 
            this.UserNameColumnHeader.Text = "UserName";
            this.UserNameColumnHeader.Width = 300;
            // 
            // ExportFromCsvButton
            // 
            this.ExportFromCsvButton.Location = new System.Drawing.Point(12, 12);
            this.ExportFromCsvButton.Name = "ExportFromCsvButton";
            this.ExportFromCsvButton.Size = new System.Drawing.Size(107, 23);
            this.ExportFromCsvButton.TabIndex = 1;
            this.ExportFromCsvButton.Text = "Export From CSV";
            this.ExportFromCsvButton.UseVisualStyleBackColor = true;
            this.ExportFromCsvButton.Click += new System.EventHandler(this.ExportFromCsvButton_Click);
            // 
            // CreateNewRecordButton
            // 
            this.CreateNewRecordButton.Location = new System.Drawing.Point(418, 12);
            this.CreateNewRecordButton.Name = "CreateNewRecordButton";
            this.CreateNewRecordButton.Size = new System.Drawing.Size(211, 23);
            this.CreateNewRecordButton.TabIndex = 2;
            this.CreateNewRecordButton.Text = "Create New Record";
            this.CreateNewRecordButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 2);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(617, 2);
            this.label2.TabIndex = 4;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(60, 59);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(158, 23);
            this.SearchTextBox.TabIndex = 5;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(12, 62);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(42, 15);
            this.SearchLabel.TabIndex = 6;
            this.SearchLabel.Text = "Search";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(12, 91);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(95, 23);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Begin Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Results:";
            // 
            // TotalResultsLabel
            // 
            this.TotalResultsLabel.AutoSize = true;
            this.TotalResultsLabel.Location = new System.Drawing.Point(541, 62);
            this.TotalResultsLabel.Name = "TotalResultsLabel";
            this.TotalResultsLabel.Size = new System.Drawing.Size(16, 15);
            this.TotalResultsLabel.TabIndex = 9;
            this.TotalResultsLabel.Text = "...";
            // 
            // ClearSearchButton
            // 
            this.ClearSearchButton.Location = new System.Drawing.Point(12, 120);
            this.ClearSearchButton.Name = "ClearSearchButton";
            this.ClearSearchButton.Size = new System.Drawing.Size(95, 23);
            this.ClearSearchButton.TabIndex = 10;
            this.ClearSearchButton.Text = "ClearSearch";
            this.ClearSearchButton.UseVisualStyleBackColor = true;
            this.ClearSearchButton.Click += new System.EventHandler(this.ClearSearchButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 692);
            this.Controls.Add(this.ClearSearchButton);
            this.Controls.Add(this.TotalResultsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateNewRecordButton);
            this.Controls.Add(this.ExportFromCsvButton);
            this.Controls.Add(this.listView1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private ColumnHeader DomainColumnHeader;
        private ColumnHeader UserNameColumnHeader;
        private Button ExportFromCsvButton;
        private Button CreateNewRecordButton;
        private Label label1;
        private Label label2;
        private TextBox SearchTextBox;
        private Label SearchLabel;
        private Button SearchButton;
        private Label label3;
        private Label TotalResultsLabel;
        private Button ClearSearchButton;
    }
}