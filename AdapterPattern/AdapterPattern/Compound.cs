using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Compound
    {
        protected string _chemical;
        protected float _boilingPoint;
        protected float _meltingPoint;
        protected string _molecularFormula;

        // Constructor
        public Compound(string chemical) {
            this._chemical = chemical;
        }
        public virtual void Display() {
            Console.WriteLine("\nCompound: {0} ------ ", _chemical);
        }
    }
    class RichCompound : Compound
    {
        private ChemicalDatabank _bank;
        public RichCompound(string name)
        : base(name) { }
        public override void Display() {
            // Adaptee
            _bank = new ChemicalDatabank();
            _boilingPoint = _bank.GetCriticalPoint(_chemical, "B");
            _meltingPoint = _bank.GetCriticalPoint(_chemical, "M");
            _molecularFormula = _bank.GetMolecularStructure(_chemical);
            base.Display();
            Console.WriteLine(" Formula: {0}", _molecularFormula);
            Console.WriteLine(" Melting Pt: {0}", _meltingPoint);
            Console.WriteLine(" Boiling Pt: {0}", _boilingPoint);
        }
    }

    // 'Adaptee' class
    class ChemicalDatabank
    {

        // databank 'legacy API'
        public float GetCriticalPoint(string compound, string point) {

            // Melting Point
            if (point == "M") {
                switch (compound.ToLower()) {
                    case "water": return 0.0f;
                    case "ethanol": return -114.1f;
                    default: return 0f;
                }
            }

            // Boiling Point
            else {
                switch (compound.ToLower()) {
                    case "water": return 100.0f;
                    case "ethanol": return 78.3f;
                    default: return 0f;
                }
            }
        }

        public string GetMolecularStructure(string compound) {
            switch (compound.ToLower()) {
                case "water": return "H20";
                case "ethanol": return "C2H5OH";
                default: return "";
            }
        }
        public double GetMolecularWeight(string compound) {
            switch (compound.ToLower()) {
                case "water": return 18.015;
                case "ethanol": return 46.0688;
                default: return 0d;
            }
        }
    }
}

