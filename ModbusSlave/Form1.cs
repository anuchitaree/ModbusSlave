using EasyModbus;
using System;
using System.Windows.Forms;

namespace ModbusSlave
{
    public partial class Form1 : Form
    {
        ModbusServer modbusServer;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "START")
            {
                modbusServer = new ModbusServer();
                modbusServer.Listen();
                labStatus.Text = "Status : Started";
                btnStart.Text = "STOP";
            }
            else
            {
                modbusServer.StopListening();
                modbusServer = null;
                labStatus.Text = "Status :";
                btnStart.Text = "START";
            }
        }
        //        Holding Register
        //Input Register
        //Digital Register
        //Coil Register
        private void btnSetVal_Click(object sender, EventArgs e)
        {
            if(btnStart.Text == "START") return;
            try
            {

                int iaddress = int.Parse(textRegAdr.Text);

                if (cmbRegType.SelectedIndex == 0)
                {
                    short ival = short.Parse(textReqVal.Text);
                    ModbusServer.HoldingRegisters regs = modbusServer.holdingRegisters;
                    regs[iaddress] = ival;
                }
                else if (cmbRegType.SelectedIndex == 1)
                {
                    short ival = short.Parse(textReqVal.Text);
                    ModbusServer.InputRegisters regs = modbusServer.inputRegisters;
                    regs[iaddress] = ival;
                }
                else if (cmbRegType.SelectedIndex == 2)
                {
                    bool ival = false;
                    if(textReqVal.Text=="1" || textReqVal.Text.ToLower() == "true")
                    {
                        ival = true;
                    }
                    ModbusServer.DiscreteInputs regs = modbusServer.discreteInputs;
                    regs[iaddress] = ival;
                }
                else if (cmbRegType.SelectedIndex == 3)
                {
                    bool ival = false;
                    if (textReqVal.Text == "1" || textReqVal.Text.ToLower() == "true")
                    {
                        ival = true;
                    }
                    ModbusServer.Coils regs = modbusServer.coils;
                    regs[iaddress] = ival;
                }
            }
            catch
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbRegType.SelectedIndex = 0;
        }
    }
}
