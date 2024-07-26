namespace ServerSwitcher
{
    partial class ServerSwitcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerSwitcher));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Enabled = false;
            button1.Location = new Point(48, 110);
            button1.Name = "button1";
            button1.Size = new Size(120, 30);
            button1.TabIndex = 0;
            button1.Text = "Swap Server";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Location = new Point(12, 77);
            label1.Name = "label1";
            label1.Size = new Size(200, 15);
            label1.TabIndex = 1;
            label1.Text = "SM64CoopDX not detected...";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Location = new Point(12, 33);
            label2.Name = "label2";
            label2.Size = new Size(200, 23);
            label2.TabIndex = 2;
            label2.Text = "SM64 Coop Deluxe:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Enabled = false;
            button2.Location = new Point(262, 110);
            button2.Name = "button2";
            button2.Size = new Size(120, 30);
            button2.TabIndex = 3;
            button2.Text = "Swap Server";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click_1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Location = new Point(222, 33);
            label3.Name = "label3";
            label3.Size = new Size(200, 23);
            label3.TabIndex = 4;
            label3.Text = "SM64EX Coop:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.Location = new Point(222, 77);
            label4.Name = "label4";
            label4.Size = new Size(200, 15);
            label4.TabIndex = 5;
            label4.Text = "SM64EXCoop not detected...";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ServerSwitcher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(434, 161);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ServerSwitcher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ServerSwitcher";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label3;
        private Label label4;
    }
}
