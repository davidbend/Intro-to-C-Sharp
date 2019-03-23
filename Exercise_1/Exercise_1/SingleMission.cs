using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class SingleMission : IMission
    {
        private const string type = "Single";
        private string name;
        private readonly Func<double, double> func;
        
        // Ctor
        public SingleMission(Func<double, double> func, string name)
        {
            this.func = func;
            this.name = name;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                name = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
        }

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {

        }
    }
}
