using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;


namespace RobotMobilny
{
    
    public partial class Form1 : Form
    {
        private Board board;
        private Robot robot;
        private Engines engine;
        private Frame frame;

        TcpClient clientSocket = new TcpClient();
        NetworkStream serverstream = default(NetworkStream);

        string readdata = null;
        string frameTemplate;
        string LedStatus = "00", S1, S2;
        private string[] sensorValue = new string[5];

        

        public Form1()
        {
            board = new Board();
            robot = new Robot();
            engine = new Engines();
            frame = new Frame();
            
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            clientSocket.Connect(Ip_Text.Text, Int32.Parse(Port_Text.Text));
            Thread ctThread = new Thread(getFrame);
            ctThread.IsBackground = true;
            ctThread.Start();
            if (clientSocket.Connected) ConnectStatus_Box.Text = "Connecting\n";
        }

        public void getFrame()
        {
            string returndata;
        
            while (true)
            {   
                byte[] instream = readFrame();

                returndata = System.Text.Encoding.ASCII.GetString(instream);

                readdata = returndata;
                EncodeFrame();
                DecodeLeds();
                DecodeEngines();

                byte[] FrameToSend = new byte[9];
                frameTemplate = "[" + LedStatus + S1 + S2 + "]";
                FrameToSend[0] = Convert.ToByte(frameTemplate[0]);
                FrameToSend[1] = Convert.ToByte(frameTemplate[1]);
                FrameToSend[2] = Convert.ToByte(frameTemplate[2]);
                FrameToSend[3] = Convert.ToByte(frameTemplate[3]);
                FrameToSend[4] = Convert.ToByte(frameTemplate[4]);
                FrameToSend[5] = Convert.ToByte(frameTemplate[5]);
                FrameToSend[6] = Convert.ToByte(frameTemplate[6]);
                FrameToSend[7] = Convert.ToByte(frameTemplate[7]);
                serverstream.Write(FrameToSend, 0, 8);
                Send();
            }
        }

        private byte[] readFrame()
        {
            serverstream = clientSocket.GetStream();
            var buffsize = clientSocket.ReceiveBufferSize;
            byte[] instream = new byte[buffsize];
            serverstream.Read(instream, 0, buffsize);
            return instream;
        }

        private void DecodeEngines()
        {
            SilnikLewy.Invoke(new Action(delegate ()
            {

                sbyte x = (sbyte)SilnikLewy.Value;
                S1 = x.ToString("X");
                if (S1.Length == 1)
                {
                    S1 = "0" + S1;
                }
            }));

            SilnikPrawy.Invoke(new Action(delegate ()
            {
                sbyte y = (sbyte)SilnikPrawy.Value;
                S2 = y.ToString("X");
                if (S2.Length == 1)
                {
                    S2 = "0" + S2;
                }
            }));
        }

        private void DecodeLeds()
        {
            if (Led_1_Checkbox.Checked & Led_2_Checkbox.Checked) LedStatus = "03";
            else if (Led_1_Checkbox.Checked & !Led_2_Checkbox.Checked) LedStatus = "01";
            else if (Led_2_Checkbox.Checked & !Led_1_Checkbox.Checked) LedStatus = "02";
            else LedStatus = "00";
        }

        private void Send()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(Send));
            }
            else
            {
                SentFrameBox.Text = frameTemplate;
            }
        }

        private void EncodeFrame()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(EncodeFrame));
            }
            else
            {
                GetFrameBox.Text = readdata;

                sensorValue = Frame.EncodeSensors(readdata);
                Sensor1.Value = Convert.ToInt32(sensorValue[0], 16);
                Sensor2.Value = Convert.ToInt32(sensorValue[1], 16);
                Sensor3.Value = Convert.ToInt32(sensorValue[2], 16);
                Sensor4.Value = Convert.ToInt32(sensorValue[3], 16);
                Sensor5.Value = Convert.ToInt32(sensorValue[4], 16);
                Sensor1_Value.Text = Convert.ToString(Sensor1.Value);
                Sensor2_Value.Text = Convert.ToString(Sensor2.Value);
                Sensor3_Value.Text = Convert.ToString(Sensor3.Value);
                Sensor4_Value.Text = Convert.ToString(Sensor4.Value);
                Sensor5_Value.Text = Convert.ToString(Sensor5.Value);

            }

        }

        private void reset_Click(object sender, EventArgs e)
        {
            SilnikLewy.Value = 0;
            SilnikPrawy.Value = 0;
            WSilnikLewy.Text = SilnikLewy.Value.ToString();
            WSilnikPrawy.Text = SilnikPrawy.Value.ToString();

        }

        private void leftEngine_Scroll(object sender, EventArgs e)
        {
            WSilnikLewy.Text = SilnikLewy.Value.ToString();
        }

        private void rightEngine_Scroll(object sender, EventArgs e)
        {
            WSilnikPrawy.Text = SilnikPrawy.Value.ToString();
        }


        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            clientSocket.Close();
            ConnectStatus_Box.Text = "disconnected... \n";
        }


        private void moveRight_Click(object sender, EventArgs e)
        {
            if(Controlpanel_checkbox.Checked == true)
            {
                robot.changeAngle(ChangeAngle.RIGHT);
                engine.workRight(Power_Slider.Value);

                Thread.Sleep(3000);
            }

        }

        private void moveLeft_Click(object sender, EventArgs e)
        {
            if (Controlpanel_checkbox.Checked == true)
            {
                robot.changeAngle(ChangeAngle.LEFT);
                Thread.Sleep(3000);
                engine.workLeft(Power_Slider.Value);

            }     
        }

  private void moveForward_MouseDown(object sender, MouseEventArgs e)
        {
            robot.rideForward(Power_Slider.Value);
            engine.workForward(Power_Slider.Value);
        }

        private void moveForward_MouseUp(object sender, MouseEventArgs e)
        {
            robot.stop();
            engine.noPower();
        }

        private void moveBackward_MouseDown(object sender, MouseEventArgs e)
        {
            robot.rideBackward(Power_Slider.Value);
            engine.workBackward(Power_Slider.Value);
        }

        private void moveBackward_MouseUp(object sender, MouseEventArgs e)
        {
            robot.stop();
            engine.noPower();
        }

        private void Controlpanel_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Controlpanel_checkbox.Checked == true)
            {
                Moving_Timer.Start();
                engine.noPower();
            }
            else Moving_Timer.Stop();
        }

        private void Moving_Timer_Tick(object sender, EventArgs e)
        {
            robot.drive();
            Board_box.Invalidate();

            engine.startEngine();
            SilnikLewy.Value = engine.getLeftValue();
            SilnikPrawy.Value = engine.getRightValue();
            WSilnikLewy.Text = SilnikLewy.Value.ToString();
            WSilnikPrawy.Text = SilnikPrawy.Value.ToString();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            board.repaint(e, robot.getPosition());
        }

 
    }
}
