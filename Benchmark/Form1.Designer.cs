namespace Benchmark
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RAMDetailsText = new Label();
            projectTitle = new Label();
            panel1 = new Panel();
            CPUtestLabel = new Label();
            CPUperformingLabel = new Label();
            CPUTestResultLabel = new Label();
            CPUTestResult = new Label();
            CPUNameText = new Label();
            CPUNameLabel = new Label();
            cpuButton = new Button();
            cpuLabel = new Label();
            panel2 = new Panel();
            RAM2DetailsText = new Label();
            RAM1DetailsText = new Label();
            RAMPerformingLabel = new Label();
            RAMSpeedLabel = new Label();
            RAMWriteResult = new Label();
            RAMReadResult = new Label();
            RAMWriteLabel = new Label();
            RAMReadLabel = new Label();
            RAMTestLabel = new Label();
            ramButton = new Button();
            ramLabel = new Label();
            RAMDetailsLabel = new Label();
            panel3 = new Panel();
            Storage2DetailsText = new Label();
            Storage1DetailsText = new Label();
            StorageDetailsText = new Label();
            StorageWriteResult = new Label();
            StorageReadResult = new Label();
            StorageWriteLabel = new Label();
            StorageReadLabel = new Label();
            StorageTestLabel = new Label();
            StoragePerformingLabel = new Label();
            storageButton = new Button();
            storageLabel = new Label();
            StorageSpeedLabel = new Label();
            StorageDetailsLabel = new Label();
            panel4 = new Panel();
            CPUHistoryTestLabel = new Label();
            CPUHistoryFrequencyLabel = new Label();
            label1 = new Label();
            CPUHistoryFrequencyResult = new Label();
            panel5 = new Panel();
            RAMHistorySpeedLabel = new Label();
            RAMHistoryWriteResult = new Label();
            RAMHistoryReadResult = new Label();
            RAMHistoryWriteLabel = new Label();
            RAMHistoryReadLabel = new Label();
            RAMHistoryTestLabel = new Label();
            label2 = new Label();
            panel6 = new Panel();
            StorageHistoryWriteResult = new Label();
            label3 = new Label();
            StorageHistoryReadResult = new Label();
            StorageHistoryTestLabel = new Label();
            StorageHistoryWriteLabel = new Label();
            StorageHistorySpeedLabel = new Label();
            StorageHistoryReadLabel = new Label();
            button1 = new Button();
            intensiveSelectorButton = new Button();
            label4 = new Label();
            CPUShowPlot = new Button();
            RAMShowPlot = new Button();
            StorageShowPlot = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // RAMDetailsText
            // 
            RAMDetailsText.BackColor = Color.ForestGreen;
            RAMDetailsText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RAMDetailsText.ForeColor = SystemColors.ControlLightLight;
            RAMDetailsText.Location = new Point(119, 54);
            RAMDetailsText.Name = "RAMDetailsText";
            RAMDetailsText.Size = new Size(228, 65);
            RAMDetailsText.TabIndex = 16;
            RAMDetailsText.Text = " ";
            RAMDetailsText.Click += RAMDetailsText_Click;
            // 
            // projectTitle
            // 
            projectTitle.BackColor = Color.FromArgb(49, 51, 87);
            projectTitle.Dock = DockStyle.Top;
            projectTitle.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            projectTitle.ForeColor = Color.Ivory;
            projectTitle.Location = new Point(0, 0);
            projectTitle.Name = "projectTitle";
            projectTitle.Size = new Size(1397, 75);
            projectTitle.TabIndex = 0;
            projectTitle.Text = "PC Benchmark";
            projectTitle.TextAlign = ContentAlignment.MiddleCenter;
            projectTitle.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 70, 122);
            panel1.Controls.Add(CPUtestLabel);
            panel1.Controls.Add(CPUperformingLabel);
            panel1.Controls.Add(CPUTestResultLabel);
            panel1.Controls.Add(CPUTestResult);
            panel1.Controls.Add(CPUNameText);
            panel1.Controls.Add(CPUNameLabel);
            panel1.Controls.Add(cpuButton);
            panel1.Controls.Add(cpuLabel);
            panel1.Location = new Point(80, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 250);
            panel1.TabIndex = 1;
            // 
            // CPUtestLabel
            // 
            CPUtestLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CPUtestLabel.ForeColor = SystemColors.ControlLightLight;
            CPUtestLabel.Location = new Point(3, 128);
            CPUtestLabel.Name = "CPUtestLabel";
            CPUtestLabel.Size = new Size(110, 37);
            CPUtestLabel.TabIndex = 9;
            CPUtestLabel.Text = "Test";
            CPUtestLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CPUperformingLabel
            // 
            CPUperformingLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CPUperformingLabel.ForeColor = SystemColors.ControlLightLight;
            CPUperformingLabel.Location = new Point(128, 15);
            CPUperformingLabel.Name = "CPUperformingLabel";
            CPUperformingLabel.Size = new Size(169, 36);
            CPUperformingLabel.TabIndex = 8;
            CPUperformingLabel.Text = "Performing Test...";
            CPUperformingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CPUTestResultLabel
            // 
            CPUTestResultLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CPUTestResultLabel.ForeColor = SystemColors.ControlLightLight;
            CPUTestResultLabel.Location = new Point(3, 165);
            CPUTestResultLabel.Name = "CPUTestResultLabel";
            CPUTestResultLabel.Size = new Size(110, 37);
            CPUTestResultLabel.TabIndex = 6;
            CPUTestResultLabel.Text = "Frequency";
            CPUTestResultLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CPUTestResult
            // 
            CPUTestResult.BackColor = Color.ForestGreen;
            CPUTestResult.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            CPUTestResult.ForeColor = SystemColors.ControlLightLight;
            CPUTestResult.Location = new Point(119, 165);
            CPUTestResult.Name = "CPUTestResult";
            CPUTestResult.Size = new Size(110, 37);
            CPUTestResult.TabIndex = 5;
            CPUTestResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CPUNameText
            // 
            CPUNameText.BackColor = Color.ForestGreen;
            CPUNameText.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            CPUNameText.ForeColor = SystemColors.ControlLightLight;
            CPUNameText.Location = new Point(116, 73);
            CPUNameText.Name = "CPUNameText";
            CPUNameText.Size = new Size(191, 44);
            CPUNameText.TabIndex = 4;
            CPUNameText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CPUNameLabel
            // 
            CPUNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CPUNameLabel.ForeColor = SystemColors.ControlLightLight;
            CPUNameLabel.Location = new Point(3, 73);
            CPUNameLabel.Name = "CPUNameLabel";
            CPUNameLabel.Size = new Size(110, 37);
            CPUNameLabel.TabIndex = 3;
            CPUNameLabel.Text = "CPU Details";
            CPUNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cpuButton
            // 
            cpuButton.BackColor = Color.FromArgb(48, 70, 122);
            cpuButton.FlatAppearance.BorderColor = Color.White;
            cpuButton.FlatAppearance.CheckedBackColor = Color.FromArgb(48, 70, 122);
            cpuButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(53, 61, 128);
            cpuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(63, 92, 160);
            cpuButton.FlatStyle = FlatStyle.Flat;
            cpuButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cpuButton.ForeColor = Color.White;
            cpuButton.Location = new Point(165, 19);
            cpuButton.Name = "cpuButton";
            cpuButton.Size = new Size(120, 32);
            cpuButton.TabIndex = 1;
            cpuButton.TabStop = false;
            cpuButton.Text = "Benchmark";
            cpuButton.UseVisualStyleBackColor = false;
            cpuButton.Click += cpuButton_Click;
            // 
            // cpuLabel
            // 
            cpuLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            cpuLabel.ForeColor = SystemColors.ControlLightLight;
            cpuLabel.Location = new Point(0, 1);
            cpuLabel.Name = "cpuLabel";
            cpuLabel.Size = new Size(135, 60);
            cpuLabel.TabIndex = 0;
            cpuLabel.Text = "CPU Test";
            cpuLabel.TextAlign = ContentAlignment.MiddleCenter;
            cpuLabel.Click += CPUTestLabel_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 70, 122);
            panel2.Controls.Add(RAM2DetailsText);
            panel2.Controls.Add(RAM1DetailsText);
            panel2.Controls.Add(RAMDetailsText);
            panel2.Controls.Add(RAMPerformingLabel);
            panel2.Controls.Add(RAMSpeedLabel);
            panel2.Controls.Add(RAMWriteResult);
            panel2.Controls.Add(RAMReadResult);
            panel2.Controls.Add(RAMWriteLabel);
            panel2.Controls.Add(RAMReadLabel);
            panel2.Controls.Add(RAMTestLabel);
            panel2.Controls.Add(ramButton);
            panel2.Controls.Add(ramLabel);
            panel2.Controls.Add(RAMDetailsLabel);
            panel2.Location = new Point(530, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 250);
            panel2.TabIndex = 2;
            // 
            // RAM2DetailsText
            // 
            RAM2DetailsText.BackColor = Color.ForestGreen;
            RAM2DetailsText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RAM2DetailsText.ForeColor = SystemColors.ControlLightLight;
            RAM2DetailsText.Location = new Point(228, 54);
            RAM2DetailsText.Name = "RAM2DetailsText";
            RAM2DetailsText.Size = new Size(119, 65);
            RAM2DetailsText.TabIndex = 18;
            RAM2DetailsText.Text = " ";
            RAM2DetailsText.Click += RAM2DetailsText_Click;
            // 
            // RAM1DetailsText
            // 
            RAM1DetailsText.BackColor = Color.ForestGreen;
            RAM1DetailsText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RAM1DetailsText.ForeColor = SystemColors.ControlLightLight;
            RAM1DetailsText.Location = new Point(109, 54);
            RAM1DetailsText.Name = "RAM1DetailsText";
            RAM1DetailsText.Size = new Size(119, 65);
            RAM1DetailsText.TabIndex = 17;
            RAM1DetailsText.Text = " ";
            RAM1DetailsText.Click += RAM1DetailsText_Click;
            // 
            // RAMPerformingLabel
            // 
            RAMPerformingLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RAMPerformingLabel.ForeColor = SystemColors.ControlLightLight;
            RAMPerformingLabel.Location = new Point(129, 15);
            RAMPerformingLabel.Name = "RAMPerformingLabel";
            RAMPerformingLabel.Size = new Size(169, 36);
            RAMPerformingLabel.TabIndex = 9;
            RAMPerformingLabel.Text = "Performing Test...";
            RAMPerformingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RAMSpeedLabel
            // 
            RAMSpeedLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RAMSpeedLabel.ForeColor = SystemColors.ControlLightLight;
            RAMSpeedLabel.Location = new Point(113, 119);
            RAMSpeedLabel.Name = "RAMSpeedLabel";
            RAMSpeedLabel.Size = new Size(110, 37);
            RAMSpeedLabel.TabIndex = 14;
            RAMSpeedLabel.Text = "Speed GB/s";
            RAMSpeedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RAMWriteResult
            // 
            RAMWriteResult.BackColor = Color.ForestGreen;
            RAMWriteResult.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            RAMWriteResult.ForeColor = SystemColors.ControlLightLight;
            RAMWriteResult.Location = new Point(113, 202);
            RAMWriteResult.Name = "RAMWriteResult";
            RAMWriteResult.Size = new Size(110, 37);
            RAMWriteResult.TabIndex = 13;
            RAMWriteResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RAMReadResult
            // 
            RAMReadResult.BackColor = Color.ForestGreen;
            RAMReadResult.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            RAMReadResult.ForeColor = SystemColors.ControlLightLight;
            RAMReadResult.Location = new Point(113, 156);
            RAMReadResult.Name = "RAMReadResult";
            RAMReadResult.Size = new Size(110, 37);
            RAMReadResult.TabIndex = 8;
            RAMReadResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RAMWriteLabel
            // 
            RAMWriteLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RAMWriteLabel.ForeColor = SystemColors.ControlLightLight;
            RAMWriteLabel.Location = new Point(0, 202);
            RAMWriteLabel.Name = "RAMWriteLabel";
            RAMWriteLabel.Size = new Size(110, 37);
            RAMWriteLabel.TabIndex = 12;
            RAMWriteLabel.Text = " Write";
            RAMWriteLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RAMReadLabel
            // 
            RAMReadLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RAMReadLabel.ForeColor = SystemColors.ControlLightLight;
            RAMReadLabel.Location = new Point(0, 156);
            RAMReadLabel.Name = "RAMReadLabel";
            RAMReadLabel.Size = new Size(110, 37);
            RAMReadLabel.TabIndex = 11;
            RAMReadLabel.Text = " Read";
            RAMReadLabel.TextAlign = ContentAlignment.MiddleLeft;
            RAMReadLabel.Click += label5_Click;
            // 
            // RAMTestLabel
            // 
            RAMTestLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RAMTestLabel.ForeColor = SystemColors.ControlLightLight;
            RAMTestLabel.Location = new Point(-3, 119);
            RAMTestLabel.Name = "RAMTestLabel";
            RAMTestLabel.Size = new Size(110, 37);
            RAMTestLabel.TabIndex = 10;
            RAMTestLabel.Text = "Test";
            RAMTestLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ramButton
            // 
            ramButton.BackColor = Color.FromArgb(48, 70, 122);
            ramButton.FlatAppearance.BorderColor = Color.White;
            ramButton.FlatAppearance.CheckedBackColor = Color.FromArgb(48, 70, 122);
            ramButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(53, 61, 128);
            ramButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(63, 92, 160);
            ramButton.FlatStyle = FlatStyle.Flat;
            ramButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ramButton.ForeColor = Color.White;
            ramButton.Location = new Point(165, 19);
            ramButton.Name = "ramButton";
            ramButton.Size = new Size(120, 32);
            ramButton.TabIndex = 2;
            ramButton.TabStop = false;
            ramButton.Text = "Benchmark";
            ramButton.UseVisualStyleBackColor = false;
            ramButton.Click += ramButton_Click_1;
            // 
            // ramLabel
            // 
            ramLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            ramLabel.ForeColor = SystemColors.ControlLightLight;
            ramLabel.Location = new Point(0, 1);
            ramLabel.Name = "ramLabel";
            ramLabel.Size = new Size(135, 60);
            ramLabel.TabIndex = 0;
            ramLabel.Text = "RAM Test";
            ramLabel.TextAlign = ContentAlignment.MiddleCenter;
            ramLabel.Click += label1_Click_1;
            // 
            // RAMDetailsLabel
            // 
            RAMDetailsLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RAMDetailsLabel.ForeColor = SystemColors.ControlLightLight;
            RAMDetailsLabel.Location = new Point(3, 61);
            RAMDetailsLabel.Name = "RAMDetailsLabel";
            RAMDetailsLabel.Size = new Size(110, 37);
            RAMDetailsLabel.TabIndex = 15;
            RAMDetailsLabel.Text = "RAM Details";
            RAMDetailsLabel.TextAlign = ContentAlignment.MiddleLeft;
            RAMDetailsLabel.Click += label4_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(48, 70, 122);
            panel3.Controls.Add(Storage2DetailsText);
            panel3.Controls.Add(Storage1DetailsText);
            panel3.Controls.Add(StorageDetailsText);
            panel3.Controls.Add(StorageWriteResult);
            panel3.Controls.Add(StorageReadResult);
            panel3.Controls.Add(StorageWriteLabel);
            panel3.Controls.Add(StorageReadLabel);
            panel3.Controls.Add(StorageTestLabel);
            panel3.Controls.Add(StoragePerformingLabel);
            panel3.Controls.Add(storageButton);
            panel3.Controls.Add(storageLabel);
            panel3.Controls.Add(StorageSpeedLabel);
            panel3.Controls.Add(StorageDetailsLabel);
            panel3.Location = new Point(980, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 250);
            panel3.TabIndex = 3;
            // 
            // Storage2DetailsText
            // 
            Storage2DetailsText.BackColor = Color.ForestGreen;
            Storage2DetailsText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Storage2DetailsText.ForeColor = SystemColors.ControlLightLight;
            Storage2DetailsText.Location = new Point(237, 54);
            Storage2DetailsText.Name = "Storage2DetailsText";
            Storage2DetailsText.Size = new Size(110, 65);
            Storage2DetailsText.TabIndex = 21;
            Storage2DetailsText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Storage1DetailsText
            // 
            Storage1DetailsText.BackColor = Color.ForestGreen;
            Storage1DetailsText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Storage1DetailsText.ForeColor = SystemColors.ControlLightLight;
            Storage1DetailsText.Location = new Point(127, 54);
            Storage1DetailsText.Name = "Storage1DetailsText";
            Storage1DetailsText.Size = new Size(110, 65);
            Storage1DetailsText.TabIndex = 9;
            Storage1DetailsText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StorageDetailsText
            // 
            StorageDetailsText.BackColor = Color.ForestGreen;
            StorageDetailsText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            StorageDetailsText.ForeColor = SystemColors.ControlLightLight;
            StorageDetailsText.Location = new Point(127, 54);
            StorageDetailsText.Name = "StorageDetailsText";
            StorageDetailsText.Size = new Size(220, 65);
            StorageDetailsText.TabIndex = 8;
            StorageDetailsText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StorageWriteResult
            // 
            StorageWriteResult.BackColor = Color.ForestGreen;
            StorageWriteResult.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            StorageWriteResult.ForeColor = SystemColors.ControlLightLight;
            StorageWriteResult.Location = new Point(127, 202);
            StorageWriteResult.Name = "StorageWriteResult";
            StorageWriteResult.Size = new Size(110, 37);
            StorageWriteResult.TabIndex = 19;
            StorageWriteResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StorageReadResult
            // 
            StorageReadResult.BackColor = Color.ForestGreen;
            StorageReadResult.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            StorageReadResult.ForeColor = SystemColors.ControlLightLight;
            StorageReadResult.Location = new Point(127, 156);
            StorageReadResult.Name = "StorageReadResult";
            StorageReadResult.Size = new Size(110, 37);
            StorageReadResult.TabIndex = 15;
            StorageReadResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StorageWriteLabel
            // 
            StorageWriteLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StorageWriteLabel.ForeColor = SystemColors.ControlLightLight;
            StorageWriteLabel.Location = new Point(3, 202);
            StorageWriteLabel.Name = "StorageWriteLabel";
            StorageWriteLabel.Size = new Size(110, 37);
            StorageWriteLabel.TabIndex = 18;
            StorageWriteLabel.Text = " Write";
            StorageWriteLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StorageReadLabel
            // 
            StorageReadLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StorageReadLabel.ForeColor = SystemColors.ControlLightLight;
            StorageReadLabel.Location = new Point(3, 156);
            StorageReadLabel.Name = "StorageReadLabel";
            StorageReadLabel.Size = new Size(110, 37);
            StorageReadLabel.TabIndex = 17;
            StorageReadLabel.Text = " Read";
            StorageReadLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StorageTestLabel
            // 
            StorageTestLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StorageTestLabel.ForeColor = SystemColors.ControlLightLight;
            StorageTestLabel.Location = new Point(0, 119);
            StorageTestLabel.Name = "StorageTestLabel";
            StorageTestLabel.Size = new Size(110, 37);
            StorageTestLabel.TabIndex = 16;
            StorageTestLabel.Text = "Test";
            StorageTestLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StoragePerformingLabel
            // 
            StoragePerformingLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StoragePerformingLabel.ForeColor = SystemColors.ControlLightLight;
            StoragePerformingLabel.Location = new Point(138, 15);
            StoragePerformingLabel.Name = "StoragePerformingLabel";
            StoragePerformingLabel.Size = new Size(169, 36);
            StoragePerformingLabel.TabIndex = 10;
            StoragePerformingLabel.Text = "Performing Test...";
            StoragePerformingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // storageButton
            // 
            storageButton.BackColor = Color.FromArgb(48, 70, 122);
            storageButton.FlatAppearance.BorderColor = Color.White;
            storageButton.FlatAppearance.CheckedBackColor = Color.FromArgb(48, 70, 122);
            storageButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(53, 61, 128);
            storageButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(63, 92, 160);
            storageButton.FlatStyle = FlatStyle.Flat;
            storageButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            storageButton.ForeColor = Color.White;
            storageButton.Location = new Point(165, 19);
            storageButton.Name = "storageButton";
            storageButton.Size = new Size(120, 32);
            storageButton.TabIndex = 3;
            storageButton.TabStop = false;
            storageButton.Text = "Benchmark";
            storageButton.UseVisualStyleBackColor = false;
            storageButton.Click += storageButton_Click;
            // 
            // storageLabel
            // 
            storageLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            storageLabel.ForeColor = SystemColors.ControlLightLight;
            storageLabel.Location = new Point(0, 1);
            storageLabel.Name = "storageLabel";
            storageLabel.Size = new Size(159, 60);
            storageLabel.TabIndex = 0;
            storageLabel.Text = "Storage Test";
            storageLabel.TextAlign = ContentAlignment.MiddleCenter;
            storageLabel.Click += label2_Click;
            // 
            // StorageSpeedLabel
            // 
            StorageSpeedLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StorageSpeedLabel.ForeColor = SystemColors.ControlLightLight;
            StorageSpeedLabel.Location = new Point(127, 119);
            StorageSpeedLabel.Name = "StorageSpeedLabel";
            StorageSpeedLabel.Size = new Size(110, 37);
            StorageSpeedLabel.TabIndex = 20;
            StorageSpeedLabel.Text = "Speed MB/s";
            StorageSpeedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StorageDetailsLabel
            // 
            StorageDetailsLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StorageDetailsLabel.ForeColor = SystemColors.ControlLightLight;
            StorageDetailsLabel.Location = new Point(0, 61);
            StorageDetailsLabel.Name = "StorageDetailsLabel";
            StorageDetailsLabel.Size = new Size(136, 37);
            StorageDetailsLabel.TabIndex = 16;
            StorageDetailsLabel.Text = "Storage Details";
            StorageDetailsLabel.TextAlign = ContentAlignment.MiddleLeft;
            StorageDetailsLabel.Click += StorageDetailsLabel_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(48, 70, 122);
            panel4.Controls.Add(CPUHistoryTestLabel);
            panel4.Controls.Add(CPUHistoryFrequencyLabel);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(CPUHistoryFrequencyResult);
            panel4.Location = new Point(80, 455);
            panel4.Name = "panel4";
            panel4.Size = new Size(350, 200);
            panel4.TabIndex = 4;
            // 
            // CPUHistoryTestLabel
            // 
            CPUHistoryTestLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CPUHistoryTestLabel.ForeColor = SystemColors.ControlLightLight;
            CPUHistoryTestLabel.Location = new Point(25, 62);
            CPUHistoryTestLabel.Name = "CPUHistoryTestLabel";
            CPUHistoryTestLabel.Size = new Size(110, 37);
            CPUHistoryTestLabel.TabIndex = 12;
            CPUHistoryTestLabel.Text = "Test";
            CPUHistoryTestLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CPUHistoryFrequencyLabel
            // 
            CPUHistoryFrequencyLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CPUHistoryFrequencyLabel.ForeColor = SystemColors.ControlLightLight;
            CPUHistoryFrequencyLabel.Location = new Point(25, 99);
            CPUHistoryFrequencyLabel.Name = "CPUHistoryFrequencyLabel";
            CPUHistoryFrequencyLabel.Size = new Size(110, 37);
            CPUHistoryFrequencyLabel.TabIndex = 11;
            CPUHistoryFrequencyLabel.Text = "Frequency";
            CPUHistoryFrequencyLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 2);
            label1.Name = "label1";
            label1.Size = new Size(350, 60);
            label1.TabIndex = 0;
            label1.Text = "Last CPU Test Result";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_2;
            // 
            // CPUHistoryFrequencyResult
            // 
            CPUHistoryFrequencyResult.BackColor = Color.DarkKhaki;
            CPUHistoryFrequencyResult.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            CPUHistoryFrequencyResult.ForeColor = SystemColors.ControlLightLight;
            CPUHistoryFrequencyResult.Location = new Point(141, 99);
            CPUHistoryFrequencyResult.Name = "CPUHistoryFrequencyResult";
            CPUHistoryFrequencyResult.Size = new Size(110, 37);
            CPUHistoryFrequencyResult.TabIndex = 10;
            CPUHistoryFrequencyResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(48, 70, 122);
            panel5.Controls.Add(RAMHistorySpeedLabel);
            panel5.Controls.Add(RAMHistoryWriteResult);
            panel5.Controls.Add(RAMHistoryReadResult);
            panel5.Controls.Add(RAMHistoryWriteLabel);
            panel5.Controls.Add(RAMHistoryReadLabel);
            panel5.Controls.Add(RAMHistoryTestLabel);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(530, 456);
            panel5.Name = "panel5";
            panel5.Size = new Size(350, 200);
            panel5.TabIndex = 5;
            // 
            // RAMHistorySpeedLabel
            // 
            RAMHistorySpeedLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RAMHistorySpeedLabel.ForeColor = SystemColors.ControlLightLight;
            RAMHistorySpeedLabel.Location = new Point(130, 62);
            RAMHistorySpeedLabel.Name = "RAMHistorySpeedLabel";
            RAMHistorySpeedLabel.Size = new Size(110, 37);
            RAMHistorySpeedLabel.TabIndex = 20;
            RAMHistorySpeedLabel.Text = "Speed GB/s";
            RAMHistorySpeedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RAMHistoryWriteResult
            // 
            RAMHistoryWriteResult.BackColor = Color.DarkKhaki;
            RAMHistoryWriteResult.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            RAMHistoryWriteResult.ForeColor = SystemColors.ControlLightLight;
            RAMHistoryWriteResult.Location = new Point(130, 145);
            RAMHistoryWriteResult.Name = "RAMHistoryWriteResult";
            RAMHistoryWriteResult.Size = new Size(110, 37);
            RAMHistoryWriteResult.TabIndex = 19;
            RAMHistoryWriteResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RAMHistoryReadResult
            // 
            RAMHistoryReadResult.BackColor = Color.DarkKhaki;
            RAMHistoryReadResult.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            RAMHistoryReadResult.ForeColor = SystemColors.ControlLightLight;
            RAMHistoryReadResult.Location = new Point(130, 99);
            RAMHistoryReadResult.Name = "RAMHistoryReadResult";
            RAMHistoryReadResult.Size = new Size(110, 37);
            RAMHistoryReadResult.TabIndex = 15;
            RAMHistoryReadResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RAMHistoryWriteLabel
            // 
            RAMHistoryWriteLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RAMHistoryWriteLabel.ForeColor = SystemColors.ControlLightLight;
            RAMHistoryWriteLabel.Location = new Point(17, 145);
            RAMHistoryWriteLabel.Name = "RAMHistoryWriteLabel";
            RAMHistoryWriteLabel.Size = new Size(110, 37);
            RAMHistoryWriteLabel.TabIndex = 18;
            RAMHistoryWriteLabel.Text = " Write";
            RAMHistoryWriteLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RAMHistoryReadLabel
            // 
            RAMHistoryReadLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RAMHistoryReadLabel.ForeColor = SystemColors.ControlLightLight;
            RAMHistoryReadLabel.Location = new Point(17, 99);
            RAMHistoryReadLabel.Name = "RAMHistoryReadLabel";
            RAMHistoryReadLabel.Size = new Size(110, 37);
            RAMHistoryReadLabel.TabIndex = 17;
            RAMHistoryReadLabel.Text = " Read";
            RAMHistoryReadLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RAMHistoryTestLabel
            // 
            RAMHistoryTestLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RAMHistoryTestLabel.ForeColor = SystemColors.ControlLightLight;
            RAMHistoryTestLabel.Location = new Point(14, 62);
            RAMHistoryTestLabel.Name = "RAMHistoryTestLabel";
            RAMHistoryTestLabel.Size = new Size(110, 37);
            RAMHistoryTestLabel.TabIndex = 16;
            RAMHistoryTestLabel.Text = "Test";
            RAMHistoryTestLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(0, 1);
            label2.Name = "label2";
            label2.Size = new Size(350, 61);
            label2.TabIndex = 0;
            label2.Text = "Last RAM Test Result";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click_1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(48, 70, 122);
            panel6.Controls.Add(StorageHistoryWriteResult);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(StorageHistoryReadResult);
            panel6.Controls.Add(StorageHistoryTestLabel);
            panel6.Controls.Add(StorageHistoryWriteLabel);
            panel6.Controls.Add(StorageHistorySpeedLabel);
            panel6.Controls.Add(StorageHistoryReadLabel);
            panel6.Location = new Point(980, 455);
            panel6.Name = "panel6";
            panel6.Size = new Size(350, 200);
            panel6.TabIndex = 6;
            // 
            // StorageHistoryWriteResult
            // 
            StorageHistoryWriteResult.BackColor = Color.DarkKhaki;
            StorageHistoryWriteResult.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            StorageHistoryWriteResult.ForeColor = SystemColors.ControlLightLight;
            StorageHistoryWriteResult.Location = new Point(153, 144);
            StorageHistoryWriteResult.Name = "StorageHistoryWriteResult";
            StorageHistoryWriteResult.Size = new Size(110, 37);
            StorageHistoryWriteResult.TabIndex = 25;
            StorageHistoryWriteResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(0, 1);
            label3.Name = "label3";
            label3.Size = new Size(350, 60);
            label3.TabIndex = 0;
            label3.Text = "Last Storage Test Result";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StorageHistoryReadResult
            // 
            StorageHistoryReadResult.BackColor = Color.DarkKhaki;
            StorageHistoryReadResult.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            StorageHistoryReadResult.ForeColor = SystemColors.ControlLightLight;
            StorageHistoryReadResult.Location = new Point(153, 98);
            StorageHistoryReadResult.Name = "StorageHistoryReadResult";
            StorageHistoryReadResult.Size = new Size(110, 37);
            StorageHistoryReadResult.TabIndex = 21;
            StorageHistoryReadResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StorageHistoryTestLabel
            // 
            StorageHistoryTestLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StorageHistoryTestLabel.ForeColor = SystemColors.ControlLightLight;
            StorageHistoryTestLabel.Location = new Point(26, 61);
            StorageHistoryTestLabel.Name = "StorageHistoryTestLabel";
            StorageHistoryTestLabel.Size = new Size(110, 37);
            StorageHistoryTestLabel.TabIndex = 22;
            StorageHistoryTestLabel.Text = "Test";
            StorageHistoryTestLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StorageHistoryWriteLabel
            // 
            StorageHistoryWriteLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StorageHistoryWriteLabel.ForeColor = SystemColors.ControlLightLight;
            StorageHistoryWriteLabel.Location = new Point(29, 144);
            StorageHistoryWriteLabel.Name = "StorageHistoryWriteLabel";
            StorageHistoryWriteLabel.Size = new Size(110, 37);
            StorageHistoryWriteLabel.TabIndex = 24;
            StorageHistoryWriteLabel.Text = " Write";
            StorageHistoryWriteLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StorageHistorySpeedLabel
            // 
            StorageHistorySpeedLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StorageHistorySpeedLabel.ForeColor = SystemColors.ControlLightLight;
            StorageHistorySpeedLabel.Location = new Point(153, 61);
            StorageHistorySpeedLabel.Name = "StorageHistorySpeedLabel";
            StorageHistorySpeedLabel.Size = new Size(110, 37);
            StorageHistorySpeedLabel.TabIndex = 26;
            StorageHistorySpeedLabel.Text = "Speed MB/s";
            StorageHistorySpeedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StorageHistoryReadLabel
            // 
            StorageHistoryReadLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StorageHistoryReadLabel.ForeColor = SystemColors.ControlLightLight;
            StorageHistoryReadLabel.Location = new Point(29, 98);
            StorageHistoryReadLabel.Name = "StorageHistoryReadLabel";
            StorageHistoryReadLabel.Size = new Size(110, 37);
            StorageHistoryReadLabel.TabIndex = 23;
            StorageHistoryReadLabel.Text = " Read";
            StorageHistoryReadLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.CheckedBackColor = Color.FromArgb(48, 70, 122);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            button1.FlatAppearance.MouseOverBackColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(498, 739);
            button1.Name = "button1";
            button1.Size = new Size(382, 86);
            button1.TabIndex = 7;
            button1.TabStop = false;
            button1.Text = "Start all benchmark tests";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // intensiveSelectorButton
            // 
            intensiveSelectorButton.BackColor = Color.White;
            intensiveSelectorButton.FlatAppearance.BorderSize = 0;
            intensiveSelectorButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            intensiveSelectorButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            intensiveSelectorButton.FlatStyle = FlatStyle.Flat;
            intensiveSelectorButton.Location = new Point(1253, 57);
            intensiveSelectorButton.Margin = new Padding(0);
            intensiveSelectorButton.Name = "intensiveSelectorButton";
            intensiveSelectorButton.Size = new Size(38, 33);
            intensiveSelectorButton.TabIndex = 8;
            intensiveSelectorButton.UseVisualStyleBackColor = false;
            intensiveSelectorButton.Click += button2_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(1102, 57);
            label4.Name = "label4";
            label4.Size = new Size(148, 33);
            label4.TabIndex = 9;
            label4.Text = "Intensive mode";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CPUShowPlot
            // 
            CPUShowPlot.BackColor = Color.FromArgb(48, 70, 122);
            CPUShowPlot.FlatAppearance.BorderColor = Color.White;
            CPUShowPlot.FlatAppearance.CheckedBackColor = Color.FromArgb(48, 70, 122);
            CPUShowPlot.FlatAppearance.MouseDownBackColor = Color.FromArgb(53, 61, 128);
            CPUShowPlot.FlatAppearance.MouseOverBackColor = Color.FromArgb(63, 92, 160);
            CPUShowPlot.FlatStyle = FlatStyle.Flat;
            CPUShowPlot.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CPUShowPlot.ForeColor = Color.White;
            CPUShowPlot.Location = new Point(195, 397);
            CPUShowPlot.Name = "CPUShowPlot";
            CPUShowPlot.Size = new Size(119, 32);
            CPUShowPlot.TabIndex = 10;
            CPUShowPlot.TabStop = false;
            CPUShowPlot.Text = "CPU Graph";
            CPUShowPlot.UseVisualStyleBackColor = false;
            CPUShowPlot.Click += showCPUPlot_Click;
            // 
            // RAMShowPlot
            // 
            RAMShowPlot.BackColor = Color.FromArgb(48, 70, 122);
            RAMShowPlot.FlatAppearance.BorderColor = Color.White;
            RAMShowPlot.FlatAppearance.CheckedBackColor = Color.FromArgb(48, 70, 122);
            RAMShowPlot.FlatAppearance.MouseDownBackColor = Color.FromArgb(53, 61, 128);
            RAMShowPlot.FlatAppearance.MouseOverBackColor = Color.FromArgb(63, 92, 160);
            RAMShowPlot.FlatStyle = FlatStyle.Flat;
            RAMShowPlot.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RAMShowPlot.ForeColor = Color.White;
            RAMShowPlot.Location = new Point(645, 397);
            RAMShowPlot.Name = "RAMShowPlot";
            RAMShowPlot.Size = new Size(119, 32);
            RAMShowPlot.TabIndex = 11;
            RAMShowPlot.TabStop = false;
            RAMShowPlot.Text = "RAM Graph";
            RAMShowPlot.UseVisualStyleBackColor = false;
            RAMShowPlot.Click += button2_Click_1;
            // 
            // StorageShowPlot
            // 
            StorageShowPlot.BackColor = Color.FromArgb(48, 70, 122);
            StorageShowPlot.FlatAppearance.BorderColor = Color.White;
            StorageShowPlot.FlatAppearance.CheckedBackColor = Color.FromArgb(48, 70, 122);
            StorageShowPlot.FlatAppearance.MouseDownBackColor = Color.FromArgb(53, 61, 128);
            StorageShowPlot.FlatAppearance.MouseOverBackColor = Color.FromArgb(63, 92, 160);
            StorageShowPlot.FlatStyle = FlatStyle.Flat;
            StorageShowPlot.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StorageShowPlot.ForeColor = Color.White;
            StorageShowPlot.Location = new Point(1096, 397);
            StorageShowPlot.Name = "StorageShowPlot";
            StorageShowPlot.Size = new Size(130, 32);
            StorageShowPlot.TabIndex = 12;
            StorageShowPlot.TabStop = false;
            StorageShowPlot.Text = "Storage Graph";
            StorageShowPlot.UseVisualStyleBackColor = false;
            StorageShowPlot.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 51, 87);
            ClientSize = new Size(1397, 856);
            Controls.Add(StorageShowPlot);
            Controls.Add(RAMShowPlot);
            Controls.Add(CPUShowPlot);
            Controls.Add(label4);
            Controls.Add(intensiveSelectorButton);
            Controls.Add(button1);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(projectTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label projectTitle;
        private Panel panel1;
        private Panel panel2;
        private Label ramLabel;
        private Panel panel3;
        private Label storageLabel;
        private Label cpuLabel;
        private Button cpuButton;
        private Button ramButton;
        private Button storageButton;
        private Panel panel4;
        private Label label1;
        private Panel panel5;
        private Label label2;
        private Panel panel6;
        private Label label3;
        private Button button1;
        private Label CPUNameText;
        private Label CPUNameLabel;
        private Label CPUTestResult;
        private Label CPUTestResultLabel;
        private Label CPUperformingLabel;
        private Label CPUtestLabel;
        private Label RAMTestLabel;
        private Label RAMReadLabel;
        private Label RAMWriteResult;
        private Label RAMReadResult;
        private Label RAMWriteLabel;
        private Label RAMSpeedLabel;
        private Label RAMPerformingLabel;
        private Label StorageSpeedLabel;
        private Label StoragePerformingLabel;
        private Label StorageWriteResult;
        private Label StorageReadResult;
        private Label StorageWriteLabel;
        private Label StorageReadLabel;
        private Label StorageTestLabel;
        private Label RAMDetailsLabel;
        private Label RAMDetailsText;
        private Label RAM2DetailsText;
        private Label RAM1DetailsText;
        private Label StorageDetailsText;
        private Label StorageDetailsLabel;
        private Label Storage1DetailsText;
        private Label Storage2DetailsText;
        private Label CPUHistoryTestLabel;
        private Label CPUHistoryFrequencyLabel;
        private Label CPUHistoryFrequencyResult;
        private Label RAMHistorySpeedLabel;
        private Label RAMHistoryWriteResult;
        private Label RAMHistoryReadResult;
        private Label RAMHistoryWriteLabel;
        private Label RAMHistoryReadLabel;
        private Label RAMHistoryTestLabel;
        private Label StorageHistoryWriteResult;
        private Label StorageHistoryReadResult;
        private Label StorageHistoryTestLabel;
        private Label StorageHistoryWriteLabel;
        private Label StorageHistorySpeedLabel;
        private Label StorageHistoryReadLabel;
        private Button intensiveSelectorButton;
        private Label label4;
        private Button CPUShowPlot;
        private Button RAMShowPlot;
        private Button StorageShowPlot;
    }
}