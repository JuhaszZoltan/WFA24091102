namespace WFA24091102
{
    public partial class FrmMain : Form
    {
        private static Random rnd = new();

        public FrmMain()
        {
            InitializeComponent();
            btnHello.Click += BtnHello_Click;
        }

        private void BtnHello_Click(object? sender, EventArgs e)
        {
            btnHello.BackColor = Color.FromArgb(
                red: rnd.Next(256),
                green: rnd.Next(256),
                blue: rnd.Next(256));
        }
    }
}
