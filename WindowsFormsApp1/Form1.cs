using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = "Data Source=desktop-0enqdda;Initial Catalog=vpndata;Integrated Security=True;";
        private string selectedProtocol = "WireGuard"; // Default selected protocol

        public Form1()
        {
            InitializeComponent();
            InitializeVPNList();
            PromptForLogin();
        }

        private void PromptForLogin()
        {
            try
            {
                string username = Prompt.ShowDialog("Enter your username:", "Login Portal");
                string key = Prompt.ShowDialog("Enter your 14-digit key:", "Login Portal");

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(key) || key.Length != 14)
                {
                    MessageBox.Show("Invalid username or key. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PromptForLogin();
                    return;
                }

                if (!AuthenticateUser(username, key))
                {
                    MessageBox.Show("Invalid username or key. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PromptForLogin();
                    return;
                }

                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string username, string key)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND [Key] = @key";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@key", key);
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void InitializeVPNList()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT DISTINCT Country FROM VPNInfo";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string country = reader.GetString(0); // Assuming the VPN names are stored in the first column
                                vpnComboBox1.Items.Add(country);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            string selectedVPN = vpnComboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedVPN))
            {
                MessageBox.Show("Please select a VPN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ConnectToVPN(selectedVPN, selectedProtocol); // Connect to the selected VPN and protocol
        }

        private void ConnectToVPN(string selectedVPN, string selectedProtocol)
        {
            // Placeholder for connecting to VPN using selected protocol
            MessageBox.Show($"Connecting to {selectedVPN} using {selectedProtocol}...");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void openvpnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (openvpnRadioButton.Checked)
                selectedProtocol = "OpenVPN";
        }

        private void wireguardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (wireguardRadioButton.Checked)
                selectedProtocol = "WireGuard";
        }
    }
}
