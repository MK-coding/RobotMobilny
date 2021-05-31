namespace RobotMobilny
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Moving_Timer = new System.Windows.Forms.Timer(this.components);
            this.Ip_Label = new System.Windows.Forms.Label();
            this.Sensor1 = new System.Windows.Forms.ProgressBar();
            this.Connect_Button = new System.Windows.Forms.Button();
            this.SilnikPrawy = new System.Windows.Forms.TrackBar();
            this.Led_1_Checkbox = new System.Windows.Forms.CheckBox();
            this.Ip_Text = new System.Windows.Forms.TextBox();
            this.SilnikLewy = new System.Windows.Forms.TrackBar();
            this.Sensor5 = new System.Windows.Forms.ProgressBar();
            this.Sensor4 = new System.Windows.Forms.ProgressBar();
            this.Sensor3 = new System.Windows.Forms.ProgressBar();
            this.Sensor2 = new System.Windows.Forms.ProgressBar();
            this.Led_2_Checkbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ConnectStatus_Label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.WSilnikPrawy = new System.Windows.Forms.Label();
            this.WSilnikLewy = new System.Windows.Forms.Label();
            this.Sensor5_Value = new System.Windows.Forms.Label();
            this.Sensor4_Value = new System.Windows.Forms.Label();
            this.Sensor3_Value = new System.Windows.Forms.Label();
            this.Sensor2_Value = new System.Windows.Forms.Label();
            this.Sensor1_Value = new System.Windows.Forms.Label();
            this.Disconnect_Button = new System.Windows.Forms.Button();
            this.Port_Text = new System.Windows.Forms.TextBox();
            this.Port_Label = new System.Windows.Forms.Label();
            this.ConnectStatus_Box = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GetFrameBox = new System.Windows.Forms.TextBox();
            this.SentFrameBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Power_Slider = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Right_Button = new System.Windows.Forms.Button();
            this.Left_Button = new System.Windows.Forms.Button();
            this.LeftRotate_Button = new System.Windows.Forms.Button();
            this.RightRotate_Button = new System.Windows.Forms.Button();
            this.Forward_Button = new System.Windows.Forms.Button();
            this.Backward_Button = new System.Windows.Forms.Button();
            this.NotifinationBox = new System.Windows.Forms.TextBox();
            this.Board_box = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Controlpanel_checkbox = new System.Windows.Forms.CheckBox();
            this.Panel_notification = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SilnikPrawy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SilnikLewy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Power_Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Board_box)).BeginInit();
            this.SuspendLayout();
            // 
            // Moving_Timer
            // 
            this.Moving_Timer.Tick += new System.EventHandler(this.Moving_Timer_Tick);
            // 
            // Ip_Label
            // 
            this.Ip_Label.AutoSize = true;
            this.Ip_Label.BackColor = System.Drawing.Color.Transparent;
            this.Ip_Label.Location = new System.Drawing.Point(7, 13);
            this.Ip_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ip_Label.Name = "Ip_Label";
            this.Ip_Label.Size = new System.Drawing.Size(17, 13);
            this.Ip_Label.TabIndex = 0;
            this.Ip_Label.Text = "IP";
            // 
            // Sensor1
            // 
            this.Sensor1.Location = new System.Drawing.Point(416, 163);
            this.Sensor1.Margin = new System.Windows.Forms.Padding(2);
            this.Sensor1.Maximum = 2000;
            this.Sensor1.Name = "Sensor1";
            this.Sensor1.Size = new System.Drawing.Size(123, 19);
            this.Sensor1.TabIndex = 1;
            // 
            // Connect_Button
            // 
            this.Connect_Button.BackColor = System.Drawing.Color.Transparent;
            this.Connect_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Connect_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Connect_Button.ForeColor = System.Drawing.SystemColors.Control;
            this.Connect_Button.Location = new System.Drawing.Point(25, 60);
            this.Connect_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(102, 19);
            this.Connect_Button.TabIndex = 2;
            this.Connect_Button.Text = "Connect";
            this.Connect_Button.UseVisualStyleBackColor = false;
            this.Connect_Button.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // SilnikPrawy
            // 
            this.SilnikPrawy.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SilnikPrawy.Location = new System.Drawing.Point(236, 37);
            this.SilnikPrawy.Margin = new System.Windows.Forms.Padding(2);
            this.SilnikPrawy.Maximum = 127;
            this.SilnikPrawy.Minimum = -127;
            this.SilnikPrawy.Name = "SilnikPrawy";
            this.SilnikPrawy.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.SilnikPrawy.Size = new System.Drawing.Size(45, 307);
            this.SilnikPrawy.TabIndex = 3;
            this.SilnikPrawy.Scroll += new System.EventHandler(this.rightEngine_Scroll);
            // 
            // Led_1_Checkbox
            // 
            this.Led_1_Checkbox.AutoSize = true;
            this.Led_1_Checkbox.BackColor = System.Drawing.Color.Transparent;
            this.Led_1_Checkbox.Location = new System.Drawing.Point(9, 337);
            this.Led_1_Checkbox.Margin = new System.Windows.Forms.Padding(2);
            this.Led_1_Checkbox.Name = "Led_1_Checkbox";
            this.Led_1_Checkbox.Size = new System.Drawing.Size(53, 17);
            this.Led_1_Checkbox.TabIndex = 4;
            this.Led_1_Checkbox.Text = "LED1";
            this.Led_1_Checkbox.UseVisualStyleBackColor = false;
            // 
            // Ip_Text
            // 
            this.Ip_Text.Location = new System.Drawing.Point(37, 11);
            this.Ip_Text.Margin = new System.Windows.Forms.Padding(2);
            this.Ip_Text.Name = "Ip_Text";
            this.Ip_Text.Size = new System.Drawing.Size(76, 20);
            this.Ip_Text.TabIndex = 5;
            // 
            // SilnikLewy
            // 
            this.SilnikLewy.BackColor = System.Drawing.Color.DarkGray;
            this.SilnikLewy.Location = new System.Drawing.Point(164, 37);
            this.SilnikLewy.Margin = new System.Windows.Forms.Padding(2);
            this.SilnikLewy.Maximum = 127;
            this.SilnikLewy.Minimum = -127;
            this.SilnikLewy.Name = "SilnikLewy";
            this.SilnikLewy.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.SilnikLewy.Size = new System.Drawing.Size(45, 307);
            this.SilnikLewy.TabIndex = 6;
            this.SilnikLewy.Scroll += new System.EventHandler(this.leftEngine_Scroll);
            // 
            // Sensor5
            // 
            this.Sensor5.Location = new System.Drawing.Point(416, 290);
            this.Sensor5.Margin = new System.Windows.Forms.Padding(2);
            this.Sensor5.Maximum = 2000;
            this.Sensor5.Name = "Sensor5";
            this.Sensor5.Size = new System.Drawing.Size(123, 19);
            this.Sensor5.TabIndex = 9;
            // 
            // Sensor4
            // 
            this.Sensor4.Location = new System.Drawing.Point(416, 259);
            this.Sensor4.Margin = new System.Windows.Forms.Padding(2);
            this.Sensor4.Maximum = 2000;
            this.Sensor4.Name = "Sensor4";
            this.Sensor4.Size = new System.Drawing.Size(123, 19);
            this.Sensor4.TabIndex = 10;
            // 
            // Sensor3
            // 
            this.Sensor3.Location = new System.Drawing.Point(416, 226);
            this.Sensor3.Margin = new System.Windows.Forms.Padding(2);
            this.Sensor3.Maximum = 2000;
            this.Sensor3.Name = "Sensor3";
            this.Sensor3.Size = new System.Drawing.Size(123, 19);
            this.Sensor3.TabIndex = 11;
            // 
            // Sensor2
            // 
            this.Sensor2.Location = new System.Drawing.Point(416, 194);
            this.Sensor2.Margin = new System.Windows.Forms.Padding(2);
            this.Sensor2.Maximum = 2000;
            this.Sensor2.Name = "Sensor2";
            this.Sensor2.Size = new System.Drawing.Size(123, 19);
            this.Sensor2.TabIndex = 12;
            // 
            // Led_2_Checkbox
            // 
            this.Led_2_Checkbox.AutoSize = true;
            this.Led_2_Checkbox.BackColor = System.Drawing.Color.Transparent;
            this.Led_2_Checkbox.Location = new System.Drawing.Point(9, 358);
            this.Led_2_Checkbox.Margin = new System.Windows.Forms.Padding(2);
            this.Led_2_Checkbox.Name = "Led_2_Checkbox";
            this.Led_2_Checkbox.Size = new System.Drawing.Size(53, 17);
            this.Led_2_Checkbox.TabIndex = 13;
            this.Led_2_Checkbox.Text = "LED2";
            this.Led_2_Checkbox.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(327, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sensor1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(327, 296);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sensor5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(327, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Sensor4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(327, 232);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Sensor3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(327, 200);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Sensor2";
            // 
            // ConnectStatus_Label
            // 
            this.ConnectStatus_Label.AutoSize = true;
            this.ConnectStatus_Label.BackColor = System.Drawing.Color.Transparent;
            this.ConnectStatus_Label.Location = new System.Drawing.Point(6, 140);
            this.ConnectStatus_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConnectStatus_Label.Name = "ConnectStatus_Label";
            this.ConnectStatus_Label.Size = new System.Drawing.Size(40, 13);
            this.ConnectStatus_Label.TabIndex = 23;
            this.ConnectStatus_Label.Text = "Status:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(233, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Right Engine";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(149, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Left Engine";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(288, 60);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Frame revceived";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(315, 92);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Frame Sent";
            // 
            // Reset_Button
            // 
            this.Reset_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Reset_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reset_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Reset_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Reset_Button.Location = new System.Drawing.Point(164, 376);
            this.Reset_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(116, 29);
            this.Reset_Button.TabIndex = 28;
            this.Reset_Button.Text = "RESET";
            this.Reset_Button.UseVisualStyleBackColor = false;
            this.Reset_Button.Click += new System.EventHandler(this.reset_Click);
            // 
            // WSilnikPrawy
            // 
            this.WSilnikPrawy.AutoSize = true;
            this.WSilnikPrawy.BackColor = System.Drawing.Color.Transparent;
            this.WSilnikPrawy.Location = new System.Drawing.Point(233, 346);
            this.WSilnikPrawy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WSilnikPrawy.Name = "WSilnikPrawy";
            this.WSilnikPrawy.Size = new System.Drawing.Size(13, 13);
            this.WSilnikPrawy.TabIndex = 29;
            this.WSilnikPrawy.Text = "0";
            // 
            // WSilnikLewy
            // 
            this.WSilnikLewy.AutoSize = true;
            this.WSilnikLewy.BackColor = System.Drawing.Color.Transparent;
            this.WSilnikLewy.Location = new System.Drawing.Point(161, 346);
            this.WSilnikLewy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WSilnikLewy.Name = "WSilnikLewy";
            this.WSilnikLewy.Size = new System.Drawing.Size(13, 13);
            this.WSilnikLewy.TabIndex = 30;
            this.WSilnikLewy.Text = "0";
            // 
            // Sensor5_Value
            // 
            this.Sensor5_Value.AutoSize = true;
            this.Sensor5_Value.BackColor = System.Drawing.Color.Transparent;
            this.Sensor5_Value.Location = new System.Drawing.Point(377, 296);
            this.Sensor5_Value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sensor5_Value.Name = "Sensor5_Value";
            this.Sensor5_Value.Size = new System.Drawing.Size(13, 13);
            this.Sensor5_Value.TabIndex = 31;
            this.Sensor5_Value.Text = "0";
            // 
            // Sensor4_Value
            // 
            this.Sensor4_Value.AutoSize = true;
            this.Sensor4_Value.BackColor = System.Drawing.Color.Transparent;
            this.Sensor4_Value.Location = new System.Drawing.Point(377, 265);
            this.Sensor4_Value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sensor4_Value.Name = "Sensor4_Value";
            this.Sensor4_Value.Size = new System.Drawing.Size(13, 13);
            this.Sensor4_Value.TabIndex = 32;
            this.Sensor4_Value.Text = "0";
            // 
            // Sensor3_Value
            // 
            this.Sensor3_Value.AutoSize = true;
            this.Sensor3_Value.BackColor = System.Drawing.Color.Transparent;
            this.Sensor3_Value.Location = new System.Drawing.Point(377, 232);
            this.Sensor3_Value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sensor3_Value.Name = "Sensor3_Value";
            this.Sensor3_Value.Size = new System.Drawing.Size(13, 13);
            this.Sensor3_Value.TabIndex = 33;
            this.Sensor3_Value.Text = "0";
            // 
            // Sensor2_Value
            // 
            this.Sensor2_Value.AutoSize = true;
            this.Sensor2_Value.BackColor = System.Drawing.Color.Transparent;
            this.Sensor2_Value.Location = new System.Drawing.Point(377, 200);
            this.Sensor2_Value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sensor2_Value.Name = "Sensor2_Value";
            this.Sensor2_Value.Size = new System.Drawing.Size(13, 13);
            this.Sensor2_Value.TabIndex = 34;
            this.Sensor2_Value.Text = "0";
            // 
            // Sensor1_Value
            // 
            this.Sensor1_Value.AutoSize = true;
            this.Sensor1_Value.BackColor = System.Drawing.Color.Transparent;
            this.Sensor1_Value.Location = new System.Drawing.Point(377, 169);
            this.Sensor1_Value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sensor1_Value.Name = "Sensor1_Value";
            this.Sensor1_Value.Size = new System.Drawing.Size(13, 13);
            this.Sensor1_Value.TabIndex = 35;
            this.Sensor1_Value.Text = "0";
            // 
            // Disconnect_Button
            // 
            this.Disconnect_Button.BackColor = System.Drawing.Color.Transparent;
            this.Disconnect_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Disconnect_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Disconnect_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Disconnect_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Disconnect_Button.Location = new System.Drawing.Point(25, 83);
            this.Disconnect_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Disconnect_Button.Name = "Disconnect_Button";
            this.Disconnect_Button.Size = new System.Drawing.Size(102, 22);
            this.Disconnect_Button.TabIndex = 38;
            this.Disconnect_Button.Text = "Disconnect";
            this.Disconnect_Button.UseVisualStyleBackColor = false;
            this.Disconnect_Button.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // Port_Text
            // 
            this.Port_Text.Location = new System.Drawing.Point(37, 35);
            this.Port_Text.Margin = new System.Windows.Forms.Padding(2);
            this.Port_Text.Name = "Port_Text";
            this.Port_Text.Size = new System.Drawing.Size(76, 20);
            this.Port_Text.TabIndex = 41;
            // 
            // Port_Label
            // 
            this.Port_Label.AutoSize = true;
            this.Port_Label.BackColor = System.Drawing.Color.Transparent;
            this.Port_Label.Location = new System.Drawing.Point(7, 39);
            this.Port_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Port_Label.Name = "Port_Label";
            this.Port_Label.Size = new System.Drawing.Size(26, 13);
            this.Port_Label.TabIndex = 40;
            this.Port_Label.Text = "Port";
            // 
            // ConnectStatus_Box
            // 
            this.ConnectStatus_Box.BackColor = System.Drawing.Color.DarkGray;
            this.ConnectStatus_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConnectStatus_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConnectStatus_Box.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ConnectStatus_Box.Location = new System.Drawing.Point(9, 155);
            this.ConnectStatus_Box.Margin = new System.Windows.Forms.Padding(2);
            this.ConnectStatus_Box.Multiline = true;
            this.ConnectStatus_Box.Name = "ConnectStatus_Box";
            this.ConnectStatus_Box.Size = new System.Drawing.Size(129, 27);
            this.ConnectStatus_Box.TabIndex = 42;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // GetFrameBox
            // 
            this.GetFrameBox.Location = new System.Drawing.Point(380, 53);
            this.GetFrameBox.Margin = new System.Windows.Forms.Padding(2);
            this.GetFrameBox.Multiline = true;
            this.GetFrameBox.Name = "GetFrameBox";
            this.GetFrameBox.Size = new System.Drawing.Size(246, 20);
            this.GetFrameBox.TabIndex = 43;
            // 
            // SentFrameBox
            // 
            this.SentFrameBox.Location = new System.Drawing.Point(380, 89);
            this.SentFrameBox.Margin = new System.Windows.Forms.Padding(2);
            this.SentFrameBox.Multiline = true;
            this.SentFrameBox.Name = "SentFrameBox";
            this.SentFrameBox.Size = new System.Drawing.Size(246, 20);
            this.SentFrameBox.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(736, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "Control Panel";
            // 
            // Power_Slider
            // 
            this.Power_Slider.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Power_Slider.Location = new System.Drawing.Point(653, 358);
            this.Power_Slider.Maximum = 3;
            this.Power_Slider.Name = "Power_Slider";
            this.Power_Slider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Power_Slider.Size = new System.Drawing.Size(252, 45);
            this.Power_Slider.TabIndex = 56;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(650, 392);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 57;
            this.label14.Text = "30%";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(727, 392);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 58;
            this.label15.Text = "60%";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(799, 392);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 59;
            this.label16.Text = "80%";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(878, 392);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 60;
            this.label17.Text = "100%";
            // 
            // Right_Button
            // 
            this.Right_Button.BackColor = System.Drawing.Color.Transparent;
            this.Right_Button.Image = ((System.Drawing.Image)(resources.GetObject("Right_Button.Image")));
            this.Right_Button.Location = new System.Drawing.Point(825, 90);
            this.Right_Button.Name = "Right_Button";
            this.Right_Button.Size = new System.Drawing.Size(80, 66);
            this.Right_Button.TabIndex = 51;
            this.Right_Button.UseVisualStyleBackColor = false;
            this.Right_Button.Click += new System.EventHandler(this.moveRight_Click);
            // 
            // Left_Button
            // 
            this.Left_Button.Image = ((System.Drawing.Image)(resources.GetObject("Left_Button.Image")));
            this.Left_Button.Location = new System.Drawing.Point(653, 90);
            this.Left_Button.Name = "Left_Button";
            this.Left_Button.Size = new System.Drawing.Size(80, 66);
            this.Left_Button.TabIndex = 50;
            this.Left_Button.UseVisualStyleBackColor = true;
            this.Left_Button.Click += new System.EventHandler(this.moveLeft_Click);
            // 
            // LeftRotate_Button
            // 
            this.LeftRotate_Button.Image = ((System.Drawing.Image)(resources.GetObject("LeftRotate_Button.Image")));
            this.LeftRotate_Button.Location = new System.Drawing.Point(653, 162);
            this.LeftRotate_Button.Name = "LeftRotate_Button";
            this.LeftRotate_Button.Size = new System.Drawing.Size(80, 66);
            this.LeftRotate_Button.TabIndex = 49;
            this.LeftRotate_Button.UseVisualStyleBackColor = true;
            // 
            // RightRotate_Button
            // 
            this.RightRotate_Button.Image = ((System.Drawing.Image)(resources.GetObject("RightRotate_Button.Image")));
            this.RightRotate_Button.Location = new System.Drawing.Point(825, 162);
            this.RightRotate_Button.Name = "RightRotate_Button";
            this.RightRotate_Button.Size = new System.Drawing.Size(80, 66);
            this.RightRotate_Button.TabIndex = 48;
            this.RightRotate_Button.UseVisualStyleBackColor = true;
            // 
            // Forward_Button
            // 
            this.Forward_Button.Image = ((System.Drawing.Image)(resources.GetObject("Forward_Button.Image")));
            this.Forward_Button.Location = new System.Drawing.Point(739, 60);
            this.Forward_Button.Name = "Forward_Button";
            this.Forward_Button.Size = new System.Drawing.Size(80, 96);
            this.Forward_Button.TabIndex = 47;
            this.Forward_Button.Text = "c";
            this.Forward_Button.UseVisualStyleBackColor = true;
            this.Forward_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForward_MouseDown);
            this.Forward_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveForward_MouseUp);
            // 
            // Backward_Button
            // 
            this.Backward_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Backward_Button.Image = ((System.Drawing.Image)(resources.GetObject("Backward_Button.Image")));
            this.Backward_Button.Location = new System.Drawing.Point(739, 156);
            this.Backward_Button.Name = "Backward_Button";
            this.Backward_Button.Size = new System.Drawing.Size(80, 101);
            this.Backward_Button.TabIndex = 46;
            this.Backward_Button.UseVisualStyleBackColor = false;
            this.Backward_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveBackward_MouseDown);
            this.Backward_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveBackward_MouseUp);
            // 
            // NotifinationBox
            // 
            this.NotifinationBox.Location = new System.Drawing.Point(1282, 22);
            this.NotifinationBox.Margin = new System.Windows.Forms.Padding(2);
            this.NotifinationBox.Multiline = true;
            this.NotifinationBox.Name = "NotifinationBox";
            this.NotifinationBox.Size = new System.Drawing.Size(159, 20);
            this.NotifinationBox.TabIndex = 61;
            // 
            // Board_box
            // 
            this.Board_box.Location = new System.Drawing.Point(938, 59);
            this.Board_box.Name = "Board_box";
            this.Board_box.Size = new System.Drawing.Size(502, 344);
            this.Board_box.TabIndex = 62;
            this.Board_box.TabStop = false;
            this.Board_box.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(747, 318);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 13);
            this.label18.TabIndex = 65;
            this.label18.Text = "Engine power";
            // 
            // Controlpanel_checkbox
            // 
            this.Controlpanel_checkbox.AutoSize = true;
            this.Controlpanel_checkbox.Location = new System.Drawing.Point(715, 21);
            this.Controlpanel_checkbox.Name = "Controlpanel_checkbox";
            this.Controlpanel_checkbox.Size = new System.Drawing.Size(15, 14);
            this.Controlpanel_checkbox.TabIndex = 66;
            this.Controlpanel_checkbox.UseVisualStyleBackColor = true;
            this.Controlpanel_checkbox.CheckedChanged += new System.EventHandler(this.Controlpanel_checkbox_CheckedChanged);
            // 
            // Panel_notification
            // 
            this.Panel_notification.AutoSize = true;
            this.Panel_notification.Location = new System.Drawing.Point(1180, 226);
            this.Panel_notification.Name = "Panel_notification";
            this.Panel_notification.Size = new System.Drawing.Size(0, 13);
            this.Panel_notification.TabIndex = 67;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1452, 429);
            this.Controls.Add(this.Panel_notification);
            this.Controls.Add(this.Controlpanel_checkbox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Board_box);
            this.Controls.Add(this.NotifinationBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Power_Slider);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Right_Button);
            this.Controls.Add(this.Left_Button);
            this.Controls.Add(this.LeftRotate_Button);
            this.Controls.Add(this.RightRotate_Button);
            this.Controls.Add(this.Forward_Button);
            this.Controls.Add(this.Backward_Button);
            this.Controls.Add(this.SentFrameBox);
            this.Controls.Add(this.GetFrameBox);
            this.Controls.Add(this.ConnectStatus_Box);
            this.Controls.Add(this.Port_Text);
            this.Controls.Add(this.Port_Label);
            this.Controls.Add(this.Disconnect_Button);
            this.Controls.Add(this.Sensor1_Value);
            this.Controls.Add(this.Sensor2_Value);
            this.Controls.Add(this.Sensor3_Value);
            this.Controls.Add(this.Sensor4_Value);
            this.Controls.Add(this.Sensor5_Value);
            this.Controls.Add(this.WSilnikLewy);
            this.Controls.Add(this.WSilnikPrawy);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ConnectStatus_Label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Led_2_Checkbox);
            this.Controls.Add(this.Sensor2);
            this.Controls.Add(this.Sensor3);
            this.Controls.Add(this.Sensor4);
            this.Controls.Add(this.Sensor5);
            this.Controls.Add(this.SilnikLewy);
            this.Controls.Add(this.Ip_Text);
            this.Controls.Add(this.Led_1_Checkbox);
            this.Controls.Add(this.SilnikPrawy);
            this.Controls.Add(this.Connect_Button);
            this.Controls.Add(this.Sensor1);
            this.Controls.Add(this.Ip_Label);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RobotMobilny__MK";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SilnikPrawy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SilnikLewy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Power_Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Board_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ip_Label;
        private System.Windows.Forms.ProgressBar Sensor1;
        private System.Windows.Forms.Button Connect_Button;
        private System.Windows.Forms.CheckBox Led_1_Checkbox;
        private System.Windows.Forms.TextBox Ip_Text;
        private System.Windows.Forms.ProgressBar Sensor5;
        private System.Windows.Forms.ProgressBar Sensor4;
        private System.Windows.Forms.ProgressBar Sensor3;
        private System.Windows.Forms.ProgressBar Sensor2;
        private System.Windows.Forms.CheckBox Led_2_Checkbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ConnectStatus_Label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Label WSilnikLewy;
        private System.Windows.Forms.Label Sensor5_Value;
        private System.Windows.Forms.Label Sensor4_Value;
        private System.Windows.Forms.Label Sensor3_Value;
        private System.Windows.Forms.Label Sensor2_Value;
        private System.Windows.Forms.Label Sensor1_Value;
        private System.Windows.Forms.Button Disconnect_Button;
        private System.Windows.Forms.TextBox Port_Text;
        private System.Windows.Forms.Label Port_Label;
        private System.Windows.Forms.TextBox ConnectStatus_Box;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox GetFrameBox;
        private System.Windows.Forms.TextBox SentFrameBox;
        public System.Windows.Forms.TrackBar SilnikLewy;
        public System.Windows.Forms.TrackBar SilnikPrawy;
        public System.Windows.Forms.Label WSilnikPrawy;
        private System.Windows.Forms.Button Right_Button;
        private System.Windows.Forms.Button Left_Button;
        private System.Windows.Forms.Button LeftRotate_Button;
        private System.Windows.Forms.Button RightRotate_Button;
        public System.Windows.Forms.Button Forward_Button;
        private System.Windows.Forms.Button Backward_Button;
        private System.Windows.Forms.Label label13;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TrackBar Power_Slider;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Timer Moving_Timer;
        private System.Windows.Forms.TextBox NotifinationBox;
        private System.Windows.Forms.PictureBox Board_box;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox Controlpanel_checkbox;
        private System.Windows.Forms.Label Panel_notification;
    }
}

