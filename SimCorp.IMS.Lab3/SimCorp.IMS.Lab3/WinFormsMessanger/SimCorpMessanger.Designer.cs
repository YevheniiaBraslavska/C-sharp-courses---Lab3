namespace SimCorp.IMS.WinFormsMessanger {
    partial class SimCorpMessanger {
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
            this.components = new System.ComponentModel.Container();
            this.MessageRichBox = new System.Windows.Forms.RichTextBox();
            this.SMSPushTimer = new System.Windows.Forms.Timer(this.components);
            this.FormatTypesBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // MessageRichBox
            // 
            this.MessageRichBox.Location = new System.Drawing.Point(28, 77);
            this.MessageRichBox.Name = "MessageRichBox";
            this.MessageRichBox.Size = new System.Drawing.Size(434, 288);
            this.MessageRichBox.TabIndex = 0;
            this.MessageRichBox.Text = "";
            // 
            // SMSPushTimer
            // 
            this.SMSPushTimer.Enabled = true;
            this.SMSPushTimer.Interval = 1000;
            this.SMSPushTimer.Tick += new System.EventHandler(this.SMSPushTimer_Tick);
            // 
            // FormatTypesBox
            // 
            this.FormatTypesBox.FormattingEnabled = true;
            this.FormatTypesBox.Location = new System.Drawing.Point(28, 33);
            this.FormatTypesBox.Name = "FormatTypesBox";
            this.FormatTypesBox.Size = new System.Drawing.Size(296, 21);
            this.FormatTypesBox.TabIndex = 1;
            this.FormatTypesBox.SelectedIndexChanged += new System.EventHandler(this.FormatTypesBox_SelectedIndexChanged);
            // 
            // SimCorpMessanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 393);
            this.Controls.Add(this.FormatTypesBox);
            this.Controls.Add(this.MessageRichBox);
            this.MaximizeBox = false;
            this.Name = "SimCorpMessanger";
            this.Text = "SimCorp Messanger";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox MessageRichBox;
        public System.Windows.Forms.Timer SMSPushTimer;
        private System.Windows.Forms.ComboBox FormatTypesBox;
    }
}

