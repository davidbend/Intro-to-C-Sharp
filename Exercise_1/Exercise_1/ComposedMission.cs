﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class ComposedMission : IMission
    {
        public const string MISSION_TYPE = "Composed";
        public string Name { get; }
        public string Type { get; }
        List<Func<double, double>> Funcs { get; }

        // Ctor
        public ComposedMission(string name)
        {
            Name = name;
            Type = MISSION_TYPE;
            Funcs = new List<Func<double, double>>();
        }

        public ComposedMission Add(Func<double, double> func)
        {
            Funcs.Add(func);
            return this;
        }

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            foreach(var func in Funcs)
            {
                value = func(value);
            }
            OnCalculate?.Invoke(this, value);
            return value;
        }
    }
}