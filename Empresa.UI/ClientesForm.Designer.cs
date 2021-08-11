
namespace Empresa.UI
{
    partial class ClientesForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.novoButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.confirmarNovoButton = new System.Windows.Forms.Button();
            this.confirmarAlterarButton = new System.Windows.Forms.Button();
            this.confirmarExcluirButton = new System.Windows.Forms.Button();
            this.conteudoPainel = new System.Windows.Forms.Panel();
            this.listadataGridView = new System.Windows.Forms.DataGridView();
            this.fichaPainel = new System.Windows.Forms.Panel();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.voltarButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.conteudoPainel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadataGridView)).BeginInit();
            this.fichaPainel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 50);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.novoButton);
            this.flowLayoutPanel1.Controls.Add(this.alterarButton);
            this.flowLayoutPanel1.Controls.Add(this.excluirButton);
            this.flowLayoutPanel1.Controls.Add(this.sairButton);
            this.flowLayoutPanel1.Controls.Add(this.confirmarNovoButton);
            this.flowLayoutPanel1.Controls.Add(this.confirmarAlterarButton);
            this.flowLayoutPanel1.Controls.Add(this.confirmarExcluirButton);
            this.flowLayoutPanel1.Controls.Add(this.voltarButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3, 8, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(704, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // novoButton
            // 
            this.novoButton.Location = new System.Drawing.Point(6, 11);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(75, 23);
            this.novoButton.TabIndex = 0;
            this.novoButton.Text = "Novo...";
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // alterarButton
            // 
            this.alterarButton.Location = new System.Drawing.Point(87, 11);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(75, 23);
            this.alterarButton.TabIndex = 1;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = true;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(168, 11);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(75, 23);
            this.excluirButton.TabIndex = 2;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(249, 11);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 23);
            this.sairButton.TabIndex = 3;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // confirmarNovoButton
            // 
            this.confirmarNovoButton.Location = new System.Drawing.Point(330, 11);
            this.confirmarNovoButton.Name = "confirmarNovoButton";
            this.confirmarNovoButton.Size = new System.Drawing.Size(72, 23);
            this.confirmarNovoButton.TabIndex = 4;
            this.confirmarNovoButton.Text = "Gravar";
            this.confirmarNovoButton.UseVisualStyleBackColor = true;
            this.confirmarNovoButton.Click += new System.EventHandler(this.confirmarNovoButton_Click);
            // 
            // confirmarAlterarButton
            // 
            this.confirmarAlterarButton.Location = new System.Drawing.Point(408, 11);
            this.confirmarAlterarButton.Name = "confirmarAlterarButton";
            this.confirmarAlterarButton.Size = new System.Drawing.Size(108, 23);
            this.confirmarAlterarButton.TabIndex = 5;
            this.confirmarAlterarButton.Text = "Confirma Alteração";
            this.confirmarAlterarButton.UseVisualStyleBackColor = true;
            this.confirmarAlterarButton.Click += new System.EventHandler(this.confirmarAlterarButton_Click);
            // 
            // confirmarExcluirButton
            // 
            this.confirmarExcluirButton.Location = new System.Drawing.Point(522, 11);
            this.confirmarExcluirButton.Name = "confirmarExcluirButton";
            this.confirmarExcluirButton.Size = new System.Drawing.Size(96, 23);
            this.confirmarExcluirButton.TabIndex = 6;
            this.confirmarExcluirButton.Text = "Confirma Excluir";
            this.confirmarExcluirButton.UseVisualStyleBackColor = true;
            this.confirmarExcluirButton.Click += new System.EventHandler(this.confirmarExcluirButton_Click);
            // 
            // conteudoPainel
            // 
            this.conteudoPainel.Controls.Add(this.fichaPainel);
            this.conteudoPainel.Controls.Add(this.listadataGridView);
            this.conteudoPainel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conteudoPainel.Location = new System.Drawing.Point(0, 0);
            this.conteudoPainel.Name = "conteudoPainel";
            this.conteudoPainel.Padding = new System.Windows.Forms.Padding(10);
            this.conteudoPainel.Size = new System.Drawing.Size(704, 255);
            this.conteudoPainel.TabIndex = 1;
            // 
            // listadataGridView
            // 
            this.listadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadataGridView.Location = new System.Drawing.Point(342, 13);
            this.listadataGridView.Name = "listadataGridView";
            this.listadataGridView.Size = new System.Drawing.Size(269, 214);
            this.listadataGridView.TabIndex = 0;
            // 
            // fichaPainel
            // 
            this.fichaPainel.Controls.Add(this.telefoneTextBox);
            this.fichaPainel.Controls.Add(this.emailTextBox);
            this.fichaPainel.Controls.Add(this.nomeTextBox);
            this.fichaPainel.Controls.Add(this.idTextBox);
            this.fichaPainel.Controls.Add(this.label4);
            this.fichaPainel.Controls.Add(this.label3);
            this.fichaPainel.Controls.Add(this.label2);
            this.fichaPainel.Controls.Add(this.label1);
            this.fichaPainel.Location = new System.Drawing.Point(13, 13);
            this.fichaPainel.Name = "fichaPainel";
            this.fichaPainel.Size = new System.Drawing.Size(314, 214);
            this.fichaPainel.TabIndex = 1;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(84, 108);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefoneTextBox.TabIndex = 15;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(84, 76);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 14;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(84, 45);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 13;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(84, 16);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "E-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID:";
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(624, 11);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(75, 23);
            this.voltarButton.TabIndex = 7;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 305);
            this.Controls.Add(this.conteudoPainel);
            this.Controls.Add(this.panel1);
            this.Name = "ClientesForm";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.ClientesForm_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.conteudoPainel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listadataGridView)).EndInit();
            this.fichaPainel.ResumeLayout(false);
            this.fichaPainel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button confirmarNovoButton;
        private System.Windows.Forms.Button confirmarAlterarButton;
        private System.Windows.Forms.Button confirmarExcluirButton;
        private System.Windows.Forms.Panel conteudoPainel;
        private System.Windows.Forms.Panel fichaPainel;
        private System.Windows.Forms.DataGridView listadataGridView;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button voltarButton;
    }
}