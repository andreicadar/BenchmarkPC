using System;
using System.Diagnostics;
using System.Management;
using System.Runtime.CompilerServices;

namespace Benchmark
{
    public partial class Form1 : Form
    {

        bool intensiveMode = false;

        public Form1()
        {
            InitializeComponent();
            CPUNameText.Visible = false;
            CPUTestResultLabel.Visible = false;
            CPUTestResult.Visible = false;
            CPUNameLabel.Visible = false;
            CPUperformingLabel.Visible = false;
            CPUtestLabel.Visible = false;
            CPUShowPlot.Visible = false;

            RAMPerformingLabel.Visible = false;
            RAMReadLabel.Visible = false;
            RAMSpeedLabel.Visible = false;
            RAMWriteLabel.Visible = false;
            RAMReadResult.Visible = false;
            RAMWriteResult.Visible = false;
            RAMTestLabel.Visible = false;
            RAMDetailsText.Visible = false;
            RAM1DetailsText.Visible = false;
            RAM2DetailsText.Visible = false;
            RAMDetailsLabel.Visible = false;
            RAMShowPlot.Visible = false;

            StoragePerformingLabel.Visible = false;
            StorageReadLabel.Visible = false;
            StorageWriteLabel.Visible = false;
            StorageTestLabel.Visible = false;
            StorageReadResult.Visible = false;
            StorageWriteResult.Visible = false;
            StorageSpeedLabel.Visible = false;
            StorageDetailsText.Visible = false;
            Storage1DetailsText.Visible = false;
            Storage2DetailsText.Visible = false;
            StorageDetailsLabel.Visible = false;
            StorageShowPlot.Visible = false;

            CPUHistoryFrequencyResult.Visible = false;
            CPUHistoryFrequencyLabel.Visible = false;
            RAMHistoryReadResult.Visible = false;
            RAMHistoryReadLabel.Visible = false;
            RAMHistoryWriteResult.Visible = false;
            RAMHistoryWriteLabel.Visible = false;
            StorageHistoryReadResult.Visible = false;
            StorageHistoryReadLabel.Visible = false;
            StorageHistoryWriteResult.Visible = false;
            StorageHistoryWriteLabel.Visible = false;

            intensiveSelectorButton.BackColor = Color.White;
            intensiveSelectorButton.FlatAppearance.MouseOverBackColor = Color.White;
            intensiveSelectorButton.FlatAppearance.MouseDownBackColor = Color.White;

            string filePath = "history.txt"; // Replace with the actual file path

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "1\n1\n1");
                CPUHistoryTestLabel.Visible = false;
                RAMHistoryTestLabel.Visible = false;
                StorageHistoryTestLabel.Visible = false;
                RAMHistorySpeedLabel.Visible = false;
                StorageHistorySpeedLabel.Visible = false;
            }
            else if (File.ReadAllText(filePath) != "1\n1\n1")
            {
                CPUHistoryTestLabel.Visible = true;
                RAMHistoryTestLabel.Visible = true;
                StorageHistoryTestLabel.Visible = true;
                RAMHistorySpeedLabel.Visible = true;
                StorageHistorySpeedLabel.Visible = true;

                string fileContent = File.ReadAllText(filePath);
                string[] lines = fileContent.Split('\n');
                if (lines.Length >= 3)
                {
                    //cpu frequency is on a line, ram read and write speeds seprated by space on the second line, storage speeds the same but on third line
                    if (float.TryParse(lines[0], out float floatValue))
                    {
                        CPUHistoryFrequencyResult.Text = floatValue.ToString("0.00#") + " GHz";
                        CPUHistoryFrequencyResult.Visible = true;
                        CPUHistoryFrequencyLabel.Visible = true;
                    }
                    string[] ramSpeeds = lines[1].Split(' ');
                    if (float.TryParse(ramSpeeds[0], out floatValue))
                    {
                        RAMHistoryReadResult.Text = floatValue.ToString("0.00#");
                        RAMHistoryReadResult.Visible = true;
                        RAMHistoryReadLabel.Visible = true;
                    }
                    if (float.TryParse(ramSpeeds[1], out floatValue))
                    {
                        RAMHistoryWriteResult.Text = floatValue.ToString("0.00#");
                        RAMHistoryWriteResult.Visible = true;
                        RAMHistoryWriteLabel.Visible = true;
                    }
                    string[] storageSpeeds = lines[2].Split(' ');
                    if (float.TryParse(storageSpeeds[0], out floatValue))
                    {
                        StorageHistoryReadResult.Text = floatValue.ToString("0.00#");
                        StorageHistoryReadResult.Visible = true;
                        StorageHistoryReadLabel.Visible = true;
                    }
                    if (float.TryParse(storageSpeeds[1], out floatValue))
                    {
                        StorageHistoryWriteResult.Text = floatValue.ToString("0.00#");
                        StorageHistoryWriteResult.Visible = true;
                        StorageHistoryWriteLabel.Visible = true;
                    }
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void CPUTestLabel_Click(object sender, EventArgs e)
        {
        }

        static void WriteToSpecificLine(string filePath, int lineNumber, string newText)
        {
            string[] lines = File.ReadAllLines(filePath);

            if (lineNumber > 0 && lineNumber <= lines.Length)
            {
                lines[lineNumber - 1] = newText;

                File.WriteAllLines(filePath, lines);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Invalid line number");
            }
        }

        private void cpuButton_Click(object sender, EventArgs e)
        {
            CPUNameText.Visible = false;
            CPUTestResultLabel.Visible = true;
            CPUTestResult.Visible = false;
            CPUNameLabel.Visible = true;
            cpuButton.Visible = false;
            cpuButton.Enabled = false;
            CPUtestLabel.Visible = true;
            CPUperformingLabel.Visible = true;


            var cpu =
            new ManagementObjectSearcher("select * from Win32_Processor")
            .Get()
            .Cast<ManagementObject>()
            .First();

            string CPUName = (string)cpu["Name"];
            CPUName
            .Replace("(TM)", "™")
            .Replace("(tm)", "™")
            .Replace("(R)", "®")
            .Replace("(r)", "®")
            .Replace("(C)", "©")
            .Replace("(c)", "©")
            .Replace("    ", " ")
            .Replace("  ", " ");

            CPUNameText.Text = CPUName;
            CPUNameLabel.Visible = true;
            CPUNameText.Visible = true;

            Console.WriteLine("CPU Test Started");
            Application.DoEvents();

            if (intensiveMode == false)
            {
                string exePath = Path.Combine(Environment.CurrentDirectory, "cpu.exe");
                ProcessStartInfo psi = new ProcessStartInfo(exePath)
                {
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                Process process = new Process
                {
                    StartInfo = psi
                };
                process.Start();
                process.WaitForExit();

                string fileContent = File.ReadAllText("outCPU.txt");

                if (float.TryParse(fileContent, out float floatValue))
                {
                    CPUTestResult.Text = floatValue.ToString("0.00#");
                    WriteToSpecificLine("history.txt", 1, CPUTestResult.Text);
                    CPUTestResult.Text += " GHz";
                }
                CPUperformingLabel.Visible = false;
                cpuButton.Visible = true;
                cpuButton.Enabled = true;
                CPUTestResultLabel.Visible = true;
                CPUTestResult.Visible = true;
            }
            else
            {
                string pythonExePath = "C:\\Users\\Andrei\\AppData\\Local\\Programs\\Python\\Python310\\python.exe";
                string scriptPath = Path.Combine(Environment.CurrentDirectory, "script.py");
                string argument = "cpu";
                ProcessStartInfo psi = new ProcessStartInfo(pythonExePath)
                {
                    Arguments = $"\"{scriptPath}\" {argument}",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                Process process = new Process
                {
                    StartInfo = psi
                };
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                Console.WriteLine(output);
                string[] words = output.Split('\n');

                if (words.Length >= 1)
                {
                    string cpuFrequency = words[0];
                    cpuFrequency = cpuFrequency.Replace("\n", "").Replace("\r", ""); ;

                    CPUTestResult.Text = cpuFrequency + " GHz";
                    CPUTestResult.Visible = true;
                    CPUperformingLabel.Visible = false;

                    cpuButton.Visible = true;
                    cpuButton.Enabled = true;

                    WriteToSpecificLine("history.txt", 1, cpuFrequency);
                }
                CPUShowPlot.Visible = true;
            }
        }

        private void ramButton_Click_1(object sender, EventArgs e)
        {
            RAMPerformingLabel.Visible = true;
            RAMReadResult.Visible = false;
            RAMWriteResult.Visible = false;
            ramButton.Visible = false;
            ramButton.Enabled = false;
            RAMSpeedLabel.Visible = true;
            RAMWriteLabel.Visible = true;
            RAMReadLabel.Visible = true;
            RAMTestLabel.Visible = true;
            RAMDetailsText.Visible = false;
            RAM1DetailsText.Visible = false;
            RAM2DetailsText.Visible = false;
            RAMDetailsLabel.Visible = true;

            var ram = new ManagementObjectSearcher("select * from Win32_PhysicalMemory")
           .Get()
           .Cast<ManagementObject>()
           .ToArray();

            if (ram.Length == 1)
            {
                RAMDetailsText.Text = "";
                ulong capacity = (ulong)ram[0]["Capacity"] / 1024 / 1024 / 1024;
                string type = ((ushort)ram[0]["MemoryType"] == 0) ? "DDR4" : "DDR3";
                RAM1DetailsText.Text += "Slot 1" + "\n  Type: " + type + "\n  Capacity: " + capacity.ToString() + "GB\n  Speed: " + ram[0]["Speed"] + "Mhz\n";
                RAMDetailsText.Visible = true;
            }
            else if (ram.Length == 2)
            {
                RAM1DetailsText.Text = "";
                RAM2DetailsText.Text = "";
                ulong capacity1 = (ulong)ram[0]["Capacity"] / 1024 / 1024 / 1024;
                ulong capacity2 = (ulong)ram[1]["Capacity"] / 1024 / 1024 / 1024;
                string type1 = ((ushort)ram[0]["MemoryType"] == 0) ? "DDR4" : "DDR3";
                string type2 = ((ushort)ram[0]["MemoryType"] == 0) ? "DDR4" : "DDR3";
                RAM1DetailsText.Text += "Slot 1" + "\n  Type: " + type1 + "\n  Capacity: " + capacity1.ToString() + "GB\n  Speed: " + ram[0]["Speed"] + "Mhz\n";
                RAM2DetailsText.Text += "Slot 2" + "\n  Type: " + type2 + "\n  Capacity: " + capacity2.ToString() + "GB\n  Speed: " + ram[1]["Speed"] + "Mhz\n";
                RAM1DetailsText.Visible = true;
                RAM2DetailsText.Visible = true;
            }

            Application.DoEvents();


            Console.WriteLine("RAM Test Started");

            if (intensiveMode == false)
            {
                string exePath = Path.Combine(Environment.CurrentDirectory, "ram.exe");
                string argument = "2";
                ProcessStartInfo psi = new ProcessStartInfo(exePath)
                {
                    Arguments = argument,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                Process process = new Process
                {
                    StartInfo = psi
                };
                process.Start();
                process.WaitForExit();

                string fileContent = File.ReadAllText("outRAM.txt");

                if (float.TryParse(fileContent, out float floatValue))
                {
                    RAMReadResult.Text = floatValue.ToString("0.00#");
                }

                RAMReadResult.Visible = true;

                argument = "1";
                psi = new ProcessStartInfo(exePath)
                {
                    Arguments = argument,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                process = new Process
                {
                    StartInfo = psi
                };
                process.Start();
                process.WaitForExit();

                fileContent = File.ReadAllText("outRAM.txt");

                if (float.TryParse(fileContent, out floatValue))
                {
                    RAMWriteResult.Text = floatValue.ToString("0.00#");
                }

                RAMWriteResult.Visible = true;

                RAMPerformingLabel.Visible = false;

                ramButton.Visible = true;
                ramButton.Enabled = true;

                WriteToSpecificLine("history.txt", 2, RAMReadResult.Text + " " + RAMWriteResult.Text);
            }
            else
            {
                string pythonExePath = "C:\\Users\\Andrei\\AppData\\Local\\Programs\\Python\\Python310\\python.exe";
                string scriptPath = Path.Combine(Environment.CurrentDirectory, "script.py");
                string argument = "ram";
                ProcessStartInfo psi = new ProcessStartInfo(pythonExePath)
                {
                    Arguments = $"\"{scriptPath}\" {argument}",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                Process process = new Process
                {
                    StartInfo = psi
                };
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                Console.WriteLine(output);
                string[] words = output.Split('\n');

                if (words.Length >= 2)
                {
                    string writeSpeed = words[0];
                    writeSpeed = writeSpeed.Replace("\n", "").Replace("\r", ""); ;
                    string readSpeed = words[1];
                    readSpeed = readSpeed.Replace("\n", "").Replace("\r", ""); ;

                    RAMReadResult.Text = readSpeed;
                    RAMWriteResult.Text = writeSpeed;
                    RAMReadResult.Visible = true;
                    RAMWriteResult.Visible = true;
                    RAMPerformingLabel.Visible = false;

                    ramButton.Visible = true;
                    ramButton.Enabled = true;

                    WriteToSpecificLine("history.txt", 2, readSpeed + " " + writeSpeed);
                }
                RAMShowPlot.Visible = true;
            }

        }

        private void storageButton_Click(object sender, EventArgs e)
        {
            storageButton.Visible = false;
            storageButton.Enabled = false;
            StoragePerformingLabel.Visible = true;
            StorageReadLabel.Visible = true;
            StorageWriteLabel.Visible = true;
            StorageTestLabel.Visible = true;
            StorageReadResult.Visible = false;
            StorageWriteResult.Visible = false;
            StorageSpeedLabel.Visible = true;
            StorageDetailsText.Visible = false;
            Storage1DetailsText.Visible = false;
            Storage2DetailsText.Visible = false;
            StorageDetailsLabel.Visible = true;


            var storage =
            new ManagementObjectSearcher("select * from Win32_DiskDrive")
            .Get()
            .Cast<ManagementObject>()
            .ToArray();

            Application.DoEvents();

            if (storage.Length == 1)
            {
                StorageDetailsText.Text = "";
                ulong capacity = (ulong)storage[0]["Size"] / 1024 / 1024 / 1024;
                string type = (string)storage[0]["MediaType"];
                StorageDetailsText.Text += "Drive 1" + "\n  Type: " + type + "\n  Capacity " + capacity.ToString() + "GB\n  Speed " + storage[0]["InterfaceType"] + "\n";
            }
            else if (storage.Length == 2)
            {
                Storage1DetailsText.Text = "";
                Storage2DetailsText.Text = "";
                ulong capacity1 = (ulong)storage[0]["Size"] / 1024 / 1024 / 1024;
                ulong capacity2 = (ulong)storage[1]["Size"] / 1024 / 1024 / 1024;
                string type1 = (string)storage[0]["MediaType"];
                string type2 = (string)storage[1]["MediaType"];
                Storage1DetailsText.Text += "Drive 1" + "\n  Type: " + type1 + "\n  Capacity " + capacity1.ToString() + "GB\n  Speed " + storage[0]["InterfaceType"] + "\n";
                Storage2DetailsText.Text += "Drive 2" + "\n  Type: " + type2 + "\n  Capacity " + capacity2.ToString() + "GB\n  Speed " + storage[1]["InterfaceType"] + "\n";
                Storage1DetailsText.Visible = true;
                Storage2DetailsText.Visible = true;
            }

            if (intensiveMode == false)
            {
                string exePath = Path.Combine(Environment.CurrentDirectory, "storage.exe");
                string argument = "1";
                ProcessStartInfo psi = new ProcessStartInfo(exePath)
                {
                    Arguments = argument,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                Process process = new Process
                {
                    StartInfo = psi
                };
                process.Start();
                process.WaitForExit();

                string fileContent = File.ReadAllText("outStorage.txt");

                if (float.TryParse(fileContent, out float floatValue))
                {
                    StorageWriteResult.Text = floatValue.ToString("0.00#");
                }

                StorageWriteResult.Visible = true;

                argument = "2";
                psi = new ProcessStartInfo(exePath)
                {
                    Arguments = argument,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                process = new Process
                {
                    StartInfo = psi
                };
                process.Start();
                process.WaitForExit();

                fileContent = File.ReadAllText("outStorage.txt");

                if (float.TryParse(fileContent, out floatValue))
                {
                    StorageReadResult.Text = floatValue.ToString("0.00#");
                }

                StorageReadResult.Visible = true;

                StoragePerformingLabel.Visible = false;
                storageButton.Visible = true;
                storageButton.Enabled = true;
                WriteToSpecificLine("history.txt", 3, StorageReadResult.Text + " " + StorageWriteResult.Text);
            }
            else
            {
                string pythonExePath = "C:\\Users\\Andrei\\AppData\\Local\\Programs\\Python\\Python310\\python.exe";
                string scriptPath = Path.Combine(Environment.CurrentDirectory, "script.py");
                string argument = "storage";
                ProcessStartInfo psi = new ProcessStartInfo(pythonExePath)
                {
                    Arguments = $"\"{scriptPath}\" {argument}",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                Process process = new Process
                {
                    StartInfo = psi
                };
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                Console.WriteLine(output);
                string[] words = output.Split('\n');

                if (words.Length >= 2)
                {
                    string writeSpeed = words[0];
                    writeSpeed = writeSpeed.Replace("\n", "").Replace("\r", ""); ;
                    string readSpeed = words[1];
                    readSpeed = readSpeed.Replace("\n", "").Replace("\r", ""); ;

                    StorageReadResult.Text = readSpeed;
                    StorageWriteResult.Text = writeSpeed;
                    StorageReadResult.Visible = true;
                    StorageWriteResult.Visible = true;
                    StoragePerformingLabel.Visible = false;

                    storageButton.Visible = true;
                    storageButton.Enabled = true;

                    WriteToSpecificLine("history.txt", 3, readSpeed + " " + writeSpeed);
                    StorageShowPlot.Visible = true;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click_2(object sender, EventArgs e)
        {

        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cpuButton_Click(sender, e);
            ramButton_Click_1(sender, e); ;
            storageButton_Click(sender, e);
        }

        private void RAMDetailsText_Click(object sender, EventArgs e)
        {

        }

        private void RAM2DetailsText_Click(object sender, EventArgs e)
        {

        }

        private void RAM1DetailsText_Click(object sender, EventArgs e)
        {
        }

        private void StorageDetailsLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            intensiveMode = !intensiveMode;
            intensiveSelectorButton.BackColor = intensiveMode ? Color.Green : Color.White;
            intensiveSelectorButton.FlatAppearance.MouseOverBackColor = intensiveMode ? Color.Green : Color.White;
            intensiveSelectorButton.FlatAppearance.MouseDownBackColor = intensiveMode ? Color.Green : Color.White;
            if (intensiveMode == false)
            {
                CPUShowPlot.Visible = false;
                RAMShowPlot.Visible = false;
                StorageShowPlot.Visible = false;
            }
        }

        private void showCPUPlot_Click(object sender, EventArgs e)
        {
            string imagePath = "cpu.jpg";

            ImageWindow imageWindow = new ImageWindow(imagePath);
            imageWindow.Text = "CPU Frquency";
            imageWindow.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string imagePath = "ram.jpg";

            ImageWindow imageWindow = new ImageWindow(imagePath);
            imageWindow.Text = "RAM Speeds";
            imageWindow.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string imagePath = "storage.jpg";

            ImageWindow imageWindow = new ImageWindow(imagePath);
            imageWindow.Text = "Storage Speeds";
            imageWindow.Show();
        }
    }

    public class ImageWindow : Form
    {
        public ImageWindow(string imagePath)
        {
            InitializeComponent(imagePath);
        }

        private void InitializeComponent(string imagePath)
        {
            this.Size = new Size(800, 600);

            // Load the image
            Image image = Image.FromFile(imagePath);

            // Display the image in a PictureBox
            PictureBox pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                Image = image,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            this.Controls.Add(pictureBox);
        }
    }
}