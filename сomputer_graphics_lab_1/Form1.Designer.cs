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
            MoveY = new RadioButton();
            MoveX = new RadioButton();
            groupBox2 = new GroupBox();
            RotationZ = new RadioButton();
            RotationY = new RadioButton();
            RotationX = new RadioButton();
            groupBox3 = new GroupBox();
            projectionPanel = new Panel();
            groupBox4 = new GroupBox();
            prjctZ = new RadioButton();
            projectionX = new Button();
            prjctY = new RadioButton();
            prjctX = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // paintPanel
            // 
            paintPanel.BackColor = SystemColors.ButtonFace;
            paintPanel.BorderStyle = BorderStyle.FixedSingle;
            paintPanel.ForeColor = SystemColors.ControlDark;
            paintPanel.Location = new Point(1, 1);
            paintPanel.Margin = new Padding(2);
            paintPanel.Name = "paintPanel";
            paintPanel.Size = new Size(851, 248);
            paintPanel.TabIndex = 0;
            // 
            // rotationLeft
            // 
            rotationLeft.Location = new Point(42, 18);
            rotationLeft.Margin = new Padding(2);
            rotationLeft.Name = "rotationLeft";
            rotationLeft.Size = new Size(51, 33);
            rotationLeft.TabIndex = 4;
            rotationLeft.Text = "<";
            rotationLeft.UseVisualStyleBackColor = true;
            rotationLeft.Click += rotationLeft_Click;
            // 
            // rotationRight
            // 
            rotationRight.Location = new Point(108, 18);
            rotationRight.Margin = new Padding(2);
            rotationRight.Name = "rotationRight";
            rotationRight.Size = new Size(59, 33);
            rotationRight.TabIndex = 5;
            rotationRight.Text = ">";
            rotationRight.UseVisualStyleBackColor = true;
            rotationRight.Click += rotationRight_Click;
            // 
            // zoomIn
            // 
            zoomIn.Location = new Point(22, 21);
            zoomIn.Margin = new Padding(2);
            zoomIn.Name = "zoomIn";
            zoomIn.Size = new Size(41, 29);
            zoomIn.TabIndex = 6;
            zoomIn.Text = "+";
            zoomIn.UseVisualStyleBackColor = true;
            zoomIn.Click += zoomIn_Click;
            // 
            // zoomOut
            // 
            zoomOut.BackgroundImageLayout = ImageLayout.Center;
            zoomOut.Location = new Point(86, 21);
            zoomOut.Margin = new Padding(2);
            zoomOut.Name = "zoomOut";
            zoomOut.Size = new Size(41, 29);
            zoomOut.TabIndex = 7;
            zoomOut.Text = "-";
            zoomOut.UseVisualStyleBackColor = true;
            zoomOut.Click += zoomOut_Click;
            // 
            // button1
            // 
            button1.Location = new Point(759, 659);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(85, 28);
            button1.TabIndex = 8;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.Location = new Point(33, 16);
            buttonLeft.Margin = new Padding(2);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(55, 32);
            buttonLeft.TabIndex = 1;
            buttonLeft.Text = "<";
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += buttonLeft_Click;
            // 
            // buttonRight
            // 
            buttonRight.Location = new Point(115, 16);
            buttonRight.Margin = new Padding(2);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(63, 35);
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
            groupBox1.Location = new Point(36, 252);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(200, 73);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Перемещение";
            // 
            // MoveY
            // 
            MoveY.AutoSize = true;
            MoveY.Location = new Point(101, 56);
            MoveY.Name = "MoveY";
            MoveY.Size = new Size(32, 19);
            MoveY.TabIndex = 17;
            MoveY.TabStop = true;
            MoveY.Text = "Y";
            MoveY.UseVisualStyleBackColor = true;
            // 
            // MoveX
            // 
            MoveX.AutoSize = true;
            MoveX.Location = new Point(62, 56);
            MoveX.Name = "MoveX";
            MoveX.Size = new Size(32, 19);
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
            groupBox2.Location = new Point(279, 256);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(219, 78);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Поворот";
            // 
            // RotationZ
            // 
            RotationZ.AutoSize = true;
            RotationZ.Location = new Point(134, 56);
            RotationZ.Name = "RotationZ";
            RotationZ.Size = new Size(32, 19);
            RotationZ.TabIndex = 21;
            RotationZ.TabStop = true;
            RotationZ.Text = "Z";
            RotationZ.UseVisualStyleBackColor = true;
            // 
            // RotationY
            // 
            RotationY.AutoSize = true;
            RotationY.Location = new Point(88, 56);
            RotationY.Name = "RotationY";
            RotationY.Size = new Size(32, 19);
            RotationY.TabIndex = 20;
            RotationY.TabStop = true;
            RotationY.Text = "Y";
            RotationY.UseVisualStyleBackColor = true;
            // 
            // RotationX
            // 
            RotationX.AutoSize = true;
            RotationX.Location = new Point(42, 56);
            RotationX.Name = "RotationX";
            RotationX.Size = new Size(32, 19);
            RotationX.TabIndex = 19;
            RotationX.TabStop = true;
            RotationX.Text = "X";
            RotationX.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(zoomOut);
            groupBox3.Controls.Add(zoomIn);
            groupBox3.Location = new Point(552, 261);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(141, 73);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Масштаб";
            // 
            // projectionPanel
            // 
            projectionPanel.BackColor = SystemColors.ButtonFace;
            projectionPanel.BorderStyle = BorderStyle.FixedSingle;
            projectionPanel.ForeColor = SystemColors.ControlDark;
            projectionPanel.Location = new Point(1, 336);
            projectionPanel.Margin = new Padding(2);
            projectionPanel.Name = "projectionPanel";
            projectionPanel.Size = new Size(851, 276);
            projectionPanel.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(prjctZ);
            groupBox4.Controls.Add(projectionX);
            groupBox4.Controls.Add(prjctY);
            groupBox4.Controls.Add(prjctX);
            groupBox4.Location = new Point(307, 616);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(219, 75);
            groupBox4.TabIndex = 22;
            groupBox4.TabStop = false;
            groupBox4.Text = "Проекции";
            // 
            // prjctZ
            // 
            prjctZ.AutoSize = true;
            prjctZ.Location = new Point(139, 24);
            prjctZ.Name = "prjctZ";
            prjctZ.Size = new Size(32, 19);
            prjctZ.TabIndex = 24;
            prjctZ.TabStop = true;
            prjctZ.Text = "Z";
            prjctZ.UseVisualStyleBackColor = true;
            // 
            // projectionX
            // 
            projectionX.Location = new Point(61, 48);
            projectionX.Margin = new Padding(2);
            projectionX.Name = "projectionX";
            projectionX.Size = new Size(99, 23);
            projectionX.TabIndex = 23;
            projectionX.Text = "Обновить";
            projectionX.UseVisualStyleBackColor = true;
            projectionX.Click += projectionX_Click;
            // 
            // prjctY
            // 
            prjctY.AutoSize = true;
            prjctY.Location = new Point(93, 24);
            prjctY.Name = "prjctY";
            prjctY.Size = new Size(32, 19);
            prjctY.TabIndex = 23;
            prjctY.TabStop = true;
            prjctY.Text = "Y";
            prjctY.UseVisualStyleBackColor = true;
            // 
            // prjctX
            // 
            prjctX.AutoSize = true;
            prjctX.Location = new Point(47, 24);
            prjctX.Name = "prjctX";
            prjctX.Size = new Size(32, 19);
            prjctX.TabIndex = 22;
            prjctX.TabStop = true;
            prjctX.Text = "X";
            prjctX.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(groupBox4);
            Controls.Add(projectionPanel);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(paintPanel);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Лабораторная работа_КГ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button projectionX;

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
        private RadioButton prjctZ;
        private RadioButton prjctY;
        private RadioButton prjctX;
    }
}
