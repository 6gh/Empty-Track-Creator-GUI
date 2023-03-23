using System;
using System.Diagnostics;

namespace Empty_Track_Creator_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OutputPathTXT.Text = Properties.Settings.Default.OutputPath;
            MelodyTrackCount.Value = Properties.Settings.Default.MelodyTracks;
            ArtTracksCount.Value = Properties.Settings.Default.ArtTracks;
            BPMNum.Value = Properties.Settings.Default.BPM;
            DrumsChk.Checked = Properties.Settings.Default.DrumsChannel;
            PPQBox.SelectedIndex = PPQBox.Items.IndexOf(Properties.Settings.Default.PPQ);
            InputPathTXT.Text = Properties.Settings.Default.InputPath;

            toolTip1.SetToolTip(DrumsChk, "If unchecked, will skip adding channel 10");

            if (!File.Exists(Path.Join(Directory.GetCurrentDirectory(), "empty-track-creator-cli.exe")))
            {
                if (MessageBox.Show("Couldn't find empty-track-creator-cli.exe in the current directory. The CLI exe must be in the same directory as this exe, and must be named exactly \"empty-track-creator-cli.exe\"!\n\nWould you like to open the latest CLI release?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Process.Start("https://github.com/6gh/Empty-Track-Creator/releases/latest");
                }
            }
        }

        private void BrowseBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "MIDI File (*.mid)|*.mid",
                Title = "Save as MIDI (.mid)",
                Multiselect = false,
                CheckFileExists = false,
                CheckPathExists = true,
                DefaultExt = "mid",
                InitialDirectory = Path.GetDirectoryName(OutputPathTXT.Text),
                FileName = Path.GetFileName(OutputPathTXT.Text)
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OutputPathTXT.Text = openFileDialog.FileName;
            }
        }

        private void CreateBTN_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Path.Join(Directory.GetCurrentDirectory(), "empty-track-creator-cli.exe")))
            {
                MessageBox.Show("Couldn't find empty-track-creator-cli.exe in the current directory. Please put the exe in the same directory as this exe.\n\nNote: Must be named exactly \"empty-track-creator-cli.exe\"!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OutputBox.Clear();
            
            ProcessStartInfo pInfo = new ProcessStartInfo("empty-track-creator-cli.exe");
            pInfo.CreateNoWindow = true;
            pInfo.RedirectStandardInput = true;
            pInfo.RedirectStandardOutput = true;
            pInfo.RedirectStandardError = true;
            pInfo.UseShellExecute = false;
            pInfo.WindowStyle = ProcessWindowStyle.Hidden;
            pInfo.Arguments = $"-melody {MelodyTrackCount.Value} -art {ArtTracksCount.Value} -output \"{OutputPathTXT.Text}\" -ppq {PPQBox.Text} -bpm {BPMNum.Value}";
            if (DrumsChk.Checked)
            {
                pInfo.Arguments += " -drums";
            }
            if (!string.IsNullOrEmpty(InputPathTXT.Text))
            {
                pInfo.Arguments += $" -input \"{InputPathTXT.Text}\"";
            }
            if (enableTimerToolStripMenuItem.Checked)
            {
                pInfo.Arguments += $" -benchmark";
            }

            Process p = new Process();
            p.StartInfo = pInfo;

            if (p.Start() == true)
            {
                CommandTXT.Text = $"{pInfo.FileName} {pInfo.Arguments}";

                p.OutputDataReceived += new DataReceivedEventHandler(p_ouputDataReceived);
                p.ErrorDataReceived += new DataReceivedEventHandler(p_ErrorDataReceived);
                p.Exited += new EventHandler(p_Exited);

                p.BeginOutputReadLine();
                p.BeginErrorReadLine();
            }
        }

        void p_ouputDataReceived(object sender, DataReceivedEventArgs e)
        {
            UpdateConsole(e.Data);
        }

        void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            UpdateConsole(e.Data);
        }

        void p_Exited(object sender, EventArgs e)
        {
            UpdateConsole("\n============\nCLI Program Exited.");
        }

        void UpdateConsole(string text)
        {
            if (text == null)
            {
                return;
            }

            try
            {
                if (OutputBox.InvokeRequired)
                {
                    OutputBox.Invoke(new Action(() =>
                    {
                        OutputBox.AppendText(text + Environment.NewLine);
                        OutputBox.ScrollToCaret();
                    }));
                } else
                {
                    OutputBox.AppendText(text + Environment.NewLine);
                    OutputBox.ScrollToCaret();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("An Error Occurred", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.OutputPath = OutputPathTXT.Text;
            Properties.Settings.Default.MelodyTracks = ((int)MelodyTrackCount.Value);
            Properties.Settings.Default.ArtTracks = ((int)ArtTracksCount.Value);
            Properties.Settings.Default.BPM = ((int)BPMNum.Value);
            Properties.Settings.Default.DrumsChannel = DrumsChk.Checked;
            Properties.Settings.Default.PPQ = PPQBox.Items[PPQBox.SelectedIndex].ToString();
            Properties.Settings.Default.InputPath = InputPathTXT.Text;

            Properties.Settings.Default.Save();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }

        private void InputBrowseBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "MIDI File (*.mid)|*.mid",
                Title = "Open MIDI (.mid)",
                Multiselect = false,
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "mid",
                InitialDirectory = Path.GetDirectoryName(InputPathTXT.Text),
                FileName = Path.GetFileName(InputPathTXT.Text)
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                InputPathTXT.Text = openFileDialog.FileName;
            }
        }
    }
}