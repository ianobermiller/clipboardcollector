using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClipboardCollector
{
    public partial class uxMainForm : Form
    {
        #region Private Variables
        private string oldContents = string.Empty;
        #endregion

        #region Constructor
        public uxMainForm()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }
        #endregion

        #region Form Events
        private void uxMainForm_Load(object sender, EventArgs e)
        {
            Start();
        }

        private void uxTimer_Tick(object sender, EventArgs e)
        {
            AppendClipboard();
        }

        private void uxPause_Click(object sender, EventArgs e)
        {
            TogglePause();
        }

        private void uxCopy_Click(object sender, EventArgs e)
        {
            CopyContentsToClipboard();
        }

        private void uxClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void uxAbout_Click(object sender, EventArgs e)
        {
            ShowAbout();
        }
        #endregion

        #region Helper Methods
        private void Start()
        {
            uxPause.Text = "Pause";
            oldContents = GetClipboardText();
            uxTimer.Enabled = true;
        }

        private void Stop()
        {
                uxPause.Text = "Start";
                uxTimer.Enabled = false;
        }

        private void AppendClipboard()
        {
            string currentContents = GetClipboardText();
            if (currentContents != string.Empty && !currentContents.Equals(oldContents))
            {
                uxText.AppendText(currentContents + Environment.NewLine);
                oldContents = currentContents;
            }
        }

        private void TogglePause()
        {
            if (uxTimer.Enabled)
            {
                Stop();
            }
            else
            {
                Start();
            }
        }

        private string GetClipboardText()
        {
            if (!Clipboard.ContainsText())
                return string.Empty;
            return Clipboard.GetText();
        }

        private void CopyContentsToClipboard()
        {
            uxTimer.Enabled = false;

            oldContents = uxText.Text;
            Clipboard.SetText(oldContents);

            uxTimer.Enabled = true;
        }

        private void ClearText()
        {
            uxText.Clear();
        }

        private void ShowAbout()
        {
            MessageBox.Show(
                @"Developed by Ian Obermiller, http://ianobermiller.com.
Icon courtesy of the Tango Desktop Project, http://tango.freedesktop.org/.", 
                "About ClipboardCollector", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
        #endregion
    }
}
