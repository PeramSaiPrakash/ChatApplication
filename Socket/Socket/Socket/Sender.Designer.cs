namespace Client
{
    partial class Sender
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
            inputBox = new TextBox();
            Send = new Button();
            close = new Button();
            IpAddress = new TextBox();
            PortNumber = new TextBox();
            Display = new TextBox();
            clear = new Button();
            Connect = new Button();
            SuspendLayout();
            // 
            // inputBox
            // 
            inputBox.Location = new Point(66, 119);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(547, 31);
            inputBox.TabIndex = 0;
            inputBox.TextChanged += inputBox_TextChanged;
            // 
            // Send
            // 
            Send.Location = new Point(632, 116);
            Send.Name = "Send";
            Send.Size = new Size(112, 34);
            Send.TabIndex = 1;
            Send.Text = "Send";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_click;
            // 
            // close
            // 
            close.Location = new Point(642, 357);
            close.Name = "close";
            close.Size = new Size(112, 34);
            close.TabIndex = 2;
            close.Text = "Close";
            close.UseVisualStyleBackColor = true;
            close.Click += close_click;
            // 
            // IpAddress
            // 
            IpAddress.Location = new Point(66, 68);
            IpAddress.Name = "IpAddress";
            IpAddress.Size = new Size(228, 31);
            IpAddress.TabIndex = 3;
            IpAddress.Text = "IpAddress";
            IpAddress.TextChanged += IpAddress_TextChanged;
            // 
            // PortNumber
            // 
            PortNumber.Location = new Point(407, 68);
            PortNumber.Name = "PortNumber";
            PortNumber.Size = new Size(206, 31);
            PortNumber.TabIndex = 4;
            PortNumber.Text = "PortNumber";
            PortNumber.TextChanged += PortNumber_TextChanged;
            // 
            // Display
            // 
            Display.Location = new Point(66, 156);
            Display.Multiline = true;
            Display.Name = "Display";
            Display.Size = new Size(678, 187);
            Display.TabIndex = 5;
            Display.TextChanged += Display_TextChanged;
            // 
            // clear
            // 
            clear.Location = new Point(524, 357);
            clear.Name = "clear";
            clear.Size = new Size(112, 34);
            clear.TabIndex = 6;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // Connect
            // 
            Connect.Location = new Point(632, 65);
            Connect.Name = "Connect";
            Connect.Size = new Size(112, 34);
            Connect.TabIndex = 7;
            Connect.Text = "Connect";
            Connect.UseVisualStyleBackColor = true;
            Connect.Click += Connect_Click;
            // 
            // Sender
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Connect);
            Controls.Add(clear);
            Controls.Add(Display);
            Controls.Add(PortNumber);
            Controls.Add(IpAddress);
            Controls.Add(close);
            Controls.Add(Send);
            Controls.Add(inputBox);
            Name = "Sender";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputBox;
        private Button Send;
        private Button close;
        private TextBox IpAddress;
        private TextBox PortNumber;
        private TextBox Display;
        private Button clear;
        private Button Connect;
    }
}