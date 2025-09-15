namespace Ejercicio2
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
            tbTexto = new TextBox();
            lsbResultado = new ListBox();
            label1 = new Label();
            rbString = new RadioButton();
            rbRegex = new RadioButton();
            btnProcesar = new Button();
            SuspendLayout();
            // 
            // tbTexto
            // 
            tbTexto.Location = new Point(12, 12);
            tbTexto.Multiline = true;
            tbTexto.Name = "tbTexto";
            tbTexto.Size = new Size(593, 214);
            tbTexto.TabIndex = 0;
            // 
            // lsbResultado
            // 
            lsbResultado.FormattingEnabled = true;
            lsbResultado.ItemHeight = 15;
            lsbResultado.Location = new Point(12, 263);
            lsbResultado.Name = "lsbResultado";
            lsbResultado.Size = new Size(593, 169);
            lsbResultado.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 245);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 2;
            label1.Text = "Ver";
            // 
            // rbString
            // 
            rbString.AutoSize = true;
            rbString.Location = new Point(634, 171);
            rbString.Name = "rbString";
            rbString.Size = new Size(56, 19);
            rbString.TabIndex = 3;
            rbString.TabStop = true;
            rbString.Text = "String";
            rbString.UseVisualStyleBackColor = true;
            // 
            // rbRegex
            // 
            rbRegex.AutoSize = true;
            rbRegex.Location = new Point(634, 207);
            rbRegex.Name = "rbRegex";
            rbRegex.Size = new Size(56, 19);
            rbRegex.TabIndex = 4;
            rbRegex.TabStop = true;
            rbRegex.Text = "Regex";
            rbRegex.UseVisualStyleBackColor = true;
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(634, 87);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(94, 62);
            btnProcesar.TabIndex = 5;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 450);
            Controls.Add(btnProcesar);
            Controls.Add(rbRegex);
            Controls.Add(rbString);
            Controls.Add(label1);
            Controls.Add(lsbResultado);
            Controls.Add(tbTexto);
            Name = "Form1";
            Text = "Ejercicio2";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTexto;
        private ListBox lsbResultado;
        private Label label1;
        private RadioButton rbString;
        private RadioButton rbRegex;
        private Button btnProcesar;
    }
}
