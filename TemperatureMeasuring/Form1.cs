using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Runtime.InteropServices;

namespace TemperatureMeasuring
{
    public partial class Principal : Form
    {
        Color defaultButtonColor = Color.FromArgb(58, 134, 255);

        bool connected = false;
        //float Value = 0;

        delegate void SetDataControls(string value);

        public const int WN_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern int ReleaseCapture();

        private void MoveWindow(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WN_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public Principal()
        {
            InitializeComponent();
            getAllPorts();

            // Evento al recibir datos en el puerto serial
            ArduinoPort.DataReceived += ReadPort;
        }

        // Establecer datos a los controles
        public void SetData(string value)
        {
            if (InvokeRequired)
            {
                try
                {
                    Invoke(new SetDataControls(SetData), value);
                }
                catch { }
            }
            else
            {
                //int sensorValue = int.Parse(value);

                TempLabel.Text = value;
                TempMeter.Value = float.Parse(value)/100;
            }
        }

        // Evento que toma los datos del puerto serie
        private void ReadPort(object sender, SerialDataReceivedEventArgs e)
        {
            string Data = ArduinoPort.ReadLine();
            SetData(Data);
        }


        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                ConnectArduino();
            }
            else
            {
                DisconnectArduino();
            }
        }


        #region ArduinoConn
        private void ConnectArduino()
        {
            try
            {
                string Port = comPortList.GetItemText(comPortList.SelectedItem);
                ArduinoPort.PortName = Port;
                ArduinoPort.Open();
                connected = true;

                ConnectBtn.BackColor = Color.Crimson;
                ConnectBtn.Text = "DISCONNECT";
                StateLabel.Text = "CONNECTED";
                StateLabel.ForeColor = Color.LimeGreen;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisconnectArduino()
        {
            ArduinoPort.Close();
            connected = false;

            ConnectBtn.BackColor = defaultButtonColor;
            ConnectBtn.Text = "CONNECT";
            StateLabel.Text = "DISCONNECTED";
            StateLabel.ForeColor = Color.Crimson;
        }

        private void getAllPorts()
        {
            foreach(var port in SerialPort.GetPortNames())
            {
                comPortList.Items.Add(port);
            }

            if(SerialPort.GetPortNames()[0] != null)
            {
                comPortList.SelectedItem = SerialPort.GetPortNames()[0];
            }

        }
        #endregion

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
