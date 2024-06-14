namespace Observable
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
            buttonNet = new Button();
            buttonColor = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // buttonNet
            // 
            buttonNet.Location = new Point(25, 23);
            buttonNet.Name = "buttonNet";
            buttonNet.Size = new Size(112, 34);
            buttonNet.TabIndex = 0;
            buttonNet.Text = "New Form";
            buttonNet.UseVisualStyleBackColor = true;
            buttonNet.Click += buttonNet_Click;
            // 
            // buttonColor
            // 
            buttonColor.Location = new Point(143, 23);
            buttonColor.Name = "buttonColor";
            buttonColor.Size = new Size(112, 34);
            buttonColor.TabIndex = 1;
            buttonColor.Text = "Color";
            buttonColor.UseVisualStyleBackColor = true;
            buttonColor.Click += buttonColor_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 244);
            Controls.Add(buttonColor);
            Controls.Add(buttonNet);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonNet;
        private Button buttonColor;
        private FileSystemWatcher fileSystemWatcher1;
        private ColorDialog colorDialog1;
    }
}
