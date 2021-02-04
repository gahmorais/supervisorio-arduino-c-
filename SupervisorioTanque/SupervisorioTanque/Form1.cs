using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupervisorioTanque {
    public partial class Form1 : Form {

        delegate void FuncRep();

        string rxData;

        private void recebeDados() {
            string volumeTanque, etapaDoProcesso;

            rxData = serialPort1.ReadLine();

            volumeTanque = rxData.Substring(0, 4);
            etapaDoProcesso = rxData.Substring(16, 4);

            indicadorProcesso( Convert.ToInt32( etapaDoProcesso ) );
            preenchimentoTanque.Value = Convert.ToInt32(volumeTanque) / 10;
        }

        public Form1() {
            InitializeComponent();
        }

        private void indicadorProcesso(int etapa) {

            switch (etapa) {
                case 1:
                    painelValvula1.BackColor = Color.Green;
                    break;
                case 2:
                    painelValvula2.BackColor = Color.Green;
                    painelValvula1.BackColor = Color.Red;
                    break;
                case 3:
                    painelValvula3.BackColor = Color.Green;
                    painelValvula2.BackColor = Color.Red;
                    break;
                case 4:
                    painelEsvaziando.BackColor = Color.Green;
                    painelValvula3.BackColor = Color.Red;
                    break;
                case 0:
                    
                    painelValvula1.BackColor = Color.Red;
                    painelValvula2.BackColor = Color.Red;
                    painelValvula3.BackColor = Color.Red;
                    painelEsvaziando.BackColor = Color.Red;
                    break;

            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            string[] produtos = { "PROD A", "PROD B", "PROD C" };
            string[] baudRate = { "1200", "2400", "4800", "9600", "19200" };
            string[] portaCom = SerialPort.GetPortNames();

            cbxPortaCom.Items.AddRange(portaCom);
            cbxBaudRate.Items.AddRange(baudRate);
            cbxSelecioneProduto.Items.AddRange(produtos);
            btnIniciarProcesso.Enabled = false;
            lblStatusSistema.Text = "Desativado";
            
        }

        private void btnConectar_Click(object sender, EventArgs e) {
  
            if(serialPort1.IsOpen == true) {

                serialPort1.Close();

            } else {

                serialPort1.PortName = cbxPortaCom.Text;
                serialPort1.BaudRate = Convert.ToInt32(cbxBaudRate.Text);
                serialPort1.Open();

                cbxPortaCom.Enabled = false;
                cbxBaudRate.Enabled = false;
                btnConectar.Enabled = false;
                btnDesconectar.Enabled = true;
                btnFechar.Enabled = false;
                btnIniciarProcesso.Enabled = true;

                lblStatusSistema.Text = "Ativado";
                preenchimentoTanque.Value = 0;

            }
        }

        private void btnFechar_Click(object sender, EventArgs e) {

            this.Close();

        }

        private void btnDesconectar_Click(object sender, EventArgs e) {

            serialPort1.Close();
            cbxBaudRate.Enabled = true;
            cbxPortaCom.Enabled = true;
            btnDesconectar.Enabled = false;
            btnConectar.Enabled = true;
            btnFechar.Enabled = true;
            btnIniciarProcesso.Enabled = false;
            lblStatusSistema.Text = "Desativado";

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            FuncRep obj_repDadosDelegate = new FuncRep(recebeDados);
            Invoke(obj_repDadosDelegate);
        }

        private void btnIniciarProcesso_Click(object sender, EventArgs e) {

            switch (cbxSelecioneProduto.Text) {

                case "PROD A":

                    serialPort1.Write("01304030");
                    break;

                case "PROD B":
                    
                    serialPort1.Write("01403030");
                    break;

                case "PROD C":
                    
                    serialPort1.Write("01303040");
                    break;

                case "Selecione o produto":
                    MessageBox.Show("Selecione um produto\npara inicicar o processo");
                    break;
            }
        }
    }
}
