namespace Picoletes.Interface
{
    partial class InterfacePrincipal
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SFloc = new System.Windows.Forms.NumericUpDown();
            this.SMor = new System.Windows.Forms.NumericUpDown();
            this.SChoc = new System.Windows.Forms.NumericUpDown();
            this.PChoc = new System.Windows.Forms.NumericUpDown();
            this.PMor = new System.Windows.Forms.NumericUpDown();
            this.PLim = new System.Windows.Forms.NumericUpDown();
            this.AFrut = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.SFloc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SChoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PChoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AFrut)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Retirada";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ExecutarRetiradaClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Gerar Retirada";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GerarRetiradaClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sorvete Flocos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sorvete Morango";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sorvete Chocolate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(667, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Picole Choc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(759, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Picole Mor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(845, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Picole Limao";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(945, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Acai c Frutas";
            // 
            // SFloc
            // 
            this.SFloc.Location = new System.Drawing.Point(314, 104);
            this.SFloc.Name = "SFloc";
            this.SFloc.Size = new System.Drawing.Size(52, 27);
            this.SFloc.TabIndex = 3;
            this.SFloc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SMor
            // 
            this.SMor.Location = new System.Drawing.Point(436, 107);
            this.SMor.Name = "SMor";
            this.SMor.Size = new System.Drawing.Size(59, 27);
            this.SMor.TabIndex = 3;
            this.SMor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SChoc
            // 
            this.SChoc.Location = new System.Drawing.Point(545, 107);
            this.SChoc.Name = "SChoc";
            this.SChoc.Size = new System.Drawing.Size(57, 27);
            this.SChoc.TabIndex = 3;
            this.SChoc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PChoc
            // 
            this.PChoc.Location = new System.Drawing.Point(667, 107);
            this.PChoc.Name = "PChoc";
            this.PChoc.Size = new System.Drawing.Size(86, 27);
            this.PChoc.TabIndex = 3;
            this.PChoc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PMor
            // 
            this.PMor.Location = new System.Drawing.Point(780, 107);
            this.PMor.Name = "PMor";
            this.PMor.Size = new System.Drawing.Size(59, 27);
            this.PMor.TabIndex = 3;
            this.PMor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PLim
            // 
            this.PLim.Location = new System.Drawing.Point(868, 107);
            this.PLim.Name = "PLim";
            this.PLim.Size = new System.Drawing.Size(59, 27);
            this.PLim.TabIndex = 3;
            this.PLim.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AFrut
            // 
            this.AFrut.Location = new System.Drawing.Point(959, 107);
            this.AFrut.Name = "AFrut";
            this.AFrut.Size = new System.Drawing.Size(59, 27);
            this.AFrut.TabIndex = 3;
            this.AFrut.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // InterfacePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 656);
            this.Controls.Add(this.AFrut);
            this.Controls.Add(this.PLim);
            this.Controls.Add(this.PMor);
            this.Controls.Add(this.PChoc);
            this.Controls.Add(this.SChoc);
            this.Controls.Add(this.SMor);
            this.Controls.Add(this.SFloc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "InterfacePrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SFloc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SChoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PChoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AFrut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown SFloc;
        private System.Windows.Forms.NumericUpDown SMor;
        private System.Windows.Forms.NumericUpDown SChoc;
        private System.Windows.Forms.NumericUpDown PChoc;
        private System.Windows.Forms.NumericUpDown PMor;
        private System.Windows.Forms.NumericUpDown PLim;
        private System.Windows.Forms.NumericUpDown AFrut;
    }
}

