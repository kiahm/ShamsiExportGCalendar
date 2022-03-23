namespace CalendarExport
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.btnExport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.mnYear = new System.Windows.Forms.NumericUpDown();
            this.mnMonth = new System.Windows.Forms.NumericUpDown();
            this.mnDay = new System.Windows.Forms.NumericUpDown();
            this.mnRepeat = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mnYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnRepeat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(178, 140);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Repeat (month)";
            // 
            // dtTime
            // 
            this.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTime.Location = new System.Drawing.Point(99, 66);
            this.dtTime.Name = "dtTime";
            this.dtTime.Size = new System.Drawing.Size(154, 20);
            this.dtTime.TabIndex = 9;
            // 
            // mnYear
            // 
            this.mnYear.Location = new System.Drawing.Point(99, 40);
            this.mnYear.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.mnYear.Minimum = new decimal(new int[] {
            1300,
            0,
            0,
            0});
            this.mnYear.Name = "mnYear";
            this.mnYear.Size = new System.Drawing.Size(64, 20);
            this.mnYear.TabIndex = 10;
            this.mnYear.Value = new decimal(new int[] {
            1401,
            0,
            0,
            0});
            // 
            // mnMonth
            // 
            this.mnMonth.Location = new System.Drawing.Point(169, 41);
            this.mnMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.mnMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mnMonth.Name = "mnMonth";
            this.mnMonth.Size = new System.Drawing.Size(39, 20);
            this.mnMonth.TabIndex = 11;
            this.mnMonth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // mnDay
            // 
            this.mnDay.Location = new System.Drawing.Point(214, 41);
            this.mnDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.mnDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mnDay.Name = "mnDay";
            this.mnDay.Size = new System.Drawing.Size(39, 20);
            this.mnDay.TabIndex = 12;
            this.mnDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mnRepeat
            // 
            this.mnRepeat.Location = new System.Drawing.Point(99, 92);
            this.mnRepeat.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.mnRepeat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mnRepeat.Name = "mnRepeat";
            this.mnRepeat.Size = new System.Drawing.Size(154, 20);
            this.mnRepeat.TabIndex = 13;
            this.mnRepeat.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(99, 15);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(154, 20);
            this.txtTitle.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 181);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mnRepeat);
            this.Controls.Add(this.mnDay);
            this.Controls.Add(this.mnMonth);
            this.Controls.Add(this.mnYear);
            this.Controls.Add(this.dtTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExport);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mnYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnRepeat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtTime;
        private System.Windows.Forms.NumericUpDown mnYear;
        private System.Windows.Forms.NumericUpDown mnMonth;
        private System.Windows.Forms.NumericUpDown mnDay;
        private System.Windows.Forms.NumericUpDown mnRepeat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
    }
}

