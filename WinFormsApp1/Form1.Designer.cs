namespace WinFormsApp1
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
            btn_Pedra = new Button();
            btn_Papel = new Button();
            btn_Tesoura = new Button();
            label1 = new Label();
            placar_usuario = new TextBox();
            txt_maquina = new TextBox();
            txt_resultado = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_Resultado = new Label();
            label5 = new Label();
            btn_usuario = new Label();
            placar_maquina = new TextBox();
            label6 = new Label();
            txt_usuario = new TextBox();
            SuspendLayout();
            // 
            // btn_Pedra
            // 
            btn_Pedra.Location = new Point(111, 137);
            btn_Pedra.Name = "btn_Pedra";
            btn_Pedra.Size = new Size(112, 34);
            btn_Pedra.TabIndex = 0;
            btn_Pedra.Text = "Pedra";
            btn_Pedra.UseVisualStyleBackColor = true;
            btn_Pedra.Click += button1_Click;
            // 
            // btn_Papel
            // 
            btn_Papel.Location = new Point(226, 137);
            btn_Papel.Name = "btn_Papel";
            btn_Papel.Size = new Size(112, 34);
            btn_Papel.TabIndex = 1;
            btn_Papel.Text = "Papel";
            btn_Papel.UseVisualStyleBackColor = true;
            btn_Papel.Click += button2_Click;
            // 
            // btn_Tesoura
            // 
            btn_Tesoura.Location = new Point(344, 137);
            btn_Tesoura.Name = "btn_Tesoura";
            btn_Tesoura.Size = new Size(112, 34);
            btn_Tesoura.TabIndex = 2;
            btn_Tesoura.Text = "Tesoura";
            btn_Tesoura.UseVisualStyleBackColor = true;
            btn_Tesoura.Click += btn_TESOURA_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 97);
            label1.Name = "label1";
            label1.Size = new Size(211, 25);
            label1.TabIndex = 3;
            label1.Text = "Escolha uma das opções:";
            label1.Click += label1_Click;
            // 
            // placar_usuario
            // 
            placar_usuario.Enabled = false;
            placar_usuario.Location = new Point(144, 63);
            placar_usuario.Name = "placar_usuario";
            placar_usuario.Size = new Size(42, 31);
            placar_usuario.TabIndex = 4;
            placar_usuario.Text = "0";
            placar_usuario.TextChanged += textBox1_TextChanged;
            // 
            // txt_maquina
            // 
            txt_maquina.Enabled = false;
            txt_maquina.Location = new Point(344, 209);
            txt_maquina.Name = "txt_maquina";
            txt_maquina.Size = new Size(150, 31);
            txt_maquina.TabIndex = 5;
            // 
            // txt_resultado
            // 
            txt_resultado.Location = new Point(344, 303);
            txt_resultado.Name = "txt_resultado";
            txt_resultado.Size = new Size(150, 31);
            txt_resultado.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 209);
            label2.Name = "label2";
            label2.Size = new Size(170, 25);
            label2.TabIndex = 7;
            label2.Text = "Escolha da Máquina";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 278);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 9);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 9;
            label4.Text = "PLACAR";
            // 
            // btn_Resultado
            // 
            btn_Resultado.AutoSize = true;
            btn_Resultado.Location = new Point(159, 303);
            btn_Resultado.Name = "btn_Resultado";
            btn_Resultado.Size = new Size(90, 25);
            btn_Resultado.TabIndex = 10;
            btn_Resultado.Text = "Resultado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(373, 24);
            label5.Name = "label5";
            label5.Size = new Size(114, 25);
            label5.TabIndex = 11;
            label5.Text = "Computador";
            // 
            // btn_usuario
            // 
            btn_usuario.AutoSize = true;
            btn_usuario.Location = new Point(144, 24);
            btn_usuario.Name = "btn_usuario";
            btn_usuario.Size = new Size(72, 25);
            btn_usuario.TabIndex = 12;
            btn_usuario.Text = "Usuário";
            // 
            // placar_maquina
            // 
            placar_maquina.Enabled = false;
            placar_maquina.Location = new Point(373, 63);
            placar_maquina.Name = "placar_maquina";
            placar_maquina.Size = new Size(38, 31);
            placar_maquina.TabIndex = 13;
            placar_maquina.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(144, 253);
            label6.Name = "label6";
            label6.Size = new Size(163, 25);
            label6.TabIndex = 15;
            label6.Text = "Escolha do Usuário";
            // 
            // txt_usuario
            // 
            txt_usuario.Enabled = false;
            txt_usuario.Location = new Point(344, 257);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(150, 31);
            txt_usuario.TabIndex = 14;
            txt_usuario.TextChanged += textBox5_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(txt_usuario);
            Controls.Add(placar_maquina);
            Controls.Add(btn_usuario);
            Controls.Add(label5);
            Controls.Add(btn_Resultado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_resultado);
            Controls.Add(txt_maquina);
            Controls.Add(placar_usuario);
            Controls.Add(label1);
            Controls.Add(btn_Tesoura);
            Controls.Add(btn_Papel);
            Controls.Add(btn_Pedra);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Pedra;
        private Button btn_Papel;
        private Button btn_Tesoura;
        private Label label1;
        private TextBox placar_usuario;
        private TextBox txt_maquina;
        private TextBox txt_resultado;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label btn_Resultado;
        private Label label5;
        private Label btn_usuario;
        private TextBox placar_maquina;
        private Label label6;
        private TextBox txt_usuario;
    }
}