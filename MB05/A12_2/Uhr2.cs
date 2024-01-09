using MB05.A12_2;
using System;
using System.Windows.Forms;

namespace MB05.A12_2
{
    public partial class Uhr2 : Form
    {
        private readonly Clock clock;

        public Uhr2()
        {
            clock = new Clock();
            if (clock != null)
            {
                InitializeComponent();
                this.clock = clock;
                UpdateClock();
            }
            else
                throw new ArgumentNullException("Reference may not be null!");
        }
        private void CmdTick_Click(object sender, EventArgs e)
        {
            clock.TriggerClockSignal();
            UpdateClock();
        }
        private void CmdStartTimer_Click(object sender, EventArgs e)
        {
            if (TmrTick.Enabled)
            {
                TmrTick.Enabled = false;
                CmdStartTimer.Text = "Starte Automatik";
                CmdTick.Enabled = true;
            }
            else
            {
                TmrTick.Enabled = true;
                CmdStartTimer.Text = "Stoppe Automatik";
                CmdTick.Enabled = false;
            }
        }
        private void UpdateClock()
        {
            TxtHour.Text = clock.Hour;
            TxtMinute.Text = clock.Minute;
        }
    }
}