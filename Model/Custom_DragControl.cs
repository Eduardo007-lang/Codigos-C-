using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Windows.Forms;
using System;



namespace TP1.Model
{
    class Custom_DragControl : Component
    {
        private Control Handle_Control;
        public Control Select_Control
        {
            get => this.Handle_Control;
            set
            {
                this.Handle_Control = value;
                this.Handle_Control.MouseDown += new MouseEventHandler(this.DragForm_MouseDown);
            }
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr a, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DragForm_MouseDown(object sender, MouseEventArgs e)
        {
            bool flag = e.Button == MouseButtons.Left;
            if (flag)
            {
                Custom_DragControl.ReleaseCapture();
                Custom_DragControl.SendMessage(this.Select_Control.FindForm().Handle, 161, 2, 0);
            }
        }
    }
}
