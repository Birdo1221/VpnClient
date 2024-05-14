namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vpnComboBox1 = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wireguardRadioButton = new System.Windows.Forms.RadioButton();
            this.openvpnRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vpnComboBox1
            // 
            this.vpnComboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.vpnComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vpnComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vpnComboBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vpnComboBox1.FormattingEnabled = true;
            this.vpnComboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.vpnComboBox1.Location = new System.Drawing.Point(72, 237);
            this.vpnComboBox1.Name = "vpnComboBox1";
            this.vpnComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.vpnComboBox1.Size = new System.Drawing.Size(200, 24);
            this.vpnComboBox1.TabIndex = 0;
            this.vpnComboBox1.Text = "              Select a VPN";
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.connectButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.connectButton.FlatAppearance.BorderSize = 2;
            this.connectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.connectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectButton.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.ForeColor = System.Drawing.Color.White;
            this.connectButton.Location = new System.Drawing.Point(0, 363);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(340, 78);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vpnComboBox1);
            this.panel1.Controls.Add(this.wireguardRadioButton);
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Controls.Add(this.openvpnRadioButton);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 451);
            this.panel1.TabIndex = 2;
            // 
            // wireguardRadioButton
            // 
            this.wireguardRadioButton.AutoSize = true;
            this.wireguardRadioButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wireguardRadioButton.Location = new System.Drawing.Point(12, 302);
            this.wireguardRadioButton.Name = "wireguardRadioButton";
            this.wireguardRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.wireguardRadioButton.Size = new System.Drawing.Size(94, 20);
            this.wireguardRadioButton.TabIndex = 6;
            this.wireguardRadioButton.Text = "WireGuard";
            this.wireguardRadioButton.UseVisualStyleBackColor = true;
            this.wireguardRadioButton.CheckedChanged += new System.EventHandler(this.wireguardRadioButton_CheckedChanged);
            // 
            // openvpnRadioButton
            // 
            this.openvpnRadioButton.AutoSize = true;
            this.openvpnRadioButton.Checked = true;
            this.openvpnRadioButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openvpnRadioButton.ImageKey = "(none)";
            this.openvpnRadioButton.Location = new System.Drawing.Point(242, 302);
            this.openvpnRadioButton.Name = "openvpnRadioButton";
            this.openvpnRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.openvpnRadioButton.Size = new System.Drawing.Size(86, 20);
            this.openvpnRadioButton.TabIndex = 5;
            this.openvpnRadioButton.TabStop = true;
            this.openvpnRadioButton.Text = "OpenVPN";
            this.openvpnRadioButton.UseVisualStyleBackColor = true;
            this.openvpnRadioButton.CheckedChanged += new System.EventHandler(this.openvpnRadioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(340, 441);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Birdo VPN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox vpnComboBox1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton openvpnRadioButton;
        private System.Windows.Forms.RadioButton wireguardRadioButton;
    }
}
