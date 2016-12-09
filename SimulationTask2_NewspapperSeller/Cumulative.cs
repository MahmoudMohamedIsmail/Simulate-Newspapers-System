using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationTask2_NewspapperSeller
{
    class Cumulative
    {

        int NumberOfProbabilities;
        List<Range> Ranges = new List<Range>() ;
        List<double> CumualativeProbability;
        //List<double> CumualativeProbability = new List<double>();
        int count = 0;
        public void Calculate(List<double> Probability ,ref List<double> CumualativeProbability,ref List<Range> Ranges)
        {
           
            NumberOfProbabilities = Probability.Count();
            CumualativeProbability = new List<double>(NumberOfProbabilities);
            Ranges = new List<Range>(NumberOfProbabilities) ;
        
               
            for (int i = 0; i < NumberOfProbabilities; i++)
            {
                double w = new double();
                CumualativeProbability.Add(w);
  
               Range r = new Range();
               Ranges.Add(r);
                if (i == 0)
                {             
                    CumualativeProbability[i] = Probability[i];
                    Ranges[i].Start = 0;
                    Ranges[i].End = CumualativeProbability[i] *100;
                   
                }
                else
                {
                    CumualativeProbability[i] = Probability[i] + CumualativeProbability[i-1];
                    
                        Ranges[i].Start = (CumualativeProbability[i - 1] * 100) + 1;
                        Ranges[i].End = CumualativeProbability[i] * 100;
                                
                }
            }
        }
    }
}
