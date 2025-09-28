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
            paintPanel = new System.Windows.Forms.Panel();
            rotationLeft = new System.Windows.Forms.Button();
            rotationRight = new System.Windows.Forms.Button();
            zoomIn = new System.Windows.Forms.Button();
            zoomOut = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            buttonLeft = new System.Windows.Forms.Button();
            buttonRight = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            MoveY = new System.Windows.Forms.RadioButton();
            MoveX = new System.Windows.Forms.RadioButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            RotationZ = new System.Windows.Forms.RadioButton();
            RotationY = new System.Windows.Forms.RadioButton();
            RotationX = new System.Windows.Forms.RadioButton();
            groupBox3 = new System.Windows.Forms.GroupBox();
            projectionPanel = new System.Windows.Forms.Panel();
            groupBox4 = new System.Windows.Forms.GroupBox();
            projectionZ = new System.Windows.Forms.Button();
            projectionY = new System.Windows.Forms.Button();
            projectionX = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // paintPanel
            // 
            paintPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            paintPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            paintPanel.ForeColor = System.Drawing.SystemColors.ControlDark;
            paintPanel.Location = new System.Drawing.Point(1, 2);
            paintPanel.Name = "paintPanel";
            paintPanel.Size = new System.Drawing.Size(1215, 412);
            paintPanel.TabIndex = 0;
            // 
            // rotationLeft
            // 
            rotationLeft.Location = new System.Drawing.Point(60, 30);
            rotationLeft.Name = "rotationLeft";
            rotationLeft.Size = new System.Drawing.Size(73, 55);
            rotationLeft.TabIndex = 4;
            rotationLeft.Text = "<";
            rotationLeft.UseVisualStyleBackColor = true;
            rotationLeft.Click += rotationLeft_Click;
            // 
            // rotationRight
            // 
            rotationRight.Location = new System.Drawing.Point(154, 30);
            rotationRight.Name = "rotationRight";
            rotationRight.Size = new System.Drawing.Size(84, 55);
            rotationRight.TabIndex = 5;
            rotationRight.Text = ">";
            rotationRight.UseVisualStyleBackColor = true;
            rotationRight.Click += rotationRight_Click;
            // 
            // zoomIn
            // 
            zoomIn.Location = new System.Drawing.Point(31, 35);
            zoomIn.Name = "zoomIn";
            zoomIn.Size = new System.Drawing.Size(59, 48);
            zoomIn.TabIndex = 6;
            zoomIn.Text = "+";
            zoomIn.UseVisualStyleBackColor = true;
            zoomIn.Click += zoomIn_Click;
            // 
            // zoomOut
            // 
            zoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            zoomOut.Location = new System.Drawing.Point(123, 35);
            zoomOut.Name = "zoomOut";
            zoomOut.Size = new System.Drawing.Size(59, 48);
            zoomOut.TabIndex = 7;
            zoomOut.Text = "-";
            zoomOut.UseVisualStyleBackColor = true;
            zoomOut.Click += zoomOut_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(1088, 861);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(121, 47);
            button1.TabIndex = 8;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.Location = new System.Drawing.Point(47, 27);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new System.Drawing.Size(79, 53);
            buttonLeft.TabIndex = 1;
            buttonLeft.Text = "<";
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += buttonLeft_Click;
            // 
            // buttonRight
            // 
            buttonRight.Location = new System.Drawing.Point(164, 27);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new System.Drawing.Size(90, 58);
            buttonRight.TabIndex = 1;
            buttonRight.Text = ">";
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += buttonRight_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MoveY);
            groupBox1.Controls.Add(MoveX);
            groupBox1.Controls.Add(buttonRight);
            groupBox1.Controls.Add(buttonLeft);
            groupBox1.Location = new System.Drawing.Point(52, 420);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(285, 122);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Перемещение";
            // 
            // MoveY
            // 
            MoveY.AutoSize = true;
            MoveY.Location = new System.Drawing.Point(144, 93);
            MoveY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MoveY.Name = "MoveY";
            MoveY.Size = new System.Drawing.Size(47, 29);
            MoveY.TabIndex = 17;
            MoveY.TabStop = true;
            MoveY.Text = "Y";
            MoveY.UseVisualStyleBackColor = true;
            // 
            // MoveX
            // 
            MoveX.AutoSize = true;
            MoveX.Location = new System.Drawing.Point(88, 93);
            MoveX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MoveX.Name = "MoveX";
            MoveX.Size = new System.Drawing.Size(48, 29);
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
            groupBox2.Location = new System.Drawing.Point(399, 427);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(313, 130);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Поворот";
            // 
            // RotationZ
            // 
            RotationZ.AutoSize = true;
            RotationZ.Location = new System.Drawing.Point(191, 93);
            RotationZ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            RotationZ.Name = "RotationZ";
            RotationZ.Size = new System.Drawing.Size(47, 29);
            RotationZ.TabIndex = 21;
            RotationZ.TabStop = true;
            RotationZ.Text = "Z";
            RotationZ.UseVisualStyleBackColor = true;
            // 
            // RotationY
            // 
            RotationY.AutoSize = true;
            RotationY.Location = new System.Drawing.Point(126, 93);
            RotationY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            RotationY.Name = "RotationY";
            RotationY.Size = new System.Drawing.Size(47, 29);
            RotationY.TabIndex = 20;
            RotationY.TabStop = true;
            RotationY.Text = "Y";
            RotationY.UseVisualStyleBackColor = true;
            // 
            // RotationX
            // 
            RotationX.AutoSize = true;
            RotationX.Location = new System.Drawing.Point(60, 93);
            RotationX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            RotationX.Name = "RotationX";
            RotationX.Size = new System.Drawing.Size(48, 29);
            RotationX.TabIndex = 19;
            RotationX.TabStop = true;
            RotationX.Text = "X";
            RotationX.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(zoomOut);
            groupBox3.Controls.Add(zoomIn);
            groupBox3.Location = new System.Drawing.Point(788, 435);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(201, 122);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Масштаб";
            // 
            // projectionPanel
            // 
            projectionPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            projectionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            projectionPanel.ForeColor = System.Drawing.SystemColors.ControlDark;
            projectionPanel.Location = new System.Drawing.Point(1, 563);
            projectionPanel.Name = "projectionPanel";
            projectionPanel.Size = new System.Drawing.Size(1215, 279);
            projectionPanel.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(projectionZ);
            groupBox4.Controls.Add(projectionY);
            groupBox4.Controls.Add(projectionX);
            groupBox4.Location = new System.Drawing.Point(441, 848);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(313, 75);
            groupBox4.TabIndex = 22;
            groupBox4.TabStop = false;
            groupBox4.Text = "Проекции";
            // 
            // projectionZ
            // 
            projectionZ.Location = new System.Drawing.Point(181, 30);
            projectionZ.Name = "projectionZ";
            projectionZ.Size = new System.Drawing.Size(45, 40);
            projectionZ.TabIndex = 25;
            projectionZ.Text = "Z";
            projectionZ.UseVisualStyleBackColor = true;
            // 
            // projectionY
            // 
            projectionY.Location = new System.Drawing.Point(112, 30);
            projectionY.Name = "projectionY";
            projectionY.Size = new System.Drawing.Size(45, 40);
            projectionY.TabIndex = 24;
            projectionY.Text = "Y";
            projectionY.UseVisualStyleBackColor = true;
            // 
            // projectionX
            // 
            projectionX.Location = new System.Drawing.Point(35, 30);
            projectionX.Name = "projectionX";
            projectionX.Size = new System.Drawing.Size(47, 39);
            projectionX.TabIndex = 23;
            projectionX.Text = "X";
            projectionX.UseVisualStyleBackColor = true;
            projectionX.Click += projectionX_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1221, 950);
            Controls.Add(groupBox4);
            Controls.Add(projectionPanel);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(paintPanel);
            Text = "Лабораторная работа_КГ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button projectionX;
        private System.Windows.Forms.Button projectionY;
        private System.Windows.Forms.Button projectionZ;

        private System.Windows.Forms.GroupBox groupBox4;

        private System.Windows.Forms.Panel projectionPanel;

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
        private System.Windows.Forms.RadioButton MoveY;
        private System.Windows.Forms.RadioButton MoveX;
        private System.Windows.Forms.RadioButton RotationZ;
        private System.Windows.Forms.RadioButton RotationY;
        private System.Windows.Forms.RadioButton RotationX;
    }
}
