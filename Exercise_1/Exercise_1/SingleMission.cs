using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class SingleMission : IMission
    {
        private const string MISSION_TYPE = "Single";
        private readonly Calc Func;

        public string Name { get; }
        public string Type { get; }

        // Ctor
        public SingleMission(Calc func, string name)
        {
            this.Func = func;
            this.Name = name;
            this.Type = MISSION_TYPE;
        }

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            double result = this.Func(value);
            OnCalculate?.Invoke(this, result);
            return result;
        }
    }
}
