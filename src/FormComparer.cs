using System;
using System.IO;
using System.Media;
using System.Windows.Forms;
using SoundComparer.WaveUtils;

namespace SoundComparer
{
    public partial class FormComparer : Form
    {
        private WaveControl wc1 { set; get; }
        private WaveControl wc2 { set; get; }
        private string _LastPath { set; get; }
		public string LastPath {
			get => string.IsNullOrEmpty(this._LastPath) ? Application.ExecutablePath : this._LastPath;
			set => this._LastPath = value;
		}

        private SoundPlayer soundPayer = null;
        public FormComparer()
        {
            InitializeComponent();
            pSound1.Controls.Clear();
            pSound2.Controls.Clear();
            btnBrowseSound1_toolTip.SetToolTip(btnBrowseSound1, "Select audio file #1");
            btnBrowseSound2_toolTip.SetToolTip(btnBrowseSound2, "Select audio file #2");
            btnPlaySound1_toolTip.SetToolTip(btnPlaySound1, "Play audio file #1");
            btnPlaySound2_toolTip.SetToolTip(btnPlaySound2, "Play audio file #2");
            btnAnalyze_toolTip.SetToolTip(btnAnalyze, "Compare files for similarities");
            btnStopPlay_toolTip.SetToolTip(btnStopPlay, "Stop Audio (Stop Play)");
        }

        private WaveControl OpenWavFile(string filename, System.Windows.Forms.Panel pSound, System.Windows.Forms.ProgressBar pbSound, System.Windows.Forms.TextBox AudioFile)
        {
            try
            {
                // Process wave control
                WaveControl wc = new WaveControl();
                wc.Name = filename;
                LastPath = Path.GetDirectoryName(filename);
                wc.Read(wc, filename, pbSound);
                wc.Refresh();

                // Add wave result
                pSound.Controls.Clear();
                pSound.Controls.Add(wc);
                AudioFile.Text = wc.Name;
                return wc;
            }
            catch ( Exception ex )
            {
                MessageBox.Show("Error while reading the sound file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private WaveControl OpenWavFile(System.Windows.Forms.Panel pSound, System.Windows.Forms.ProgressBar pbSound, System.Windows.Forms.TextBox AudioFile) 
        {
            ofdSound = new OpenFileDialog();
            ofdSound.InitialDirectory = String.IsNullOrEmpty(LastPath) ? "c:\\" : LastPath;
            ofdSound.Filter = "WAV files (*.wav)|*.wav";
            ofdSound.FilterIndex = 2;
            ofdSound.RestoreDirectory = true;
            WaveControl wc = null;
            if ( ofdSound.ShowDialog() == DialogResult.OK )
                wc = OpenWavFile(ofdSound.FileName, pSound, pbSound, AudioFile);
            return wc;
        }

        private void btnBrowseSound1_Click(object sender, EventArgs e)
        {
            wc1 = OpenWavFile( pSound1, pbSound1, AudioFile1);
            Analyze();
        }

        private void btnPlaySound1_Click(object sender, EventArgs e)
        {
            try
            {
                if (wc1 != null && File.Exists(wc1.Name))
                {
                    if ( soundPayer != null )
                        soundPayer.Stop();
                    soundPayer = new SoundPlayer(wc1.Name);
                    soundPayer.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while playing the sound file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowseSound2_Click(object sender, EventArgs e)
        {
            wc2 = OpenWavFile(pSound2, pbSound2, AudioFile2);
            Analyze();
        }

        private void btnPlaySound2_Click(object sender, EventArgs e)
        {
            try
            {
                if (wc2 != null && File.Exists(wc2.Name))
                {
                    if ( soundPayer != null )
                        soundPayer.Stop();
                    soundPayer = new SoundPlayer(wc2.Name);
                    soundPayer.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while playing the sound file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnalyze_Click(object sender, EventArgs e) => Analyze(false);
        private void Analyze(bool SilentExecute = true) {
			if (SilentExecute) {
                btnAnalyze.Text = "Analyze";
                if (wc1 == null || wc2 == null)
					return;
				System.Threading.Thread.Sleep(500);
			}
            else {
                wc1 = OpenWavFile(AudioFile1.Text, pSound1, pbSound1, AudioFile1);
                wc2 = OpenWavFile(AudioFile2.Text, pSound2, pbSound2, AudioFile2);
                System.Threading.Thread.Sleep(3000);
            }
			if (wc1 == null)
				MessageBox.Show("The first sound should be loaded first before analyzing", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else if (wc2 == null)
				MessageBox.Show("The second sound should be loaded first before analyzing", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else {
				wc1.DrawWave = true;
				wc2.DrawWave = true;

				try {
					// Compare 2 ware controls
					float accuracy = wc2.Sound.Compare(wc1.Sound);
					lbAnalyze.Text = "Accuracy = " + accuracy + "%";
                    btnAnalyze.Text = "Reanalyze";

                }
				catch (Exception ex) {
					if (!SilentExecute)
						MessageBox.Show("Error while analyzing the sound files: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

        private void btnStopPlay_Click(object sender, EventArgs e)
        {
            if ( soundPayer == null )
                return;
            soundPayer.Stop();
            soundPayer = null;
        }
    }
}
