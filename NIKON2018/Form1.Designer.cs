namespace NIKON2018
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.Xval_label = new System.Windows.Forms.Label();
            this.Yval_label = new System.Windows.Forms.Label();
            this.Yvalue_label = new System.Windows.Forms.Label();
            this.Xvalue_label = new System.Windows.Forms.Label();
            this.RESET_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBox_Standard_Baudrates = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBox_Available_SerialPorts = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 4800;
            this.serialPort1.PortName = "COM7";
            this.serialPort1.RtsEnable = true;
            this.serialPort1.StopBits = System.IO.Ports.StopBits.Two;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(356, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 76);
            this.button3.TabIndex = 30;
            this.button3.Text = "EXPORT";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Xval_label
            // 
            this.Xval_label.AutoSize = true;
            this.Xval_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xval_label.ForeColor = System.Drawing.Color.DarkGreen;
            this.Xval_label.Location = new System.Drawing.Point(87, 318);
            this.Xval_label.Name = "Xval_label";
            this.Xval_label.Size = new System.Drawing.Size(55, 18);
            this.Xval_label.TabIndex = 29;
            this.Xval_label.Text = "X Axis";
            // 
            // Yval_label
            // 
            this.Yval_label.AutoSize = true;
            this.Yval_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yval_label.ForeColor = System.Drawing.Color.DarkGreen;
            this.Yval_label.Location = new System.Drawing.Point(247, 318);
            this.Yval_label.Name = "Yval_label";
            this.Yval_label.Size = new System.Drawing.Size(54, 18);
            this.Yval_label.TabIndex = 28;
            this.Yval_label.Text = "Y Axis";
            // 
            // Yvalue_label
            // 
            this.Yvalue_label.AutoSize = true;
            this.Yvalue_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yvalue_label.ForeColor = System.Drawing.Color.Blue;
            this.Yvalue_label.Location = new System.Drawing.Point(243, 336);
            this.Yvalue_label.Name = "Yvalue_label";
            this.Yvalue_label.Size = new System.Drawing.Size(70, 25);
            this.Yvalue_label.TabIndex = 27;
            this.Yvalue_label.Text = "empty";
            // 
            // Xvalue_label
            // 
            this.Xvalue_label.AutoSize = true;
            this.Xvalue_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xvalue_label.ForeColor = System.Drawing.Color.Blue;
            this.Xvalue_label.Location = new System.Drawing.Point(71, 336);
            this.Xvalue_label.Name = "Xvalue_label";
            this.Xvalue_label.Size = new System.Drawing.Size(70, 25);
            this.Xvalue_label.TabIndex = 24;
            this.Xvalue_label.Text = "empty";
            // 
            // RESET_button
            // 
            this.RESET_button.Location = new System.Drawing.Point(356, 132);
            this.RESET_button.Name = "RESET_button";
            this.RESET_button.Size = new System.Drawing.Size(75, 76);
            this.RESET_button.TabIndex = 23;
            this.RESET_button.Text = "RESET";
            this.RESET_button.UseVisualStyleBackColor = true;
            this.RESET_button.Click += new System.EventHandler(this.RESET_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Baudrate";
            // 
            // ComboBox_Standard_Baudrates
            // 
            this.ComboBox_Standard_Baudrates.FormattingEnabled = true;
            this.ComboBox_Standard_Baudrates.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.ComboBox_Standard_Baudrates.Location = new System.Drawing.Point(319, 22);
            this.ComboBox_Standard_Baudrates.Name = "ComboBox_Standard_Baudrates";
            this.ComboBox_Standard_Baudrates.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Standard_Baudrates.TabIndex = 20;
            this.ComboBox_Standard_Baudrates.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_Standard_Baudrates_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Available Ports";
            // 
            // ComboBox_Available_SerialPorts
            // 
            this.ComboBox_Available_SerialPorts.FormattingEnabled = true;
            this.ComboBox_Available_SerialPorts.Location = new System.Drawing.Point(111, 22);
            this.ComboBox_Available_SerialPorts.Name = "ComboBox_Available_SerialPorts";
            this.ComboBox_Available_SerialPorts.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Available_SerialPorts.Sorted = true;
            this.ComboBox_Available_SerialPorts.TabIndex = 18;
            this.ComboBox_Available_SerialPorts.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_Available_SerialPorts_SelectionChangeCommitted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(785, 575);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Xval_label);
            this.Controls.Add(this.Yval_label);
            this.Controls.Add(this.Yvalue_label);
            this.Controls.Add(this.Xvalue_label);
            this.Controls.Add(this.RESET_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboBox_Standard_Baudrates);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBox_Available_SerialPorts);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "NIKON2018";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Xval_label;
        private System.Windows.Forms.Label Yval_label;
        private System.Windows.Forms.Label Yvalue_label;
        private System.Windows.Forms.Label Xvalue_label;
        private System.Windows.Forms.Button RESET_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBox_Standard_Baudrates;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBox_Available_SerialPorts;
        private System.Windows.Forms.Button button1;
    }
}

