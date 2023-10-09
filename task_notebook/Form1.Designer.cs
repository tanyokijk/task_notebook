namespace task_notebook
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
            startButton = new Button();
            StopButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.Location = new Point(358, 76);
            startButton.Name = "startButton";
            startButton.Size = new Size(187, 74);
            startButton.TabIndex = 0;
            startButton.Text = "Старт";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // StopButton
            // 
            StopButton.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point);
            StopButton.Location = new Point(358, 178);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(187, 74);
            StopButton.TabIndex = 1;
            StopButton.Text = "Стоп";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 333);
            label1.Name = "label1";
            label1.Size = new Size(0, 35);
            label1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 450);
            Controls.Add(label1);
            Controls.Add(StopButton);
            Controls.Add(startButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Button StopButton;
        private Label label1;
    }
}