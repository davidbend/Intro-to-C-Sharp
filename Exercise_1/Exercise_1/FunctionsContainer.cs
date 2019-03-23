using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    delegate double Calc(double x, double y); 
    public class FunctionsContainer
    {
        private Dictionary<string, Func<double, double>> funcs;

        // Ctor
        public FunctionsContainer()
        {
            this.funcs = new Dictionary<string, Func<double, double>>();
        }


        // Indexer
        public Func<double, double> this[string funcName]
        {
            get
            {
                Func<double, double> func;
                if (funcs.TryGetValue(funcName, out func))
                {
                    return func;
                }
                else
                {
                    return value => value;
                }
            } 
            set
            {
                this.funcs[funcName] = value;
            }

        }

        public List<string> getAllMissions()
        {
            List<string> keyList = new List<string>(this.funcs.Keys);
            return keyList;
        }
    }
}
