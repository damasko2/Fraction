using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace fraction.K
{
    class Fraction
    {
        public int Numerator { get; set; }
        public int Denumerator { get; set; }

        public Fraction(int numerator, int denominator)
        {
            if (denominator >= 0)
            {
                Numerator = numerator;
                Denumerator = denominator;
            }
        }

        public static Fraction operator *(Fraction f, int num)
        {
            return new Fraction(f.Numerator*num, f.Denumerator);
        }
        public static Fraction operator *(int num, Fraction f)
        {
            return new Fraction(f.Numerator*num, f.Denumerator);
        }
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Numerator * f2.Numerator, f1.Denumerator);
        }
        public static Fraction operator *(Fraction f, double d)
        {
            int num = Convert.ToInt32(Math.Round(d));

            return new Fraction(f.Numerator * num, f.Denumerator);
        }
        public static Fraction operator *(double d, Fraction f)
        {
            int num = Convert.ToInt32(Math.Round(d));

            return new Fraction(f.Numerator * num, f.Denumerator);
        }

        public static Fraction operator /(Fraction f, int num)
        {
            if (num!=0)
            {
                return new Fraction(f.Numerator / num, f.Denumerator);
            }
            else
            {
                return new Fraction(0, 0);
            }
        }
        public static Fraction operator /(int num, Fraction f)
        {
            if (num != 0)
            {
                return new Fraction(num, f.Denumerator);
            }
            else
            {
                return new Fraction(0, 0);
            }
        }
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            if (f2.Numerator != 0)
            {
                return new Fraction(f1.Numerator / f2.Numerator, f1.Denumerator);
            }
            else
            {
                return new Fraction(0, 0);
            }
        }
        public static Fraction operator /(Fraction f, double d)
        {
            int num = Convert.ToInt32(Math.Round(d));

            if (num!=0)
            {
                return new Fraction(f.Numerator / num, f.Denumerator);
            }
            else
            {
                return new Fraction(0, 0);
            }
        }
        public static Fraction operator /(double d, Fraction f)
        {
            int num = Convert.ToInt32(Math.Round(d));

            if (num != 0)
            {
                return new Fraction(num / f.Numerator, f.Denumerator);
            }
            else
            {
                return new Fraction(0, 0);
            }
        }

        public static Fraction operator -(Fraction f, int num)
        {
            Fraction fr = new Fraction(f.Denumerator * num, f.Denumerator);

            return f - fr;
        }
        public static Fraction operator -(int num, Fraction f)
        {
            Fraction fr = new Fraction(f.Denumerator * num, f.Denumerator);

            return fr - f;
        }
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Numerator-f2.Numerator, f1.Denumerator);
        }
        public static Fraction operator -(Fraction f, double d)
        {
            int num = Convert.ToInt32(Math.Round(d));

            return new Fraction(f.Numerator - num, f.Denumerator);
        }
        public static Fraction operator -(double d, Fraction f)
        {
            int num = Convert.ToInt32(Math.Round(d));

            return new Fraction(num - f.Numerator, f.Denumerator);
        }

        public static Fraction operator +(Fraction f, int num)
        {
            Fraction fr = new Fraction(f.Denumerator * num, f.Denumerator);

            return f + fr;
        }
        public static Fraction operator +(int num, Fraction f)
        {
            Fraction fr = new Fraction(f.Denumerator * num, f.Denumerator);

            return fr + f;
        }
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Numerator + f2.Numerator, f1.Denumerator);
        }
        public static Fraction operator +(Fraction f, double d)
        {
            int num = Convert.ToInt32(Math.Round(d));

            return new Fraction(f.Numerator + num, f.Denumerator);
        }
        public static Fraction operator +(double d, Fraction f)
        {
            int num = Convert.ToInt32(Math.Round(d));

            return new Fraction(f.Numerator + num, f.Denumerator);
        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            return f1.Numerator == f2.Numerator && f1.Denumerator == f2.Denumerator;
        }
        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return f1.Numerator != f2.Numerator && f1.Denumerator != f2.Denumerator;
        }

        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static bool operator <(Fraction f1, Fraction f2)
        {
            return f1.Numerator < f2.Numerator;
        }
        public static bool operator >(Fraction f1, Fraction f2)
        {
            return f1.Numerator > f2.Numerator;
        }

        public static bool operator true(Fraction f1)
        {
            return f1.Numerator>f1.Denumerator;
        }
        public static bool operator false(Fraction f1)
        {
            return (f1.Numerator < f1.Denumerator);
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denumerator}\n";
        }
    }
}
