using StoredProcedureExtractor.DataAccess;
using StoredProcedureExtractor.Models;

namespace StoredProcedureExtractor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using var openFolder = new FolderBrowserDialog();

            if (openFolder.ShowDialog() == DialogResult.OK)
            {
                txtDirectory.Text = openFolder.SelectedPath;
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                groupBoxPanel.Enabled = false;

                var command = GetCommandQuery();
                var procedures = await StoredProcedureDataAccess.GetAllAsync(txtConnectionString.Text, command);               
                HandleProcedures(procedures);            

                groupBoxPanel.Enabled = true;
            }
        }

        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(txtConnectionString.Text) || string.IsNullOrWhiteSpace(txtDirectory.Text))
            {
                MessageBox.Show("You haven't provided all required fields. Please check it again!", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void HandleProcedures(IEnumerable<StoredProcedure> procedures)
        {
            if (procedures == null)
            {
                MessageBox.Show("An error occurred while getting data from server!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!procedures.Any())
            {
                MessageBox.Show("No procedures were retrieved from server!", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var retrieved = procedures.Count();
            var saved = FileWriter.WriteToFile(procedures, txtDirectory.Text);

            if (saved > 0)
            {
                MessageBox.Show("Operation is completed! \n" +
                                $"Retrieved procedures from server: {retrieved} \n" +
                                $"Saved to file: {saved}", "Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error! Writing procedures to file failed!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtConnectionString.Clear();
            txtDirectory.Clear();
            txtProcedureName.Clear();
        }

        private string GetCommandQuery()
        {
            return !string.IsNullOrWhiteSpace(txtProcedureName.Text)
                ? Resource1.QuerySingle.Replace("procedure", txtProcedureName.Text)
                : Resource1.QueryAll;
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("When you specify procedure name,only that procedure will be retrieved from database.", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}