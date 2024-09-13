using EasyModbus;
using System;
using System.Windows.Forms;
using System.Windows.Threading;

namespace ModbusMonitor
{
    public partial class Form1 : Form
    {
        ModbusClient modbusClient = new ModbusClient();
        DispatcherTimer timerPoll = new DispatcherTimer();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnConnect.Text == "CONNECT")
                {
                    modbusClient.IPAddress = "127.0.0.1";
                    modbusClient.Port = 502;
                    modbusClient.ConnectionTimeout = 5000;
                    modbusClient.Connect();
                    timerPoll.Interval = TimeSpan.FromSeconds(1);
                    timerPoll.Tick += timerPoll_Tick;
                    timerPoll.Start();
                    btnConnect.Text = "CONNECTED";
                    lbStatus.Text = "";
                }
                else
                {
                    modbusClient.Disconnect();
                    btnConnect.Text = "CONNECT";
                    timerPoll.Tick -= timerPoll_Tick;
                }
            }
            catch (EasyModbus.Exceptions.ConnectionException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (System.Net.Sockets.SocketException ex)
            {
                Console.WriteLine(ex.Message);
                lbStatus.Text = "Status : Connection timed out";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timerPoll_Tick(object sender, EventArgs e)
        {
            if (modbusClient.Connected == true)
            {
                int[] vals = modbusClient.ReadHoldingRegisters(0, 10);
                label1.Text = vals[0].ToString();
                label2.Text = vals[1].ToString();
                label3.Text = vals[2].ToString();
                label4.Text = vals[3].ToString();
                label5.Text = vals[4].ToString();
                label6.Text = vals[5].ToString();
                label7.Text = vals[6].ToString();
                label8.Text = vals[7].ToString();
                label9.Text = vals[8].ToString();


            }
        }
    }
}
