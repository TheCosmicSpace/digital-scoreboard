namespace WindowsFormsApp1
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
            this.kField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dField = new System.Windows.Forms.TextBox();
            this.firstPiece = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.hFieldasa = new System.Windows.Forms.Label();
            this.hField = new System.Windows.Forms.TextBox();
            this.wFieldasdas = new System.Windows.Forms.Label();
            this.wField = new System.Windows.Forms.TextBox();
            this.ElPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // kField
            // 
            this.kField.Location = new System.Drawing.Point(48, 57);
            this.kField.Name = "kField";
            this.kField.Size = new System.Drawing.Size(55, 20);
            this.kField.TabIndex = 0;
            this.kField.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите «увеличить в k раз»";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите толщину линии";
            // 
            // dField
            // 
            this.dField.Location = new System.Drawing.Point(211, 57);
            this.dField.Name = "dField";
            this.dField.Size = new System.Drawing.Size(55, 20);
            this.dField.TabIndex = 2;
            this.dField.Text = "1";
            // 
            // firstPiece
            // 
            this.firstPiece.Location = new System.Drawing.Point(48, 111);
            this.firstPiece.Name = "firstPiece";
            this.firstPiece.Size = new System.Drawing.Size(161, 20);
            this.firstPiece.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить отрезок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите отрезок: x1, y1, x2, y2 ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Запустить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hFieldasa
            // 
            this.hFieldasa.AutoSize = true;
            this.hFieldasa.Location = new System.Drawing.Point(455, 41);
            this.hFieldasa.Name = "hFieldasa";
            this.hFieldasa.Size = new System.Drawing.Size(88, 13);
            this.hFieldasa.TabIndex = 13;
            this.hFieldasa.Text = "Введите высоту";
            // 
            // hField
            // 
            this.hField.Location = new System.Drawing.Point(458, 57);
            this.hField.Name = "hField";
            this.hField.Size = new System.Drawing.Size(55, 20);
            this.hField.TabIndex = 12;
            this.hField.Text = "6";
            // 
            // wFieldasdas
            // 
            this.wFieldasdas.AutoSize = true;
            this.wFieldasdas.Location = new System.Drawing.Point(354, 41);
            this.wFieldasdas.Name = "wFieldasdas";
            this.wFieldasdas.Size = new System.Drawing.Size(89, 13);
            this.wFieldasdas.TabIndex = 11;
            this.wFieldasdas.Text = "Введите ширину";
            // 
            // wField
            // 
            this.wField.Location = new System.Drawing.Point(357, 57);
            this.wField.Name = "wField";
            this.wField.Size = new System.Drawing.Size(55, 20);
            this.wField.TabIndex = 10;
            this.wField.Text = "4";
            // 
            // ElPanel
            // 
            this.ElPanel.AutoScroll = true;
            this.ElPanel.Location = new System.Drawing.Point(221, 139);
            this.ElPanel.Name = "ElPanel";
            this.ElPanel.Size = new System.Drawing.Size(508, 358);
            this.ElPanel.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(742, 536);
            this.Controls.Add(this.ElPanel);
            this.Controls.Add(this.hFieldasa);
            this.Controls.Add(this.hField);
            this.Controls.Add(this.wFieldasdas);
            this.Controls.Add(this.wField);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstPiece);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kField);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dField;
        private System.Windows.Forms.TextBox firstPiece;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label hFieldasa;
        private System.Windows.Forms.TextBox hField;
        private System.Windows.Forms.Label wFieldasdas;
        private System.Windows.Forms.TextBox wField;
        private System.Windows.Forms.Panel ElPanel;
    }
}

