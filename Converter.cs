using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synesthesia
{
    /// <summary>
    /// Implements several conversions used in the application
    /// </summary>
    public static class Converter
    {
        /// <summary>
        /// Minimum audible frequency
        /// </summary>
        public static Double MinAudibleFreq { get { return 20; } }
        /// <summary>
        /// Maximum audible frequency
        /// </summary>
        public static Double MaxAudibleFreq { get { return 20000; } }
        /// <summary>
        /// Minimum visible frequency
        /// </summary>
        public static Double MinVisibleFreq { get { return 400; } }
        /// <summary>
        /// Maximum visible frequency
        /// </summary>
        public static Double MaxVisibleFreq { get { return 750; } }
        /// <summary>
        /// Converts a sound frequency to a normalized light spectrum 
        /// </summary>
        /// <param name="Sound">The sound frequency in Hz</param>
        /// <returns>The corresponding light frequency in THz in the normalized spectrum</returns>
        public static Double SoundToLight (Double Sound)
        {
            Sound = (Sound > MaxAudibleFreq ? MaxAudibleFreq : Sound);
            Sound = (Sound < MinAudibleFreq ? MinAudibleFreq : Sound);
            return MinVisibleFreq + ((Sound - MinAudibleFreq) / (MaxAudibleFreq - MinAudibleFreq)) * (MaxVisibleFreq - MinVisibleFreq);
        }
        /// <summary>
        /// Converts a light frequency to a normalized sound spectrum
        /// </summary>
        /// <param name="Light">The light frequency in THz</param>
        /// <returns>The correspoding sound frequency in Hz in the normalized spectrum</returns>
        public static Double LightToSound(Double Light)
        {
            Light = (Light > MaxVisibleFreq ? MaxVisibleFreq : Light);
            Light = (Light < MinVisibleFreq ? MinVisibleFreq : Light);
            return MinAudibleFreq + ((Light - MinVisibleFreq) / (MaxVisibleFreq - MinVisibleFreq)) * (MaxAudibleFreq - MinAudibleFreq);
        }
        /// <summary>
        /// Returns a RGB color based on a light frequency
        /// </summary>
        /// <param name="Frequency">The light frequency in THz</param>
        /// <returns>The RGB color corresponding to the supplied frequency</returns>
        public static Color GetColorFromFrequency(Double Frequency)
        {
            Int32 FactorAdjust(Double color, Double factor, Int32 intensityMax, Double gamma)
            {
                if (color == 0.0)
                {
                    return 0;
                }
                else
                {
                    return (int)Math.Round(intensityMax * Math.Pow(color * factor, gamma));
                }
            }
            Int32 Wavelength = Convert.ToInt32(Math.Floor(300000 / Frequency));
            Double Gamma = 1.00;
            Int32 IntensityMax = 255;
            Double Blue;
            Double Green;
            Double Red;
            Double Factor;

            if (Wavelength >= 350 && Wavelength <= 439)
            {
                Red = -(Wavelength - 440d) / (440d - 350d);
                Green = 0.0;
                Blue = 1.0;
            }
            else if (Wavelength >= 440 && Wavelength <= 489)
            {
                Red = 0.0;
                Green = (Wavelength - 440d) / (490d - 440d);
                Blue = 1.0;
            }
            else if (Wavelength >= 490 && Wavelength <= 509)
            {
                Red = 0.0;
                Green = 1.0;
                Blue = -(Wavelength - 510d) / (510d - 490d);

            }
            else if (Wavelength >= 510 && Wavelength <= 579)
            {
                Red = (Wavelength - 510d) / (580d - 510d);
                Green = 1.0;
                Blue = 0.0;
            }
            else if (Wavelength >= 580 && Wavelength <= 644)
            {
                Red = 1.0;
                Green = -(Wavelength - 645d) / (645d - 580d);
                Blue = 0.0;
            }
            else if (Wavelength >= 645 && Wavelength <= 780)
            {
                Red = 1.0;
                Green = 0.0;
                Blue = 0.0;
            }
            else
            {
                Red = 0.0;
                Green = 0.0;
                Blue = 0.0;
            }
            if (Wavelength >= 350 && Wavelength <= 419)
            {
                Factor = 0.3 + 0.7 * (Wavelength - 350d) / (420d - 350d);
            }
            else if (Wavelength >= 420 && Wavelength <= 700)
            {
                Factor = 1.0;
            }
            else if (Wavelength >= 701 && Wavelength <= 780)
            {
                Factor = 0.3 + 0.7 * (780d - Wavelength) / (780d - 700d);
            }
            else
            {
                Factor = 0.0;
            }

            int R = FactorAdjust(Red, Factor, IntensityMax, Gamma);
            int G = FactorAdjust(Green, Factor, IntensityMax, Gamma);
            int B = FactorAdjust(Blue, Factor, IntensityMax, Gamma);

            return Color.FromArgb(R, G, B);
        }
    }
}
