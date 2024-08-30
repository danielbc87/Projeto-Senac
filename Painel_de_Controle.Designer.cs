namespace Projeto_Senac
{
    partial class Painel_de_Controle
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
            label5 = new Label();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(57, 51);
            label5.Name = "label5";
            label5.Size = new Size(358, 31);
            label5.TabIndex = 44;
            label5.Text = "PROGRAMAÇÃO ORIENTADA A OBJETOS";
            label5.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(47, 9);
            label4.Name = "label4";
            label4.Size = new Size(385, 42);
            label4.TabIndex = 43;
            label4.Text = "PROJETO INTEGRADOR SENAC";
            label4.UseCompatibleTextRendering = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(57, 96);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(34, 15);
            linkLabel1.TabIndex = 45;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Perfil";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(73, 141);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(39, 15);
            linkLabel2.TabIndex = 46;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Aluno";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(73, 173);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(56, 15);
            linkLabel3.TabIndex = 46;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Professor";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Location = new Point(73, 208);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(56, 15);
            linkLabel4.TabIndex = 47;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Professor";
            // 
            // Painel_de_Controle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 452);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Name = "Painel_de_Controle";
            Text = "Painel_de_Controle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel4;
    }
}