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

namespace LED_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try // A try block is used to encapsulate a region of code. If any code throws an exception within that try block, the exception will be handled by the corresponding catch.
            {
                portBox.Items.AddRange(SerialPort.GetPortNames());
                portBox.SelectedIndex = 0; //Depending on which COM port the user selects it will put it into the 0 position in the combobox
                serialPort1.BaudRate = (9600); //Set baudrate to 9600 to match the Arduino Nano
                serialPort1.ReadTimeout = (2000); //2 seconds before it times out and it errors
                serialPort1.WriteTimeout = (2000); //2 seconds before it times out and it errors
            }
            catch (Exception ex) //When an exception occurs, the Catch block of code is executed. This is where you are able to handle the exception, log it, or ignore it.
            {
                MessageBox.Show(ex.Message); //there are nothing to run here since all we did above is set the baudrate, timeouts, index, and get the COM ports available.
            }
        }

        private void onBox_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open(); //Open COM port 
                serialPort1.WriteLine("on"); //Send "on" through serial communication
                serialPort1.Close(); //Close COM port
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void offBox_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open(); //Open COM port 
                serialPort1.WriteLine("off"); //Send "off" through serial communication
                serialPort1.Close(); //Close COM port 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void portBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = portBox.Text; //Set the serial port name equals to the text inside portBox
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
