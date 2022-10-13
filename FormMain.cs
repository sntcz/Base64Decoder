namespace Base64Decoder
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDecode64_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(textBase64.Text))
                {
                    hexBox.ByteProvider = null;
                }
                else
                {
                    byte[] data = Convert.FromBase64String(textBase64.Text);
                    var byteProvider = new ArrayByteProvider(data);
                    hexBox.ByteProvider = byteProvider;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            try
            {
                textBase64.Text = null;
                hexBox.ByteProvider = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void hexBox_CurrentLineChanged(object sender, EventArgs e)
        {
            UpdatePosition();
        }

        private void hexBox_CurrentPositionInLineChanged(object sender, EventArgs e)
        {
            UpdatePosition();
        }

        private void UpdatePosition()
        {
            try
            {
                long pos = hexBox.BytesPerLine * (hexBox.CurrentLine - 1) + hexBox.CurrentPositionInLine - 1;
                if (pos < 0)
                    pos = 0;
                toolStripStatusPosition.Text = String.Format("Position: {0}", pos);
                if (hexBox.ByteProvider != null && hexBox.ByteProvider.Length > pos)
                {
                    byte b = hexBox.ByteProvider.ReadByte(pos);
                    toolStripStatusByteDec.Text = Convert.ToString(b);
                    toolStripStatusByteBin.Text = Convert.ToString(b, 2).PadLeft(8, '0').Insert(4, " ");
                }
                else
                {
                    toolStripStatusByteDec.Text = "?";
                    toolStripStatusByteBin.Text = "???? ????";
                }
            }
            catch (Exception)
            {
                toolStripStatusPosition.Text = String.Format("Position: {0}", 0);
                toolStripStatusByteDec.Text = "?";
                toolStripStatusByteBin.Text = "???? ????";
            }
        }

        private void toolStripStatusWeb_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(
                new System.Diagnostics.ProcessStartInfo("https://www.sntcz.cz") { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }

        private void toolStripStatusSupport_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(
                new System.Diagnostics.ProcessStartInfo("https://github.com/sntcz/Base64Decoder/issues") { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }
    }
}