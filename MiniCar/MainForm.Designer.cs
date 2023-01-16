namespace MiniCar
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelWarning = new System.Windows.Forms.Label();
            this.labelDistanceHeader = new System.Windows.Forms.Label();
            this.panelSensorLeft = new System.Windows.Forms.Panel();
            this.panelSensorMiddle = new System.Windows.Forms.Panel();
            this.panelSensorRight = new System.Windows.Forms.Panel();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.labelSpeedHeader = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelSpacer2 = new System.Windows.Forms.Panel();
            this.miniMap = new MiniCar.MiniMap();
            this.panelSpacer1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDistance = new System.Windows.Forms.Label();
            this.videoFeed = new MiniCar.VideoFeed();
            this.colorTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.panelRight.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWarning
            // 
            this.labelWarning.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelWarning.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarning.ForeColor = System.Drawing.Color.Red;
            this.labelWarning.Location = new System.Drawing.Point(0, 0);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(151, 49);
            this.labelWarning.TabIndex = 2;
            this.labelWarning.Text = "WARNUNG!";
            this.labelWarning.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelWarning.Visible = false;
            // 
            // labelDistanceHeader
            // 
            this.labelDistanceHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDistanceHeader.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistanceHeader.Location = new System.Drawing.Point(0, 49);
            this.labelDistanceHeader.Name = "labelDistanceHeader";
            this.labelDistanceHeader.Size = new System.Drawing.Size(151, 45);
            this.labelDistanceHeader.TabIndex = 3;
            this.labelDistanceHeader.Text = "Distanz";
            this.labelDistanceHeader.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panelSensorLeft
            // 
            this.panelSensorLeft.BackColor = System.Drawing.Color.Gray;
            this.panelSensorLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSensorLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSensorLeft.ForeColor = System.Drawing.Color.Snow;
            this.panelSensorLeft.Location = new System.Drawing.Point(3, 3);
            this.panelSensorLeft.Name = "panelSensorLeft";
            this.panelSensorLeft.Size = new System.Drawing.Size(44, 40);
            this.panelSensorLeft.TabIndex = 5;
            // 
            // panelSensorMiddle
            // 
            this.panelSensorMiddle.BackColor = System.Drawing.Color.Gray;
            this.panelSensorMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSensorMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSensorMiddle.Location = new System.Drawing.Point(53, 3);
            this.panelSensorMiddle.Name = "panelSensorMiddle";
            this.panelSensorMiddle.Size = new System.Drawing.Size(44, 40);
            this.panelSensorMiddle.TabIndex = 6;
            // 
            // panelSensorRight
            // 
            this.panelSensorRight.BackColor = System.Drawing.Color.Gray;
            this.panelSensorRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSensorRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSensorRight.Location = new System.Drawing.Point(103, 3);
            this.panelSensorRight.Name = "panelSensorRight";
            this.panelSensorRight.Size = new System.Drawing.Size(45, 40);
            this.panelSensorRight.TabIndex = 7;
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBarSpeed.Location = new System.Drawing.Point(0, 180);
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(151, 45);
            this.trackBarSpeed.TabIndex = 8;
            // 
            // labelSpeedHeader
            // 
            this.labelSpeedHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSpeedHeader.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeedHeader.Location = new System.Drawing.Point(0, 135);
            this.labelSpeedHeader.Name = "labelSpeedHeader";
            this.labelSpeedHeader.Size = new System.Drawing.Size(151, 45);
            this.labelSpeedHeader.TabIndex = 9;
            this.labelSpeedHeader.Text = "Geschwindigkeit";
            this.labelSpeedHeader.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.panelSpacer2);
            this.panelRight.Controls.Add(this.miniMap);
            this.panelRight.Controls.Add(this.panelSpacer1);
            this.panelRight.Controls.Add(this.tableLayoutPanel1);
            this.panelRight.Controls.Add(this.trackBarSpeed);
            this.panelRight.Controls.Add(this.labelSpeedHeader);
            this.panelRight.Controls.Add(this.labelDistance);
            this.panelRight.Controls.Add(this.labelDistanceHeader);
            this.panelRight.Controls.Add(this.labelWarning);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(666, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panelRight.Size = new System.Drawing.Size(161, 505);
            this.panelRight.TabIndex = 10;
            // 
            // panelSpacer2
            // 
            this.panelSpacer2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSpacer2.Location = new System.Drawing.Point(0, 492);
            this.panelSpacer2.Name = "panelSpacer2";
            this.panelSpacer2.Size = new System.Drawing.Size(151, 13);
            this.panelSpacer2.TabIndex = 13;
            // 
            // miniMap
            // 
            this.miniMap.BackColor = System.Drawing.Color.White;
            this.miniMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.miniMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.miniMap.Location = new System.Drawing.Point(0, 293);
            this.miniMap.Name = "miniMap";
            this.miniMap.Size = new System.Drawing.Size(151, 212);
            this.miniMap.TabIndex = 0;
            // 
            // panelSpacer1
            // 
            this.panelSpacer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSpacer1.Location = new System.Drawing.Point(0, 271);
            this.panelSpacer1.Name = "panelSpacer1";
            this.panelSpacer1.Size = new System.Drawing.Size(151, 22);
            this.panelSpacer1.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.panelSensorLeft, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelSensorMiddle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelSensorRight, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 225);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(151, 46);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // labelDistance
            // 
            this.labelDistance.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDistance.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistance.Location = new System.Drawing.Point(0, 94);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(151, 41);
            this.labelDistance.TabIndex = 10;
            this.labelDistance.Text = "? cm";
            this.labelDistance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // videoFeed
            // 
            this.videoFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.videoFeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.videoFeed.Location = new System.Drawing.Point(12, 14);
            this.videoFeed.Name = "videoFeed";
            this.videoFeed.Size = new System.Drawing.Size(640, 480);
            this.videoFeed.TabIndex = 1;
            // 
            // colorTimer
            // 
            this.colorTimer.Interval = 2000;
            this.colorTimer.Tick += new System.EventHandler(this.colorTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 505);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.videoFeed);
            this.Name = "MainForm";
            this.Text = "MiniCar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MiniMap miniMap;
        private VideoFeed videoFeed;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.Label labelDistanceHeader;
        private System.Windows.Forms.Panel panelSensorLeft;
        private System.Windows.Forms.Panel panelSensorMiddle;
        private System.Windows.Forms.Panel panelSensorRight;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label labelSpeedHeader;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Panel panelSpacer2;
        private System.Windows.Forms.Panel panelSpacer1;
        private System.Windows.Forms.Timer colorTimer;
    }
}

