using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Management management = new Management();
        DateTime voteTime = new DateTime(2021, 04, 17, 10, 0, 0);
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick_1;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            TimeSpan TimeRemaining = voteTime - DateTime.Now;
            OTTime.Text = TimeRemaining.Hours + " : " + TimeRemaining.Minutes + " : " + TimeRemaining.Seconds;
            Time1.Text = DateTime.Now.ToString("d") + "  " + DateTime.Now.ToString("T") + "  " + DateTime.Now.ToString("dddd");

        }

        #region  Банк
        private void button1_Click(object sender, EventArgs e)
        {
            int ID = 0;
            management.ADDAcount(ref ID);
            Amount.Text = (Convert.ToInt32(1000).ToString());
            IncreaseAmount.Text = (Convert.ToInt32(20).ToString());
            MonthNumber.Text = (Convert.ToInt32(0).ToString());
            string Message = "Запомните ваш ID.\nID : " + Convert.ToString(ID);
            comboBox1.Items.Add(Convert.ToString(ID));
            MessageBox.Show(Message);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int _MonthNumber = Int32.Parse(MonthNumber.Text);
            int _Amount = Int32.Parse(Amount.Text);
            int _IncreaseAmount = Int32.Parse(IncreaseAmount.Text);
            management.TotalIncreaseAmoun(ref _Amount, ref _IncreaseAmount, ref _MonthNumber);
            Amount.Text = Convert.ToString(_Amount);
            IncreaseAmount.Text = Convert.ToString(_IncreaseAmount);
            MonthNumber.Text = (Convert.ToString(_MonthNumber));
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int _MonthNumber = 0;
            int _Amount = 0;
            int _IncreaseAmount = 0;
            int _ID = Int32.Parse(IDNumber.Text);
            management.TotalLoad(ref _ID, ref _MonthNumber, ref _Amount, ref _IncreaseAmount);
            Amount.Text = Convert.ToString(_Amount);
            IncreaseAmount.Text = Convert.ToString(_IncreaseAmount);
            MonthNumber.Text = (Convert.ToString(_MonthNumber));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int ID = 0;
            int _MonthNumber = 0;
            int _Amount = 0;
            int _IncreaseAmount = 0;

            management.ADDRandom(ref ID, ref _Amount, ref _IncreaseAmount, ref _MonthNumber);
            Amount.Text = Convert.ToString(_Amount);
            IncreaseAmount.Text = Convert.ToString(_IncreaseAmount);
            MonthNumber.Text = (Convert.ToString(_MonthNumber));
            string Message = "Запомните ваш ID.\nID : " + Convert.ToString(ID);
            comboBox1.Items.Add(Convert.ToString(ID));
            MessageBox.Show(Message);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            int dlina = 0;
            int _ID = Int32.Parse(comboBox1.Text);
            if (comboBox1.Text != null)
            {
                management.Del(_ID, ref dlina);
                comboBox1.Items.RemoveAt(dlina);
            }

        }
        private void button13_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            int _MonthNumber = 0;
            int _Amount = 0;
            int _IncreaseAmount = 0;
            int _ID = Int32.Parse(comboBox1.Text);
            if (comboBox1.Text != null)
            {
                management.CombolLoad(ref _ID, ref _MonthNumber, ref _Amount, ref _IncreaseAmount);
            }
           fm2.IDNumber.Text = Convert.ToString(_ID);
            fm2.Amount.Text = Convert.ToString(_Amount);
            fm2.IncreaseAmount.Text = Convert.ToString(_IncreaseAmount);
            fm2.MonthNumber.Text = (Convert.ToString(_MonthNumber));
            fm2.ShowDialog();
        }
        #endregion


        #region Лыжник
        private void button6_Click(object sender, EventArgs e)
        {
            int ID = 0;
            management.ADDSkier(ref ID);
            TotalDistance.Text = (Convert.ToInt32(10000).ToString());
            DistanceSkier.Text = (Convert.ToInt32(10000).ToString());
            DaySkier.Text = (Convert.ToInt32(0).ToString());
            string Message = "Запомните ваш ID.\nID : " + Convert.ToString(ID);
            comboBox2.Items.Add(Convert.ToString(ID));
            MessageBox.Show(Message);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int _MonthNumber = Int32.Parse(DaySkier.Text);
            int _TotalDistance = Int32.Parse(TotalDistance.Text);
            int _DistanceSkier = Int32.Parse(DistanceSkier.Text);
            management.TotalIncreaseSkier(ref _TotalDistance, ref _DistanceSkier, ref _MonthNumber);
            TotalDistance.Text = Convert.ToString(_TotalDistance);
            DistanceSkier.Text = Convert.ToString(_DistanceSkier);
            DaySkier.Text = (Convert.ToString(_MonthNumber));
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int _MonthNumber = 0;
            int _TotalDistance = 0;
            int _DistanceSkier = 0;
            int _ID = Int32.Parse(IDSkier.Text);
            management.TotalLoadSkier(ref _ID, ref _MonthNumber, ref _DistanceSkier, ref _TotalDistance);
            TotalDistance.Text = Convert.ToString(_TotalDistance);
            DistanceSkier.Text = Convert.ToString(_DistanceSkier);
            DaySkier.Text = (Convert.ToString(_MonthNumber));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int ID = 0;
            int _MonthNumber = 0;
            int _TotalDistance = 0;
            int _DistanceSkier = 0;
            management.ADDSkierRandom(ref ID, ref _TotalDistance, ref _DistanceSkier, ref _MonthNumber);
            TotalDistance.Text = Convert.ToString(_TotalDistance);
            DistanceSkier.Text = Convert.ToString(_DistanceSkier);
            DaySkier.Text = (Convert.ToString(_MonthNumber));
            string Message = "Запомните ваш ID.\nID : " + Convert.ToString(ID);
            comboBox2.Items.Add(Convert.ToString(ID));
            MessageBox.Show(Message);
        }
        private void button15_Click(object sender, EventArgs e)
        {
            int dlina = 0;
            int _ID = Int32.Parse(comboBox2.Text);
            if (comboBox2.Text != null)
            {
                management.DELSkier(_ID, ref dlina);
                comboBox2.Items.RemoveAt(dlina);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            int _MonthNumber = 0;
            int _TotalDistance = 0;
            int _DistanceSkier = 0;
            int _ID = Int32.Parse(comboBox2.Text);
            if (comboBox2.Text != null)
            {
                management.CombolLoadSkier(ref _ID, ref _MonthNumber, ref _TotalDistance, ref _DistanceSkier);
            }
            fm3.IDNumber.Text = Convert.ToString(_ID);
            fm3.Amount.Text = Convert.ToString(_TotalDistance);
            fm3.IncreaseAmount.Text = Convert.ToString(_DistanceSkier);
            fm3.MonthNumber.Text = (Convert.ToString(_MonthNumber));
            fm3.ShowDialog();
        }
        #endregion
        #region Сельхоз
        private void button9_Click(object sender, EventArgs e)
        {
            int ID = 0;
            management.ADDHarvest(ref ID);
            Yield.Text = (Convert.ToInt32(2000).ToString());
            Square.Text = (Convert.ToInt32(100).ToString());
            Year.Text = (Convert.ToInt32(0).ToString());
            TotalYield.Text = (Convert.ToInt32(2000).ToString());
            string Message = "Запомните ваш ID.\nID : " + Convert.ToString(ID);
            comboBox3.Items.Add(Convert.ToString(ID));
            MessageBox.Show(Message);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            int _Yield = Int32.Parse(Yield.Text);
            int _Square = Int32.Parse(Square.Text);
            int _Year = Int32.Parse(Year.Text);
            int _TotalYield = Int32.Parse(TotalYield.Text);
            management.TotalHarvest(ref _TotalYield, ref _Square, ref _Yield, ref _Year);
            Yield.Text = Convert.ToString(_Yield);
            Square.Text = Convert.ToString(_Square);
            Year.Text = (Convert.ToString(_Year));
            TotalYield.Text = (Convert.ToString(_TotalYield));
        }
        private void button7_Click(object sender, EventArgs e)
        {
            int _Yield = 0;
            int _Square = 0;
            int _Year = 0;
            int _TotalYield = 0;
            int _ID = Int32.Parse(IDHarvest.Text);
            management.TotalLoadHarvest(ref _ID, ref _TotalYield, ref _Square, ref _Yield, ref _Year);
            Yield.Text = Convert.ToString(_Yield);
            Square.Text = Convert.ToString(_Square);
            Year.Text = (Convert.ToString(_Year));
            TotalYield.Text = (Convert.ToString(_TotalYield));
        }
        private void button12_Click(object sender, EventArgs e)
        {
            int ID = 0;
            int _Yield = 0;
            int _Square = 0;
            int _Year = 0;
            int _TotalYield = 0;
            management.ADDHarvestRandom(ref ID, ref _Yield, ref _Square, ref _Year, ref _TotalYield);
            Yield.Text = Convert.ToString(_Yield);
            Square.Text = Convert.ToString(_Square);
            Year.Text = (Convert.ToString(_Year));
            TotalYield.Text = (Convert.ToString(_TotalYield));
            string Message = "Запомните ваш ID.\nID : " + Convert.ToString(ID);
            comboBox3.Items.Add(Convert.ToString(ID));
            MessageBox.Show(Message);
        }
        private void button17_Click(object sender, EventArgs e)
        {
            int dlina = 0;
            int _ID = Int32.Parse(comboBox3.Text);
            if (comboBox3.Text != null)
            {
                management.DELHarvest(_ID, ref dlina);
                comboBox3.Items.RemoveAt(dlina);
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            Form4 fm4 = new Form4();        
            int _Yield = 0;
            int _Square = 0;
            int _Year = 0;
            int _TotalYield = 0;
            int _ID = Int32.Parse(comboBox3.Text);
            if (comboBox3.Text != null)
            {
                management.CombolLoadHarvest(ref _ID, ref _Yield, ref _Square, ref _Year, ref _TotalYield);
            }
            fm4.Yield.Text = Convert.ToString(_Yield);
            fm4.Square.Text = Convert.ToString(_Square);
            fm4.Year.Text = (Convert.ToString(_Year));
            fm4.TotalYield.Text = (Convert.ToString(_TotalYield));
            fm4.ShowDialog();
        }
        #endregion


    }
}