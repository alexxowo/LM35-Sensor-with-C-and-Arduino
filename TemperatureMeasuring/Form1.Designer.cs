namespace TemperatureMeasuring
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Titlebar = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GaugeTitl = new System.Windows.Forms.Label();
            this.TempLabel = new System.Windows.Forms.Label();
            this.comPortList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.ArduinoPort = new System.IO.Ports.SerialPort(this.components);
            this.TempMeter = new System.Windows.Forms.AGauge();
            this.Titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titlebar
            // 
            this.Titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.Titlebar.Controls.Add(this.Title);
            this.Titlebar.Controls.Add(this.MinimizeBtn);
            this.Titlebar.Controls.Add(this.CloseBtn);
            this.Titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titlebar.Location = new System.Drawing.Point(0, 0);
            this.Titlebar.Name = "Titlebar";
            this.Titlebar.Size = new System.Drawing.Size(574, 37);
            this.Titlebar.TabIndex = 0;
            this.Titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(12, 8);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(174, 21);
            this.Title.TabIndex = 4;
            this.Title.Text = "Temperature Control";
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.MinimizeBtn.Location = new System.Drawing.Point(491, 0);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(41, 37);
            this.MinimizeBtn.TabIndex = 3;
            this.MinimizeBtn.Text = "_";
            this.MinimizeBtn.UseVisualStyleBackColor = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseBtn.Location = new System.Drawing.Point(533, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(41, 37);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(122)))), ((int)(((byte)(95)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 13);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // GaugeTitl
            // 
            this.GaugeTitl.AutoSize = true;
            this.GaugeTitl.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GaugeTitl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GaugeTitl.Location = new System.Drawing.Point(36, 40);
            this.GaugeTitl.Name = "GaugeTitl";
            this.GaugeTitl.Size = new System.Drawing.Size(140, 23);
            this.GaugeTitl.TabIndex = 4;
            this.GaugeTitl.Text = "TEMPERATURE";
            // 
            // TempLabel
            // 
            this.TempLabel.AutoSize = true;
            this.TempLabel.Font = new System.Drawing.Font("Hack", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempLabel.ForeColor = System.Drawing.Color.Crimson;
            this.TempLabel.Location = new System.Drawing.Point(388, 65);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(74, 38);
            this.TempLabel.TabIndex = 5;
            this.TempLabel.Text = "0ºC";
            // 
            // comPortList
            // 
            this.comPortList.FormattingEnabled = true;
            this.comPortList.Location = new System.Drawing.Point(329, 186);
            this.comPortList.Name = "comPortList";
            this.comPortList.Size = new System.Drawing.Size(189, 29);
            this.comPortList.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "COM PORT:";
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.ForeColor = System.Drawing.Color.Crimson;
            this.StateLabel.Location = new System.Drawing.Point(352, 267);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(137, 21);
            this.StateLabel.TabIndex = 8;
            this.StateLabel.Text = "DISCONNECTED";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.ConnectBtn.FlatAppearance.BorderSize = 0;
            this.ConnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectBtn.Location = new System.Drawing.Point(329, 228);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(188, 36);
            this.ConnectBtn.TabIndex = 9;
            this.ConnectBtn.Text = "CONNECT";
            this.ConnectBtn.UseVisualStyleBackColor = false;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // TempMeter
            // 
            this.TempMeter.BaseArcColor = System.Drawing.Color.White;
            this.TempMeter.BaseArcRadius = 80;
            this.TempMeter.BaseArcStart = 135;
            this.TempMeter.BaseArcSweep = 270;
            this.TempMeter.BaseArcWidth = 2;
            this.TempMeter.GaugeAutoSize = true;
            this.TempMeter.Location = new System.Drawing.Point(0, 93);
            this.TempMeter.MaxValue = 100F;
            this.TempMeter.MinValue = -100F;
            this.TempMeter.Name = "TempMeter";
            this.TempMeter.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.TempMeter.NeedleColor2 = System.Drawing.Color.White;
            this.TempMeter.NeedleRadius = 80;
            this.TempMeter.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.TempMeter.NeedleWidth = 1;
            this.TempMeter.ScaleLinesInterColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.TempMeter.ScaleLinesInterInnerRadius = 73;
            this.TempMeter.ScaleLinesInterOuterRadius = 80;
            this.TempMeter.ScaleLinesInterWidth = 1;
            this.TempMeter.ScaleLinesMajorColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.TempMeter.ScaleLinesMajorInnerRadius = 70;
            this.TempMeter.ScaleLinesMajorOuterRadius = 80;
            this.TempMeter.ScaleLinesMajorStepValue = 50F;
            this.TempMeter.ScaleLinesMajorWidth = 2;
            this.TempMeter.ScaleLinesMinorColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.TempMeter.ScaleLinesMinorInnerRadius = 75;
            this.TempMeter.ScaleLinesMinorOuterRadius = 80;
            this.TempMeter.ScaleLinesMinorTicks = 9;
            this.TempMeter.ScaleLinesMinorWidth = 1;
            this.TempMeter.ScaleNumbersColor = System.Drawing.Color.WhiteSmoke;
            this.TempMeter.ScaleNumbersFormat = null;
            this.TempMeter.ScaleNumbersRadius = 95;
            this.TempMeter.ScaleNumbersRotation = 0;
            this.TempMeter.ScaleNumbersStartScaleLine = 0;
            this.TempMeter.ScaleNumbersStepScaleLines = 1;
            this.TempMeter.Size = new System.Drawing.Size(323, 240);
            this.TempMeter.TabIndex = 10;
            this.TempMeter.Text = "aGauge1";
            this.TempMeter.Value = 17F;
            // 
            // Principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(574, 352);
            this.Controls.Add(this.TempMeter);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comPortList);
            this.Controls.Add(this.TempLabel);
            this.Controls.Add(this.GaugeTitl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Titlebar);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            this.Titlebar.ResumeLayout(false);
            this.Titlebar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Titlebar;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label GaugeTitl;
        private System.Windows.Forms.Label TempLabel;
        private System.Windows.Forms.ComboBox comPortList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Button ConnectBtn;
        private System.IO.Ports.SerialPort ArduinoPort;
        private System.Windows.Forms.AGauge TempMeter;
    }
}

