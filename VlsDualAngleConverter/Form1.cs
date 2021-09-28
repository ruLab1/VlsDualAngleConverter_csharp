using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace psaConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }
        private double RadianToDegree(double angle)
        {
            return angle *(180.0/Math.PI);
        }

        private void btn_toPsa_Click(object sender, EventArgs e)
        {
            clearPsa();
            numPintopap2.Value = numPintopap.Value;
            Double Psatopap = 0;
            Double PinBuffer = 0;
            try
            {
                Psatopap = Math.Acos(Math.Cos(DegreeToRadian(decimal.ToDouble(numDrill.Value))) * Math.Sin(decimal.ToDouble(numPintopap2.Value) * Math.PI / 13.5)) * 13.5 / Math.PI;
                //=ACOS(COS(RADIANS(B7))*SIN(B8*PI()/13.5))*13.5/PI()
            }
            catch {  }
            try
            {
                PinBuffer = Math.Asin(Math.Sin(DegreeToRadian(decimal.ToDouble(numVal.Value))) * Math.Sin(decimal.ToDouble(numPintopap2.Value) * Math.PI / 13.5)) * 13.5 / Math.PI;
                //=ASIN(SIN(RADIANS(B9))*SIN(B8*PI()/13.5))*13.5/PI()
            }
            catch {  }

            try
            {
                numPsatopap.Value = decimal.Parse(Psatopap.ToString());
            }
            catch
            {
                numPsatopap.Value = 0;
            }
            try
            {
                numPinbuffer.Value = decimal.Parse(PinBuffer.ToString());
            }
            catch
            {
                numPinbuffer.Value = 0;
            }
        }

        private void btn_toDual_Click(object sender, EventArgs e)
        {
            clearDual();
            numPintopap.Value = numPintopap2.Value;
            Double drillValue = 0;
            Double valValue = 0;
            try
            {
                drillValue = 180 / Math.PI * Math.Acos(Math.Cos(decimal.ToDouble(numPsatopap.Value) * Math.PI / 13.5) / Math.Sin(decimal.ToDouble(numPintopap.Value) * Math.PI / 13.5));
                //=180/PI()*ACOS(COS(B2*PI()/13.5)/SIN(B1*PI()/13.5))
            }
            catch { }
            try
            {
                valValue = 180 / Math.PI * Math.Asin(Math.Sin(decimal.ToDouble(numPinbuffer.Value) * Math.PI / 13.5) / Math.Sin(decimal.ToDouble(numPintopap.Value) * Math.PI / 13.5));
                //=180/PI()*ASIN(SIN(B3*PI()/13.5)/SIN(B1*PI()/13.5))
            }
            catch {}

            try
            {
                numVal.Value = decimal.Parse(valValue.ToString());
            }
            catch
            { numVal.Value = 0; }
            try
            {
                numDrill.Value = decimal.Parse(drillValue.ToString());
            }
            catch
            { numDrill.Value = 0; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearPsa();
        }

        private void btnClearDual_Click(object sender, EventArgs e)
        {
            clearDual();
        }

        public void clearDual()
        {
            numVal.Value = 0;
            numPintopap.Value = 0;
            numDrill.Value = 0;
        }

        public void clearPsa()
        {
            numPinbuffer.Value = 0;
            numPsatopap.Value = 0;
            numPintopap2.Value = 0;
        }

    }
}
