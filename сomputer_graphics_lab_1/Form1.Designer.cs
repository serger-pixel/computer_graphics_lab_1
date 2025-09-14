namespace сomputer_graphics_lab_1
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
            paintPanel = new Panel();
            zoomIn = new Button();
            zoomOut = new Button();
            SuspendLayout();
            // 
            // paintPanel
            // 
            paintPanel.Location = new Point(63, 187);
            paintPanel.Name = "paintPanel";
            paintPanel.Size = new Size(1495, 858);
            paintPanel.TabIndex = 0;
            // 
            // zoomIn
            // 
            zoomIn.Location = new Point(104, 12);
            zoomIn.Name = "zoomIn";
            zoomIn.Size = new Size(94, 84);
            zoomIn.TabIndex = 1;
            zoomIn.Text = "button1";
            zoomIn.UseVisualStyleBackColor = true;
            // 
            // zoomOut
            // 
            zoomOut.Location = new Point(220, 47);
            zoomOut.Name = "zoomOut";
            zoomOut.Size = new Size(94, 84);
            zoomOut.TabIndex = 1;
            zoomOut.Text = "button1";
            zoomOut.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1631, 1134);
            Controls.Add(zoomOut);
            Controls.Add(zoomIn);
            Controls.Add(paintPanel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel paintPanel;
        private Button zoomIn;
        private Button zoomOut;
    }
}
