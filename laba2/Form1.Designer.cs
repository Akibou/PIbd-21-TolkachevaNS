﻿namespace laba2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LinerPic = new System.Windows.Forms.PictureBox();
            this.MaxSpeedL = new System.Windows.Forms.Label();
            this.MaxCountPassengers = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.Label();
            this.ColorBody = new System.Windows.Forms.Label();
            this.SortButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WaterLine = new System.Windows.Forms.TextBox();
            this.RoundLine = new System.Windows.Forms.CheckBox();
            this.BorderLine = new System.Windows.Forms.CheckBox();
            this.TopLine = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSelectColor = new System.Windows.Forms.Button();
            this.buttonDopColor = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Rest = new System.Windows.Forms.CheckBox();
            this.Bass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.LinerPic)).BeginInit();
            this.SuspendLayout();
            // 
            // LinerPic
            // 
            this.LinerPic.Location = new System.Drawing.Point(19, 14);
            this.LinerPic.Name = "LinerPic";
            this.LinerPic.Size = new System.Drawing.Size(670, 282);
            this.LinerPic.TabIndex = 0;
            this.LinerPic.TabStop = false;
            this.LinerPic.Click += new System.EventHandler(this.LinerPic_Click);
            // 
            // MaxSpeedL
            // 
            this.MaxSpeedL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MaxSpeedL.AutoSize = true;
            this.MaxSpeedL.Location = new System.Drawing.Point(16, 312);
            this.MaxSpeedL.Name = "MaxSpeedL";
            this.MaxSpeedL.Size = new System.Drawing.Size(62, 13);
            this.MaxSpeedL.TabIndex = 1;
            this.MaxSpeedL.Text = "Max speed:";
            // 
            // MaxCountPassengers
            // 
            this.MaxCountPassengers.AutoSize = true;
            this.MaxCountPassengers.Location = new System.Drawing.Point(16, 335);
            this.MaxCountPassengers.Name = "MaxCountPassengers";
            this.MaxCountPassengers.Size = new System.Drawing.Size(117, 13);
            this.MaxCountPassengers.TabIndex = 2;
            this.MaxCountPassengers.Text = "Max count passengers:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 309);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "11";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 332);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(47, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "11";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(257, 309);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(47, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "11";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Location = new System.Drawing.Point(200, 312);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(44, 13);
            this.Weight.TabIndex = 9;
            this.Weight.Text = "Weight:";
            this.Weight.Click += new System.EventHandler(this.Weight_Click);
            // 
            // ColorBody
            // 
            this.ColorBody.AutoSize = true;
            this.ColorBody.Location = new System.Drawing.Point(319, 312);
            this.ColorBody.Name = "ColorBody";
            this.ColorBody.Size = new System.Drawing.Size(34, 13);
            this.ColorBody.TabIndex = 10;
            this.ColorBody.Text = "Color:";
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(568, 345);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(121, 21);
            this.SortButton.TabIndex = 11;
            this.SortButton.Text = "Сортировать корабли";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(568, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 21);
            this.button2.TabIndex = 12;
            this.button2.Text = "Задать лайнер";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "WaterLine:";
            // 
            // WaterLine
            // 
            this.WaterLine.Location = new System.Drawing.Point(257, 333);
            this.WaterLine.Name = "WaterLine";
            this.WaterLine.Size = new System.Drawing.Size(47, 20);
            this.WaterLine.TabIndex = 14;
            this.WaterLine.TextChanged += new System.EventHandler(this.WaterLine_TextChanged);
            // 
            // RoundLine
            // 
            this.RoundLine.AutoSize = true;
            this.RoundLine.Location = new System.Drawing.Point(457, 348);
            this.RoundLine.Name = "RoundLine";
            this.RoundLine.Size = new System.Drawing.Size(87, 17);
            this.RoundLine.TabIndex = 18;
            this.RoundLine.Text = "Круглишок?";
            this.RoundLine.UseVisualStyleBackColor = true;
            this.RoundLine.CheckedChanged += new System.EventHandler(this.RoundLine_CheckedChanged);
            // 
            // BorderLine
            // 
            this.BorderLine.AutoSize = true;
            this.BorderLine.Location = new System.Drawing.Point(457, 302);
            this.BorderLine.Name = "BorderLine";
            this.BorderLine.Size = new System.Drawing.Size(102, 17);
            this.BorderLine.TabIndex = 19;
            this.BorderLine.Text = "Боковая линия";
            this.BorderLine.UseVisualStyleBackColor = true;
            this.BorderLine.CheckedChanged += new System.EventHandler(this.BorderLine_CheckedChanged);
            // 
            // TopLine
            // 
            this.TopLine.AutoSize = true;
            this.TopLine.Location = new System.Drawing.Point(457, 325);
            this.TopLine.Name = "TopLine";
            this.TopLine.Size = new System.Drawing.Size(106, 17);
            this.TopLine.TabIndex = 20;
            this.TopLine.Text = "Окантовка труб";
            this.TopLine.UseVisualStyleBackColor = true;
            this.TopLine.CheckedChanged += new System.EventHandler(this.TopLine_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Dop color:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonSelectColor
            // 
            this.buttonSelectColor.Location = new System.Drawing.Point(385, 309);
            this.buttonSelectColor.Name = "buttonSelectColor";
            this.buttonSelectColor.Size = new System.Drawing.Size(47, 18);
            this.buttonSelectColor.TabIndex = 22;
            this.buttonSelectColor.UseVisualStyleBackColor = true;
            this.buttonSelectColor.Click += new System.EventHandler(this.buttonSelectColor_Click);
            // 
            // buttonDopColor
            // 
            this.buttonDopColor.Location = new System.Drawing.Point(385, 331);
            this.buttonDopColor.Name = "buttonDopColor";
            this.buttonDopColor.Size = new System.Drawing.Size(47, 18);
            this.buttonDopColor.TabIndex = 23;
            this.buttonDopColor.UseVisualStyleBackColor = true;
            this.buttonDopColor.Click += new System.EventHandler(this.buttonDopColor_click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(568, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 21);
            this.button3.TabIndex = 24;
            this.button3.Text = "Задать корабль";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Rest
            // 
            this.Rest.AutoSize = true;
            this.Rest.Location = new System.Drawing.Point(322, 351);
            this.Rest.Name = "Rest";
            this.Rest.Size = new System.Drawing.Size(82, 17);
            this.Rest.TabIndex = 25;
            this.Rest.Text = "Рестораны";
            this.Rest.UseVisualStyleBackColor = true;
            this.Rest.CheckedChanged += new System.EventHandler(this.Rest_CheckedChanged);
            // 
            // Bass
            // 
            this.Bass.AutoSize = true;
            this.Bass.Location = new System.Drawing.Point(224, 352);
            this.Bass.Name = "Bass";
            this.Bass.Size = new System.Drawing.Size(77, 17);
            this.Bass.TabIndex = 26;
            this.Bass.Text = "Бассейны";
            this.Bass.UseVisualStyleBackColor = true;
            this.Bass.CheckedChanged += new System.EventHandler(this.Bass_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 372);
            this.Controls.Add(this.Bass);
            this.Controls.Add(this.Rest);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonDopColor);
            this.Controls.Add(this.buttonSelectColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TopLine);
            this.Controls.Add(this.BorderLine);
            this.Controls.Add(this.RoundLine);
            this.Controls.Add(this.WaterLine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.ColorBody);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MaxCountPassengers);
            this.Controls.Add(this.MaxSpeedL);
            this.Controls.Add(this.LinerPic);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LinerPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LinerPic;
        private System.Windows.Forms.Label MaxSpeedL;
        private System.Windows.Forms.Label MaxCountPassengers;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.Label ColorBody;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WaterLine;
        private System.Windows.Forms.CheckBox RoundLine;
        private System.Windows.Forms.CheckBox BorderLine;
        private System.Windows.Forms.CheckBox TopLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSelectColor;
        private System.Windows.Forms.Button buttonDopColor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox Rest;
        private System.Windows.Forms.CheckBox Bass;
    }
}

