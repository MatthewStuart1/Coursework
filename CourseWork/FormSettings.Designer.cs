namespace CourseWork
{
    partial class FormSettings
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
            this.tlpSettings = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveExit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tlpSettings
            // 
            this.tlpSettings.ColumnCount = 2;
            this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.25F));
            this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.75F));
            this.tlpSettings.Location = new System.Drawing.Point(12, 12);
            this.tlpSettings.Name = "tlpSettings";
            this.tlpSettings.RowCount = 1;
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSettings.Size = new System.Drawing.Size(659, 426);
            this.tlpSettings.TabIndex = 0;
            // 
            // btnSaveExit
            // 
            this.btnSaveExit.Location = new System.Drawing.Point(677, 391);
            this.btnSaveExit.Name = "btnSaveExit";
            this.btnSaveExit.Size = new System.Drawing.Size(111, 47);
            this.btnSaveExit.TabIndex = 0;
            this.btnSaveExit.Text = "Save + Exit";
            this.btnSaveExit.UseVisualStyleBackColor = true;
            this.btnSaveExit.Click += new System.EventHandler(this.btnSaveExit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(677, 338);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 47);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit\r\n(Without Saving)";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveExit);
            this.Controls.Add(this.tlpSettings);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSettings;
        private System.Windows.Forms.Button btnSaveExit;
        private System.Windows.Forms.Button btnExit;
    }
}