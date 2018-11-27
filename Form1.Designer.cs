namespace LED_Control
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.portBox = new System.Windows.Forms.ComboBox();
            this.onBox = new System.Windows.Forms.Button();
            this.offBox = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // portBox
            // 
            this.portBox.FormattingEnabled = true;
            this.portBox.Location = new System.Drawing.Point(13, 12);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(121, 24);
            this.portBox.TabIndex = 0;
            this.portBox.SelectedIndexChanged += new System.EventHandler(this.portBox_SelectedIndexChanged);
            // 
            // onBox
            // 
            this.onBox.Location = new System.Drawing.Point(13, 42);
            this.onBox.Name = "onBox";
            this.onBox.Size = new System.Drawing.Size(121, 33);
            this.onBox.TabIndex = 1;
            this.onBox.Text = "ON";
            this.onBox.UseVisualStyleBackColor = true;
            this.onBox.Click += new System.EventHandler(this.onBox_Click);
            // 
            // offBox
            // 
            this.offBox.Location = new System.Drawing.Point(13, 81);
            this.offBox.Name = "offBox";
            this.offBox.Size = new System.Drawing.Size(121, 38);
            this.offBox.TabIndex = 2;
            this.offBox.Text = "OFF";
            this.offBox.UseVisualStyleBackColor = true;
            this.offBox.Click += new System.EventHandler(this.offBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 135);
            this.Controls.Add(this.offBox);
            this.Controls.Add(this.onBox);
            this.Controls.Add(this.portBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox portBox;
        private System.Windows.Forms.Button onBox;
        private System.Windows.Forms.Button offBox;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

