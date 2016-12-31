namespace HMI_WindowsForms
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.XY_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.X_AxisPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y_AxisPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XY_TableChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FileOpenpictureBox = new System.Windows.Forms.PictureBox();
            this.FileSavePictureBox = new System.Windows.Forms.PictureBox();
            this.FileDownloadPictureBox = new System.Windows.Forms.PictureBox();
            this.RowDeletePictureBox = new System.Windows.Forms.PictureBox();
            this.McStopButton = new System.Windows.Forms.Button();
            this.Y_AxisPTPButton = new System.Windows.Forms.Button();
            this.ErrorResetButton = new System.Windows.Forms.Button();
            this.JogGroupBox = new System.Windows.Forms.GroupBox();
            this.X_AxisRightButton = new System.Windows.Forms.Button();
            this.X_AxisLeftButton = new System.Windows.Forms.Button();
            this.Y_AxisDownButton = new System.Windows.Forms.Button();
            this.Y_AxisUpButton = new System.Windows.Forms.Button();
            this.PTPGroupBox = new System.Windows.Forms.GroupBox();
            this.X_AxisPositionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.X_AxisVelocityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Y_AxisPositionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Y_AxisVelocityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Y_AxisVelocityLabel = new System.Windows.Forms.Label();
            this.Y_AxisPositionLabel = new System.Windows.Forms.Label();
            this.X_AxisVelocityLabel = new System.Windows.Forms.Label();
            this.X_AxisPositionLabel = new System.Windows.Forms.Label();
            this.X_AxisPTPButton = new System.Windows.Forms.Button();
            this.AutoRUNGroupBox = new System.Windows.Forms.GroupBox();
            this.AutoRunningPictureBox = new System.Windows.Forms.PictureBox();
            this.PointReadedPictureBox = new System.Windows.Forms.PictureBox();
            this.PointReadButton = new System.Windows.Forms.Button();
            this.AutoRunButton = new System.Windows.Forms.Button();
            this.HomedPictureBox = new System.Windows.Forms.PictureBox();
            this.HomeSearchButton = new System.Windows.Forms.Button();
            this.AutoRunVelocityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AutoRunVelocityLabel = new System.Windows.Forms.Label();
            this.X_AxisCurrentPositionTextBox = new System.Windows.Forms.TextBox();
            this.X_AxisCurrentPositionLabel = new System.Windows.Forms.Label();
            this.X_AxisCurrentVelocityLabel = new System.Windows.Forms.Label();
            this.X_AxisCurrentVelocityTextBox = new System.Windows.Forms.TextBox();
            this.Y_AxisCurrentVelocityLabel = new System.Windows.Forms.Label();
            this.Y_AxisCurrentVelocityTextBox = new System.Windows.Forms.TextBox();
            this.Y_AxisCurrentPostionLabel = new System.Windows.Forms.Label();
            this.Y_AxisCurrentPositionTextBox = new System.Windows.Forms.TextBox();
            this.ErrorPictureBox = new System.Windows.Forms.PictureBox();
            this.ButtonOnePulseTimer = new System.Windows.Forms.Timer(this.components);
            this.RowDeleteLabel = new System.Windows.Forms.Label();
            this.DataExchangeTimer = new System.Windows.Forms.Timer(this.components);
            this.ShowCurrentValueFormButton = new System.Windows.Forms.Button();
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ConnectServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BreakServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.XY_TableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XY_TableChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileOpenpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileSavePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileDownloadPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowDeletePictureBox)).BeginInit();
            this.JogGroupBox.SuspendLayout();
            this.PTPGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.X_AxisPositionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_AxisVelocityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_AxisPositionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_AxisVelocityNumericUpDown)).BeginInit();
            this.AutoRUNGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoRunningPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointReadedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoRunVelocityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPictureBox)).BeginInit();
            this.MainFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // XY_TableDataGridView
            // 
            this.XY_TableDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.XY_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.XY_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X_AxisPoint,
            this.Y_AxisPoint});
            this.XY_TableDataGridView.Location = new System.Drawing.Point(12, 38);
            this.XY_TableDataGridView.MultiSelect = false;
            this.XY_TableDataGridView.Name = "XY_TableDataGridView";
            this.XY_TableDataGridView.RowHeadersWidth = 4;
            this.XY_TableDataGridView.RowTemplate.Height = 24;
            this.XY_TableDataGridView.Size = new System.Drawing.Size(216, 282);
            this.XY_TableDataGridView.TabIndex = 1;
            this.XY_TableDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.XY_TableDataGridView_RowEnter);
            // 
            // X_AxisPoint
            // 
            this.X_AxisPoint.HeaderText = "X Axis座標點位";
            this.X_AxisPoint.MinimumWidth = 10;
            this.X_AxisPoint.Name = "X_AxisPoint";
            // 
            // Y_AxisPoint
            // 
            this.Y_AxisPoint.HeaderText = "Y_Axis座標點位";
            this.Y_AxisPoint.Name = "Y_AxisPoint";
            // 
            // XY_TableChart
            // 
            chartArea1.AxisX.Maximum = 250D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 250D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.XY_TableChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.XY_TableChart.Legends.Add(legend1);
            this.XY_TableChart.Location = new System.Drawing.Point(262, 38);
            this.XY_TableChart.Name = "XY_TableChart";
            this.XY_TableChart.Size = new System.Drawing.Size(420, 348);
            this.XY_TableChart.TabIndex = 2;
            this.XY_TableChart.Text = "chart1";
            // 
            // FileOpenpictureBox
            // 
            this.FileOpenpictureBox.BackgroundImage = global::HMI_WindowsForms.Properties.Resources.Image_FileOpen;
            this.FileOpenpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FileOpenpictureBox.Location = new System.Drawing.Point(717, 45);
            this.FileOpenpictureBox.Name = "FileOpenpictureBox";
            this.FileOpenpictureBox.Size = new System.Drawing.Size(90, 90);
            this.FileOpenpictureBox.TabIndex = 4;
            this.FileOpenpictureBox.TabStop = false;
            this.FileOpenpictureBox.Click += new System.EventHandler(this.FileOpenpictureBox_Click);
            // 
            // FileSavePictureBox
            // 
            this.FileSavePictureBox.BackgroundImage = global::HMI_WindowsForms.Properties.Resources.Image_FileSave;
            this.FileSavePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FileSavePictureBox.Location = new System.Drawing.Point(717, 163);
            this.FileSavePictureBox.Name = "FileSavePictureBox";
            this.FileSavePictureBox.Size = new System.Drawing.Size(90, 90);
            this.FileSavePictureBox.TabIndex = 5;
            this.FileSavePictureBox.TabStop = false;
            this.FileSavePictureBox.Click += new System.EventHandler(this.FileSavePictureBox_Click);
            // 
            // FileDownloadPictureBox
            // 
            this.FileDownloadPictureBox.BackgroundImage = global::HMI_WindowsForms.Properties.Resources.Image_FileDownload;
            this.FileDownloadPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FileDownloadPictureBox.Location = new System.Drawing.Point(717, 280);
            this.FileDownloadPictureBox.Name = "FileDownloadPictureBox";
            this.FileDownloadPictureBox.Size = new System.Drawing.Size(90, 90);
            this.FileDownloadPictureBox.TabIndex = 6;
            this.FileDownloadPictureBox.TabStop = false;
            this.FileDownloadPictureBox.Click += new System.EventHandler(this.FileDownloadPictureBox_Click);
            // 
            // RowDeletePictureBox
            // 
            this.RowDeletePictureBox.BackgroundImage = global::HMI_WindowsForms.Properties.Resources.Image_RowDelete;
            this.RowDeletePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RowDeletePictureBox.Location = new System.Drawing.Point(20, 340);
            this.RowDeletePictureBox.Name = "RowDeletePictureBox";
            this.RowDeletePictureBox.Size = new System.Drawing.Size(120, 60);
            this.RowDeletePictureBox.TabIndex = 7;
            this.RowDeletePictureBox.TabStop = false;
            this.RowDeletePictureBox.Click += new System.EventHandler(this.RowDeletePictureBox_Click);
            // 
            // McStopButton
            // 
            this.McStopButton.BackColor = System.Drawing.Color.Gray;
            this.McStopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.McStopButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.McStopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.McStopButton.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.McStopButton.Location = new System.Drawing.Point(9, 251);
            this.McStopButton.Name = "McStopButton";
            this.McStopButton.Size = new System.Drawing.Size(166, 63);
            this.McStopButton.TabIndex = 16;
            this.McStopButton.Text = "動作停止";
            this.McStopButton.UseVisualStyleBackColor = false;
            this.McStopButton.Click += new System.EventHandler(this.McStopButton_Click);
            // 
            // Y_AxisPTPButton
            // 
            this.Y_AxisPTPButton.BackColor = System.Drawing.Color.Gray;
            this.Y_AxisPTPButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Y_AxisPTPButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Y_AxisPTPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Y_AxisPTPButton.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Y_AxisPTPButton.Location = new System.Drawing.Point(232, 115);
            this.Y_AxisPTPButton.Name = "Y_AxisPTPButton";
            this.Y_AxisPTPButton.Size = new System.Drawing.Size(95, 63);
            this.Y_AxisPTPButton.TabIndex = 19;
            this.Y_AxisPTPButton.Text = "Y軸\r\nPTP移動";
            this.Y_AxisPTPButton.UseVisualStyleBackColor = false;
            this.Y_AxisPTPButton.Click += new System.EventHandler(this.Y_AxisPTPButton_Click);
            // 
            // ErrorResetButton
            // 
            this.ErrorResetButton.BackColor = System.Drawing.Color.Red;
            this.ErrorResetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ErrorResetButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ErrorResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ErrorResetButton.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ErrorResetButton.Location = new System.Drawing.Point(12, 610);
            this.ErrorResetButton.Name = "ErrorResetButton";
            this.ErrorResetButton.Size = new System.Drawing.Size(115, 116);
            this.ErrorResetButton.TabIndex = 20;
            this.ErrorResetButton.Text = "異常復歸";
            this.ErrorResetButton.UseVisualStyleBackColor = false;
            this.ErrorResetButton.Click += new System.EventHandler(this.ErrorResetButton_Click);
            // 
            // JogGroupBox
            // 
            this.JogGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.JogGroupBox.Controls.Add(this.X_AxisRightButton);
            this.JogGroupBox.Controls.Add(this.X_AxisLeftButton);
            this.JogGroupBox.Controls.Add(this.Y_AxisDownButton);
            this.JogGroupBox.Controls.Add(this.Y_AxisUpButton);
            this.JogGroupBox.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.JogGroupBox.Location = new System.Drawing.Point(12, 404);
            this.JogGroupBox.Name = "JogGroupBox";
            this.JogGroupBox.Size = new System.Drawing.Size(267, 200);
            this.JogGroupBox.TabIndex = 21;
            this.JogGroupBox.TabStop = false;
            this.JogGroupBox.Text = "伺服馬達JOG運動";
            // 
            // X_AxisRightButton
            // 
            this.X_AxisRightButton.Image = global::HMI_WindowsForms.Properties.Resources.Image_Right;
            this.X_AxisRightButton.Location = new System.Drawing.Point(185, 66);
            this.X_AxisRightButton.Name = "X_AxisRightButton";
            this.X_AxisRightButton.Size = new System.Drawing.Size(70, 70);
            this.X_AxisRightButton.TabIndex = 17;
            this.X_AxisRightButton.UseVisualStyleBackColor = true;
            this.X_AxisRightButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.X_AxisRightButton_MouseDown);
            this.X_AxisRightButton.MouseLeave += new System.EventHandler(this.X_AxisRightButton_MouseLeave);
            this.X_AxisRightButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.X_AxisRightButton_MouseUp);
            // 
            // X_AxisLeftButton
            // 
            this.X_AxisLeftButton.Image = global::HMI_WindowsForms.Properties.Resources.Image_Left;
            this.X_AxisLeftButton.Location = new System.Drawing.Point(11, 66);
            this.X_AxisLeftButton.Name = "X_AxisLeftButton";
            this.X_AxisLeftButton.Size = new System.Drawing.Size(70, 70);
            this.X_AxisLeftButton.TabIndex = 16;
            this.X_AxisLeftButton.UseVisualStyleBackColor = true;
            this.X_AxisLeftButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.X_AxisLeftButton_MouseDown);
            this.X_AxisLeftButton.MouseLeave += new System.EventHandler(this.X_AxisLeftButton_MouseLeave);
            this.X_AxisLeftButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.X_AxisLeftButton_MouseUp);
            // 
            // Y_AxisDownButton
            // 
            this.Y_AxisDownButton.Image = global::HMI_WindowsForms.Properties.Resources.Image_Down;
            this.Y_AxisDownButton.Location = new System.Drawing.Point(98, 116);
            this.Y_AxisDownButton.Name = "Y_AxisDownButton";
            this.Y_AxisDownButton.Size = new System.Drawing.Size(70, 70);
            this.Y_AxisDownButton.TabIndex = 15;
            this.Y_AxisDownButton.UseVisualStyleBackColor = true;
            this.Y_AxisDownButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Y_AxisDownButton_MouseDown);
            this.Y_AxisDownButton.MouseLeave += new System.EventHandler(this.Y_AxisDownButton_MouseLeave);
            this.Y_AxisDownButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Y_AxisDownButton_MouseUp);
            // 
            // Y_AxisUpButton
            // 
            this.Y_AxisUpButton.Image = global::HMI_WindowsForms.Properties.Resources.Image_Up;
            this.Y_AxisUpButton.Location = new System.Drawing.Point(98, 27);
            this.Y_AxisUpButton.Name = "Y_AxisUpButton";
            this.Y_AxisUpButton.Size = new System.Drawing.Size(70, 70);
            this.Y_AxisUpButton.TabIndex = 14;
            this.Y_AxisUpButton.UseVisualStyleBackColor = true;
            this.Y_AxisUpButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Y_AxisUpButton_MouseDown);
            this.Y_AxisUpButton.MouseLeave += new System.EventHandler(this.Y_AxisUpButton_MouseLeave);
            this.Y_AxisUpButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Y_AxisUpButton_MouseUp);
            // 
            // PTPGroupBox
            // 
            this.PTPGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PTPGroupBox.Controls.Add(this.X_AxisPositionNumericUpDown);
            this.PTPGroupBox.Controls.Add(this.X_AxisVelocityNumericUpDown);
            this.PTPGroupBox.Controls.Add(this.Y_AxisPositionNumericUpDown);
            this.PTPGroupBox.Controls.Add(this.Y_AxisVelocityNumericUpDown);
            this.PTPGroupBox.Controls.Add(this.Y_AxisVelocityLabel);
            this.PTPGroupBox.Controls.Add(this.Y_AxisPositionLabel);
            this.PTPGroupBox.Controls.Add(this.X_AxisVelocityLabel);
            this.PTPGroupBox.Controls.Add(this.X_AxisPositionLabel);
            this.PTPGroupBox.Controls.Add(this.X_AxisPTPButton);
            this.PTPGroupBox.Controls.Add(this.Y_AxisPTPButton);
            this.PTPGroupBox.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PTPGroupBox.Location = new System.Drawing.Point(483, 532);
            this.PTPGroupBox.Name = "PTPGroupBox";
            this.PTPGroupBox.Size = new System.Drawing.Size(342, 194);
            this.PTPGroupBox.TabIndex = 22;
            this.PTPGroupBox.TabStop = false;
            this.PTPGroupBox.Text = "單動設定執行區塊";
            // 
            // X_AxisPositionNumericUpDown
            // 
            this.X_AxisPositionNumericUpDown.Location = new System.Drawing.Point(16, 67);
            this.X_AxisPositionNumericUpDown.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.X_AxisPositionNumericUpDown.Name = "X_AxisPositionNumericUpDown";
            this.X_AxisPositionNumericUpDown.Size = new System.Drawing.Size(77, 26);
            this.X_AxisPositionNumericUpDown.TabIndex = 28;
            // 
            // X_AxisVelocityNumericUpDown
            // 
            this.X_AxisVelocityNumericUpDown.Location = new System.Drawing.Point(124, 67);
            this.X_AxisVelocityNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.X_AxisVelocityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.X_AxisVelocityNumericUpDown.Name = "X_AxisVelocityNumericUpDown";
            this.X_AxisVelocityNumericUpDown.Size = new System.Drawing.Size(76, 26);
            this.X_AxisVelocityNumericUpDown.TabIndex = 27;
            this.X_AxisVelocityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Y_AxisPositionNumericUpDown
            // 
            this.Y_AxisPositionNumericUpDown.Location = new System.Drawing.Point(16, 151);
            this.Y_AxisPositionNumericUpDown.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.Y_AxisPositionNumericUpDown.Name = "Y_AxisPositionNumericUpDown";
            this.Y_AxisPositionNumericUpDown.Size = new System.Drawing.Size(77, 26);
            this.Y_AxisPositionNumericUpDown.TabIndex = 26;
            // 
            // Y_AxisVelocityNumericUpDown
            // 
            this.Y_AxisVelocityNumericUpDown.Location = new System.Drawing.Point(123, 151);
            this.Y_AxisVelocityNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Y_AxisVelocityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Y_AxisVelocityNumericUpDown.Name = "Y_AxisVelocityNumericUpDown";
            this.Y_AxisVelocityNumericUpDown.Size = new System.Drawing.Size(77, 26);
            this.Y_AxisVelocityNumericUpDown.TabIndex = 25;
            this.Y_AxisVelocityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Y_AxisVelocityLabel
            // 
            this.Y_AxisVelocityLabel.AutoSize = true;
            this.Y_AxisVelocityLabel.Location = new System.Drawing.Point(126, 119);
            this.Y_AxisVelocityLabel.Name = "Y_AxisVelocityLabel";
            this.Y_AxisVelocityLabel.Size = new System.Drawing.Size(71, 16);
            this.Y_AxisVelocityLabel.TabIndex = 24;
            this.Y_AxisVelocityLabel.Text = "Y軸速度";
            // 
            // Y_AxisPositionLabel
            // 
            this.Y_AxisPositionLabel.AutoSize = true;
            this.Y_AxisPositionLabel.Location = new System.Drawing.Point(22, 119);
            this.Y_AxisPositionLabel.Name = "Y_AxisPositionLabel";
            this.Y_AxisPositionLabel.Size = new System.Drawing.Size(71, 16);
            this.Y_AxisPositionLabel.TabIndex = 23;
            this.Y_AxisPositionLabel.Text = "Y軸位置";
            // 
            // X_AxisVelocityLabel
            // 
            this.X_AxisVelocityLabel.AutoSize = true;
            this.X_AxisVelocityLabel.Location = new System.Drawing.Point(126, 32);
            this.X_AxisVelocityLabel.Name = "X_AxisVelocityLabel";
            this.X_AxisVelocityLabel.Size = new System.Drawing.Size(71, 16);
            this.X_AxisVelocityLabel.TabIndex = 22;
            this.X_AxisVelocityLabel.Text = "X軸速度";
            // 
            // X_AxisPositionLabel
            // 
            this.X_AxisPositionLabel.AutoSize = true;
            this.X_AxisPositionLabel.Location = new System.Drawing.Point(20, 32);
            this.X_AxisPositionLabel.Name = "X_AxisPositionLabel";
            this.X_AxisPositionLabel.Size = new System.Drawing.Size(71, 16);
            this.X_AxisPositionLabel.TabIndex = 21;
            this.X_AxisPositionLabel.Text = "X軸位置";
            // 
            // X_AxisPTPButton
            // 
            this.X_AxisPTPButton.BackColor = System.Drawing.Color.Gray;
            this.X_AxisPTPButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.X_AxisPTPButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.X_AxisPTPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X_AxisPTPButton.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.X_AxisPTPButton.Location = new System.Drawing.Point(232, 30);
            this.X_AxisPTPButton.Name = "X_AxisPTPButton";
            this.X_AxisPTPButton.Size = new System.Drawing.Size(95, 63);
            this.X_AxisPTPButton.TabIndex = 20;
            this.X_AxisPTPButton.Text = "X軸\r\nPTP移動";
            this.X_AxisPTPButton.UseVisualStyleBackColor = false;
            this.X_AxisPTPButton.Click += new System.EventHandler(this.X_AxisPTPButton_Click);
            // 
            // AutoRUNGroupBox
            // 
            this.AutoRUNGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AutoRUNGroupBox.Controls.Add(this.AutoRunningPictureBox);
            this.AutoRUNGroupBox.Controls.Add(this.PointReadedPictureBox);
            this.AutoRUNGroupBox.Controls.Add(this.PointReadButton);
            this.AutoRUNGroupBox.Controls.Add(this.AutoRunButton);
            this.AutoRUNGroupBox.Controls.Add(this.McStopButton);
            this.AutoRUNGroupBox.Controls.Add(this.HomedPictureBox);
            this.AutoRUNGroupBox.Controls.Add(this.HomeSearchButton);
            this.AutoRUNGroupBox.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AutoRUNGroupBox.Location = new System.Drawing.Point(290, 404);
            this.AutoRUNGroupBox.Name = "AutoRUNGroupBox";
            this.AutoRUNGroupBox.Size = new System.Drawing.Size(182, 322);
            this.AutoRUNGroupBox.TabIndex = 23;
            this.AutoRUNGroupBox.TabStop = false;
            this.AutoRUNGroupBox.Text = "流程區塊";
            // 
            // AutoRunningPictureBox
            // 
            this.AutoRunningPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AutoRunningPictureBox.Image = global::HMI_WindowsForms.Properties.Resources.Image_OFF;
            this.AutoRunningPictureBox.Location = new System.Drawing.Point(115, 185);
            this.AutoRunningPictureBox.Name = "AutoRunningPictureBox";
            this.AutoRunningPictureBox.Size = new System.Drawing.Size(60, 60);
            this.AutoRunningPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AutoRunningPictureBox.TabIndex = 25;
            this.AutoRunningPictureBox.TabStop = false;
            // 
            // PointReadedPictureBox
            // 
            this.PointReadedPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PointReadedPictureBox.Image = global::HMI_WindowsForms.Properties.Resources.Image_OFF;
            this.PointReadedPictureBox.Location = new System.Drawing.Point(115, 105);
            this.PointReadedPictureBox.Name = "PointReadedPictureBox";
            this.PointReadedPictureBox.Size = new System.Drawing.Size(60, 60);
            this.PointReadedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PointReadedPictureBox.TabIndex = 26;
            this.PointReadedPictureBox.TabStop = false;
            // 
            // PointReadButton
            // 
            this.PointReadButton.BackColor = System.Drawing.Color.Gray;
            this.PointReadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PointReadButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PointReadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PointReadButton.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PointReadButton.Location = new System.Drawing.Point(9, 104);
            this.PointReadButton.Name = "PointReadButton";
            this.PointReadButton.Size = new System.Drawing.Size(95, 63);
            this.PointReadButton.TabIndex = 20;
            this.PointReadButton.Text = "流程準備";
            this.PointReadButton.UseVisualStyleBackColor = false;
            this.PointReadButton.Click += new System.EventHandler(this.PointReadButton_Click);
            // 
            // AutoRunButton
            // 
            this.AutoRunButton.BackColor = System.Drawing.Color.Gray;
            this.AutoRunButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AutoRunButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AutoRunButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoRunButton.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AutoRunButton.Location = new System.Drawing.Point(8, 182);
            this.AutoRunButton.Name = "AutoRunButton";
            this.AutoRunButton.Size = new System.Drawing.Size(95, 63);
            this.AutoRunButton.TabIndex = 19;
            this.AutoRunButton.Text = "流程啟動";
            this.AutoRunButton.UseVisualStyleBackColor = false;
            this.AutoRunButton.Click += new System.EventHandler(this.AutoRunButton_Click);
            // 
            // HomedPictureBox
            // 
            this.HomedPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HomedPictureBox.Image = global::HMI_WindowsForms.Properties.Resources.Image_OFF;
            this.HomedPictureBox.Location = new System.Drawing.Point(115, 29);
            this.HomedPictureBox.Name = "HomedPictureBox";
            this.HomedPictureBox.Size = new System.Drawing.Size(60, 60);
            this.HomedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomedPictureBox.TabIndex = 24;
            this.HomedPictureBox.TabStop = false;
            // 
            // HomeSearchButton
            // 
            this.HomeSearchButton.BackColor = System.Drawing.Color.Gray;
            this.HomeSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HomeSearchButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.HomeSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeSearchButton.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HomeSearchButton.Location = new System.Drawing.Point(9, 27);
            this.HomeSearchButton.Name = "HomeSearchButton";
            this.HomeSearchButton.Size = new System.Drawing.Size(95, 63);
            this.HomeSearchButton.TabIndex = 18;
            this.HomeSearchButton.Text = "原點復歸";
            this.HomeSearchButton.UseVisualStyleBackColor = false;
            this.HomeSearchButton.Click += new System.EventHandler(this.HomeSearchButton_Click);
            // 
            // AutoRunVelocityNumericUpDown
            // 
            this.AutoRunVelocityNumericUpDown.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AutoRunVelocityNumericUpDown.Location = new System.Drawing.Point(149, 664);
            this.AutoRunVelocityNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.AutoRunVelocityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AutoRunVelocityNumericUpDown.Name = "AutoRunVelocityNumericUpDown";
            this.AutoRunVelocityNumericUpDown.Size = new System.Drawing.Size(115, 46);
            this.AutoRunVelocityNumericUpDown.TabIndex = 30;
            this.AutoRunVelocityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AutoRunVelocityLabel
            // 
            this.AutoRunVelocityLabel.AutoSize = true;
            this.AutoRunVelocityLabel.BackColor = System.Drawing.Color.Transparent;
            this.AutoRunVelocityLabel.Font = new System.Drawing.Font("黑体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AutoRunVelocityLabel.Location = new System.Drawing.Point(134, 631);
            this.AutoRunVelocityLabel.Name = "AutoRunVelocityLabel";
            this.AutoRunVelocityLabel.Size = new System.Drawing.Size(148, 22);
            this.AutoRunVelocityLabel.TabIndex = 29;
            this.AutoRunVelocityLabel.Text = "流程速度設定";
            // 
            // X_AxisCurrentPositionTextBox
            // 
            this.X_AxisCurrentPositionTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.X_AxisCurrentPositionTextBox.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.X_AxisCurrentPositionTextBox.ForeColor = System.Drawing.Color.Lime;
            this.X_AxisCurrentPositionTextBox.Location = new System.Drawing.Point(490, 414);
            this.X_AxisCurrentPositionTextBox.Name = "X_AxisCurrentPositionTextBox";
            this.X_AxisCurrentPositionTextBox.ReadOnly = true;
            this.X_AxisCurrentPositionTextBox.Size = new System.Drawing.Size(104, 44);
            this.X_AxisCurrentPositionTextBox.TabIndex = 31;
            // 
            // X_AxisCurrentPositionLabel
            // 
            this.X_AxisCurrentPositionLabel.AutoSize = true;
            this.X_AxisCurrentPositionLabel.BackColor = System.Drawing.Color.Transparent;
            this.X_AxisCurrentPositionLabel.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.X_AxisCurrentPositionLabel.Location = new System.Drawing.Point(481, 395);
            this.X_AxisCurrentPositionLabel.Name = "X_AxisCurrentPositionLabel";
            this.X_AxisCurrentPositionLabel.Size = new System.Drawing.Size(122, 16);
            this.X_AxisCurrentPositionLabel.TabIndex = 32;
            this.X_AxisCurrentPositionLabel.Text = "X軸位置現在值";
            // 
            // X_AxisCurrentVelocityLabel
            // 
            this.X_AxisCurrentVelocityLabel.AutoSize = true;
            this.X_AxisCurrentVelocityLabel.BackColor = System.Drawing.Color.Transparent;
            this.X_AxisCurrentVelocityLabel.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.X_AxisCurrentVelocityLabel.Location = new System.Drawing.Point(482, 462);
            this.X_AxisCurrentVelocityLabel.Name = "X_AxisCurrentVelocityLabel";
            this.X_AxisCurrentVelocityLabel.Size = new System.Drawing.Size(122, 16);
            this.X_AxisCurrentVelocityLabel.TabIndex = 34;
            this.X_AxisCurrentVelocityLabel.Text = "X軸速度現在值";
            // 
            // X_AxisCurrentVelocityTextBox
            // 
            this.X_AxisCurrentVelocityTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.X_AxisCurrentVelocityTextBox.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.X_AxisCurrentVelocityTextBox.ForeColor = System.Drawing.Color.Lime;
            this.X_AxisCurrentVelocityTextBox.Location = new System.Drawing.Point(490, 481);
            this.X_AxisCurrentVelocityTextBox.Name = "X_AxisCurrentVelocityTextBox";
            this.X_AxisCurrentVelocityTextBox.ReadOnly = true;
            this.X_AxisCurrentVelocityTextBox.Size = new System.Drawing.Size(104, 44);
            this.X_AxisCurrentVelocityTextBox.TabIndex = 33;
            // 
            // Y_AxisCurrentVelocityLabel
            // 
            this.Y_AxisCurrentVelocityLabel.AutoSize = true;
            this.Y_AxisCurrentVelocityLabel.BackColor = System.Drawing.Color.Transparent;
            this.Y_AxisCurrentVelocityLabel.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Y_AxisCurrentVelocityLabel.Location = new System.Drawing.Point(630, 461);
            this.Y_AxisCurrentVelocityLabel.Name = "Y_AxisCurrentVelocityLabel";
            this.Y_AxisCurrentVelocityLabel.Size = new System.Drawing.Size(122, 16);
            this.Y_AxisCurrentVelocityLabel.TabIndex = 38;
            this.Y_AxisCurrentVelocityLabel.Text = "Y軸速度現在值";
            // 
            // Y_AxisCurrentVelocityTextBox
            // 
            this.Y_AxisCurrentVelocityTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.Y_AxisCurrentVelocityTextBox.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Y_AxisCurrentVelocityTextBox.ForeColor = System.Drawing.Color.Lime;
            this.Y_AxisCurrentVelocityTextBox.Location = new System.Drawing.Point(640, 480);
            this.Y_AxisCurrentVelocityTextBox.Name = "Y_AxisCurrentVelocityTextBox";
            this.Y_AxisCurrentVelocityTextBox.ReadOnly = true;
            this.Y_AxisCurrentVelocityTextBox.Size = new System.Drawing.Size(104, 44);
            this.Y_AxisCurrentVelocityTextBox.TabIndex = 37;
            // 
            // Y_AxisCurrentPostionLabel
            // 
            this.Y_AxisCurrentPostionLabel.AutoSize = true;
            this.Y_AxisCurrentPostionLabel.BackColor = System.Drawing.Color.Transparent;
            this.Y_AxisCurrentPostionLabel.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Y_AxisCurrentPostionLabel.Location = new System.Drawing.Point(630, 394);
            this.Y_AxisCurrentPostionLabel.Name = "Y_AxisCurrentPostionLabel";
            this.Y_AxisCurrentPostionLabel.Size = new System.Drawing.Size(122, 16);
            this.Y_AxisCurrentPostionLabel.TabIndex = 36;
            this.Y_AxisCurrentPostionLabel.Text = "Y軸位置現在值";
            // 
            // Y_AxisCurrentPositionTextBox
            // 
            this.Y_AxisCurrentPositionTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.Y_AxisCurrentPositionTextBox.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Y_AxisCurrentPositionTextBox.ForeColor = System.Drawing.Color.Lime;
            this.Y_AxisCurrentPositionTextBox.Location = new System.Drawing.Point(640, 413);
            this.Y_AxisCurrentPositionTextBox.Name = "Y_AxisCurrentPositionTextBox";
            this.Y_AxisCurrentPositionTextBox.ReadOnly = true;
            this.Y_AxisCurrentPositionTextBox.Size = new System.Drawing.Size(104, 44);
            this.Y_AxisCurrentPositionTextBox.TabIndex = 35;
            // 
            // ErrorPictureBox
            // 
            this.ErrorPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ErrorPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ErrorPictureBox.Location = new System.Drawing.Point(173, 327);
            this.ErrorPictureBox.Name = "ErrorPictureBox";
            this.ErrorPictureBox.Size = new System.Drawing.Size(70, 70);
            this.ErrorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ErrorPictureBox.TabIndex = 39;
            this.ErrorPictureBox.TabStop = false;
            // 
            // ButtonOnePulseTimer
            // 
            this.ButtonOnePulseTimer.Interval = 200;
            this.ButtonOnePulseTimer.Tick += new System.EventHandler(this.ButtonOnePulseTimer_Tick);
            // 
            // RowDeleteLabel
            // 
            this.RowDeleteLabel.AutoSize = true;
            this.RowDeleteLabel.BackColor = System.Drawing.Color.Transparent;
            this.RowDeleteLabel.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RowDeleteLabel.Location = new System.Drawing.Point(46, 322);
            this.RowDeleteLabel.Name = "RowDeleteLabel";
            this.RowDeleteLabel.Size = new System.Drawing.Size(76, 16);
            this.RowDeleteLabel.TabIndex = 40;
            this.RowDeleteLabel.Text = "刪除一列";
            // 
            // DataExchangeTimer
            // 
            this.DataExchangeTimer.Tick += new System.EventHandler(this.DataExchangeTimer_Tick);
            // 
            // ShowCurrentValueFormButton
            // 
            this.ShowCurrentValueFormButton.BackColor = System.Drawing.Color.Gray;
            this.ShowCurrentValueFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ShowCurrentValueFormButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ShowCurrentValueFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowCurrentValueFormButton.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ShowCurrentValueFormButton.ForeColor = System.Drawing.Color.Black;
            this.ShowCurrentValueFormButton.Location = new System.Drawing.Point(758, 395);
            this.ShowCurrentValueFormButton.Name = "ShowCurrentValueFormButton";
            this.ShowCurrentValueFormButton.Size = new System.Drawing.Size(69, 129);
            this.ShowCurrentValueFormButton.TabIndex = 41;
            this.ShowCurrentValueFormButton.Text = "即時動作視窗";
            this.ShowCurrentValueFormButton.UseVisualStyleBackColor = false;
            this.ShowCurrentValueFormButton.Click += new System.EventHandler(this.ShowCurrentValueFormButton_Click);
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.BackColor = System.Drawing.Color.Black;
            this.MainFormMenuStrip.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectServerToolStripMenuItem,
            this.BreakServerToolStripMenuItem});
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.Size = new System.Drawing.Size(834, 28);
            this.MainFormMenuStrip.TabIndex = 42;
            // 
            // ConnectServerToolStripMenuItem
            // 
            this.ConnectServerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ConnectServerToolStripMenuItem.Name = "ConnectServerToolStripMenuItem";
            this.ConnectServerToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.ConnectServerToolStripMenuItem.Text = "連線";
            this.ConnectServerToolStripMenuItem.Click += new System.EventHandler(this.ConnectServerToolStripMenuItem_Click);
            // 
            // BreakServerToolStripMenuItem
            // 
            this.BreakServerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.BreakServerToolStripMenuItem.Name = "BreakServerToolStripMenuItem";
            this.BreakServerToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.BreakServerToolStripMenuItem.Text = "離線";
            this.BreakServerToolStripMenuItem.Click += new System.EventHandler(this.BreakServerToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HMI_WindowsForms.Properties.Resources.Image0011;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 742);
            this.Controls.Add(this.ShowCurrentValueFormButton);
            this.Controls.Add(this.RowDeleteLabel);
            this.Controls.Add(this.ErrorPictureBox);
            this.Controls.Add(this.Y_AxisCurrentVelocityLabel);
            this.Controls.Add(this.Y_AxisCurrentVelocityTextBox);
            this.Controls.Add(this.Y_AxisCurrentPostionLabel);
            this.Controls.Add(this.Y_AxisCurrentPositionTextBox);
            this.Controls.Add(this.X_AxisCurrentVelocityLabel);
            this.Controls.Add(this.X_AxisCurrentVelocityTextBox);
            this.Controls.Add(this.X_AxisCurrentPositionLabel);
            this.Controls.Add(this.X_AxisCurrentPositionTextBox);
            this.Controls.Add(this.AutoRunVelocityNumericUpDown);
            this.Controls.Add(this.AutoRunVelocityLabel);
            this.Controls.Add(this.AutoRUNGroupBox);
            this.Controls.Add(this.PTPGroupBox);
            this.Controls.Add(this.JogGroupBox);
            this.Controls.Add(this.ErrorResetButton);
            this.Controls.Add(this.RowDeletePictureBox);
            this.Controls.Add(this.FileDownloadPictureBox);
            this.Controls.Add(this.FileSavePictureBox);
            this.Controls.Add(this.FileOpenpictureBox);
            this.Controls.Add(this.XY_TableChart);
            this.Controls.Add(this.XY_TableDataGridView);
            this.Controls.Add(this.MainFormMenuStrip);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainFormMenuStrip;
            this.Name = "MainForm";
            this.Text = "定位平台操作畫面";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.XY_TableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XY_TableChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileOpenpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileSavePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileDownloadPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowDeletePictureBox)).EndInit();
            this.JogGroupBox.ResumeLayout(false);
            this.PTPGroupBox.ResumeLayout(false);
            this.PTPGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.X_AxisPositionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_AxisVelocityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_AxisPositionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_AxisVelocityNumericUpDown)).EndInit();
            this.AutoRUNGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AutoRunningPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointReadedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoRunVelocityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPictureBox)).EndInit();
            this.MainFormMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView XY_TableDataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart XY_TableChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn X_AxisPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_AxisPoint;
        private System.Windows.Forms.PictureBox FileOpenpictureBox;
        private System.Windows.Forms.PictureBox FileSavePictureBox;
        private System.Windows.Forms.PictureBox FileDownloadPictureBox;
        private System.Windows.Forms.PictureBox RowDeletePictureBox;
        private System.Windows.Forms.Button McStopButton;
        private System.Windows.Forms.Button Y_AxisPTPButton;
        private System.Windows.Forms.Button ErrorResetButton;
        private System.Windows.Forms.GroupBox JogGroupBox;
        private System.Windows.Forms.Button X_AxisRightButton;
        private System.Windows.Forms.Button X_AxisLeftButton;
        private System.Windows.Forms.Button Y_AxisDownButton;
        private System.Windows.Forms.Button Y_AxisUpButton;
        private System.Windows.Forms.GroupBox PTPGroupBox;
        private System.Windows.Forms.Button X_AxisPTPButton;
        private System.Windows.Forms.GroupBox AutoRUNGroupBox;
        private System.Windows.Forms.Button PointReadButton;
        private System.Windows.Forms.Button AutoRunButton;
        private System.Windows.Forms.Button HomeSearchButton;
        private System.Windows.Forms.PictureBox HomedPictureBox;
        private System.Windows.Forms.PictureBox AutoRunningPictureBox;
        private System.Windows.Forms.PictureBox PointReadedPictureBox;
        private System.Windows.Forms.Label Y_AxisVelocityLabel;
        private System.Windows.Forms.Label Y_AxisPositionLabel;
        private System.Windows.Forms.Label X_AxisVelocityLabel;
        private System.Windows.Forms.Label X_AxisPositionLabel;
        private System.Windows.Forms.NumericUpDown X_AxisPositionNumericUpDown;
        private System.Windows.Forms.NumericUpDown X_AxisVelocityNumericUpDown;
        private System.Windows.Forms.NumericUpDown Y_AxisPositionNumericUpDown;
        private System.Windows.Forms.NumericUpDown Y_AxisVelocityNumericUpDown;
        private System.Windows.Forms.NumericUpDown AutoRunVelocityNumericUpDown;
        private System.Windows.Forms.Label AutoRunVelocityLabel;
        private System.Windows.Forms.TextBox X_AxisCurrentPositionTextBox;
        private System.Windows.Forms.Label X_AxisCurrentPositionLabel;
        private System.Windows.Forms.Label X_AxisCurrentVelocityLabel;
        private System.Windows.Forms.TextBox X_AxisCurrentVelocityTextBox;
        private System.Windows.Forms.Label Y_AxisCurrentVelocityLabel;
        private System.Windows.Forms.TextBox Y_AxisCurrentVelocityTextBox;
        private System.Windows.Forms.Label Y_AxisCurrentPostionLabel;
        private System.Windows.Forms.TextBox Y_AxisCurrentPositionTextBox;
        private System.Windows.Forms.PictureBox ErrorPictureBox;
        private System.Windows.Forms.Timer ButtonOnePulseTimer;
        private System.Windows.Forms.Label RowDeleteLabel;
        private System.Windows.Forms.Timer DataExchangeTimer;
        private System.Windows.Forms.Button ShowCurrentValueFormButton;
        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ConnectServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BreakServerToolStripMenuItem;
    }
}

