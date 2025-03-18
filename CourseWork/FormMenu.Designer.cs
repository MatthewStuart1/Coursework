namespace CourseWork
{
    partial class FormMenu
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
            this.ImgSettings = new System.Windows.Forms.PictureBox();
            this.MbcAircraft = new CourseWork.menuBoxControl();
            this.MbcInstructor = new CourseWork.menuBoxControl();
            this.MbcStudent = new CourseWork.menuBoxControl();
            this.MbcLogs = new CourseWork.menuBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgSettings
            // 
            this.ImgSettings.Image = global::CourseWork.Properties.Resources.iconSettings;
            this.ImgSettings.Location = new System.Drawing.Point(799, 12);
            this.ImgSettings.Name = "ImgSettings";
            this.ImgSettings.Size = new System.Drawing.Size(50, 50);
            this.ImgSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgSettings.TabIndex = 4;
            this.ImgSettings.TabStop = false;
            this.ImgSettings.Click += new System.EventHandler(this.ImgSettings_Click);
            // 
            // MbcAircraft
            // 
            this.MbcAircraft.Icon = global::CourseWork.Properties.Resources.iconFlight;
            this.MbcAircraft.Location = new System.Drawing.Point(647, 82);
            this.MbcAircraft.Name = "MbcAircraft";
            this.MbcAircraft.Size = new System.Drawing.Size(208, 257);
            this.MbcAircraft.TabIndex = 3;
            this.MbcAircraft.Title = "Aircraft";
            // 
            // MbcInstructor
            // 
            this.MbcInstructor.Icon = global::CourseWork.Properties.Resources.iconInstructor;
            this.MbcInstructor.Location = new System.Drawing.Point(219, 82);
            this.MbcInstructor.Name = "MbcInstructor";
            this.MbcInstructor.Size = new System.Drawing.Size(208, 257);
            this.MbcInstructor.TabIndex = 2;
            this.MbcInstructor.Title = "CFI\'s";
            // 
            // MbcStudent
            // 
            this.MbcStudent.Icon = global::CourseWork.Properties.Resources.iconStudent;
            this.MbcStudent.Location = new System.Drawing.Point(433, 82);
            this.MbcStudent.Name = "MbcStudent";
            this.MbcStudent.Size = new System.Drawing.Size(208, 257);
            this.MbcStudent.TabIndex = 1;
            this.MbcStudent.Title = "Students";
            // 
            // MbcLogs
            // 
            this.MbcLogs.Icon = global::CourseWork.Properties.Resources.iconLogs;
            this.MbcLogs.Location = new System.Drawing.Point(5, 82);
            this.MbcLogs.Name = "MbcLogs";
            this.MbcLogs.Size = new System.Drawing.Size(208, 257);
            this.MbcLogs.TabIndex = 0;
            this.MbcLogs.Title = "Logs";
            this.MbcLogs.Click += new System.EventHandler(this.MbcLogs_Click);
            // 
            // FormMenu
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(861, 441);
            this.Controls.Add(this.ImgSettings);
            this.Controls.Add(this.MbcAircraft);
            this.Controls.Add(this.MbcInstructor);
            this.Controls.Add(this.MbcStudent);
            this.Controls.Add(this.MbcLogs);
            this.Name = "FormMenu";
            ((System.ComponentModel.ISupportInitialize)(this.ImgSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private menuBoxControl MbcLogs;
        private menuBoxControl MbcStudent;
        private menuBoxControl MbcInstructor;
        private menuBoxControl MbcAircraft;
        private System.Windows.Forms.PictureBox ImgSettings;
    }
}

