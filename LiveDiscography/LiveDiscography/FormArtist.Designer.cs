namespace LiveDiscography
{
    partial class FormArtist
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
            this.txtArName = new System.Windows.Forms.TextBox();
            this.txtArLabel = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbArGenre = new System.Windows.Forms.ComboBox();
            this.txtArRealName = new System.Windows.Forms.TextBox();
            this.lblRealName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtArName
            // 
            this.txtArName.Location = new System.Drawing.Point(28, 31);
            this.txtArName.Name = "txtArName";
            this.txtArName.Size = new System.Drawing.Size(221, 20);
            this.txtArName.TabIndex = 0;
            // 
            // txtArLabel
            // 
            this.txtArLabel.Location = new System.Drawing.Point(28, 133);
            this.txtArLabel.Name = "txtArLabel";
            this.txtArLabel.Size = new System.Drawing.Size(221, 20);
            this.txtArLabel.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(138, 231);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(57, 231);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Record Label";
            // 
            // cbArGenre
            // 
            this.cbArGenre.FormattingEnabled = true;
            this.cbArGenre.Location = new System.Drawing.Point(28, 78);
            this.cbArGenre.Name = "cbArGenre";
            this.cbArGenre.Size = new System.Drawing.Size(221, 21);
            this.cbArGenre.TabIndex = 8;
            // 
            // txtArRealName
            // 
            this.txtArRealName.Location = new System.Drawing.Point(28, 189);
            this.txtArRealName.Name = "txtArRealName";
            this.txtArRealName.Size = new System.Drawing.Size(218, 20);
            this.txtArRealName.TabIndex = 9;
            // 
            // lblRealName
            // 
            this.lblRealName.AutoSize = true;
            this.lblRealName.Location = new System.Drawing.Point(25, 173);
            this.lblRealName.Name = "lblRealName";
            this.lblRealName.Size = new System.Drawing.Size(60, 13);
            this.lblRealName.TabIndex = 10;
            this.lblRealName.Text = "Real Name";
            // 
            // FormArtist
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(278, 287);
            this.Controls.Add(this.lblRealName);
            this.Controls.Add(this.txtArRealName);
            this.Controls.Add(this.cbArGenre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtArLabel);
            this.Controls.Add(this.txtArName);
            this.Name = "FormArtist";
            this.Text = "FormArtist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtArName;
        public System.Windows.Forms.TextBox txtArLabel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbArGenre;
        public System.Windows.Forms.TextBox txtArRealName;
        private System.Windows.Forms.Label lblRealName;
    }
}