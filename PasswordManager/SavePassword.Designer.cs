namespace PasswordManager
{
    partial class SavePassword
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
            this.SaveMasterPasswordButton = new System.Windows.Forms.Button();
            this.MasterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveMasterPasswordButton
            // 
            this.SaveMasterPasswordButton.Location = new System.Drawing.Point(65, 71);
            this.SaveMasterPasswordButton.Name = "SaveMasterPasswordButton";
            this.SaveMasterPasswordButton.Size = new System.Drawing.Size(75, 23);
            this.SaveMasterPasswordButton.TabIndex = 0;
            this.SaveMasterPasswordButton.Text = "Save";
            this.SaveMasterPasswordButton.UseVisualStyleBackColor = true;
            this.SaveMasterPasswordButton.Click += new System.EventHandler(this.SaveMasterPasswordButton_Click);
            // 
            // MasterPasswordTextBox
            // 
            this.MasterPasswordTextBox.Location = new System.Drawing.Point(12, 42);
            this.MasterPasswordTextBox.Name = "MasterPasswordTextBox";
            this.MasterPasswordTextBox.Size = new System.Drawing.Size(195, 23);
            this.MasterPasswordTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Master Password";
            // 
            // SavePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 106);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MasterPasswordTextBox);
            this.Controls.Add(this.SaveMasterPasswordButton);
            this.Name = "SavePassword";
            this.Text = "SavePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SaveMasterPasswordButton;
        private TextBox MasterPasswordTextBox;
        private Label label1;
    }
}