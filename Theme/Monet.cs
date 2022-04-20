﻿using ColorThiefDotNet;
using ControlzEx.Theming;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;
using WPF_Mockup.Tabs.AIO_Info;

namespace WPF_Mockup.CustomTheming
{
    internal class Monet
    {
        #region Variables
        public static System.Windows.Media.Brush MainColour = null;
        public static System.Windows.Media.Brush DarkColour = null;
        public static System.Windows.Media.Brush DarkishColour = null;
        public static System.Windows.Media.Brush DarkerColour = null;
        #endregion
        #region DLL imports
        [DllImport("User32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool PrintWindow(IntPtr hwnd, IntPtr hDC, uint nFlags);

        [DllImport("user32.dll")]
        static extern bool GetWindowRect(IntPtr handle, ref System.Drawing.Rectangle rect);
        [DllImport("user32.dll", SetLastError = false)]
        static extern IntPtr GetShellWindow();
        #endregion
        #region Functions
        public static Bitmap CaptureWindow(IntPtr handle)
        {
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle();
            GetWindowRect(handle, ref rect);

            rect.Width = rect.Width - rect.X;
            rect.Height = rect.Height - rect.Y;

            Bitmap bitmap = new Bitmap(rect.Width, rect.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                IntPtr hdc = g.GetHdc();
                if (!PrintWindow(handle, hdc, 0))
                {
                    int error = Marshal.GetLastWin32Error();
                    var exception = new System.ComponentModel.Win32Exception(error);
                }
                g.ReleaseHdc(hdc);
            }
            return bitmap;
        }
        private static System.Drawing.Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return System.Drawing.Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return System.Drawing.Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return System.Drawing.Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return System.Drawing.Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return System.Drawing.Color.FromArgb(255, t, p, v);
            else
                return System.Drawing.Color.FromArgb(255, v, p, q);
        }
        private static void ColorToHSV(System.Drawing.Color color, out double hue, out double saturation, out double value)
        {
            int max = Math.Max(color.R, Math.Max(color.G, color.B));
            int min = Math.Min(color.R, Math.Min(color.G, color.B));

            hue = color.GetHue();
            saturation = (max == 0) ? 0 : 1d - (1d * min / max);
            value = max / 255d;
        }
        public static void ApplyMonet()
        {
            
            var colorThief = new ColorThief();
            Bitmap DesktopWallpaper = CaptureWindow(GetShellWindow());
            DesktopWallpaper.Save("test.bmp");

            QuantizedColor Colour = colorThief.GetColor(DesktopWallpaper);
            ColorThiefDotNet.Color Colour2 = Colour.Color;

            double H; double S; double V1; double V2; double V3; double V4;

            MainWindow.mw.Dispatcher.BeginInvoke((Action)delegate ()
            {
                ColorToHSV(ColorTranslator.FromHtml(Colour2.ToHexString()), out H, out S, out V1);
                V2 = V1;
                V3 = V1;
                V4 = V1;
                V1 *= AIO_Info.ai.LightnessSlider.Value / AIO_Info.ai.LightnessSlider.Maximum;
                if (V1 < 0) V1 = 0;
                V2 *= (AIO_Info.ai.LightnessSlider.Value / 1.25) / AIO_Info.ai.LightnessSlider.Maximum;
                if (V2 < 0) V2 = 0;
                V3 *= (AIO_Info.ai.LightnessSlider.Value / 1.5) / AIO_Info.ai.LightnessSlider.Maximum;
                if (V3 < 0) V3 = 0;
                V4 *= (AIO_Info.ai.LightnessSlider.Value / 2) / AIO_Info.ai.LightnessSlider.Maximum;
                if (V4 < 0) V4 = 0;

                System.Drawing.Color FinalColour1 = ColorFromHSV(H, S, V1);
                System.Drawing.Color FinalColour2 = ColorFromHSV(H, S, V2);
                System.Drawing.Color FinalColour3 = ColorFromHSV(H, S, V3);
                System.Drawing.Color FinalColour4 = ColorFromHSV(H, S, V4);
                string ColourHex1 = ColorTranslator.ToHtml(FinalColour1);
                string ColourHex2 = ColorTranslator.ToHtml(FinalColour2);
                string ColourHex3 = ColorTranslator.ToHtml(FinalColour3);
                string ColourHex4 = ColorTranslator.ToHtml(FinalColour4);

                var converter = new BrushConverter();
                MainColour = (System.Windows.Media.Brush)converter.ConvertFromString(ColourHex1);
                DarkishColour = (System.Windows.Media.Brush)converter.ConvertFromString(ColourHex2);
                DarkColour = (System.Windows.Media.Brush)converter.ConvertFromString(ColourHex3);
                DarkerColour = (System.Windows.Media.Brush)converter.ConvertFromString(ColourHex4);
            
                MainWindow.mw.Background.Background = MainColour;
                MainWindow.mw.SideBar.Background = DarkishColour;
                MainWindow.mw.TopBar1.Background = DarkColour;
                MainWindow.mw.TopBar2.Background = DarkColour;

                string RandName = Guid.NewGuid().ToString();
                ThemeManager.Current.AddTheme(new Theme(RandName, RandName, "Dark", "Red", (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(ColourHex4), DarkerColour, true, false));
                ThemeManager.Current.ChangeTheme(Application.Current, RandName);

                MainWindow.mw.CategoryButton_Click(new Object(), new RoutedEventArgs());
                foreach (FrameworkElement Element in MainWindow.mw.Window.GetChildren(true))
                {
                    if(Element.GetType() == typeof(System.Windows.Controls.Button))
                    {
                        Element.GetType().GetProperty("Background").SetValue(Element, DarkerColour);
                        Element.GetType().GetProperty("BorderBrush").SetValue(Element, DarkerColour);
                    }
                }
            });
        }
        #endregion
    }
}