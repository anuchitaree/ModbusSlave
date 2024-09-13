using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModbusClient
{
    public partial class Form1 : Form
    {
        ModbusClient modbusClient = new ModbusClient();
        public Form1()
        {
            InitializeComponent();
        }
    }
}
