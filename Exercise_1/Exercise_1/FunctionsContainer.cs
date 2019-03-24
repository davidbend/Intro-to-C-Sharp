using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public delegate double Calc(double value); 
    public class FunctionsContainer
    {
        private Dictionary<string, Calc> funcs;

        // Ctor
        public FunctionsContainer()
        {
            this.funcs = new Dictionary<string, Calc>();
        }

        // Indexer
        public Calc this[string funcName]
        {
            get
            {
                if (funcs.TryGetValue(funcName, out Calc func))
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
