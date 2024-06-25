using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace unblockIP_forIPBan
{
    public partial class Form1 : Form
    {
        private string filePath = @"C:\Program Files\IPBan\history_unban.txt";

        public Form1()
        {
            InitializeComponent();
            LoadIPHistory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newIP = textBoxIP.Text.Trim(); // Trim whitespace from input

            if (IsValidIPAddress(newIP))
            {
                // IP address is valid, proceed with saving or using it
                try
                {
                    // Append the new IP to the file or process it as needed
                    using (StreamWriter sw = File.AppendText(filePath))
                    {
                        sw.WriteLine(newIP);
                    }

                    // Add the new IP to the ListBox or update UI as needed
                    listBoxIPs.Items.Add(newIP);
                    textBoxIP.Clear();

                    MessageBox.Show("IP added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Handle any errors that may occur
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // IP address is not valid, show error message
                MessageBox.Show("Please enter a valid IP address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the ListBox
            if (listBoxIPs.SelectedItem != null)
            {
                string selectedIP = listBoxIPs.SelectedItem?.ToString();

                // Remove the selected item from the ListBox
                listBoxIPs.Items.Remove(selectedIP);

                // Update the file without the deleted IP
                File.WriteAllLines(filePath, listBoxIPs.Items.Cast<string>());

                MessageBox.Show("IP deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select an IP to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadIPHistory()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string[] ips = File.ReadAllLines(filePath);
                    listBoxIPs.Items.AddRange(ips);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the IP history: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // instead of this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: handle list box selection changes if needed
        }

        private bool IsValidIPAddress(string ipAddress)
        {
            if (string.IsNullOrWhiteSpace(ipAddress))
                return false;

            // Split the IP address by '.'
            string[] ipSegments = ipAddress.Split('.');

            // Check that we have exactly 4 segments
            if (ipSegments.Length != 4)
                return false;

            // Validate each segment
            foreach (string segment in ipSegments)
            {
                // Check if the segment is a valid integer
                if (!int.TryParse(segment, out int num))
                    return false;

                // Check if the number is within the range of 0 to 255
                if (num < 0 || num > 255)
                    return false;
            }

            return true;
        }

    }
}
