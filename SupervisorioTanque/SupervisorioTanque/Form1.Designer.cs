namespace SupervisorioTanque {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.painelValvula1 = new System.Windows.Forms.Panel();
            this.painelValvula2 = new System.Windows.Forms.Panel();
            this.painelValvula3 = new System.Windows.Forms.Panel();
            this.cbxSelecioneProduto = new System.Windows.Forms.ComboBox();
            this.cbxPortaCom = new System.Windows.Forms.ComboBox();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnIniciarProcesso = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblStatusSistema = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.preenchimentoTanque = new SupervisorioTanque.VerticalProgressBar();
            this.label16 = new System.Windows.Forms.Label();
            this.painelEsvaziando = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supervisório";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(948, 637);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tanque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(820, 578);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "10%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(820, 532);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "20%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(820, 488);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "30%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(820, 442);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "40%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(820, 397);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "50%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(820, 349);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "60%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(820, 305);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "70%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(820, 258);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "80%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(820, 212);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "90%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(819, 166);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "100%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(75, 323);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 33);
            this.label13.TabIndex = 13;
            this.label13.Text = "VÁLVULA 1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(75, 391);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 33);
            this.label14.TabIndex = 14;
            this.label14.Text = "VÁLVULA 2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(75, 463);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(168, 33);
            this.label15.TabIndex = 15;
            this.label15.Text = "VÁLVULA 3";
            // 
            // painelValvula1
            // 
            this.painelValvula1.BackColor = System.Drawing.Color.Red;
            this.painelValvula1.Location = new System.Drawing.Point(273, 323);
            this.painelValvula1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.painelValvula1.Name = "painelValvula1";
            this.painelValvula1.Size = new System.Drawing.Size(50, 37);
            this.painelValvula1.TabIndex = 16;
            // 
            // painelValvula2
            // 
            this.painelValvula2.BackColor = System.Drawing.Color.Red;
            this.painelValvula2.Location = new System.Drawing.Point(273, 391);
            this.painelValvula2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.painelValvula2.Name = "painelValvula2";
            this.painelValvula2.Size = new System.Drawing.Size(50, 37);
            this.painelValvula2.TabIndex = 17;
            // 
            // painelValvula3
            // 
            this.painelValvula3.BackColor = System.Drawing.Color.Red;
            this.painelValvula3.Location = new System.Drawing.Point(273, 463);
            this.painelValvula3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.painelValvula3.Name = "painelValvula3";
            this.painelValvula3.Size = new System.Drawing.Size(50, 37);
            this.painelValvula3.TabIndex = 18;
            // 
            // cbxSelecioneProduto
            // 
            this.cbxSelecioneProduto.FormattingEnabled = true;
            this.cbxSelecioneProduto.Location = new System.Drawing.Point(81, 600);
            this.cbxSelecioneProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxSelecioneProduto.Name = "cbxSelecioneProduto";
            this.cbxSelecioneProduto.Size = new System.Drawing.Size(240, 28);
            this.cbxSelecioneProduto.TabIndex = 19;
            this.cbxSelecioneProduto.Text = "Selecione o produto";
            // 
            // cbxPortaCom
            // 
            this.cbxPortaCom.FormattingEnabled = true;
            this.cbxPortaCom.Location = new System.Drawing.Point(81, 160);
            this.cbxPortaCom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxPortaCom.Name = "cbxPortaCom";
            this.cbxPortaCom.Size = new System.Drawing.Size(180, 28);
            this.cbxPortaCom.TabIndex = 21;
            this.cbxPortaCom.Text = "Selecione Porta Com";
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Location = new System.Drawing.Point(273, 160);
            this.cbxBaudRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(180, 28);
            this.cbxBaudRate.TabIndex = 22;
            this.cbxBaudRate.Text = "Selecione BaudRate";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(81, 218);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(182, 35);
            this.btnConectar.TabIndex = 23;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(273, 218);
            this.btnDesconectar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(182, 35);
            this.btnDesconectar.TabIndex = 24;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnIniciarProcesso
            // 
            this.btnIniciarProcesso.Location = new System.Drawing.Point(81, 649);
            this.btnIniciarProcesso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIniciarProcesso.Name = "btnIniciarProcesso";
            this.btnIniciarProcesso.Size = new System.Drawing.Size(242, 35);
            this.btnIniciarProcesso.TabIndex = 25;
            this.btnIniciarProcesso.Text = "Iniciar processo";
            this.btnIniciarProcesso.UseVisualStyleBackColor = true;
            this.btnIniciarProcesso.Click += new System.EventHandler(this.btnIniciarProcesso_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(444, 695);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(333, 89);
            this.btnFechar.TabIndex = 26;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblStatusSistema
            // 
            this.lblStatusSistema.AutoSize = true;
            this.lblStatusSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusSistema.Location = new System.Drawing.Point(174, 278);
            this.lblStatusSistema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusSistema.Name = "lblStatusSistema";
            this.lblStatusSistema.Size = new System.Drawing.Size(0, 29);
            this.lblStatusSistema.TabIndex = 27;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // preenchimentoTanque
            // 
            this.preenchimentoTanque.Location = new System.Drawing.Point(882, 160);
            this.preenchimentoTanque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.preenchimentoTanque.Maximum = 103;
            this.preenchimentoTanque.Name = "preenchimentoTanque";
            this.preenchimentoTanque.Size = new System.Drawing.Size(243, 472);
            this.preenchimentoTanque.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(75, 525);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(330, 33);
            this.label16.TabIndex = 29;
            this.label16.Text = "ESVAZIANDO TANQUE";
            // 
            // painelEsvaziando
            // 
            this.painelEsvaziando.BackColor = System.Drawing.Color.Red;
            this.painelEsvaziando.Location = new System.Drawing.Point(418, 525);
            this.painelEsvaziando.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.painelEsvaziando.Name = "painelEsvaziando";
            this.painelEsvaziando.Size = new System.Drawing.Size(50, 37);
            this.painelEsvaziando.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(75, 278);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 29);
            this.label17.TabIndex = 30;
            this.label17.Text = "Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 832);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.painelEsvaziando);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblStatusSistema);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnIniciarProcesso);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.cbxBaudRate);
            this.Controls.Add(this.cbxPortaCom);
            this.Controls.Add(this.cbxSelecioneProduto);
            this.Controls.Add(this.painelValvula3);
            this.Controls.Add(this.painelValvula2);
            this.Controls.Add(this.painelValvula1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.preenchimentoTanque);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label label1;
        private VerticalProgressBar preenchimentoTanque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel painelValvula1;
        private System.Windows.Forms.Panel painelValvula2;
        private System.Windows.Forms.Panel painelValvula3;
        private System.Windows.Forms.ComboBox cbxSelecioneProduto;
        private System.Windows.Forms.ComboBox cbxPortaCom;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnIniciarProcesso;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblStatusSistema;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel painelEsvaziando;
        private System.Windows.Forms.Label label17;
    }
}

