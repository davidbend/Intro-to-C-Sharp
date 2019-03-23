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
        private readonly Func<double, double> Func;

        public string Name { get; }
        public string Type { get; }

        // Ctor
        public SingleMission(Func<double, double> func, string name)
        {
            this.Func = func;
            this.Name = name;
            this.Type = MISSION_TYPE;
        }

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            OnCalculate?.Invoke(this, value);
            return Func(value);
        }
    }
}
