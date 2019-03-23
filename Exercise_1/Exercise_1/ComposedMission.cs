using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class ComposedMission : IMission
    {
        private string type;
        private string name;

        // Ctor
        public ComposedMission(string name)
        {
            this.name = name;
            this.type = "Composed";
        }

        public string Name => throw new NotImplementedException();

        public string Type => throw new NotImplementedException();

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            throw new NotImplementedException();
        }
    }
}
