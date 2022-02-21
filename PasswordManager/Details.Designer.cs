namespace PasswordManager
{
    partial class Details
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
            this.RevealPasswordButton = new System.Windows.Forms.Button();
            this.MasterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WebPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RevealPasswordButton
            // 
            this.RevealPasswordButton.Location = new System.Drawing.Point(93, 153);
            this.RevealPasswordButton.Name = "RevealPasswordButton";
            this.RevealPasswordButton.Size = new System.Drawing.Size(119, 23);
            this.RevealPasswordButton.TabIndex = 0;
            this.RevealPasswordButton.Text = "Reveal Password";
            this.RevealPasswordButton.UseVisualStyleBackColor = true;
            this.RevealPasswordButton.Click += new System.EventHandler(this.RevealPasswordButton_Click);
            // 
            // MasterPasswordTextBox
            // 
            this.MasterPasswordTextBox.Location = new System.Drawing.Point(80, 27);
            this.MasterPasswordTextBox.Name = "MasterPasswordTextBox";
            this.MasterPasswordTextBox.Size = new System.Drawing.Size(151, 23);
            this.MasterPasswordTextBox.TabIndex = 1;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(12, 153);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(218, 153);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Master Password";
            // 
            // WebPasswordTextBox
            // 
            this.WebPasswordTextBox.Location = new System.Drawing.Point(80, 106);
            this.WebPasswordTextBox.Name = "WebPasswordTextBox";
            this.WebPasswordTextBox.Size = new System.Drawing.Size(151, 23);
            this.WebPasswordTextBox.TabIndex = 6;
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 188);
            this.Controls.Add(this.WebPasswordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.MasterPasswordTextBox);
            this.Controls.Add(this.RevealPasswordButton);
            this.Name = "Details";
            this.Text = "Details";
            this.Load += new System.EventHandler(this.Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button RevealPasswordButton;
        private TextBox MasterPasswordTextBox;
        private Button EditButton;
        private Button DeleteButton;
        private Label label1;
        private TextBox WebPasswordTextBox;
    }
}