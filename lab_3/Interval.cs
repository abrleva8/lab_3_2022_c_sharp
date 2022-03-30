using System;

namespace lab_3 {
    public class Interval {
        public double LeftBorder { get; set; }
        public double RightBorder { get; set; }

        public Interval(double leftBorder, double rightBorder) {
            if (!IsGoodData(leftBorder, rightBorder)) {
                throw new ArgumentException("The left border should be less than the right border!");
            } else {
                this.LeftBorder = leftBorder;
                this.RightBorder = rightBorder;
            }
        }

        public bool IsGoodData(double leftBorder, double rightBorder) {
            return leftBorder < rightBorder;
        }

        public bool IsGoodData() {
            return this.LeftBorder < this.RightBorder;
        }
    }
}
