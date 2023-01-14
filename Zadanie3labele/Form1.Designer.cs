namespace Zadanie3labele
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.z1btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.z2btn = new System.Windows.Forms.Button();
            this.z3btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // z1btn
            // 
            this.z1btn.Location = new System.Drawing.Point(263, 29);
            this.z1btn.Name = "z1btn";
            this.z1btn.Size = new System.Drawing.Size(75, 23);
            this.z1btn.TabIndex = 0;
            this.z1btn.Text = "kliknij1";
            this.z1btn.UseVisualStyleBackColor = true;
            this.z1btn.Click += new System.EventHandler(this.z1btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // z2btn
            // 
            this.z2btn.Location = new System.Drawing.Point(263, 70);
            this.z2btn.Name = "z2btn";
            this.z2btn.Size = new System.Drawing.Size(75, 23);
            this.z2btn.TabIndex = 3;
            this.z2btn.Text = "kliknij2";
            this.z2btn.UseVisualStyleBackColor = true;
            this.z2btn.Click += new System.EventHandler(this.z2btn_Click);
            // 
            // z3btn
            // 
            this.z3btn.Location = new System.Drawing.Point(263, 113);
            this.z3btn.Name = "z3btn";
            this.z3btn.Size = new System.Drawing.Size(75, 23);
            this.z3btn.TabIndex = 4;
            this.z3btn.Text = "kliknij3";
            this.z3btn.UseVisualStyleBackColor = true;
            this.z3btn.Click += new System.EventHandler(this.z3btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.z3btn);
            this.Controls.Add(this.z2btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.z1btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button z1btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button z2btn;
        private System.Windows.Forms.Button z3btn;
    }
}

