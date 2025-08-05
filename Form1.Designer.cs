namespace StoredProcedureExtractor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBoxPanel = new GroupBox();
            button1 = new Button();
            btnReset = new Button();
            btnSave = new Button();
            txtProcedureName = new TextBox();
            btnBrowse = new Button();
            txtDirectory = new TextBox();
            txtConnectionString = new TextBox();
            lblConnectionString = new Label();
            lblDirectory = new Label();
            lblStoredProcedure = new Label();
            toolTips = new ToolTip(components);
            groupBoxPanel.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPanel
            // 
            groupBoxPanel.Controls.Add(button1);
            groupBoxPanel.Controls.Add(btnReset);
            groupBoxPanel.Controls.Add(btnSave);
            groupBoxPanel.Controls.Add(txtProcedureName);
            groupBoxPanel.Controls.Add(btnBrowse);
            groupBoxPanel.Controls.Add(txtDirectory);
            groupBoxPanel.Controls.Add(txtConnectionString);
            groupBoxPanel.Controls.Add(lblConnectionString);
            groupBoxPanel.Controls.Add(lblDirectory);
            groupBoxPanel.Controls.Add(lblStoredProcedure);
            groupBoxPanel.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxPanel.Location = new Point(12, 12);
            groupBoxPanel.Name = "groupBoxPanel";
            groupBoxPanel.Size = new Size(430, 237);
            groupBoxPanel.TabIndex = 0;
            groupBoxPanel.TabStop = false;
            groupBoxPanel.Text = "Panel";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(387, 118);
            button1.Name = "button1";
            button1.Size = new Size(29, 23);
            button1.TabIndex = 9;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnInfo_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(215, 177);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(140, 30);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += BtnReset_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(69, 177);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 30);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // txtProcedureName
            // 
            txtProcedureName.Location = new Point(144, 118);
            txtProcedureName.Name = "txtProcedureName";
            txtProcedureName.Size = new Size(237, 23);
            txtProcedureName.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.Font = new Font("Segoe UI", 9F);
            btnBrowse.Location = new Point(387, 79);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(29, 23);
            btnBrowse.TabIndex = 6;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += BtnBrowse_Click;
            // 
            // txtDirectory
            // 
            txtDirectory.Location = new Point(144, 80);
            txtDirectory.Name = "txtDirectory";
            txtDirectory.ReadOnly = true;
            txtDirectory.Size = new Size(237, 23);
            txtDirectory.TabIndex = 5;
            toolTips.SetToolTip(txtDirectory, "Required");
            // 
            // txtConnectionString
            // 
            txtConnectionString.Location = new Point(144, 42);
            txtConnectionString.Name = "txtConnectionString";
            txtConnectionString.Size = new Size(272, 23);
            txtConnectionString.TabIndex = 4;
            toolTips.SetToolTip(txtConnectionString, "Required");
            // 
            // lblConnectionString
            // 
            lblConnectionString.AutoSize = true;
            lblConnectionString.Font = new Font("Segoe UI Light", 9F);
            lblConnectionString.Location = new Point(20, 45);
            lblConnectionString.Name = "lblConnectionString";
            lblConnectionString.Size = new Size(100, 15);
            lblConnectionString.TabIndex = 1;
            lblConnectionString.Text = "Connection string: ";
            // 
            // lblDirectory
            // 
            lblDirectory.AutoSize = true;
            lblDirectory.Font = new Font("Segoe UI Light", 9F);
            lblDirectory.Location = new Point(12, 83);
            lblDirectory.Name = "lblDirectory";
            lblDirectory.Size = new Size(110, 15);
            lblDirectory.TabIndex = 2;
            lblDirectory.Text = "Extraction directory: ";
            // 
            // lblStoredProcedure
            // 
            lblStoredProcedure.AutoSize = true;
            lblStoredProcedure.Font = new Font("Segoe UI Light", 9F);
            lblStoredProcedure.Location = new Point(31, 121);
            lblStoredProcedure.Name = "lblStoredProcedure";
            lblStoredProcedure.Size = new Size(93, 15);
            lblStoredProcedure.TabIndex = 3;
            lblStoredProcedure.Text = "Procedure name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(454, 261);
            Controls.Add(groupBoxPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stored Procedure Extractor";
            groupBoxPanel.ResumeLayout(false);
            groupBoxPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPanel;
        private Label lblConnectionString;
        private Label lblDirectory;
        private Label lblStoredProcedure;
        private Button btnSave;
        private TextBox txtProcedureName;
        private Button btnBrowse;
        private TextBox txtDirectory;
        private TextBox txtConnectionString;
        private Button btnReset;
        private ToolTip toolTips;
        private Button button1;
    }
}
