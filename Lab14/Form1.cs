using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab14
{
    public partial class Form1 : Form
    {
        public Random rnd = new Random();
        public List<double> stat;
        public int a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stat = new List<double>() { 0, 0, 0, 0, 0 };
            List<double> probs = new List<double>() { 0, 0, 0, 0, 0 };
            double e0 = (double)meanNum.Value, d0 = (double)varNum.Value, k;
            double xi = 0, E = 0, D = 0, Eerror, Derror;
            int days = (int)daysNumeric.Value;
            List<double> vals = new List<double>();
            vals = Calculate(days, vals, d0, e0);
            var ans = Count(vals);
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.ChartAreas[0].Axes[0].Interval = ((double)(b - a)) / 5;
            for (var i = 0; i < 5; i++)
            {
                probs[i] = (double)((b - a) * func((2 * a + i * ((double)(b - a)) / 5 + (i + 1) * ((double)(b - a)) / 5) / 2, e0, d0) / 5);
                xi += Math.Pow(stat[i], 2) / (probs[i] * vals.Count);
            }
            xi -= vals.Count;
            foreach (var t in vals)
            {
                E += t;
                D += t * t;
            }
            E /= vals.Count;
            D /= vals.Count;
            D -= Math.Pow(E, 2);
            E = Math.Round(E, 3);
            D = Math.Round(D, 3);
            Eerror = countError(E, e0);
            Derror = countError(D, d0);

            ShowFreq(ans, E, Eerror, D, Derror, xi);
            ShowDistr(e0, d0);
        }

        private List<double> Calculate(int days, List<double> v, double d0, double e0)
        {
            double k;
            for (var i = 0; i < days; i++)
            {
                k = 0;
                for (var j = 0; j < 12; j++)
                {
                    k += rnd.NextDouble();
                }
                double a = ((k - 6) * Math.Sqrt((double)d0)) + e0;
                v.Add(a);
            }
            return v;
        }

        private List<double> Count(List<double> v)
        {
            List<double> result = new List<double>() { 0, 0, 0, 0, 0 };
            double min = v[0], max = v[0];
            for (int i = 1; i < v.Count; i++)
            {
                if (v[i] < min)
                {
                    min = v[i];
                }
                if (v[i] > max)
                {
                    max = v[i];
                }
            }
            a = (int)Math.Floor(min); b = (int)Math.Ceiling(max);
            foreach (var t in v)
            {
                int j = 0;
                double minus = (double)(b - a) / 5;
                while (a + j * minus >= t || a + (j + 1) * minus < t)
                {
                    j++;
                }
                stat[j]++;
            }
            for (var i = 0; i < 5; i++)
            {
                result[i] = (double)stat[i] / v.Count;
            }
            return result;
        }

        private void ShowFreq(List<double> freq, double e, double er, double d, double dr, double xi)
        {
            double ai = a;
            for (var i = 0; i < freq.Count; i++)
            {
                chart1.Series[0].Points.AddXY(ai + ((double)(b - a)) / 10, Math.Round((double)freq[i], 3));
                ai += ((double)(b - a)) / 5;
            }
            averageLabel.Text = e.ToString();
            varietyLabel.Text = d.ToString();
            averageError.Text = er.ToString();
            varienceError.Text = dr.ToString();
            if (xi < 11.07d)
            {
                xiLabel.Text = xi + " < 11.07 is true";
            }
            else
            {
                xiLabel.Text = xi + " < 11.07 is false";
            }
        }

        private void ShowDistr(double e0, double d0)
        {
            double a1 = a;
            for (var i = 0; i < 5; i++)
            {
                chart1.Series[1].Points.AddXY(a1 + (double)(b - a) / 10, func(a1 + (double)(b - a) / 10, e0, d0));
                a1 += (double)(b - a) / 5;
            }
        }

        private double countError(double i, double i0)
        {
            var a = Math.Round(Math.Abs((double)(i - i0)) * 100 / Math.Abs((double)i0), 3);
            return Math.Round(Math.Abs((double)(i - i0)) * 100 / Math.Abs((double)i0), 3);
        }

        public double func(double x, double E0, double D0)
        {
            return Math.Exp(-(x - E0) * (x - E0) /
                (2 * D0)) / Math.Sqrt(2 * Math.PI * D0);
        }
    }
}
