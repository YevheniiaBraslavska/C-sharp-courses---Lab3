namespace SimCorp.IMS.WinFormApp {
    partial class WinFormApp {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.PlaybackGroupBox = new System.Windows.Forms.GroupBox();
            this.PhoneSpeakerButton = new System.Windows.Forms.RadioButton();
            this.SamsungHeadsetButton = new System.Windows.Forms.RadioButton();
            this.IPhoneHeadsetButton = new System.Windows.Forms.RadioButton();
            this.ChargerGroupBox = new System.Windows.Forms.GroupBox();
            this.USBChargerButton = new System.Windows.Forms.RadioButton();
            this.WirelessChargerButton = new System.Windows.Forms.RadioButton();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.PlaybackGroupBox.SuspendLayout();
            this.ChargerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlaybackGroupBox
            // 
            this.PlaybackGroupBox.Controls.Add(this.PhoneSpeakerButton);
            this.PlaybackGroupBox.Controls.Add(this.SamsungHeadsetButton);
            this.PlaybackGroupBox.Controls.Add(this.IPhoneHeadsetButton);
            this.PlaybackGroupBox.Location = new System.Drawing.Point(26, 28);
            this.PlaybackGroupBox.Name = "PlaybackGroupBox";
            this.PlaybackGroupBox.Size = new System.Drawing.Size(178, 133);
            this.PlaybackGroupBox.TabIndex = 0;
            this.PlaybackGroupBox.TabStop = false;
            this.PlaybackGroupBox.Text = "Select playback component:";
            // 
            // PhoneSpeakerButton
            // 
            this.PhoneSpeakerButton.AutoSize = true;
            this.PhoneSpeakerButton.Location = new System.Drawing.Point(16, 76);
            this.PhoneSpeakerButton.Name = "PhoneSpeakerButton";
            this.PhoneSpeakerButton.Size = new System.Drawing.Size(96, 17);
            this.PhoneSpeakerButton.TabIndex = 3;
            this.PhoneSpeakerButton.Text = "PhoneSpeaker";
            this.PhoneSpeakerButton.UseVisualStyleBackColor = true;
            // 
            // SamsungHeadsetButton
            // 
            this.SamsungHeadsetButton.AutoSize = true;
            this.SamsungHeadsetButton.Location = new System.Drawing.Point(16, 53);
            this.SamsungHeadsetButton.Name = "SamsungHeadsetButton";
            this.SamsungHeadsetButton.Size = new System.Drawing.Size(109, 17);
            this.SamsungHeadsetButton.TabIndex = 1;
            this.SamsungHeadsetButton.Text = "SamsungHeadset";
            this.SamsungHeadsetButton.UseVisualStyleBackColor = true;
            // 
            // IPhoneHeadsetButton
            // 
            this.IPhoneHeadsetButton.AutoSize = true;
            this.IPhoneHeadsetButton.Location = new System.Drawing.Point(16, 30);
            this.IPhoneHeadsetButton.Name = "IPhoneHeadsetButton";
            this.IPhoneHeadsetButton.Size = new System.Drawing.Size(99, 17);
            this.IPhoneHeadsetButton.TabIndex = 0;
            this.IPhoneHeadsetButton.Text = "IPhoneHeadset";
            this.IPhoneHeadsetButton.UseVisualStyleBackColor = true;
            // 
            // ChargerGroupBox
            // 
            this.ChargerGroupBox.Controls.Add(this.USBChargerButton);
            this.ChargerGroupBox.Controls.Add(this.WirelessChargerButton);
            this.ChargerGroupBox.Location = new System.Drawing.Point(234, 28);
            this.ChargerGroupBox.Name = "ChargerGroupBox";
            this.ChargerGroupBox.Size = new System.Drawing.Size(183, 133);
            this.ChargerGroupBox.TabIndex = 1;
            this.ChargerGroupBox.TabStop = false;
            this.ChargerGroupBox.Text = "Select charging component:";
            // 
            // USBChargerButton
            // 
            this.USBChargerButton.AutoSize = true;
            this.USBChargerButton.Location = new System.Drawing.Point(17, 53);
            this.USBChargerButton.Name = "USBChargerButton";
            this.USBChargerButton.Size = new System.Drawing.Size(84, 17);
            this.USBChargerButton.TabIndex = 1;
            this.USBChargerButton.TabStop = true;
            this.USBChargerButton.Text = "USBCharger";
            this.USBChargerButton.UseVisualStyleBackColor = true;
            // 
            // WirelessChargerButton
            // 
            this.WirelessChargerButton.AutoSize = true;
            this.WirelessChargerButton.Location = new System.Drawing.Point(17, 30);
            this.WirelessChargerButton.Name = "WirelessChargerButton";
            this.WirelessChargerButton.Size = new System.Drawing.Size(102, 17);
            this.WirelessChargerButton.TabIndex = 0;
            this.WirelessChargerButton.TabStop = true;
            this.WirelessChargerButton.Text = "WirelessCharger";
            this.WirelessChargerButton.UseVisualStyleBackColor = true;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(330, 170);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 0;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // TextBox
            // 
            this.TextBox.Enabled = false;
            this.TextBox.Location = new System.Drawing.Point(26, 198);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(391, 167);
            this.TextBox.TabIndex = 4;
            this.TextBox.Text = "";
            // 
            // WinFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 391);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.ChargerGroupBox);
            this.Controls.Add(this.PlaybackGroupBox);
            this.MaximizeBox = false;
            this.Name = "WinFormApp";
            this.Text = "WinForm App";
            this.PlaybackGroupBox.ResumeLayout(false);
            this.PlaybackGroupBox.PerformLayout();
            this.ChargerGroupBox.ResumeLayout(false);
            this.ChargerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PlaybackGroupBox;
        private System.Windows.Forms.RadioButton PhoneSpeakerButton;
        private System.Windows.Forms.RadioButton SamsungHeadsetButton;
        private System.Windows.Forms.RadioButton IPhoneHeadsetButton;
        private System.Windows.Forms.GroupBox ChargerGroupBox;
        private System.Windows.Forms.RadioButton USBChargerButton;
        private System.Windows.Forms.RadioButton WirelessChargerButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.RichTextBox TextBox;
    }
}

