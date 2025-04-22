namespace NumerosPrimos
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtnumprim = new RichTextBox();
            lbl_inf = new Label();
            lbl_sup = new Label();
            txtlimsup = new TextBox();
            txtliminf = new TextBox();
            btnMost = new Button();
            btnclear = new Button();
            SuspendLayout();
            // 
            // txtnumprim
            // 
            txtnumprim.Location = new Point(12, 12);
            txtnumprim.Name = "txtnumprim";
            txtnumprim.Size = new Size(253, 325);
            txtnumprim.TabIndex = 0;
            txtnumprim.Text = "";
            // 
            // lbl_inf
            // 
            lbl_inf.AutoSize = true;
            lbl_inf.Location = new Point(271, 36);
            lbl_inf.Name = "lbl_inf";
            lbl_inf.Size = new Size(84, 15);
            lbl_inf.TabIndex = 1;
            lbl_inf.Text = "Limite inferior:";
            // 
            // lbl_sup
            // 
            lbl_sup.AutoSize = true;
            lbl_sup.Location = new Point(271, 78);
            lbl_sup.Name = "lbl_sup";
            lbl_sup.Size = new Size(89, 15);
            lbl_sup.TabIndex = 2;
            lbl_sup.Text = "Limite superior:";
            // 
            // txtlimsup
            // 
            txtlimsup.Location = new Point(366, 75);
            txtlimsup.Name = "txtlimsup";
            txtlimsup.Size = new Size(56, 23);
            txtlimsup.TabIndex = 3;
            // 
            // txtliminf
            // 
            txtliminf.Location = new Point(366, 33);
            txtliminf.Name = "txtliminf";
            txtliminf.Size = new Size(56, 23);
            txtliminf.TabIndex = 4;
            // 
            // btnMost
            // 
            btnMost.Location = new Point(347, 314);
            btnMost.Name = "btnMost";
            btnMost.Size = new Size(75, 23);
            btnMost.TabIndex = 6;
            btnMost.Text = "Mostrar";
            btnMost.UseVisualStyleBackColor = true;
            btnMost.Click += btnMost_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(266, 314);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(75, 23);
            btnclear.TabIndex = 7;
            btnclear.Text = "Limpiar";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 345);
            Controls.Add(btnclear);
            Controls.Add(btnMost);
            Controls.Add(txtliminf);
            Controls.Add(txtlimsup);
            Controls.Add(lbl_sup);
            Controls.Add(lbl_inf);
            Controls.Add(txtnumprim);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtnumprim;
        private Label lbl_inf;
        private Label lbl_sup;
        private TextBox txtlimsup;
        private TextBox txtliminf;
        private Button btnMost;
        private Button btnclear;
    }
}
