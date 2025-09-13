namespace Ejercicio1
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
            label1 = new Label();
            lsbVer = new ListBox();
            btnProcesar = new Button();
            rbString = new RadioButton();
            rbRegex = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 0;
            label1.Text = "Ver";
            // 
            // lsbVer
            // 
            lsbVer.FormattingEnabled = true;
            lsbVer.ItemHeight = 15;
            lsbVer.Location = new Point(12, 27);
            lsbVer.Name = "lsbVer";
            lsbVer.Size = new Size(427, 229);
            lsbVer.TabIndex = 1;
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(462, 27);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(75, 65);
            btnProcesar.TabIndex = 2;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // rbString
            // 
            rbString.AutoSize = true;
            rbString.Location = new Point(462, 154);
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
            rbRegex.Location = new Point(462, 202);
            rbRegex.Name = "rbRegex";
            rbRegex.Size = new Size(56, 19);
            rbRegex.TabIndex = 4;
            rbRegex.TabStop = true;
            rbRegex.Text = "Regex";
            rbRegex.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 277);
            Controls.Add(rbRegex);
            Controls.Add(rbString);
            Controls.Add(btnProcesar);
            Controls.Add(lsbVer);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lsbVer;
        private Button btnProcesar;
        private RadioButton rbString;
        private RadioButton rbRegex;
    }
}
