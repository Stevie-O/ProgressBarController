using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ProgressBarControllerDemo
{
    /// <summary>
    /// Indicates the progress bar's state.
    /// </summary>
    public enum ProgressBarState
    {
        /// <summary>
        /// Normal progress bar
        /// </summary>
        Normal = 1,
        /// <summary>
        /// Displaying an error
        /// </summary>
        Error = 2,
        /// <summary>
        /// Paused
        /// </summary>
        Paused = 3,
    }

    public abstract class ProgressBarController
    {
        protected readonly ProgressBar _bar;

        protected ProgressBarController(ProgressBar bar)
        {
            if (bar == null) throw new ArgumentNullException(nameof(bar));
            _bar = bar;
        }

        public virtual bool CanSetState { get { return false; } }
        public virtual ProgressBarState State { get { throw new NotSupportedException(); } set { throw new NotSupportedException(); } }

        public static ProgressBarController CreateProgressBarController(ProgressBar bar)
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                case PlatformID.Win32Windows:
                    return new Win32ProgressBarController(bar);
                default:
                    return new UnsupportedProgressBarController(bar);
            }
        }
    }

    public class UnsupportedProgressBarController : ProgressBarController
    {
        public UnsupportedProgressBarController(ProgressBar bar) : base(bar)
        {
        }
    }

    public class Win32ProgressBarController : ProgressBarController
    {
        const int WM_USER = 0x0400;
        const int PBM_SETSTATE = (WM_USER + 16);
        const int PBM_GETSTATE = (WM_USER + 17);

        [DllImport("user32", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        public Win32ProgressBarController(ProgressBar bar) : base(bar)
        {
        }

        public override bool CanSetState
        {
            get
            {
                // PBM_GETSTATE and PBM_SETSTATE was added in Vista
                return (Environment.OSVersion.Version.Major >= 6);
            }
        }

        public override ProgressBarState State
        {
            get
            {
                int result = (int)SendMessage(_bar.Handle, PBM_GETSTATE, IntPtr.Zero, IntPtr.Zero);
                return (ProgressBarState)result;
            }

            set
            {
                SendMessage(_bar.Handle, PBM_SETSTATE, (IntPtr)(int)value, IntPtr.Zero);
            }
        }
    }
}