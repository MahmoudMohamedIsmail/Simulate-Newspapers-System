using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationTask2_NewspapperSeller
{
    class Range
    {
        public double Start, End;
        public Range()
        {
            Start = 0;
            End = 0;
        }
        public Range(double S, double E)
        {
            Start = S;
            End = E;
        }
        public void Get_Min_Max(ref List<Day> Days, ref double Min, ref double Max)
        {
            
            for (int i = 0; i < Days.Count(); i++)
            {
                if (Min > Days[i].DailyProfit)
                {
                    Min = Days[i].DailyProfit;
                }
                if (Max < Days[i].DailyProfit)
                {
                    Max = Days[i].DailyProfit;
                }
            }
       
        }
        public void Set_Ranges(double Min, double Max, ref List<Range> Ranges)
        {
            double interval = (Max - Min) / 5.0;
            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    Ranges[i].Start = Min;
                    Ranges[i].End = Min + interval;

                }
                else
                {
                    Ranges[i].Start = Ranges[i - 1].End;
                    Ranges[i].End = Ranges[i - 1].End + interval;
                }

            }
        
        }
        public void Get_Ranges_Of_Frequency(List<Range> Ranges,List<Day> Days , ref List<int> Frequency)
        {

            for (int i = 0; i < Days.Count; i++)
            {

                for (int j = 0; j < 5; j++)
                {

                    if (Days[i].DailyProfit >= Ranges[j].Start && Days[i].DailyProfit <= Ranges[j].End)
                    {
                        Frequency[j]++;
                        break;
                    }
                }
             
            }

        }
    }
}
