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
            // buttonLeft
            // 
            buttonLeft.Location = new Point(63, 47);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(94, 84);
            buttonLeft.TabIndex = 1;
            buttonLeft.Text = "Влево";
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += buttonLeft_Click;
            // 
            // buttonRight
            // 
            buttonRight.Location = new Point(220, 47);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(94, 84);
            buttonRight.TabIndex = 1;
            buttonRight.Text = "Вправо";
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += buttonRight_Click;
            // 
            // buttonUp
            // 
            buttonUp.Location = new Point(370, 52);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(112, 75);
            buttonUp.TabIndex = 2;
            buttonUp.Text = "Вверх";
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += buttonUp_Click;
            // 
            // buttonDown
            // 
            buttonDown.Location = new Point(537, 52);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(112, 75);
            buttonDown.TabIndex = 3;
            buttonDown.Text = "Вниз";
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += buttonDown_Click;
            // 
            // rotationLeft
            // 
            rotationLeft.Location = new Point(671, 52);
            rotationLeft.Name = "rotationLeft";
            rotationLeft.Size = new Size(112, 71);
            rotationLeft.TabIndex = 4;
            rotationLeft.Text = "Поворот влево";
            rotationLeft.UseVisualStyleBackColor = true;
            rotationLeft.Click += rotationLeft_Click;
            // 
            // rotationRight
            // 
            rotationRight.Location = new Point(789, 58);
            rotationRight.Name = "rotationRight";
            rotationRight.Size = new Size(112, 62);
            rotationRight.TabIndex = 5;
            rotationRight.Text = "Поворот вправо";
            rotationRight.UseVisualStyleBackColor = true;
            rotationRight.Click += rotationRight_Click;
            // 
            // zoomIn
            // 
            zoomIn.Location = new Point(924, 61);
            zoomIn.Name = "zoomIn";
            zoomIn.Size = new Size(122, 59);
            zoomIn.TabIndex = 6;
            zoomIn.Text = "Увеличение";
            zoomIn.UseVisualStyleBackColor = true;
            zoomIn.Click += zoomIn_Click;
            // 
            // zoomOut
            // 
            zoomOut.Location = new Point(1052, 63);
            zoomOut.Name = "zoomOut";
            zoomOut.Size = new Size(142, 55);
            zoomOut.TabIndex = 7;
            zoomOut.Text = "Уменьшение";
            zoomOut.UseVisualStyleBackColor = true;
            zoomOut.Click += zoomOut_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1631, 1134);
            Controls.Add(zoomOut);
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
        private Button zoomOut;
    }
}
