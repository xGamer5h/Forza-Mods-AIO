﻿using System.Windows;
using System.Windows.Controls;

namespace Forza_Mods_AIO.Tabs.TuningTablePort.DropDownTabs
{
    public partial class Gearing : Page
    {
        public Gearing()
        {
            InitializeComponent();
        }

        private void FinalDriveRatioBox_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            try { MainWindow.mw.m.WriteMemory(Addresses.FinalDrive, "float", FinalDriveRatioBox.Value.ToString()); } catch { }
        }

        private void ReverseGearBox_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            try { MainWindow.mw.m.WriteMemory(Addresses.ReverseGear, "float", ReverseGearBox.Value.ToString()); } catch { }
        }

        private void FirstGearBox_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            try { MainWindow.mw.m.WriteMemory(Addresses.FirstGear, "float", FirstGearBox.Value.ToString()); } catch { }
        }

        private void SecondGearBox_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            try { MainWindow.mw.m.WriteMemory(Addresses.SecondGear, "float", SecondGearBox.Value.ToString()); } catch { }
        }

        private void ThirdGearBox_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            try { MainWindow.mw.m.WriteMemory(Addresses.ThirdGear, "float", ThirdGearBox.Value.ToString()); } catch { }
        }

        private void FourthGearBox_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            try { MainWindow.mw.m.WriteMemory(Addresses.FourthGear, "float", FourthGearBox.Value.ToString()); } catch { }
        }

        private void FifthGearBox_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            try { MainWindow.mw.m.WriteMemory(Addresses.FifthGear, "float", FifthGearBox.Value.ToString()); } catch { }
        }

        private void SixthGearBox_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            try { MainWindow.mw.m.WriteMemory(Addresses.SixthGear, "float", SixthGearBox.Value.ToString()); } catch { }
        }

        private void SeventhGearBox_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            try { MainWindow.mw.m.WriteMemory(Addresses.SeventhGear, "float", SeventhGearBox.Value.ToString()); } catch { }
        }

        private void EighthBox_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            try { MainWindow.mw.m.WriteMemory(Addresses.EighthGear, "float", EighthBox.Value.ToString()); } catch { }
        }

        private void NinthGearBox_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            try { MainWindow.mw.m.WriteMemory(Addresses.NinthGear, "float", NinthGearBox.Value.ToString()); } catch { }
        }

        private void TenthGearBox_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            try { MainWindow.mw.m.WriteMemory(Addresses.TenthGear, "float", TenthGearBox.Value.ToString()); } catch { }
        }
    }
}
