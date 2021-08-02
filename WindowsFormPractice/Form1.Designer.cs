
namespace WindowsFormPractice
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numero1TextBox = new System.Windows.Forms.TextBox();
            this.numero2TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.somarButton = new System.Windows.Forms.Button();
            this.subtrairButton = new System.Windows.Forms.Button();
            this.multButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 2";
            // 
            // numero1TextBox
            // 
            this.numero1TextBox.Location = new System.Drawing.Point(87, 24);
            this.numero1TextBox.Name = "numero1TextBox";
            this.numero1TextBox.Size = new System.Drawing.Size(100, 20);
            this.numero1TextBox.TabIndex = 2;
            // 
            // numero2TextBox
            // 
            this.numero2TextBox.Location = new System.Drawing.Point(87, 62);
            this.numero2TextBox.Name = "numero2TextBox";
            this.numero2TextBox.Size = new System.Drawing.Size(100, 20);
            this.numero2TextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado";
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.AutoSize = true;
            this.resultadoLabel.Location = new System.Drawing.Point(136, 153);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(13, 13);
            this.resultadoLabel.TabIndex = 5;
            this.resultadoLabel.Text = "0";
            // 
            // somarButton
            // 
            this.somarButton.Location = new System.Drawing.Point(16, 96);
            this.somarButton.Name = "somarButton";
            this.somarButton.Size = new System.Drawing.Size(43, 36);
            this.somarButton.TabIndex = 6;
            this.somarButton.Text = "+";
            this.somarButton.UseVisualStyleBackColor = true;
            this.somarButton.Click += new System.EventHandler(this.somarButton_Click);
            // 
            // subtrairButton
            // 
            this.subtrairButton.Location = new System.Drawing.Point(65, 96);
            this.subtrairButton.Name = "subtrairButton";
            this.subtrairButton.Size = new System.Drawing.Size(44, 36);
            this.subtrairButton.TabIndex = 7;
            this.subtrairButton.Text = "-";
            this.subtrairButton.UseVisualStyleBackColor = true;
            this.subtrairButton.Click += new System.EventHandler(this.subtrairButton_Click);
            // 
            // multButton
            // 
            this.multButton.Location = new System.Drawing.Point(115, 95);
            this.multButton.Name = "multButton";
            this.multButton.Size = new System.Drawing.Size(49, 37);
            this.multButton.TabIndex = 8;
            this.multButton.Text = "x";
            this.multButton.UseVisualStyleBackColor = true;
            this.multButton.Click += new System.EventHandler(this.multButton_Click);
            // 
            // divButton
            // 
            this.divButton.Location = new System.Drawing.Point(170, 95);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(49, 37);
            this.divButton.TabIndex = 9;
            this.divButton.Text = "%";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.divButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 183);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.multButton);
            this.Controls.Add(this.subtrairButton);
            this.Controls.Add(this.somarButton);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numero2TextBox);
            this.Controls.Add(this.numero1TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numero1TextBox;
        private System.Windows.Forms.TextBox numero2TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultadoLabel;
        private System.Windows.Forms.Button somarButton;
        private System.Windows.Forms.Button subtrairButton;
        private System.Windows.Forms.Button multButton;
        private System.Windows.Forms.Button divButton;
    }
}

