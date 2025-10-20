namespace TermoOfIssac
{
    partial class TermoOfIsaac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TermoOfIsaac));
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("IsaacGame", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(331, 399);
            button1.Name = "button1";
            button1.Size = new Size(53, 38);
            button1.TabIndex = 1;
            button1.Text = "A";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(396, 227);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // TermoOfIsaac
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1002, 561);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "TermoOfIsaac";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Termo of Isaac";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
    }
}
