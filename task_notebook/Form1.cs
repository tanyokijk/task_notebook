using System;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace task_notebook
{
    public partial class Form1 : Form
    {
        private Process programProcess;
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            string programPath = @"c:\Windows\System32\notepad.exe";
            if (programProcess == null || programProcess.HasExited)
            {
                programProcess = new Process();
                programProcess.StartInfo.FileName = programPath;
                try
                {
                    programProcess.Start();
                    label1.Text = "Ідентифікатор процеса - " + programProcess.Id.ToString();
                    label1.Text += "; назва процеса - " + programProcess.ProcessName.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не вдалося відкрити програму: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            string processName = "notepad";
            try
            {
                Process[] processes = Process.GetProcessesByName(processName);
                foreach (Process process in processes)
                {
                    process.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gмилка при завершенні процесу: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}