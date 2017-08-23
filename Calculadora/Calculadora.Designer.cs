namespace Calculadora
{
    partial class Calculadora
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
            this.txt_visor = new System.Windows.Forms.TextBox();
            this.btn_raiz = new System.Windows.Forms.Button();
            this.btn_mc = new System.Windows.Forms.Button();
            this.btn_log = new System.Windows.Forms.Button();
            this.btn_mr = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_multiplica = new System.Windows.Forms.Button();
            this.btn_diminui = new System.Windows.Forms.Button();
            this.btn_soma = new System.Windows.Forms.Button();
            this.btn_igual = new System.Windows.Forms.Button();
            this.btn_virgula = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_ce = new System.Windows.Forms.Button();
            this.btn_fatorial = new System.Windows.Forms.Button();
            this.btn_exp2 = new System.Windows.Forms.Button();
            this.btn_pot = new System.Windows.Forms.Button();
            this.btn_sen = new System.Windows.Forms.Button();
            this.btn_cos = new System.Windows.Forms.Button();
            this.btn_tan = new System.Windows.Forms.Button();
            this.btn_mmais = new System.Windows.Forms.Button();
            this.btn_mmenos = new System.Windows.Forms.Button();
            this.lbl_desenvolvedor = new System.Windows.Forms.Label();
            this.lbl_operacao = new System.Windows.Forms.Label();
            this.tp_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_memoria = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_visor
            // 
            this.txt_visor.Enabled = false;
            this.txt_visor.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_visor.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_visor.Location = new System.Drawing.Point(12, 12);
            this.txt_visor.Name = "txt_visor";
            this.txt_visor.Size = new System.Drawing.Size(274, 43);
            this.txt_visor.TabIndex = 0;
            this.txt_visor.TabStop = false;
            this.txt_visor.Text = "0";
            this.txt_visor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_raiz
            // 
            this.btn_raiz.Location = new System.Drawing.Point(68, 188);
            this.btn_raiz.Name = "btn_raiz";
            this.btn_raiz.Size = new System.Drawing.Size(50, 50);
            this.btn_raiz.TabIndex = 1;
            this.btn_raiz.TabStop = false;
            this.btn_raiz.Text = "raiz";
            this.tp_toolTip.SetToolTip(this.btn_raiz, "Raiz quadrada");
            this.btn_raiz.UseVisualStyleBackColor = true;
            this.btn_raiz.Click += new System.EventHandler(this.btn_raiz_Click);
            // 
            // btn_mc
            // 
            this.btn_mc.Location = new System.Drawing.Point(12, 76);
            this.btn_mc.Name = "btn_mc";
            this.btn_mc.Size = new System.Drawing.Size(50, 50);
            this.btn_mc.TabIndex = 1;
            this.btn_mc.TabStop = false;
            this.btn_mc.Text = "MC";
            this.tp_toolTip.SetToolTip(this.btn_mc, "Limpar memória");
            this.btn_mc.UseVisualStyleBackColor = true;
            this.btn_mc.Click += new System.EventHandler(this.btn_mc_Click);
            // 
            // btn_log
            // 
            this.btn_log.Location = new System.Drawing.Point(180, 188);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(50, 50);
            this.btn_log.TabIndex = 1;
            this.btn_log.TabStop = false;
            this.btn_log.Text = "log";
            this.tp_toolTip.SetToolTip(this.btn_log, "Logarítmo");
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // btn_mr
            // 
            this.btn_mr.Location = new System.Drawing.Point(68, 76);
            this.btn_mr.Name = "btn_mr";
            this.btn_mr.Size = new System.Drawing.Size(50, 50);
            this.btn_mr.TabIndex = 1;
            this.btn_mr.TabStop = false;
            this.btn_mr.Text = "MR";
            this.tp_toolTip.SetToolTip(this.btn_mr, "Rechamar memória");
            this.btn_mr.UseVisualStyleBackColor = true;
            this.btn_mr.Click += new System.EventHandler(this.btn_mr_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Location = new System.Drawing.Point(236, 188);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(50, 50);
            this.btn_divide.TabIndex = 1;
            this.btn_divide.TabStop = false;
            this.btn_divide.Text = "/";
            this.tp_toolTip.SetToolTip(this.btn_divide, "Divisão");
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // btn_multiplica
            // 
            this.btn_multiplica.Location = new System.Drawing.Point(236, 244);
            this.btn_multiplica.Name = "btn_multiplica";
            this.btn_multiplica.Size = new System.Drawing.Size(50, 50);
            this.btn_multiplica.TabIndex = 1;
            this.btn_multiplica.TabStop = false;
            this.btn_multiplica.Text = "*";
            this.tp_toolTip.SetToolTip(this.btn_multiplica, "Multiplicação");
            this.btn_multiplica.UseVisualStyleBackColor = true;
            this.btn_multiplica.Click += new System.EventHandler(this.btn_multiplica_Click);
            // 
            // btn_diminui
            // 
            this.btn_diminui.Location = new System.Drawing.Point(236, 300);
            this.btn_diminui.Name = "btn_diminui";
            this.btn_diminui.Size = new System.Drawing.Size(50, 50);
            this.btn_diminui.TabIndex = 1;
            this.btn_diminui.TabStop = false;
            this.btn_diminui.Text = "-";
            this.tp_toolTip.SetToolTip(this.btn_diminui, "Subtração");
            this.btn_diminui.UseVisualStyleBackColor = true;
            this.btn_diminui.Click += new System.EventHandler(this.btn_diminui_Click);
            // 
            // btn_soma
            // 
            this.btn_soma.Location = new System.Drawing.Point(236, 356);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(50, 106);
            this.btn_soma.TabIndex = 1;
            this.btn_soma.TabStop = false;
            this.btn_soma.Text = "+";
            this.tp_toolTip.SetToolTip(this.btn_soma, "Soma");
            this.btn_soma.UseVisualStyleBackColor = true;
            this.btn_soma.Click += new System.EventHandler(this.btn_soma_Click);
            // 
            // btn_igual
            // 
            this.btn_igual.Location = new System.Drawing.Point(12, 412);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(50, 50);
            this.btn_igual.TabIndex = 0;
            this.btn_igual.Text = "=";
            this.btn_igual.UseVisualStyleBackColor = true;
            this.btn_igual.Click += new System.EventHandler(this.btn_igual_Click);
            // 
            // btn_virgula
            // 
            this.btn_virgula.Location = new System.Drawing.Point(180, 412);
            this.btn_virgula.Name = "btn_virgula";
            this.btn_virgula.Size = new System.Drawing.Size(50, 50);
            this.btn_virgula.TabIndex = 2;
            this.btn_virgula.TabStop = false;
            this.btn_virgula.Text = ",";
            this.btn_virgula.UseVisualStyleBackColor = true;
            this.btn_virgula.Click += new System.EventHandler(this.btn_virgula_Click);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_0.Location = new System.Drawing.Point(68, 412);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(106, 50);
            this.btn_0.TabIndex = 1;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_3.Location = new System.Drawing.Point(180, 356);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(50, 50);
            this.btn_3.TabIndex = 4;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_2.Location = new System.Drawing.Point(124, 356);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(50, 50);
            this.btn_2.TabIndex = 3;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_1.Location = new System.Drawing.Point(68, 356);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(50, 50);
            this.btn_1.TabIndex = 2;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_6.Location = new System.Drawing.Point(180, 300);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(50, 50);
            this.btn_6.TabIndex = 7;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_5.Location = new System.Drawing.Point(124, 300);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(50, 50);
            this.btn_5.TabIndex = 6;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_4.Location = new System.Drawing.Point(68, 300);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(50, 50);
            this.btn_4.TabIndex = 5;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_9.Location = new System.Drawing.Point(180, 244);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(50, 50);
            this.btn_9.TabIndex = 10;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_8.Location = new System.Drawing.Point(124, 244);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(50, 50);
            this.btn_8.TabIndex = 9;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_7.Location = new System.Drawing.Point(68, 244);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(50, 50);
            this.btn_7.TabIndex = 8;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_c
            // 
            this.btn_c.Location = new System.Drawing.Point(12, 300);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(50, 106);
            this.btn_c.TabIndex = 0;
            this.btn_c.TabStop = false;
            this.btn_c.Text = "C";
            this.tp_toolTip.SetToolTip(this.btn_c, "Limpar");
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // btn_ce
            // 
            this.btn_ce.Location = new System.Drawing.Point(12, 188);
            this.btn_ce.Name = "btn_ce";
            this.btn_ce.Size = new System.Drawing.Size(50, 106);
            this.btn_ce.TabIndex = 1;
            this.btn_ce.TabStop = false;
            this.btn_ce.Text = "CE";
            this.tp_toolTip.SetToolTip(this.btn_ce, "Limpar entrada");
            this.btn_ce.UseVisualStyleBackColor = true;
            this.btn_ce.Click += new System.EventHandler(this.btn_ce_Click);
            // 
            // btn_fatorial
            // 
            this.btn_fatorial.Location = new System.Drawing.Point(124, 188);
            this.btn_fatorial.Name = "btn_fatorial";
            this.btn_fatorial.Size = new System.Drawing.Size(50, 50);
            this.btn_fatorial.TabIndex = 1;
            this.btn_fatorial.TabStop = false;
            this.btn_fatorial.Text = "n!";
            this.tp_toolTip.SetToolTip(this.btn_fatorial, "Fatorial");
            this.btn_fatorial.UseVisualStyleBackColor = true;
            this.btn_fatorial.Click += new System.EventHandler(this.btn_fatorial_Click);
            // 
            // btn_exp2
            // 
            this.btn_exp2.Location = new System.Drawing.Point(12, 132);
            this.btn_exp2.Name = "btn_exp2";
            this.btn_exp2.Size = new System.Drawing.Size(50, 50);
            this.btn_exp2.TabIndex = 1;
            this.btn_exp2.TabStop = false;
            this.btn_exp2.Text = "x^2";
            this.tp_toolTip.SetToolTip(this.btn_exp2, "Elevado ao quadrado");
            this.btn_exp2.UseVisualStyleBackColor = true;
            this.btn_exp2.Click += new System.EventHandler(this.btn_exp2_Click);
            // 
            // btn_pot
            // 
            this.btn_pot.Location = new System.Drawing.Point(68, 132);
            this.btn_pot.Name = "btn_pot";
            this.btn_pot.Size = new System.Drawing.Size(50, 50);
            this.btn_pot.TabIndex = 1;
            this.btn_pot.TabStop = false;
            this.btn_pot.Text = "x^y";
            this.tp_toolTip.SetToolTip(this.btn_pot, "Potenciação");
            this.btn_pot.UseVisualStyleBackColor = true;
            this.btn_pot.Click += new System.EventHandler(this.btn_pot_Click);
            // 
            // btn_sen
            // 
            this.btn_sen.Location = new System.Drawing.Point(124, 132);
            this.btn_sen.Name = "btn_sen";
            this.btn_sen.Size = new System.Drawing.Size(50, 50);
            this.btn_sen.TabIndex = 1;
            this.btn_sen.TabStop = false;
            this.btn_sen.Text = "sen";
            this.tp_toolTip.SetToolTip(this.btn_sen, "Seno");
            this.btn_sen.UseVisualStyleBackColor = true;
            this.btn_sen.Click += new System.EventHandler(this.btn_sen_Click);
            // 
            // btn_cos
            // 
            this.btn_cos.Location = new System.Drawing.Point(180, 132);
            this.btn_cos.Name = "btn_cos";
            this.btn_cos.Size = new System.Drawing.Size(50, 50);
            this.btn_cos.TabIndex = 1;
            this.btn_cos.TabStop = false;
            this.btn_cos.Text = "cos";
            this.tp_toolTip.SetToolTip(this.btn_cos, "Cosseno");
            this.btn_cos.UseVisualStyleBackColor = true;
            this.btn_cos.Click += new System.EventHandler(this.btn_cos_Click);
            // 
            // btn_tan
            // 
            this.btn_tan.Location = new System.Drawing.Point(236, 132);
            this.btn_tan.Name = "btn_tan";
            this.btn_tan.Size = new System.Drawing.Size(50, 50);
            this.btn_tan.TabIndex = 1;
            this.btn_tan.TabStop = false;
            this.btn_tan.Text = "tan";
            this.tp_toolTip.SetToolTip(this.btn_tan, "Tangente");
            this.btn_tan.UseVisualStyleBackColor = true;
            this.btn_tan.Click += new System.EventHandler(this.btn_tan_Click);
            // 
            // btn_mmais
            // 
            this.btn_mmais.Location = new System.Drawing.Point(124, 76);
            this.btn_mmais.Name = "btn_mmais";
            this.btn_mmais.Size = new System.Drawing.Size(50, 50);
            this.btn_mmais.TabIndex = 1;
            this.btn_mmais.TabStop = false;
            this.btn_mmais.Text = "M+";
            this.tp_toolTip.SetToolTip(this.btn_mmais, "Adição de memória");
            this.btn_mmais.UseVisualStyleBackColor = true;
            this.btn_mmais.Click += new System.EventHandler(this.btn_mmais_Click);
            // 
            // btn_mmenos
            // 
            this.btn_mmenos.Location = new System.Drawing.Point(180, 76);
            this.btn_mmenos.Name = "btn_mmenos";
            this.btn_mmenos.Size = new System.Drawing.Size(50, 50);
            this.btn_mmenos.TabIndex = 1;
            this.btn_mmenos.TabStop = false;
            this.btn_mmenos.Text = "M-";
            this.tp_toolTip.SetToolTip(this.btn_mmenos, "Subtração de memória");
            this.btn_mmenos.UseVisualStyleBackColor = true;
            this.btn_mmenos.Click += new System.EventHandler(this.btn_mmenos_Click);
            // 
            // lbl_desenvolvedor
            // 
            this.lbl_desenvolvedor.AutoSize = true;
            this.lbl_desenvolvedor.Enabled = false;
            this.lbl_desenvolvedor.Location = new System.Drawing.Point(112, 470);
            this.lbl_desenvolvedor.Name = "lbl_desenvolvedor";
            this.lbl_desenvolvedor.Size = new System.Drawing.Size(74, 13);
            this.lbl_desenvolvedor.TabIndex = 11;
            this.lbl_desenvolvedor.Text = "RCL Solutions";
            // 
            // lbl_operacao
            // 
            this.lbl_operacao.AutoSize = true;
            this.lbl_operacao.BackColor = System.Drawing.Color.Transparent;
            this.lbl_operacao.Location = new System.Drawing.Point(16, 16);
            this.lbl_operacao.Name = "lbl_operacao";
            this.lbl_operacao.Size = new System.Drawing.Size(13, 13);
            this.lbl_operacao.TabIndex = 12;
            this.lbl_operacao.Text = "+";
            // 
            // lbl_memoria
            // 
            this.lbl_memoria.AutoSize = true;
            this.lbl_memoria.BackColor = System.Drawing.Color.Transparent;
            this.lbl_memoria.Location = new System.Drawing.Point(16, 38);
            this.lbl_memoria.Name = "lbl_memoria";
            this.lbl_memoria.Size = new System.Drawing.Size(13, 13);
            this.lbl_memoria.TabIndex = 12;
            this.lbl_memoria.Text = "0";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(236, 76);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(50, 50);
            this.btn_back.TabIndex = 1;
            this.btn_back.TabStop = false;
            this.btn_back.Text = "<--";
            this.tp_toolTip.SetToolTip(this.btn_back, "Backspace");
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 494);
            this.Controls.Add(this.lbl_memoria);
            this.Controls.Add(this.lbl_operacao);
            this.Controls.Add(this.lbl_desenvolvedor);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_mmenos);
            this.Controls.Add(this.btn_mmais);
            this.Controls.Add(this.btn_ce);
            this.Controls.Add(this.btn_fatorial);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_virgula);
            this.Controls.Add(this.btn_igual);
            this.Controls.Add(this.btn_soma);
            this.Controls.Add(this.btn_diminui);
            this.Controls.Add(this.btn_multiplica);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_tan);
            this.Controls.Add(this.btn_mr);
            this.Controls.Add(this.btn_cos);
            this.Controls.Add(this.btn_sen);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.btn_pot);
            this.Controls.Add(this.btn_mc);
            this.Controls.Add(this.btn_exp2);
            this.Controls.Add(this.btn_raiz);
            this.Controls.Add(this.txt_visor);
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RCL Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_visor;
        private System.Windows.Forms.Button btn_raiz;
        private System.Windows.Forms.Button btn_mc;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Button btn_mr;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_multiplica;
        private System.Windows.Forms.Button btn_diminui;
        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.Button btn_igual;
        private System.Windows.Forms.Button btn_virgula;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button btn_ce;
        private System.Windows.Forms.Button btn_fatorial;
        private System.Windows.Forms.Button btn_exp2;
        private System.Windows.Forms.Button btn_pot;
        private System.Windows.Forms.Button btn_sen;
        private System.Windows.Forms.Button btn_cos;
        private System.Windows.Forms.Button btn_tan;
        private System.Windows.Forms.Button btn_mmais;
        private System.Windows.Forms.Button btn_mmenos;
        private System.Windows.Forms.Label lbl_desenvolvedor;
        private System.Windows.Forms.Label lbl_operacao;
        private System.Windows.Forms.ToolTip tp_toolTip;
        private System.Windows.Forms.Label lbl_memoria;
        private System.Windows.Forms.Button btn_back;
    }
}

