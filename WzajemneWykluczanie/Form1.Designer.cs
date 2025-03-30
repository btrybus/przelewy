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
            this.txtIleDziala = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numIleWatkow)).BeginInit();
            this.SuspendLayout();
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(184, 15);
            this.bStart.Margin = new System.Windows.Forms.Padding(4);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(161, 28);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Rób wypłaty";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // numIleWatkow
            // 
            this.numIleWatkow.Location = new System.Drawing.Point(31, 15);
            this.numIleWatkow.Margin = new System.Windows.Forms.Padding(4);
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
            this.numIleWatkow.Size = new System.Drawing.Size(127, 22);
            this.numIleWatkow.TabIndex = 1;
            this.numIleWatkow.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // txtWyniki
            // 
            this.txtWyniki.Location = new System.Drawing.Point(32, 111);
            this.txtWyniki.Margin = new System.Windows.Forms.Padding(4);
            this.txtWyniki.Multiline = true;
            this.txtWyniki.Name = "txtWyniki";
            this.txtWyniki.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWyniki.Size = new System.Drawing.Size(313, 197);
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
            this.label2.Location = new System.Drawing.Point(28, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stan:";
            // 
            // txtStan
            // 
            this.txtStan.Location = new System.Drawing.Point(77, 62);
            this.txtStan.Margin = new System.Windows.Forms.Padding(4);
            this.txtStan.Name = "txtStan";
            this.txtStan.ReadOnly = true;
            this.txtStan.Size = new System.Drawing.Size(79, 22);
            this.txtStan.TabIndex = 6;
            // 
            // txtIleDziala
            // 
            this.txtIleDziala.Location = new System.Drawing.Point(250, 64);
            this.txtIleDziala.Margin = new System.Windows.Forms.Padding(4);
            this.txtIleDziala.Name = "txtIleDziala";
            this.txtIleDziala.ReadOnly = true;
            this.txtIleDziala.Size = new System.Drawing.Size(94, 22);
            this.txtIleDziala.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pracuje:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIleDziala);
            this.Controls.Add(this.txtStan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWyniki);
            this.Controls.Add(this.numIleWatkow);
            this.Controls.Add(this.bStart);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox txtIleDziala;
        private System.Windows.Forms.Label label1;
    }
}

