namespace MB08.A12_1
{
    public partial class Uhr1 : Form
    {
        private int hour;
        private int minute;
        private int limitHour = 24;
        private int limitMinute = 60;

        public Uhr1()
        {
            hour = 23;
            minute = 55;
            InitializeComponent();
        }

        private void CmdTick_Click(object sender, EventArgs e)
        {
            minute = (minute + 1) % limitMinute;
            if (minute == 0)
                hour = hour == limitHour - 1 ? 0 : hour + 1;
            
            hour =+3;


            TxtHour.Text = ConvertValue(hour);
            TxtMinute.Text = ConvertValue(minute);
        }

        private string ConvertValue(int value)
        {
            if (value < 10)
                return "0" + value;
            else
                return "" + value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtHour.Text = ConvertValue(hour);
            TxtMinute.Text = ConvertValue(minute);
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
    }
}