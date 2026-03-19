namespace EchoMessenger
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
            label1 = new Label();
            lstEchoWindow = new ListBox();
            txtInput = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("한컴 말랑말랑 Bold", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(530, 83);
            label1.TabIndex = 0;
            label1.Text = "Echo Messenger";
            // 
            // lstEchoWindow
            // 
            lstEchoWindow.FormattingEnabled = true;
            lstEchoWindow.Location = new Point(12, 86);
            lstEchoWindow.Name = "lstEchoWindow";
            lstEchoWindow.Size = new Size(904, 516);
            lstEchoWindow.TabIndex = 1;
            lstEchoWindow.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 628);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(904, 78);
            txtInput.TabIndex = 2;
            txtInput.TextChanged += textBox1_TextChanged;
            // 
            // btnSend
            // 
            btnSend.BackColor = SystemColors.ActiveCaption;
            btnSend.Font = new Font("한컴 말랑말랑 Bold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSend.Location = new Point(960, 628);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(190, 78);
            btnSend.TabIndex = 3;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1510, 744);
            Controls.Add(btnSend);
            Controls.Add(txtInput);
            Controls.Add(lstEchoWindow);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstEchoWindow;
        private TextBox txtInput;
        private Button btnSend;
    }
}
