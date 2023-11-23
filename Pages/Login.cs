using System.Runtime.InteropServices;

namespace Syncra
{
    public partial class Login : Form
    {
        #region WindowsAPI
        public enum DWMWINDOWATTRIBUTE
        {
            DWMWA_WINDOW_CORNER_PREFERENCE = 33
        }
        public enum DWM_WINDOW_CORNER_PREFERENCE
        {
            DWMWCP_DEFAULT = 0,
            DWMWCP_DONOTROUND = 1,
            DWMWCP_ROUND = 2,
            DWMWCP_ROUNDSMALL = 3
        }

        [DllImport("dwmapi.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
        internal static extern void DwmSetWindowAttribute(IntPtr hwnd, DWMWINDOWATTRIBUTE attribute, ref DWM_WINDOW_CORNER_PREFERENCE pvAttribute, uint cbAttribute);

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void DragWindow(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion WindowsAPI
        #region Initialize
        public Login()
        {
            try
            {
                var attribute = DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE;
                var preference = DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUND;
                DwmSetWindowAttribute(this.Handle, attribute, ref preference, sizeof(uint));
            }
            catch (Exception x) { }

            InitializeComponent();
        }
        #endregion Initialize

        #region Events
        private void CloseApplication(object? sender, EventArgs e) => Application.Exit();

        private void Login_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        #endregion Events

        private void RegisterButton_MouseEnter(object sender, EventArgs e)
        {
            RegisterButton.Font = new Font(RegisterButton.Font, FontStyle.Underline);
        }

        private void RegisterButton_MouseLeave(object sender, EventArgs e)
        {
            RegisterButton.Font = new Font(RegisterButton.Font, FontStyle.Regular);
        }

        private void CloseApp_MouseEnter(object sender, EventArgs e)
        {
            CloseApp.ForeColor = Color.FromArgb(50, 78, 205);
        }

        private void CloseApp_MouseLeave(object sender, EventArgs e)
        {
            CloseApp.ForeColor = Color.Black;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            new Register().ShowDialog();
        }
    }
}