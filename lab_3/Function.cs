﻿using System;
using System.Collections.Generic;
using System.Windows.Forms.VisualStyles;

namespace lab_3 {
    public class WitchOfAgnesi {

        private const double minA = -20.0;
        private const double maxA = 20.0;

        private const double minStep = 0.001;
        private const double maxStep = 1.0;

        private double A { get; set; }
        private double Step { get; set; }
        private Interval GraphInterval { get; set; }

        public List<KeyValuePair<double, double>> Pairs { get; set; }

        public WitchOfAgnesi(double a, Interval interval, double step) {
            this.A = a;
            this.GraphInterval = interval;
            this.Step = step;
        }

        private bool IsGoodA() {
            return  maxA > this.A && this.A > minA;
        }

        private bool IsGoodStep() {
            return maxStep > this.Step && this.Step > minStep;
        }

        public bool IsGoodParameters() {
            return IsGoodA() && IsGoodStep() && GraphInterval.IsGoodData();
        }

        public double Calculate(double x) {
            return Math.Pow(this.A, 3) / (this.A * this.A + x * x);
        }

        public bool IsSpecialSituation() {
            return A == 0 && GraphInterval.RightBorder > 0 && GraphInterval.LeftBorder < 0;
        }

        public void SetValues() {
            List < KeyValuePair<double, double> > pairs = new List<KeyValuePair<double, double>>();
            int leftSide = (int) (GraphInterval.LeftBorder / Step);
            int rightSide = (int) (GraphInterval.RightBorder / Step);
            for (int i = leftSide; i <= rightSide; i++) {
                double x = Step * i;
                KeyValuePair<double, double> pair = new KeyValuePair<double, double>(x, Calculate(x));
                pairs.Add(pair);
            }
            this.Pairs = pairs;
        }
    }
}
