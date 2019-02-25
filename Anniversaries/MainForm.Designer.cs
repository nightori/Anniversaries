namespace Anniversaries
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.intervalNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCompute = new System.Windows.Forms.Button();
            this.outputTB = new System.Windows.Forms.TextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker.Location = new System.Drawing.Point(15, 25);
            this.dateTimePicker.MaxDate = new System.DateTime(9000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата рождения";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // intervalNUD
            // 
            this.intervalNUD.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.intervalNUD.Location = new System.Drawing.Point(141, 25);
            this.intervalNUD.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.intervalNUD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.intervalNUD.Name = "intervalNUD";
            this.intervalNUD.Size = new System.Drawing.Size(94, 20);
            this.intervalNUD.TabIndex = 2;
            this.intervalNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.intervalNUD.ThousandsSeparator = true;
            this.intervalNUD.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(141, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Интервал (дни)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCompute
            // 
            this.buttonCompute.Location = new System.Drawing.Point(15, 51);
            this.buttonCompute.Name = "buttonCompute";
            this.buttonCompute.Size = new System.Drawing.Size(220, 23);
            this.buttonCompute.TabIndex = 4;
            this.buttonCompute.Text = "Рассчитать";
            this.buttonCompute.UseVisualStyleBackColor = true;
            this.buttonCompute.Click += new System.EventHandler(this.buttonCompute_Click);
            // 
            // outputTB
            // 
            this.outputTB.BackColor = System.Drawing.SystemColors.Window;
            this.outputTB.Font = new System.Drawing.Font("Consolas", 9F);
            this.outputTB.Location = new System.Drawing.Point(15, 80);
            this.outputTB.Multiline = true;
            this.outputTB.Name = "outputTB";
            this.outputTB.ReadOnly = true;
            this.outputTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTB.Size = new System.Drawing.Size(220, 169);
            this.outputTB.TabIndex = 5;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(15, 255);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(220, 23);
            this.buttonCopy.TabIndex = 6;
            this.buttonCopy.Text = "Скопировать в буфер обмена";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 286);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.outputTB);
            this.Controls.Add(this.buttonCompute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.intervalNUD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Anniversaries";
            ((System.ComponentModel.ISupportInitialize)(this.intervalNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown intervalNUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCompute;
        private System.Windows.Forms.TextBox outputTB;
        private System.Windows.Forms.Button buttonCopy;
    }
}

