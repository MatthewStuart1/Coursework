using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseWork
{


    public partial class FormSettings : Form
    {

        private Dictionary<string, TextBox> textBoxPairs = new Dictionary<string, TextBox>();
        //https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-9.0

        public FormSettings()
        {
            InitializeComponent();
            DarkMode.Apply(this);
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {

            SettingsManager.Load();


            tlpSettings.Controls.Clear();
            tlpSettings.RowStyles.Clear();
            tlpSettings.RowCount = 0;
            textBoxPairs.Clear();

            // for each setting, add row and stuff
            foreach (var setting in SettingsManager.Settings)
            {
                int rowIndex = tlpSettings.RowCount++;
                tlpSettings.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                //autosize row (like excel)

                // txt for value
                TextBox txtValue = new TextBox();
                txtValue.Text = setting.Value;
                txtValue.Dock = DockStyle.Fill;

                // lbl for key
                Label lblKey = new Label();
                lblKey.Text = setting.Key;
                lblKey.AutoSize = true;
                lblKey.Dock = DockStyle.Fill;


                // Add the label and textbox to the TableLayoutPanel.
                tlpSettings.Controls.Add(lblKey, 0, rowIndex);
                tlpSettings.Controls.Add(txtValue, 1, rowIndex);

                // Remember the textbox for saving changes.
                textBoxPairs[setting.Key] = txtValue;
            }


        }

    }
}
