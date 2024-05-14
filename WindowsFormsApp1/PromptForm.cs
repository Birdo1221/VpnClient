using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class Prompt
    {
        public static string ShowDialog(string promptText, string promptCaption)
        {
            const int maxAttempts = 3;
            int attempts = 0;

            using (Form prompt = new Form())
            {
                prompt.Width = 400;
                prompt.Height = 220;
                prompt.FormBorderStyle = FormBorderStyle.FixedSingle;
                prompt.Text = promptCaption;
                prompt.StartPosition = FormStartPosition.CenterScreen;
                prompt.BackColor = Color.FromArgb(244, 244, 244); // Light gray background color

                // Header
                Panel headerPanel = new Panel()
                {
                    Dock = DockStyle.Top,
                    Height = 40,
                    BackColor = Color.FromArgb(43, 87, 154), // Blue header color
                };
                Label headerLabel = new Label()
                {
                    Text = promptCaption,
                    ForeColor = Color.White,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                };
                headerPanel.Controls.Add(headerLabel);
                prompt.Controls.Add(headerPanel);

                Label textLabel = new Label()
                {
                    Left = 20,
                    Top = 70,
                    Width = 360,
                    Text = promptText,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                };

                TextBox textBox = new TextBox()
                {
                    Left = 20,
                    Top = 100,
                    Width = 360,
                    TextAlign = HorizontalAlignment.Center,
                    MaxLength = 14, // Limit to 14 characters
                    Font = new Font("Arial", 10, FontStyle.Regular),
                };

                Button confirmation = new Button()
                {
                    Text = "OK",
                    Left = 150,
                    Width = 100,
                    Top = 150,
                    DialogResult = DialogResult.OK,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                };
                confirmation.Click += (sender, e) =>
                {
                    if (++attempts >= maxAttempts)
                    {
                        MessageBox.Show("Maximum number of attempts exceeded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        prompt.DialogResult = DialogResult.Cancel;
                    }
                    else
                    {
                        prompt.Close();
                    }
                };

                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);

                prompt.AcceptButton = confirmation;

                if (prompt.ShowDialog() == DialogResult.OK)
                {
                    return textBox.Text;
                }
                else
                {
                    return null; // Return null if user cancels the prompt
                }
            }
        }
    }
}
