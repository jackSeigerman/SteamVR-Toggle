namespace XRSwitcher
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            button8 = new Button();
            label5 = new Label();
            label6 = new Label();

            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(30, 81);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 0;
            button1.Text = "Desktop Mode";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(171, 81);
            button2.Name = "button2";
            button2.Size = new Size(121, 23);
            button2.TabIndex = 1;
            button2.Text = "VR Mode";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 2;
            label1.Text = "Mode Select";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveBorder;
            label2.Location = new Point(30, 43);
            label2.Name = "label2";
            label2.Size = new Size(420, 15);
            label2.TabIndex = 4;
            label2.Text = "Switch name of SteamVR folder to stop from auto launching som apps into VR";
            label2.Click += label2_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Silver;
            button8.ForeColor = SystemColors.ActiveCaptionText;
            button8.Location = new Point(314, 81);
            button8.Name = "button8";
            button8.Size = new Size(121, 23);
            button8.TabIndex = 12;
            button8.Text = "Launch VR";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(30, 123);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 13;
            label5.Text = "Current Mode:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.OrangeRed;
            label6.Location = new Point(120, 123);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 203);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button8);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Button button8;
        private Label label5;
        private Label label6;
    }
}
