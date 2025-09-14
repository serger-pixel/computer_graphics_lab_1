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
            buttonLeft = new Button();
            buttonRight = new Button();
            buttonUp = new Button();
            buttonDown = new Button();
            rotationLeft = new Button();
            rotationRight = new Button();
            zoomIn = new Button();
            SuspendLayout();
            // 
            // paintPanel
            // 
            paintPanel.Location = new Point(63, 187);
            paintPanel.Name = "paintPanel";
            paintPanel.Size = new Size(1495, 858);
            paintPanel.TabIndex = 0;
            // 
            // buttonLeft
            // 
            buttonLeft.Location = new Point(63, 47);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(94, 84);
            buttonLeft.TabIndex = 1;
            buttonLeft.Text = "button1";
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += buttonLeft_Click;
            // 
            // buttonRight
            // 
            buttonRight.Location = new Point(220, 47);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(94, 84);
            buttonRight.TabIndex = 1;
            buttonRight.Text = "button1";
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += buttonRight_Click;
            // 
            // buttonUp
            // 
            buttonUp.Location = new Point(379, 81);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(112, 34);
            buttonUp.TabIndex = 2;
            buttonUp.Text = "button1";
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += buttonUp_Click;
            // 
            // buttonDown
            // 
            buttonDown.Location = new Point(551, 82);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(112, 34);
            buttonDown.TabIndex = 3;
            buttonDown.Text = "button2";
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += buttonDown_Click;
            // 
            // rotationLeft
            // 
            rotationLeft.Location = new Point(721, 82);
            rotationLeft.Name = "rotationLeft";
            rotationLeft.Size = new Size(112, 34);
            rotationLeft.TabIndex = 4;
            rotationLeft.Text = "button1";
            rotationLeft.UseVisualStyleBackColor = true;
            rotationLeft.Click += rotationRight_Click;
            // 
            // rotationRight
            // 
            rotationRight.Location = new Point(890, 81);
            rotationRight.Name = "rotationRight";
            rotationRight.Size = new Size(112, 34);
            rotationRight.TabIndex = 5;
            rotationRight.Text = "button2";
            rotationRight.UseVisualStyleBackColor = true;
            rotationRight.Click += rotationRight_Click_1;
            // 
            // zoomIn
            // 
            zoomIn.Location = new Point(1071, 90);
            zoomIn.Name = "zoomIn";
            zoomIn.Size = new Size(112, 34);
            zoomIn.TabIndex = 6;
            zoomIn.Text = "button1";
            zoomIn.UseVisualStyleBackColor = true;
            zoomIn.Click += zoomIn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1631, 1134);
            Controls.Add(zoomIn);
            Controls.Add(rotationRight);
            Controls.Add(rotationLeft);
            Controls.Add(buttonDown);
            Controls.Add(buttonUp);
            Controls.Add(buttonRight);
            Controls.Add(buttonLeft);
            Controls.Add(paintPanel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel paintPanel;
        private Button buttonLeft;
        private Button buttonRight;
        private Button buttonUp;
        private Button buttonDown;
        private Button rotationLeft;
        private Button rotationRight;
        private Button zoomIn;
    }
}
