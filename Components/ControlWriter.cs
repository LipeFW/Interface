using System.Text;

namespace Interface.Components
{
    public class ControlWriter : TextWriter
    {
        private Control TextBox;
        public ControlWriter(Control textBox)
        {
            TextBox = textBox;
        }

        public override void Write(char value)
        {
            TextBox.Text += value;
        }

        public override void Write(string value)
        {
            TextBox.Text += value;
        }

        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }
    }
}
