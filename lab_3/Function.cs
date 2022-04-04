using System;
using System.Collections.Generic;
using System.Windows.Forms.VisualStyles;

namespace lab_3 {
    public class WitchOfAgnesi {

        private const double minA = -20.0;
        private const double maxA = 20.0;

        private const double minStep = 0.001;
        private const double maxStep = 1.0;

        public double A { get; set; }
        public double Step { get; set; }
        public Interval GraphInterval { get; set; }

        public List<KeyValuePair<double, double>> Pairs { get; set; }

        public WitchOfAgnesi(double a, Interval interval, double step) {
            this.A = a;
            this.GraphInterval = interval;
            this.Step = step;
            if (!IsGoodA()) {
                throw new FormatException($"a should be between {minA} and {maxA}");
            }
            if (!IsGoodStep()) {
                throw new FormatException($"step should be between {minStep} and {maxStep}");
            }
        }

        private bool IsGoodA() {
            return  minA < this.A && this.A < maxA;
        }

        private bool IsGoodStep() {
            return maxStep > this.Step && this.Step > minStep;
        }

        public double Calculate(double x) {
            if (this.A == 0 && x == 0) {
                return Double.NaN;
            }
            return Math.Pow(this.A, 3) / (this.A * this.A + x * x);
        }

        public void SetValues() {
            List < KeyValuePair<double, double> > pairs = new List<KeyValuePair<double, double>>();
            int leftSide = (int) (GraphInterval.LeftBorder / Step);
            int rightSide = (int) (GraphInterval.RightBorder / Step);
            for (int i = leftSide; i <= rightSide; i++) {
                double x = Step * i;
                KeyValuePair<double, double> pair = new KeyValuePair<double, double>(Math.Round(x, 2), Math.Round(Calculate(x), 2));
                pairs.Add(pair);
            }
            this.Pairs = pairs;
        }
    }
}
