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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            paintPanel = new Panel();
            rotationLeft = new Button();
            rotationRight = new Button();
            zoomIn = new Button();
            zoomOut = new Button();
            button1 = new Button();
            buttonLeft = new Button();
            buttonRight = new Button();
            groupBox1 = new GroupBox();
            MoveZ = new RadioButton();
            MoveY = new RadioButton();
            MoveX = new RadioButton();
            groupBox2 = new GroupBox();
            RotationZ = new RadioButton();
            RotationY = new RadioButton();
            RotationX = new RadioButton();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // paintPanel
            // 
            paintPanel.BackColor = SystemColors.ButtonFace;
            paintPanel.BorderStyle = BorderStyle.FixedSingle;
            paintPanel.ForeColor = SystemColors.ControlDark;
            paintPanel.Location = new Point(1, 2);
            paintPanel.Name = "paintPanel";
            paintPanel.Size = new Size(1215, 480);
            paintPanel.TabIndex = 0;
            // 
            // rotationLeft
            // 
            rotationLeft.Location = new Point(26, 38);
            rotationLeft.Name = "rotationLeft";
            rotationLeft.Size = new Size(111, 63);
            rotationLeft.TabIndex = 4;
            rotationLeft.Text = "<";
            rotationLeft.UseVisualStyleBackColor = true;
            rotationLeft.Click += rotationLeft_Click;
            // 
            // rotationRight
            // 
            rotationRight.Location = new Point(177, 38);
            rotationRight.Name = "rotationRight";
            rotationRight.Size = new Size(111, 63);
            rotationRight.TabIndex = 5;
            rotationRight.Text = ">";
            rotationRight.UseVisualStyleBackColor = true;
            rotationRight.Click += rotationRight_Click;
            // 
            // zoomIn
            // 
            zoomIn.Location = new Point(31, 35);
            zoomIn.Name = "zoomIn";
            zoomIn.Size = new Size(59, 48);
            zoomIn.TabIndex = 6;
            zoomIn.Text = "+";
            zoomIn.UseVisualStyleBackColor = true;
            zoomIn.Click += zoomIn_Click;
            // 
            // zoomOut
            // 
            zoomOut.BackgroundImageLayout = ImageLayout.Center;
            zoomOut.Location = new Point(123, 35);
            zoomOut.Name = "zoomOut";
            zoomOut.Size = new Size(59, 48);
            zoomOut.TabIndex = 7;
            zoomOut.Text = "-";
            zoomOut.UseVisualStyleBackColor = true;
            zoomOut.Click += zoomOut_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1096, 547);
            button1.Name = "button1";
            button1.Size = new Size(121, 47);
            button1.TabIndex = 8;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.Location = new Point(28, 40);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(79, 53);
            buttonLeft.TabIndex = 1;
            buttonLeft.Text = "<";
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += buttonLeft_Click;
            // 
            // buttonRight
            // 
            buttonRight.Location = new Point(170, 38);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(90, 58);
            buttonRight.TabIndex = 1;
            buttonRight.Text = ">";
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += buttonRight_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MoveZ);
            groupBox1.Controls.Add(MoveY);
            groupBox1.Controls.Add(MoveX);
            groupBox1.Controls.Add(buttonRight);
            groupBox1.Controls.Add(buttonLeft);
            groupBox1.Location = new Point(50, 483);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(285, 193);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Перемещение";
            // 
            // MoveZ
            // 
            MoveZ.AutoSize = true;
            MoveZ.Location = new Point(191, 140);
            MoveZ.Margin = new Padding(4, 5, 4, 5);
            MoveZ.Name = "MoveZ";
            MoveZ.Size = new Size(47, 29);
            MoveZ.TabIndex = 18;
            MoveZ.TabStop = true;
            MoveZ.Text = "Z";
            MoveZ.UseVisualStyleBackColor = true;
            // 
            // MoveY
            // 
            MoveY.AutoSize = true;
            MoveY.Location = new Point(122, 140);
            MoveY.Margin = new Padding(4, 5, 4, 5);
            MoveY.Name = "MoveY";
            MoveY.Size = new Size(47, 29);
            MoveY.TabIndex = 17;
            MoveY.TabStop = true;
            MoveY.Text = "Y";
            MoveY.UseVisualStyleBackColor = true;
            // 
            // MoveX
            // 
            MoveX.AutoSize = true;
            MoveX.Location = new Point(59, 140);
            MoveX.Margin = new Padding(4, 5, 4, 5);
            MoveX.Name = "MoveX";
            MoveX.Size = new Size(48, 29);
            MoveX.TabIndex = 16;
            MoveX.TabStop = true;
            MoveX.Text = "X";
            MoveX.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RotationZ);
            groupBox2.Controls.Add(RotationY);
            groupBox2.Controls.Add(RotationX);
            groupBox2.Controls.Add(rotationRight);
            groupBox2.Controls.Add(rotationLeft);
            groupBox2.Location = new Point(421, 483);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(313, 193);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Поворот";
            // 
            // RotationZ
            // 
            RotationZ.AutoSize = true;
            RotationZ.Location = new Point(209, 140);
            RotationZ.Margin = new Padding(4, 5, 4, 5);
            RotationZ.Name = "RotationZ";
            RotationZ.Size = new Size(47, 29);
            RotationZ.TabIndex = 21;
            RotationZ.TabStop = true;
            RotationZ.Text = "Z";
            RotationZ.UseVisualStyleBackColor = true;
            // 
            // RotationY
            // 
            RotationY.AutoSize = true;
            RotationY.Location = new Point(126, 140);
            RotationY.Margin = new Padding(4, 5, 4, 5);
            RotationY.Name = "RotationY";
            RotationY.Size = new Size(47, 29);
            RotationY.TabIndex = 20;
            RotationY.TabStop = true;
            RotationY.Text = "Y";
            RotationY.UseVisualStyleBackColor = true;
            // 
            // RotationX
            // 
            RotationX.AutoSize = true;
            RotationX.Location = new Point(51, 140);
            RotationX.Margin = new Padding(4, 5, 4, 5);
            RotationX.Name = "RotationX";
            RotationX.Size = new Size(48, 29);
            RotationX.TabIndex = 19;
            RotationX.TabStop = true;
            RotationX.Text = "X";
            RotationX.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(zoomOut);
            groupBox3.Controls.Add(zoomIn);
            groupBox3.Location = new Point(851, 488);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(201, 107);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Масштаб";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 695);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(paintPanel);
            Name = "Form1";
            Text = "Лабораторная работа_КГ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;

        private System.Windows.Forms.Button button1;

        #endregion

        private System.Windows.Forms.Panel paintPanel;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button rotationLeft;
        private System.Windows.Forms.Button rotationRight;
        private System.Windows.Forms.Button zoomIn;
        private System.Windows.Forms.Button zoomOut;
        private RadioButton MoveZ;
        private RadioButton MoveY;
        private RadioButton MoveX;
        private RadioButton RotationZ;
        private RadioButton RotationY;
        private RadioButton RotationX;
    }
}
