using System.Drawing;

namespace SoundComparer
{
    partial class FormComparer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComparer));
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.pbSound1 = new System.Windows.Forms.ProgressBar();
            this.pbSound2 = new System.Windows.Forms.ProgressBar();
            this.lbAnalyze = new System.Windows.Forms.TextBox();
            this.pSound2 = new System.Windows.Forms.Panel();
            this.ofdSound = new System.Windows.Forms.OpenFileDialog();
            this.pSound1 = new System.Windows.Forms.Panel();
            this.AudioFile1 = new System.Windows.Forms.TextBox();
            this.AudioFile2 = new System.Windows.Forms.TextBox();
            this.AudioGrp1 = new System.Windows.Forms.GroupBox();
            this.btnBrowseSound1 = new System.Windows.Forms.Button();
            this.btnPlaySound1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPlaySound2 = new System.Windows.Forms.Button();
            this.btnStopPlay = new System.Windows.Forms.Button();
            this.btnBrowseSound2 = new System.Windows.Forms.Button();
            this.btnBrowseSound1_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnBrowseSound2_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnPlaySound1_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnPlaySound2_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnAnalyze_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnStopPlay_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AudioGrp1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyze.Location = new System.Drawing.Point(18, 582);
            this.btnAnalyze.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(159, 45);
            this.btnAnalyze.TabIndex = 0;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // pbSound1
            // 
            this.pbSound1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSound1.Location = new System.Drawing.Point(18, 189);
            this.pbSound1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbSound1.Maximum = 500;
            this.pbSound1.Name = "pbSound1";
            this.pbSound1.Size = new System.Drawing.Size(799, 39);
            this.pbSound1.TabIndex = 2;
            // 
            // pbSound2
            // 
            this.pbSound2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSound2.Location = new System.Drawing.Point(18, 480);
            this.pbSound2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbSound2.Maximum = 500;
            this.pbSound2.Name = "pbSound2";
            this.pbSound2.Size = new System.Drawing.Size(799, 39);
            this.pbSound2.TabIndex = 3;
            // 
            // lbAnalyze
            // 
            this.lbAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAnalyze.Enabled = false;
            this.lbAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnalyze.Location = new System.Drawing.Point(192, 582);
            this.lbAnalyze.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbAnalyze.Name = "lbAnalyze";
            this.lbAnalyze.Size = new System.Drawing.Size(544, 43);
            this.lbAnalyze.TabIndex = 4;
            this.lbAnalyze.Text = "Select 2 audio files to compare";
            this.lbAnalyze.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pSound2
            // 
            this.pSound2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pSound2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pSound2.Location = new System.Drawing.Point(18, 319);
            this.pSound2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pSound2.Name = "pSound2";
            this.pSound2.Size = new System.Drawing.Size(799, 151);
            this.pSound2.TabIndex = 5;
            // 
            // ofdSound
            // 
            this.ofdSound.FileName = "openFileDialog1";
            // 
            // pSound1
            // 
            this.pSound1.BackColor = System.Drawing.SystemColors.Control;
            this.pSound1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pSound1.Location = new System.Drawing.Point(18, 28);
            this.pSound1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pSound1.Name = "pSound1";
            this.pSound1.Size = new System.Drawing.Size(794, 151);
            this.pSound1.TabIndex = 6;
            // 
            // AudioFile1
            // 
            this.AudioFile1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AudioFile1.Enabled = false;
            this.AudioFile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AudioFile1.Location = new System.Drawing.Point(18, 234);
            this.AudioFile1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AudioFile1.Name = "AudioFile1";
            this.AudioFile1.Size = new System.Drawing.Size(890, 26);
            this.AudioFile1.TabIndex = 11;
            // 
            // AudioFile2
            // 
            this.AudioFile2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AudioFile2.Enabled = false;
            this.AudioFile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AudioFile2.Location = new System.Drawing.Point(18, 525);
            this.AudioFile2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AudioFile2.Name = "AudioFile2";
            this.AudioFile2.Size = new System.Drawing.Size(892, 26);
            this.AudioFile2.TabIndex = 12;
            // 
            // AudioGrp1
            // 
            this.AudioGrp1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AudioGrp1.Controls.Add(this.btnBrowseSound1);
            this.AudioGrp1.Controls.Add(this.btnPlaySound1);
            this.AudioGrp1.Location = new System.Drawing.Point(12, 1);
            this.AudioGrp1.Name = "AudioGrp1";
            this.AudioGrp1.Size = new System.Drawing.Size(907, 271);
            this.AudioGrp1.TabIndex = 13;
            this.AudioGrp1.TabStop = false;
            this.AudioGrp1.Text = "Audio File #1";
            // 
            // btnBrowseSound1
            // 
            this.btnBrowseSound1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseSound1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowseSound1.Image = global::SoundComparer.Properties.Resources.TransparentYellowFolder_Add_48;
            this.btnBrowseSound1.Location = new System.Drawing.Point(812, 26);
            this.btnBrowseSound1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowseSound1.Name = "btnBrowseSound1";
            this.btnBrowseSound1.Size = new System.Drawing.Size(85, 85);
            this.btnBrowseSound1.TabIndex = 7;
            this.btnBrowseSound1.UseVisualStyleBackColor = true;
            this.btnBrowseSound1.Click += new System.EventHandler(this.btnBrowseSound1_Click);
            // 
            // btnPlaySound1
            // 
            this.btnPlaySound1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlaySound1.AutoEllipsis = true;
            this.btnPlaySound1.Image = global::SoundComparer.Properties.Resources.TransparentBluePlayButton_48;
            this.btnPlaySound1.Location = new System.Drawing.Point(812, 140);
            this.btnPlaySound1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlaySound1.Name = "btnPlaySound1";
            this.btnPlaySound1.Size = new System.Drawing.Size(85, 85);
            this.btnPlaySound1.TabIndex = 9;
            this.btnPlaySound1.UseVisualStyleBackColor = true;
            this.btnPlaySound1.Click += new System.EventHandler(this.btnPlaySound1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnPlaySound2);
            this.groupBox1.Location = new System.Drawing.Point(9, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 271);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Audio File #2";
            // 
            // btnPlaySound2
            // 
            this.btnPlaySound2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlaySound2.Image = global::SoundComparer.Properties.Resources.TransparentBluePlayButton_48;
            this.btnPlaySound2.Location = new System.Drawing.Point(812, 142);
            this.btnPlaySound2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlaySound2.Name = "btnPlaySound2";
            this.btnPlaySound2.Size = new System.Drawing.Size(85, 85);
            this.btnPlaySound2.TabIndex = 10;
            this.btnPlaySound2.UseVisualStyleBackColor = true;
            this.btnPlaySound2.Click += new System.EventHandler(this.btnPlaySound2_Click);
            // 
            // btnStopPlay
            // 
            this.btnStopPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopPlay.Image = global::SoundComparer.Properties.Resources.StopButton;
            this.btnStopPlay.Location = new System.Drawing.Point(809, 570);
            this.btnStopPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStopPlay.Name = "btnStopPlay";
            this.btnStopPlay.Size = new System.Drawing.Size(96, 57);
            this.btnStopPlay.TabIndex = 15;
            this.btnStopPlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStopPlay.UseVisualStyleBackColor = true;
            this.btnStopPlay.Click += new System.EventHandler(this.btnStopPlay_Click);
            // 
            // btnBrowseSound2
            // 
            this.btnBrowseSound2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseSound2.Image = global::SoundComparer.Properties.Resources.TransparentYellowFolder_Add_48;
            this.btnBrowseSound2.Location = new System.Drawing.Point(822, 319);
            this.btnBrowseSound2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowseSound2.Name = "btnBrowseSound2";
            this.btnBrowseSound2.Size = new System.Drawing.Size(85, 85);
            this.btnBrowseSound2.TabIndex = 8;
            this.btnBrowseSound2.UseVisualStyleBackColor = true;
            this.btnBrowseSound2.Click += new System.EventHandler(this.btnBrowseSound2_Click);
            // 
            // FormComparer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 629);
            this.Controls.Add(this.btnStopPlay);
            this.Controls.Add(this.AudioFile2);
            this.Controls.Add(this.AudioFile1);
            this.Controls.Add(this.btnBrowseSound2);
            this.Controls.Add(this.pSound2);
            this.Controls.Add(this.lbAnalyze);
            this.Controls.Add(this.pbSound2);
            this.Controls.Add(this.pbSound1);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.pSound1);
            this.Controls.Add(this.AudioGrp1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormComparer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sound Comparer";
            this.AudioGrp1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.ProgressBar pbSound1;
        private System.Windows.Forms.ProgressBar pbSound2;
        private System.Windows.Forms.TextBox lbAnalyze;
        private System.Windows.Forms.Panel pSound2;
        private System.Windows.Forms.Panel pSound1;
        private System.Windows.Forms.OpenFileDialog ofdSound;
        private System.Windows.Forms.Button btnBrowseSound1;
        private System.Windows.Forms.Button btnBrowseSound2;
        private System.Windows.Forms.Button btnPlaySound1;
        private System.Windows.Forms.Button btnPlaySound2;
		private System.Windows.Forms.TextBox AudioFile1;
		private System.Windows.Forms.TextBox AudioFile2;
		private System.Windows.Forms.GroupBox AudioGrp1;
		private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStopPlay;
        private System.Windows.Forms.ToolTip btnBrowseSound1_toolTip;
        private System.Windows.Forms.ToolTip btnBrowseSound2_toolTip;
        private System.Windows.Forms.ToolTip btnPlaySound1_toolTip;
        private System.Windows.Forms.ToolTip btnPlaySound2_toolTip;
        private System.Windows.Forms.ToolTip btnAnalyze_toolTip;
        private System.Windows.Forms.ToolTip btnStopPlay_toolTip;
    }
}

