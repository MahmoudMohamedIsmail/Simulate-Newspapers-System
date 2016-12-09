using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulationTask2_NewspapperSeller
{
    public partial class Form1 : Form
    {
        Cumulative cumlative = new Cumulative();
        Range Calculate=new Range();
        List<double> probability = new List<double>();
        List<double> cumlativeNumber = new List<double>();
        List<Range> ranges = new List<Range>();
        List<string> daysType = new List<string>();
        List<int> demand_list;
        List<double> Good_prob;
        List<double> Fair_prob;
        List<double> Poor_prob;
        List<double> Goodcumlative = new List<double>();
        List<Range> Goodranges = new List<Range>();
        List<double> Faircumlative = new List<double>();
        List<Range> Fairranges = new List<Range>();
        List<double> Poorcumlative = new List<double>();
        List<Range> Poorranges = new List<Range>();
        List<Day> Days;
        Random rand = new Random();
        double TotalRevenuefromSales = 0,CurBestProift=0, TotalCostofNewspapers = 0, TotalLostProfitfromExcessDemand = 0, TotalSalvagefromsaleofScrappapers = 0, TotalDailyProfit = 0;
        List<int> FrequencyOfRanges;
        List<Range> RangesOfDailyProfit;
       int DaysHavingExcessDemand = 0, NumberOfDaysHavingUnsoldPapers = 0;
       Output SimulationTable = new Output();
       int BestNewsPapers = 0;
       double Min = double.MaxValue,Max=double.MinValue;

        public Form1()
        {
            InitializeComponent();
        }

        //insert distrubition button..
        private void DayType_btn_Click(object sender, EventArgs e)
        {
            demand_list = new List<int>(DemandGrid.Rows.Count);
            Good_prob = new List<double>(DemandGrid.Rows.Count);
            Fair_prob = new List<double>(DemandGrid.Rows.Count);
            Poor_prob = new List<double>(DemandGrid.Rows.Count);

            for (int rows = 0; rows <= DayTypeGrid.Rows.Count - 2; rows++)
            {
                daysType.Add(DayTypeGrid.Rows[rows].Cells[0].Value.ToString()); //All Dayes From User Input
                probability.Add(double.Parse(DayTypeGrid.Rows[rows].Cells[1].Value.ToString()));
            }
            cumlative.Calculate(probability, ref cumlativeNumber, ref ranges);
           
            //Show cumulative and rangess
            for (int rows = 0; rows < DayTypeGrid.Rows.Count - 1; rows++)
            {
                DayTypeGrid.Rows[rows].Cells[2].Value = cumlativeNumber[rows];
                DayTypeGrid.Rows[rows].Cells[3].Value = ranges[rows].Start + "  to  " + ranges[rows].End;
            }
            //===

            for (int rows = 0; rows <= DemandGrid.Rows.Count - 2; rows++)
            {
                demand_list.Add(int.Parse(DemandGrid.Rows[rows].Cells[0].Value.ToString()));
                Good_prob.Add(double.Parse(DemandGrid.Rows[rows].Cells[1].Value.ToString()));
                Fair_prob.Add(double.Parse(DemandGrid.Rows[rows].Cells[2].Value.ToString()));
                Poor_prob.Add(double.Parse(DemandGrid.Rows[rows].Cells[3].Value.ToString()));
            }
            //Gets All cumulatives
            cumlative.Calculate(Good_prob, ref Goodcumlative, ref Goodranges);
            cumlative.Calculate(Fair_prob, ref Faircumlative, ref Fairranges);
            cumlative.Calculate(Poor_prob, ref Poorcumlative, ref Poorranges);

            //Shows All cumulatives
            for (int rows = 0; rows < DemandGrid.Rows.Count - 1; rows++)
            {
                DemandGrid.Rows[rows].Cells[4].Value = Goodcumlative[rows];

                if (Good_prob[rows] != 0)
                    DemandGrid.Rows[rows].Cells[7].Value = Goodranges[rows].Start + "  to  " + Goodranges[rows].End;

                DemandGrid.Rows[rows].Cells[5].Value = Faircumlative[rows];

                if (Fair_prob[rows] != 0)
                    DemandGrid.Rows[rows].Cells[8].Value = Fairranges[rows].Start + "  to  " + Fairranges[rows].End;

                DemandGrid.Rows[rows].Cells[6].Value = Poorcumlative[rows];

                if (Poor_prob[rows] != 0)
                    DemandGrid.Rows[rows].Cells[9].Value = Poorranges[rows].Start + "  to  " + Poorranges[rows].End;
            }

        }

        private void SimulationButton_Click(object sender, EventArgs e)
        {
            if (Purchase.Text == "" || Selling.Text == "" || Scrap.Text == "" || NumOfDays.Text == "" || NumberOfNews.Text == "")
            {
                MessageBox.Show("PLZ Insert Data Of Costs...");
            }

            //Get size of forloop To Get Best profit first... 
            int Size=(int.Parse(EndNewsPapers.Text.ToString())-int.Parse(StartNewsPapers.Text.ToString()))/10;
          
            //for All NumberOfNewsPapers Range
            for (int start = 0; start < Size; start++)
            {
                
                // Set All Globale Varibles By Zeeroo
                TotalRevenuefromSales = 0; TotalCostofNewspapers = 0; TotalLostProfitfromExcessDemand = 0; TotalSalvagefromsaleofScrappapers = 0;
                DaysHavingExcessDemand = 0; NumberOfDaysHavingUnsoldPapers = 0;
                TotalDailyProfit = 0;

                // List Of day From NumberOFDays 
                Days = new List<Day>();


                // Cal All Data Per Day 
                for (int i = 0; i < int.Parse(NumOfDays.Text.ToString()); i++)
                {

                    // Day NewDay = new Day(i + 1);
                    // Constract By ID
                    Days.Add(new Day(i + 1));

                    // Get Tybe oF Day.... Rand Value 
                    Days[i].RandomForType = rand.Next(0, 100);

                    //Get Tybe oF DEmand.... Rand Value 
                    Days[i].RandomForDemand = rand.Next(0, 100);

                    // Determin Type of This Day 
                    Days[i].Determin_Day(ranges, daysType, Days[i].RandomForType, ref Days[i].DayType);



                    // TO Determin type of Demand First Check Whitch Day is? (Good, Poor, Fair)..

                    // For Good Day 
                    if (Days[i].DayType == "Good")
                    {
                        Days[i].Determin_Demand(Goodranges, demand_list, Days[i].RandomForDemand, ref Days[i].Demand);
                        // Check if This Day Having Excess Demand OR Unsold Papers
                        if (Days[i].Demand > int.Parse(NumberOfNews.Text.ToString()))
                        {
                            DaysHavingExcessDemand++;
                        }
                        else if (Days[i].Demand < int.Parse(NumberOfNews.Text.ToString()))
                        {
                            NumberOfDaysHavingUnsoldPapers++;
                        }
                    }
                    else if (Days[i].DayType == "Fair")// For Fair 
                    {
                        Days[i].Determin_Demand(Fairranges, demand_list, Days[i].RandomForDemand, ref Days[i].Demand);
                        // Check if This Day Having Excess Demand OR Unsold Papers
                        if (Days[i].Demand > int.Parse(NumberOfNews.Text.ToString()))
                        {
                            DaysHavingExcessDemand++;
                        }
                        else if (Days[i].Demand < int.Parse(NumberOfNews.Text.ToString()))
                        {
                            NumberOfDaysHavingUnsoldPapers++;
                        }
                    }
                    else if (Days[i].DayType == "Poor")//For poor
                    {
                        Days[i].Determin_Demand(Poorranges, demand_list, Days[i].RandomForDemand, ref Days[i].Demand);
                        // Check if This Day Having Excess Demand OR Unsold Papers
                        if (Days[i].Demand > int.Parse(NumberOfNews.Text.ToString()))
                        {
                            DaysHavingExcessDemand++;
                        }
                        else if (Days[i].Demand < int.Parse(NumberOfNews.Text.ToString()))
                        {
                            NumberOfDaysHavingUnsoldPapers++;
                        }
                    }


                    // Set Values Of Days RevenueFromSales, LostProfit, SalvageOfScrap, DailyProfit, RandomForType, RandomForDemand;
                    Days[i].Set_values(Days[i].Demand, int.Parse(NumberOfNews.Text.ToString()), double.Parse(Purchase.Text.ToString()), double.Parse(Selling.Text.ToString()), double.Parse(Scrap.Text.ToString()), 
                        ref Days[i].AvilableNumOfNewsPapers, ref Days[i].NumberOfScrap, ref Days[i].RevenueFromSales, ref Days[i].LostProfit,
                        ref Days[i].SalvageOfScrap, ref Days[i].DailyProfit, ref Days[i].CostOfNewsPapers);

                    // Cmulate All Costs (TotalRevenuefromSales ,TotalCostofNewspapers ,TotalLostProfitfromExcessDemand ,TotalSalvagefromsaleofScrappapers)
                    TotalRevenuefromSales += Days[i].RevenueFromSales;
                    TotalCostofNewspapers += Days[i].CostOfNewsPapers;
                    TotalLostProfitfromExcessDemand += Days[i].LostProfit;
                    TotalSalvagefromsaleofScrappapers += Days[i].SalvageOfScrap;
                    TotalDailyProfit+=Days[i].DailyProfit;

                }//End Of For All Days



                // Showing Smulation Table ...............................................
                // Delete DataGridView
                SimulationTable.SimTable.Rows.Clear();
                //Becuse I cleared ... Must Set All Culms Again
                Set_DataGridVeiw(SimulationTable.SimTable);
                
                // SET Simulation Table
                SimulationTable.SimTable.Rows.Add(int.Parse(NumOfDays.Text.ToString()));
                for (int i = 0; i < int.Parse(NumOfDays.Text.ToString()); i++)
                {
                    SimulationTable.SimTable[0, i].Value = Days[i].Id;
                    SimulationTable.SimTable[1, i].Value = Days[i].RandomForType;
                    SimulationTable.SimTable[2, i].Value = Days[i].DayType;
                    SimulationTable.SimTable[3, i].Value = Days[i].RandomForDemand;
                    SimulationTable.SimTable[4, i].Value = Days[i].Demand;
                    SimulationTable.SimTable[5, i].Value = Days[i].RevenueFromSales;
                    SimulationTable.SimTable[6, i].Value = Days[i].LostProfit;
                    SimulationTable.SimTable[7, i].Value = Days[i].SalvageOfScrap;
                    SimulationTable.SimTable[8, i].Value = Days[i].DailyProfit;
                }



                // Calculation Output 
                SimulationTable.TotalRevenuefromSales.Text = TotalRevenuefromSales.ToString();
                SimulationTable.TotalCostofNewspapers.Text = TotalCostofNewspapers.ToString();
                SimulationTable.TotalLostProfitFromExcessDemand.Text = TotalLostProfitfromExcessDemand.ToString();
                SimulationTable.TotalSalvagefromSaleOfscrapPapers.Text = TotalSalvagefromsaleofScrappapers.ToString();
                SimulationTable.Numberofdayshavingexcessdemand.Text = DaysHavingExcessDemand.ToString();
                SimulationTable.NumberOfDaysHavingUnsoldPapers.Text = NumberOfDaysHavingUnsoldPapers.ToString();

                // Set Frequency Of DailyProfit
                RangesOfDailyProfit = new List<Range>();
                FrequencyOfRanges = new List<int>();
                //Declare construct
                for (int a = 0; a < 5;a++)
                {
                    RangesOfDailyProfit.Add(new Range());
                    FrequencyOfRanges.Add(new int());
                }

                Min = double.MaxValue;
                Max = double.MinValue;
                Calculate.Get_Min_Max(ref Days, ref Min, ref Max);
                Calculate.Set_Ranges(Min, Max, ref RangesOfDailyProfit);
                Calculate.Get_Ranges_Of_Frequency(RangesOfDailyProfit, Days, ref FrequencyOfRanges);
               

                // Calculate BEST NewSPapers
                if (TotalDailyProfit > CurBestProift)
                {
                    CurBestProift = TotalDailyProfit;
                    BestNewsPapers = (start * 10) + int.Parse(StartNewsPapers.Text.ToString());
                }

                Best_Num.Text = BestNewsPapers.ToString();
                SimulationTable.Show();
               
              
            }
        }
        public void Set_DataGridVeiw(DataGridView simTible)
        {
            DataGridViewColumn Column = new DataGridViewColumn();
            Column.CellTemplate = new DataGridViewTextBoxCell();
            simTible.Columns.Add(Column);

            Column = new DataGridViewColumn();
            Column.CellTemplate = new DataGridViewTextBoxCell();
            simTible.Columns.Add(Column);
            Column = new DataGridViewColumn();
            Column.CellTemplate = new DataGridViewTextBoxCell();
            simTible.Columns.Add(Column);

            Column = new DataGridViewColumn();
            Column.CellTemplate = new DataGridViewTextBoxCell();
            simTible.Columns.Add(Column);
            Column = new DataGridViewColumn();
            Column.CellTemplate = new DataGridViewTextBoxCell();
            simTible.Columns.Add(Column);

            Column = new DataGridViewColumn();
            Column.CellTemplate = new DataGridViewTextBoxCell();
            simTible.Columns.Add(Column);
            Column = new DataGridViewColumn();
            Column.CellTemplate = new DataGridViewTextBoxCell();
            simTible.Columns.Add(Column);

            Column = new DataGridViewColumn();
            Column.CellTemplate = new DataGridViewTextBoxCell();
            simTible.Columns.Add(Column);
            Column = new DataGridViewColumn();
            Column.CellTemplate = new DataGridViewTextBoxCell();
            simTible.Columns.Add(Column);
        }

        private void Drwa_Graph_Click(object sender, EventArgs e)
        {
            if (FrequencyOfRanges.Count == 5 && RangesOfDailyProfit.Count == 5)
            {
                Graph Drwa = new Graph();

                Drwa.GraphOfChart.ChartAreas.Add("Area");
               Drwa.GraphOfChart.ChartAreas[0].AxisX.Minimum=Min;
                Drwa.GraphOfChart.ChartAreas[0].AxisX.Maximum=Max;

                for (int i = 0; i < 5; i++)
                {


                    Drwa.GraphOfChart.Series[0].Points.AddXY(RangesOfDailyProfit[i].Start, FrequencyOfRanges[i]);
                    Drwa.GraphOfChart.Series[0].Points[i].AxisLabel = RangesOfDailyProfit[i].Start.ToString() + " - " + RangesOfDailyProfit[i].End.ToString();
                    /*   if(i==0)
                       {
                       Drwa.GraphOfChart.ChartAreas[0].AxisX.CustomLabels.Add(RangesOfDailyProfit[i].Start,(RangesOfDailyProfit[i].End-RangesOfDailyProfit[i].Start),(RangesOfDailyProfit[i].Start.ToString()+" - "+RangesOfDailyProfit[i].End.ToString()));
                       }
                       else
                       {
                      Drwa.GraphOfChart.ChartAreas[0].AxisX.CustomLabels.Add(RangesOfDailyProfit[i].Start,(RangesOfDailyProfit[i].End-RangesOfDailyProfit[i].Start),(RangesOfDailyProfit[i].Start.ToString()+" - "+RangesOfDailyProfit[i].End.ToString()));
                       }
  
                     //  Drwa.GraphOfChart.Series[0].Points.AddXY(i, FrequencyOfRanges[i]);
                
                   }*/
                } Drwa.Show();

           }
            else {
                MessageBox.Show("PLZ Click In Simulation Button...");
            }
        }
        }

    }

