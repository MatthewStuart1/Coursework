namespace CourseWork
{
    partial class FormAircraftMenu
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
            this.lstAircraft = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lstAircraft
            // 
            this.lstAircraft.HideSelection = false;
            this.lstAircraft.Location = new System.Drawing.Point(300, 12);
            this.lstAircraft.Name = "lstAircraft";
            this.lstAircraft.Size = new System.Drawing.Size(488, 426);
            this.lstAircraft.TabIndex = 0;
            this.lstAircraft.UseCompatibleStateImageBehavior = false;

            // 
            // FormAircraftMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstAircraft);
            this.Name = "FormAircraftMenu";
            this.Text = "FormAircraftMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstAircraft;
    }
}