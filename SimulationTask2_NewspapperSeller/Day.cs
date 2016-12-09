using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationTask2_NewspapperSeller
{
    class Day
    {
        public string DayType;
        public int Id, Demand, NumberOfScrap, AvilableNumOfNewsPapers;
        public double RevenueFromSales, LostProfit, SalvageOfScrap, DailyProfit, RandomForType, RandomForDemand, CostOfNewsPapers;
        public Day(int id)
        {
            Id = id;
            DayType = "";
            Demand = 0;
            CostOfNewsPapers = 0;
            NumberOfScrap = 0;
            AvilableNumOfNewsPapers = 0;
            RevenueFromSales = 0;
            LostProfit = 0;
            SalvageOfScrap = 0;
            DailyProfit = 0;
            RandomForType = 0;
            RandomForDemand = 0;
        }
        public void Set_values(int Demand, int NumberOfNewspapers, double PurchasePrice, double SellingPrice, double ScrapValue, ref int AvilableNumOfNewsPapers, ref int NumberOfScrap, ref double RevenueFromSales, ref double LostProfit, ref double SalvageOfScrap, ref double DailyProfit, ref double CostOfNewsPapers)
        {
            AvilableNumOfNewsPapers = NumberOfNewspapers;
            NumberOfScrap = 0;
           
            // To Check if there are a Scraps value
            if (Demand < NumberOfNewspapers)
            {
                NumberOfScrap = NumberOfNewspapers - Demand;
            }


            // Cal Revenue From Sales "/100" to convert it to $ 
            RevenueFromSales = (Demand * SellingPrice) / 100;
            // Cal Salvage Of Scrap 
            SalvageOfScrap = (NumberOfScrap * ScrapValue) / 100;
            // Cal Lost Profit  .... USE   "MAX" To Avoid Negitive Value 
            LostProfit = ((Math.Max(Demand, NumberOfNewspapers) - NumberOfNewspapers) *  (SellingPrice - PurchasePrice)) / 100;

              CostOfNewsPapers=(NumberOfNewspapers*PurchasePrice)/100;
            
            // Daily Profit From Equation 
             //Profit= RevenueFromSales - CostOfNewsPapers - LostProfit + SalvageOfScrap; 
             DailyProfit = RevenueFromSales - CostOfNewsPapers - LostProfit + SalvageOfScrap;
        }
        public void Determin_Day(List<Range> Ranges, List<string> DaysType, double RandomForType, ref string DayType)
        {

            for (int i = 0; i < Ranges.Count(); i++)
            {

                if (RandomForType >= Ranges[i].Start && RandomForType <= Ranges[i].End)
                {

                    DayType = DaysType[i];
                    break;
                }
            }

        }
        public void Determin_Demand(List<Range> Ranges, List<int> DemandList, double RandomForDemand, ref int Demand)
        {

            for (int i = 0; i < Ranges.Count(); i++)
            {

                if (RandomForDemand >= Ranges[i].Start && RandomForDemand <= Ranges[i].End)
                {

                    Demand = DemandList[i];
                    break;
                }
            }

        }
     
    }
}
