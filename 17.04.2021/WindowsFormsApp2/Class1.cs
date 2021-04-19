using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Management
    {
        #region BANK
        Bank[] banks = new Bank[0];
        private int IDBank;
        public void ADDAcount(ref int _ID)
        {
            _ID = IDBank;
            Array.Resize(ref banks, banks.Length + 1);
            banks[banks.Length - 1] = new Bank(ref _ID);
            IDBank = _ID;         
        }
        public void ADDRandom(ref int _ID, ref int _Payment, ref int _Amount, ref int _Month)
        {
            _ID = IDBank;
            Array.Resize(ref banks, banks.Length + 1);
            banks[banks.Length - 1] = new Bank(ref _ID, ref _Payment, ref _Amount, ref _Month);
            IDBank = _ID;
        }
        public void TotalIncreaseAmoun(ref int _Payment, ref int _Amount, ref int _Month)
        {
            for (int i = 0; i < banks.Length; i++)
            {
                if (i == IDBank-1)
                    banks[i].IncreaseAmoun(ref _Payment, ref _Amount, ref _Month);
            }
        }
        public void TotalLoad(ref int _ID, ref int _Month, ref int _Payment, ref int _Amount)
        {
            for(int i=0; i<banks.Length; i++)
            {
                if (i == _ID - 1)
                    banks[i].Load(ref _Month, ref _Payment, ref _Amount);
            }
        }
        public void CombolLoad(ref int _ID, ref int _Month, ref int _Payment, ref int _Amount)
        {
            for (int i = 0; i < banks.Length; i++)
            {
                if (i == _ID - 1)
                    banks[i].ComboLoad(ref _Month, ref _Payment, ref _Amount);
            }


        }


        public void Del(int _ID, ref int Dlina)
        {
            int _temp_index = -1;

            for (int i = 0; i < banks.Length; i++)
            {
                if (i == _ID - 1)
                    _temp_index = i;
            }

            if (_temp_index > -1)
            {
                Bank[] temp = new Bank[banks.Length - 1];
                for (int i = 0; i < _temp_index; i++)
                    temp[i] = banks[i];
                for (int i = _temp_index + 1; i < banks.Length; i++)
                    temp[i - 1] = banks[i];
                banks = temp;
                
            }
            IDBank = IDBank - 1;
            Dlina = banks.Length;
        }
        #endregion
        #region Skier
            Skier[] skier = new Skier[0];
        private int IDSkier;

        public void CombolLoadSkier(ref int _ID, ref int _MonthNumber, ref int _TotalDistance, ref int _DistanceSkier)
        {
            for (int i = 0; i < skier.Length; i++)
            {
                if (i == _ID - 1)
                    skier[i].ComboLoadSkier(ref _MonthNumber, ref _TotalDistance, ref _DistanceSkier);
            }
        }
        public void DELSkier(int _ID, ref int Dlina)
        {
            int _temp_index = -1;

            for (int i = 0; i < skier.Length; i++)
            {
                if (i == _ID - 1)
                    _temp_index = i;
            }
            if (_temp_index > -1)
            {
               Skier[] temp = new Skier[skier.Length - 1];
                for (int i = 0; i < _temp_index; i++)
                    temp[i] = skier[i];
                for (int i = _temp_index + 1; i < skier.Length; i++)
                    temp[i - 1] = skier[i];
                skier = temp;
            }
            IDBank = IDBank - 1;
            Dlina = skier.Length;
        }

        public void ADDSkier(ref int _ID)
        {
            _ID = IDSkier;
            Array.Resize(ref skier, skier.Length + 1);
            skier[skier.Length - 1] = new Skier(ref _ID);
            IDSkier = _ID;

        }
        public void TotalIncreaseSkier(ref int _TotalDistance, ref int _DistanceSkier, ref int _Month)
        {
            for (int i = 0; i < skier.Length; i++)
            {
                if (i == IDSkier - 1)
                    skier[i].IncreaseSkier(ref _TotalDistance, ref _DistanceSkier, ref _Month);
            }
        }


        public void TotalLoadSkier(ref int _ID, ref int _Month, ref int _DistanceSkier, ref int _TotalDistance)
        {
            for (int i = 0; i < skier.Length; i++)
            {
                if (i == _ID - 1)
                {
                    skier[i].LoadSkier(ref _Month, ref _DistanceSkier, ref _TotalDistance);

                }
            }
        }

        public void ADDSkierRandom(ref int _ID, ref int _TotalDistance, ref int _DistanceSkier, ref int _MonthNumber)
        {
            _ID = IDSkier;
            Array.Resize(ref skier, skier.Length + 1);
            skier[skier.Length - 1] = new Skier(ref _ID, ref _TotalDistance, ref _DistanceSkier, ref _MonthNumber);
            IDSkier = _ID;
        }
        #endregion
        #region Harvest
        Harvest[] harvests = new Harvest[0];
        private int IDHarvest;

        public void CombolLoadHarvest(ref int _ID, ref int _Yield, ref int _Square, ref int _Year, ref int _TotalYield)
        {
            for (int i = 0; i < harvests.Length; i++)
            {
                if (i == _ID - 1)
                    harvests[i].CombolLoadHarvest(ref _Yield, ref _Square, ref _Year, ref _TotalYield);
            }
        }
        public void DELHarvest(int _ID, ref int Dlina)
        {
            int _temp_index = -1;
            for (int i = 0; i < harvests.Length; i++)
            {
                if (i == _ID - 1)
                    _temp_index = i;
            }
            if (_temp_index > -1)
            {
                Harvest[] temp = new Harvest[harvests.Length - 1];
                for (int i = 0; i < _temp_index; i++)
                    temp[i] = harvests[i];
                for (int i = _temp_index + 1; i < harvests.Length; i++)
                    temp[i - 1] = harvests[i];
                harvests = temp;
            }
            IDHarvest = IDHarvest - 1;
            Dlina = harvests.Length;
        }
        public void ADDHarvest(ref int _ID)
        {
            _ID = IDHarvest;
            Array.Resize(ref harvests, harvests.Length + 1);
            harvests[harvests.Length - 1] = new Harvest(ref _ID);
            IDHarvest = _ID;
        }
        public void TotalHarvest(ref int _TotalYield, ref int _Square, ref int _Yield, ref int _Year)
        {
            for (int i = 0; i < harvests.Length; i++)
            {
                if (i == IDHarvest - 1)
                    harvests[i].YearHarvest(ref _TotalYield, ref _Square, ref _Yield, ref _Year);
            }
        }
        public void TotalLoadHarvest(ref int _ID, ref int _TotalYield, ref int _Square, ref int _Yield, ref int _Year)
        {
            for (int i = 0; i < harvests.Length; i++)
            {
                if (i == _ID - 1)
                {
                    harvests[i].LoadHarvest(ref _TotalYield, ref _Square, ref _Yield, ref _Year);
                }
            }
        }
        public void ADDHarvestRandom(ref int _ID, ref int _Yield, ref int _Square, ref int _Year, ref int _TotalYield)
        {
            _ID = IDHarvest;
            Array.Resize(ref harvests, harvests.Length + 1);
            harvests[harvests.Length - 1] = new Harvest(ref _ID, ref _Yield, ref _Square, ref _Year, ref _TotalYield);
            IDHarvest = _ID;
        }
        #endregion
    }
    class Bank
    {
        int IDBank { get; set; }
        int Payment { get; set; }
        int Amount { get; set; }
        int Month { get; set; }
        public Bank(ref int _ID)
        {
            Payment = 1000;
            Amount = Payment / 100 * 2;
            Month = 0;
            IDBank = _ID+1;
            _ID = IDBank;
        }
        public Bank(ref int _ID, ref int _Payment, ref int _Amount, ref int _Month)
        {
            Random RND = new Random();
            _Payment = RND.Next(1, 10000);
            Payment = _Payment;
            Amount = Payment / 100 * 2;
            _Amount = Amount;
            _Month = RND.Next(1, 99);
                       Month = _Month;
            IDBank = _ID + 1;
            _ID = IDBank;
        }
        public void IncreaseAmoun(ref int _Payment, ref int _Amount, ref int _Month)
        {
            Payment = _Payment;
            Payment = Payment+Amount;
            _Payment = Payment;
            Amount = Payment / 100 * 2;
            _Amount = Amount;
            Month = _Month;
            Month += 1;
            _Month = Month;
        }
        public void Load(ref int _Month, ref int _Payment, ref int _Amount)
        {
            _Month = Month;
            _Payment = Payment;
            _Amount = Amount;
        }
        public void ComboLoad(ref int _Month, ref int _Payment, ref int _Amount)
        {
            _Month = Month;
            _Payment = Payment;
            _Amount = Amount;
        }


    }
    class Skier
    {
        int IDSkier { get; set; }
        int TotalDistance { get; set; }
        int DistanceSkier { get; set; }
        int Month { get; set; }
        public Skier(ref int _ID)
        {
            TotalDistance = 10000;
            DistanceSkier = 10000;
            Month = 0;
            IDSkier = _ID + 1;
            _ID = IDSkier;
        }
        public Skier(ref int _ID, ref int _TotalDistance, ref int _DistanceSkier, ref int _MonthNumber)
        {
            Random RND = new Random();
            _TotalDistance = RND.Next(1, 10000);
            TotalDistance = _TotalDistance;        
            _DistanceSkier = RND.Next(1,10000);
            DistanceSkier = _DistanceSkier;
            _MonthNumber = RND.Next(1, 99);
            Month = _MonthNumber;
            IDSkier = _ID + 1;
            _ID = IDSkier;
        }
        public void IncreaseSkier(ref int _TotalDistance, ref int _DistanceSkier, ref int _Month)
        {
            TotalDistance = _TotalDistance;
            TotalDistance = TotalDistance + DistanceSkier;
            _TotalDistance = TotalDistance;
            DistanceSkier = _DistanceSkier + (_DistanceSkier / 100 * 10);
            _DistanceSkier = DistanceSkier;
            Month = _Month;
            Month += 1;
            _Month = Month;
        }
        public void LoadSkier(ref int _Month, ref int _DistanceSkierent, ref int _TotalDistance)
        {
            _Month = Month;
            _TotalDistance = TotalDistance;
            _DistanceSkierent = DistanceSkier;
        }

        public void ComboLoadSkier(ref int _MonthNumber, ref int _DistanceSkierent, ref int _TotalDistance)
        {
            _MonthNumber = Month;
            _TotalDistance = TotalDistance;
            _DistanceSkierent = DistanceSkier;
        }



    }
    class Harvest
    {
        int IDHarvest { get; set; }
        int Yield { get; set; }
        int Square { get; set; }
        int TotalYield { get; set; }
        int Year { get; set; }
        public Harvest(ref int _ID)
        {
            TotalYield = 2000;
            Yield = 2000;
            Square = 100;
            Year = 0;
            IDHarvest = _ID + 1;
            _ID = IDHarvest;
        }


        public Harvest(ref int _ID, ref int _Yield, ref int _Square, ref int _Year, ref int _TotalYield)
        {
            Random RND = new Random();
            _Yield = RND.Next(1, 10000);
            Yield = _Yield;
            _Square = RND.Next(1, 10000);
            Square = _Square;
            _TotalYield = RND.Next(1, 10000);
            TotalYield = _TotalYield;
            _Year = RND.Next(1, 99);
            Year = _Year;
            IDHarvest = _ID + 1;
            _ID = IDHarvest;
        }
        public void YearHarvest(ref int _TotalYield, ref int _Square, ref int _Yield, ref int _Year)
        {
            Square = _Square + _Square / 100 * 5;
            _Square = Square;
            Yield = _Yield + _Yield / 100 * 2;
            _Yield = Yield;
            _TotalYield += Yield;
            Year = _Year;
            Year += 1;
            _Year = Year;
        }
        public void LoadHarvest(ref int _TotalYield, ref int _Square, ref int _Yield, ref int _Year)
        {
            _Year = Year;
            _Yield = Yield;
            _Square = Square;
            _TotalYield = TotalYield;
        }
        public void CombolLoadHarvest(ref int _Yield, ref int _Square, ref int _Year, ref int _TotalYield)
        {
            _Year = Year;
            _Yield = Yield;
            _Square = Square;
            _TotalYield = TotalYield;
        }

    }
}