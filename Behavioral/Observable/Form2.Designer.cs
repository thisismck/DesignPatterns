namespace Observable
{
    partial class Form2
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
            subscribe = new Button();
            unsubscribe = new Button();
            SuspendLayout();
            // 
            // subscribe
            // 
            subscribe.Location = new Point(12, 12);
            subscribe.Name = "subscribe";
            subscribe.Size = new Size(112, 34);
            subscribe.TabIndex = 0;
            subscribe.Text = "Subscribe";
            subscribe.UseVisualStyleBackColor = true;
            subscribe.Click += subscribe_Click;
            // 
            // unsubscribe
            // 
            unsubscribe.Location = new Point(130, 12);
            unsubscribe.Name = "unsubscribe";
            unsubscribe.Size = new Size(112, 34);
            unsubscribe.TabIndex = 1;
            unsubscribe.Text = "Unsubscribe";
            unsubscribe.UseVisualStyleBackColor = true;
            unsubscribe.Click += unsubscribe_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 244);
            Controls.Add(unsubscribe);
            Controls.Add(subscribe);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button subscribe;
        private Button unsubscribe;
    }
}