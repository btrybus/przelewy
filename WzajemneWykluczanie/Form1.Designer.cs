namespace WzajemneWykluczanie
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
            this.components = new System.ComponentModel.Container();
            this.bStart = new System.Windows.Forms.Button();
            this.numIleWatkow = new System.Windows.Forms.NumericUpDown();
            this.txtWyniki = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtStan = new System.Windows.Forms.TextBox();
            this.txtPracuje = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numIleWatkow)).BeginInit();
            this.SuspendLayout();
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(138, 12);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(121, 23);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Rób przelewy";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // numIleWatkow
            // 
            this.numIleWatkow.Location = new System.Drawing.Point(23, 12);
            this.numIleWatkow.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numIleWatkow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIleWatkow.Name = "numIleWatkow";
            this.numIleWatkow.Size = new System.Drawing.Size(95, 20);
            this.numIleWatkow.TabIndex = 1;
            this.numIleWatkow.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // txtWyniki
            // 
            this.txtWyniki.Location = new System.Drawing.Point(23, 88);
            this.txtWyniki.Multiline = true;
            this.txtWyniki.Name = "txtWyniki";
            this.txtWyniki.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWyniki.Size = new System.Drawing.Size(236, 161);
            this.txtWyniki.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stan:";
            // 
            // txtStan
            // 
            this.txtStan.Location = new System.Drawing.Point(58, 50);
            this.txtStan.Name = "txtStan";
            this.txtStan.ReadOnly = true;
            this.txtStan.Size = new System.Drawing.Size(60, 20);
            this.txtStan.TabIndex = 6;
            // 
            // txtPracuje
            // 
            this.txtPracuje.Location = new System.Drawing.Point(148, 52);
            this.txtPracuje.Name = "txtPracuje";
            this.txtPracuje.ReadOnly = true;
            this.txtPracuje.Size = new System.Drawing.Size(100, 20);
            this.txtPracuje.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtPracuje);
            this.Controls.Add(this.txtStan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWyniki);
            this.Controls.Add(this.numIleWatkow);
            this.Controls.Add(this.bStart);
            this.Name = "Form1";
            this.Text = "Konto";
            ((System.ComponentModel.ISupportInitialize)(this.numIleWatkow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.NumericUpDown numIleWatkow;
        private System.Windows.Forms.TextBox txtWyniki;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStan;
        private System.Windows.Forms.TextBox txtPracuje;
    }
}

