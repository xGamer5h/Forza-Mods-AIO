﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Forza_Mods_AIO.Tabs.Self_Vehicle
{
    internal class Self_Vehicle_Addrs
    {
        int ScanAmount = 26;
        #region Addresses - Longs
        public static long TimeNOPAddrLong;
        public static long CheckPointxASMAddrLong;
        public static long WayPointxASMAddrLong;
        public static long BaseAddrLong;
        public static long Base2AddrLong;
        public static long Base3AddrLong;
        public static long Base4AddrLong;
        public static long Car1AddrLong;
        public static long Car2AddrLong;
        public static long Wall1AddrLong;
        public static long Wall2AddrLong;
        public static long FOVnopOutAddrLong;
        public static long FOVnopInAddrLong;
        public static long FirstPersonAddrLong;
        public static long DashAddrLong;
        public static long FrontAddrLong;
        public static long LowAddrLong;
        public static long BonnetAddrLong;
        public static long CurrentIDAddrLong;
        public static long OOBnopAddrLong;
        public static long SuperCarAddrLong;
        public static long WorldRGBAddrLong;
        public static long FOVJmpAddrLong;
        public static long DiscoverRoadsAddrLong;
        public static long WaterAddrLong;
        public static long AIXAobAddrLong;
        public static long CosmeticUnlockAddrLong;
        public static long HornAsmAddrLong;
        public static long XPaddrLong;
        public static long XPAmountaddrLong;
        #endregion
        #region Addresses - AOB's
        public static string BaseAob;
        public static string Base2Aob;
        public static string RGBAob;
        public static string Car1Aob;
        public static string Car2Aob;
        public static string Wall1Aob;
        public static string Wall2Aob;
        public static string FOVOutAob;
        public static string FOVInAob;
        public static string FOVJmpAob;
        public static string TimeAob;
        public static string CheckPointxASMAob;
        public static string WayPointxASMAob;
        public static string FirstPersonAob;
        public static string DashAob;
        public static string LowAob;
        public static string BonnetAob;
        public static string FrontAob;
        public static string XPAob;
        public static string XPAmountAob;
        public static string CurrentIDAob;
        public static string OOBAob;
        public static string SuperCarAob;
        public static string DLCPatchAob;
        public static string CarIdAob;
        public static string DiscoverRoadsAob;
        public static string WaterAob;
        public static string AIXAob;
        public static string CosmeticUnlockAob;
        public static string HornAsmAob;
        #endregion
        #region Addresses
        public static string BaseAddr;
        public static string Base2Addr;
        public static string Base3Addr;
        public static string Base4Addr;
        public static string Car1Addr;
        public static string Car2Addr;
        public static string FOVnopOutAddr;
        public static string FOVnopInAddr;
        public static string TimeNOPAddr;
        public static string TimeAddr;
        public static string Wall1Addr;
        public static string Wall2Addr;
        public static string FrontLeftAddr;
        public static string FrontRightAddr;
        public static string BackLeftAddr;
        public static string BackRightAddr;
        public static string OnGroundAddr;
        public static string InRaceAddr;
        public static string PastStartAddr;
        public static string PastIntroAddr = null;
        public static string xVelocityAddr;
        public static string yVelocityAddr;
        public static string zVelocityAddr;
        public static string xAddr;
        public static string yAddr;
        public static string zAddr;
        public static string CheckPointxAddr;
        public static string CheckPointyAddr;
        public static string CheckPointzAddr;
        public static string CheckPointxASMAddr;
        public static string WayPointxAddr;
        public static string WayPointyAddr;
        public static string WayPointzAddr;
        public static string WayPointxASMAddr;
        public static string YawAddr;
        public static string RollAddr;
        public static string PitchAddr;
        public static string yAngVelAddr;
        public static string GasAddr;
        public static string GravityAddr;
        public static string WeirdAddr;
        public static string FOVHighAddr;
        public static string FOVInAddr;
        public static string FirstPersonAddr;
        public static string DashAddr;
        public static string FrontAddr;
        public static string BonnetAddr;
        public static string LowAddr;
        public static string LowCompare;
        public static string CurrentIDAddr;
        public static string TimeAddrAddr;
        public static string allocationstring;
        public static string OOBnopAddr;
        public static string SuperCarAddr;
        public static string WorldRGBAddr;
        public static string InPauseAddr;
        public static string InHouseAddr;
        public static string TestAddr;
        public static string FOVJmpAddr;
        public static string CheckPointBaseAddr = null;
        public static string WayPointBaseAddr = null;
        public static string DiscoverRoadsAddr = null;
        public static string TotalXpAddr = null;
        public static string WaterAddr = null;
        public static string AIXAobAddr = null;
        public static string CosmeticUnlockAddr = null;
        public static string HornAsmAddr = null;
        public static string XPaddr = null;
        public static string XPAmountaddr = null;
        #endregion
        #region Addresses - CodeCaves
        public static IntPtr CCBA = (IntPtr)0;
        public static IntPtr CCBA2 = (IntPtr)0;
        public static IntPtr CCBA3 = (IntPtr)0;
        public static IntPtr CCBA4 = (IntPtr)0;
        public static IntPtr CCBA5 = (IntPtr)0;
        public static IntPtr CCBA6 = (IntPtr)0;
        public static IntPtr CCBA7 = (IntPtr)0;
        public static IntPtr CCBA8 = (IntPtr)0;
        public static IntPtr CodeCave = (IntPtr)0;
        public static IntPtr CodeCave2 = (IntPtr)0;
        public static IntPtr CodeCave3 = (IntPtr)0;
        public static IntPtr CodeCave4 = (IntPtr)0;
        public static IntPtr CodeCave5 = (IntPtr)0;
        public static IntPtr CodeCave6 = (IntPtr)0;
        public static IntPtr CodeCave7 = (IntPtr)0;
        public static IntPtr CodeCave8 = (IntPtr)0;
        #endregion
        #region Addresses - FOV
        long ScanStartAddr;
        long ScanEndAddr;
        List<string> RearAddresses = new List<string>();
        List<string> RestAddresses = new List<string>();
        #endregion
        public bool MainAOBScanDone = false;
        #region Offsets + AOB's
        private static void AddressesFour()
        {
            FrontLeftAddr = (BaseAddr + ",0x2E0,0x58,0x60,0x1A0,0x60,0xD18,0xC");
            FrontRightAddr = (BaseAddr + ",0x2E0,0x58,0x60,0x1A0,0x60,0xD20,0xC");
            BackLeftAddr = (BaseAddr + ",0x2E0,0x58,0x60,0x1A0,0x60,0xD38,0xC");
            BackRightAddr = (BaseAddr + ",0x2E0,0x58,0x60,0x1A0,0x60,0xD30,0xC");
            OnGroundAddr = (BaseAddr + ",0x550,0x260,0x258,0x4B0,0x640,0x368,0x10C");
            InRaceAddr = (Base2Addr + ",0x80,0x8,0x38,0x58,0x28,0x18,0x230");
            xVelocityAddr = (BaseAddr + ",0x2E0,0x58,0x60,0x1A0,0x60,-0x540");
            yVelocityAddr = (BaseAddr + ",0x2E0,0x58,0x60,0x1A0,0x60,-0x53C");
            zVelocityAddr = (BaseAddr + ",0x2E0,0x58,0x60,0x1A0,0x60,-0x538");
            yAddr = (BaseAddr + ",0x2E0,0x58,0x60,0x1A0,0x60,-0x51C");
            zAddr = (BaseAddr + ",0x2E0,0x58,0x60,0x1A0,0x60,-0x518");
            xAddr = (BaseAddr + ",0x2E0,0x58,0x60,0x1A0,0x60,-0x520");
            yAddr = (BaseAddr + ",0x2E0,0x58,0x60,0x1A0,0x60,-0x51C");
            zAddr = (BaseAddr + ",0x2E0,0x58,0x60,0x1A0,0x60,-0x518");
            YawAddr = (BaseAddr + ",0x2E0,0x58,0x60,0x1A0,0x60,-0x3FC");
            RollAddr = (BaseAddr + ",0x2E0,0x58,0x60,0x1A0,0x60,-0x418");
            PitchAddr = (BaseAddr + ",0x2E0,0x58,0x60,0x1A0,0x60,-0x410");
            yAngVelAddr = (BaseAddr + ",0x2E0,0x58,0x60,0x1A0,0x60,-0x52C");
            GasAddr = (BaseAddr + ",0x2E0,0x58,0x60,0x1A0,0x60,0xD18,-0x53C");
            PastStartAddr = (Base2Addr + ",0x80,0x8,0x38,0x58,0x28,0x18,0x5C");
            InPauseAddr = (Base2Addr + ",0x80,0x8,0x38,0x58,0x28,0x18,0x3D8");
            FOVHighAddr = (BaseAddr + ",0x568,0x270,0x258,0xB8,0x348,0x70,0x5B0");
            WeirdAddr = (BaseAddr + ",0x2E0,0x58,0x60,0x1A0,0x60,-0x554");
            GravityAddr = (BaseAddr + ",0x2E0,0x58,0x60,0x1A0,0x60,-0x558");
            /*s.LST_TeleportLocation.Items.Clear();
            s.LST_TeleportLocation.Items.Add("Waypoint");
            s.LST_TeleportLocation.Items.Add("Adventure Park");
            s.LST_TeleportLocation.Items.Add("Ambleside");
            s.LST_TeleportLocation.Items.Add("Beach");
            s.LST_TeleportLocation.Items.Add("Broadway");
            s.LST_TeleportLocation.Items.Add("Dam");
            s.LST_TeleportLocation.Items.Add("Edinburgh");
            s.LST_TeleportLocation.Items.Add("Festival");
            s.LST_TeleportLocation.Items.Add("Greendale Airstrip");
            s.LST_TeleportLocation.Items.Add("Lake Island");
            s.LST_TeleportLocation.Items.Add("Mortimer Gardens");
            s.LST_TeleportLocation.Items.Add("Quarry");
            s.LST_TeleportLocation.Items.Add("Railyard");
            s.LST_TeleportLocation.Items.Add("Start of Motorway");
            s.LST_TeleportLocation.Items.Add("Top of Mountain");
            s.g2gWorker.RunWorkerAsync();*/
        }
        private static void AddressesFourSteam()
        {
            FrontRightAddr = (BaseAddr + ",0x2E0,0x58,0x60,0x1A0,0x60,0xD20,0xC");
        }
        private static void AddressesFive()
        {
            FrontLeftAddr = (BaseAddr + ",0x1F0,0xDB8,0x780,0x8,0x10");
            FrontRightAddr = (BaseAddr + ",0x1F0,0xDB8,0x780,0x8,0xA80");
            BackLeftAddr = (BaseAddr + ",0x1F0,0xDB8,0x780,0x8,0x1F60");
            BackRightAddr = (BaseAddr + ",0x1F0,0xDB8,0x780,0x8,0x14F0");
            xVelocityAddr = (BaseAddr + ",0x1F0,0xDB8,0x780,0x8,-0x2618");
            yVelocityAddr = (BaseAddr + ",0x1F0,0xDB8,0x780,0x8,-0x261C");
            zVelocityAddr = (BaseAddr + ",0x1F0,0xDB8,0x780,0x8,-0x2620");
            yAddr = (BaseAddr + ",0x1F0,0xDB8,0x780,0x8,-0x25EC");
            zAddr = (BaseAddr + ",0x1F0,0xDB8,0x780,0x8,-0x25E8");
            xAddr = (BaseAddr + ",0x1F0,0xDB8,0x780,0x8,-0x25F0");
            WeirdAddr = (BaseAddr + ",0x1F0,0xDB8,0x780,0x8,-0x2634");
            GravityAddr = (BaseAddr + ",0x1F0,0xDB8,0x780,0x8,-0x2638");
            OnGroundAddr = (BaseAddr + ",0x1F0,0xDB8,0x780,0x8,-0xB84");
            GasAddr = (BaseAddr + ",0x1F0,0xDB8,0x780,0x8,-0xBC8");
            YawAddr = (BaseAddr + ",0x1F0,0xDB8,0x780,0x8,-0x2550");
            RollAddr = (BaseAddr + ",0x1F0,0xDB8,0x780,0x8,-0x254C");
            PitchAddr = (BaseAddr + ",0x1F0,0xDB8,0x780,0x8,-0x2538");
            yAngVelAddr = (BaseAddr + ",0x1F0,0xDB8,0x780,0x8,-0x260C");
            InRaceAddr = (Base2Addr + ",0x50,0x3D8");
            InPauseAddr = (Base2Addr + ",0x50,0x480");
            InHouseAddr = (Base2Addr + ",0x50,0x368");
            TestAddr = (Base2Addr + ",0x50,0x218");
            FOVHighAddr = (Base3Addr + ",0x538,0xF0,0xD80,0x6F0");
            /*s.LST_TeleportLocation.Items.Clear();
            s.LST_TeleportLocation.Items.Add("Waypoint");
            s.LST_TeleportLocation.Items.Add("Airstrip");
            s.LST_TeleportLocation.Items.Add("Bridge");
            s.LST_TeleportLocation.Items.Add("Dirt Circuit");
            s.LST_TeleportLocation.Items.Add("Dunes");
            s.LST_TeleportLocation.Items.Add("Golf Course");
            s.LST_TeleportLocation.Items.Add("Guanajuato (Main City)");
            s.LST_TeleportLocation.Items.Add("Motorway");
            s.LST_TeleportLocation.Items.Add("Mulege");
            s.LST_TeleportLocation.Items.Add("Playa Azul");
            s.LST_TeleportLocation.Items.Add("River");
            s.LST_TeleportLocation.Items.Add("Stadium");
            s.LST_TeleportLocation.Items.Add("Temple");
            s.LST_TeleportLocation.Items.Add("Temple Drag");
            s.LST_TeleportLocation.Items.Add("Top Of Volcano");
            s.g2gWorker.RunWorkerAsync();*/
        }
        private static void Aobs()
        {
            BaseAob = "43 3a 5c 57 ? 4e 44 4f 57 53 5c 53 59 53 54 45 4d 33 32 5c 44";
            Car1Aob = "48 89 ? ? ? 44 8B ? 48 89 ? ? ? BA";
            Car2Aob = "0F 28 ? 41 0F ? ? ? 0F C6 D6 ? 41 0F";
            Wall1Aob = "F3 0F ? ? ? 0F 59 ? 0F C6 ED ? 0F C6 F6";
            Wall2Aob = "0F 28 ? 0F C6 C1 ? 0F 28 ? 0F C6 CB ? 41 0F ? ? F3 0F ? ? 41 0F ? ? 0F C6 C0 ? 0F C6 E4";
            FOVOutAob = "4C 8D ? ? ? 0F 29 ? ? ? F3 0F";
            FOVInAob = "48 81 EC ? ? ? ? 48 8B ? E8 ? ? ? ? 48 8B ? ? 48 8B";
            TimeAob = "20 F2 0F 11 43 08 48 83";
            CheckPointxASMAob = "0F 28 ? ? ? ? ? 0F 29 ? ? 0F 29 ? ? C3 90 48 8B ? 55";
            WayPointxASMAob = "0F 10 ? ? ? ? ? 0F 28 ? 0F C2 ? 00 0F 50 C1 83 E0 07 3C 07";
            FirstPersonAob = "80 00 80 82 43";
            DashAob = "3F 00 00 80 3F 00 00 80 3F 00 00 80 3F 01 ?? 00 00 00 00 00 00 00 00 A0 40";
            LowAob = "80 CD CC 4C 3E CD CC CC";
            BonnetAob = "00 80 3E 63 B8 1E 3F 00 00 80 3F";
            //Front = "A0 41 01 00 8C 42 00 00 11 43 00 00 3E 43 00 00 00 80 00 00 00 80 00 00 80 3E 7B 14 2E 3F";
            FrontAob = "80 3E 7B 14 2E 3F 00 00 80 3F";
            XPAob = "F3 0F ? ? 89 45 ? 48 8D ? ? ? ? ? 41 83 BD C0 00 00 00";
            XPAmountAob = "8B 89 ? ? ? ? 85 C9 0F 8E";
            CurrentIDAob = "00 00 50 4C 41 59 45 52 5F 43 41 52 00 00";
            OOBAob = "0F 11 ? ? ? ? ? 0F 5C ? 0F 59 ? 0F 28 ? 0F C6 CA ? F3 0F";
            SuperCarAob = "0F 10 ? ? 0F 11 ? ? 0F 10 ? ? 0F 11 ? ? 0F 10 ? ? 0F 11 ? ? 0F 10 ? ? 48 83 C2 ? 0F 11 ? ? 48 83 C1 ? E8 ? ? ? ? 0F 10";
            DiscoverRoadsAob = "00 96 42 ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? 40 1C 45 ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? 03 00";
            WaterAob = "3D ? ? ? ? 00 00 A0 ? ? ? ? ? ? ? ? 3F 00 00";
            AIXAob = "48 89 ? ? ? 57 48 83 EC ? 0F 10 ? 48 8B ? 0F 11 ? ? 48 8B";
        }
        private static void AobsSteam()
        {
            BaseAob = "7F ? 00 01 00 00 00 03 00 00 00 01 00 00 00 00 00 00 00 64";
        }
        private static void AobsFive()
        {
            BaseAob = "7F ? 00 AC ? ? ? ? ? 6E 27 00 24";
            RGBAob = "81 80 80 3B 81 80 80 3B 81 80 80 3B 81 80 80 3B";
            Base2Aob = "E0 ? 41 ? E1 ? 00 00";
            XPAob = "F3 0F ? ? 89 45 ? 48 8D ? ? ? ? ? 41 83";
            XPAmountAob = "8B 89 ? ? ? ? 85 C9 0F 8E";
            Car1Aob = "0F 84 ? ? ? ? 4C 8B ? ? ? ? ? ? 45 0F ? ? 4C 8B";
            Wall1Aob = "0F 84 ? ? ? ? 4C 8B ? ? ? ? ? ? 49 83 C1 ? 66 44 ? ? ? ? ? ? ? 49 83 C0 ? 66 44 ? ? ? ? ? ? ? 45 0F ? ? 4D 8B ? 90";
            Wall2Aob = "0F 84 ? ? ? ? 4C 8B ? ? ? ? ? ? 49 83 C1 ? 66 44 ? ? ? ? ? ? ? 49 83 C0 ? 66 44 ? ? ? ? ? ? ? 45 0F ? ? 4D 8B ? 0F";
            TimeAob = "20 F2 0F 11 43 08 48 83";
            SuperCarAob = "0F 10 ? ? 0F 11 ? ? 0F 10 ? ? 0F 11 ? ? 0F 10 ? ? 0F 11 ? ? 0F 10 ? ? 48 83 C2 ? 0F 11 ? ? 48 83 C1 ? E8 ? ? ? ? 0F 10";
            WayPointxASMAob = "0F 10 ? ? ? ? ? 0F 28 ? 0F C2 ? 00 0F 50 C1 83 E0 07 3C 07";
            FOVJmpAob = "0F 2F ? ? ? 0F 10 ? ? 0F 28 ? 0F 10";
            //OOBaob = "0F 28 ? 0F 28 ? 0F C6 D1 ? 0F 59 ? ? ? ? ? 0F C6 C1 ? 0F 59 ? ? ? ? ? 0F C6 C9 ? 0F 59 ? ? ? ? ? 0F 58 ? 0F 58 ? 0F 58 ? ? 0F 11";
            OOBAob = "0F 11 9B ? FA FF FF";
            //CheckPointxASMsig = "48 85 ? 74 ? 48 ? ? ? ? ? C7 0F";
            CheckPointxASMAob = "33 C0 48 89 ? 48 89 ? ? 48 E9 ? ? ? ? 90 40 F3";
            CarIdAob = "00 B0 ? ? ? ? 7F ? 00 D8 6E";
            DiscoverRoadsAob = "63 70 ? B7 ? 5D";
            WaterAob = "3D ? ? ? ? 00 00 A0 ? ? ? ? ? ? ? ? 3F 00 00";
            AIXAob = "0F 11 41 50 0F 28 EB";
            CosmeticUnlockAob = "8B 73 58 8B 43 64";
            HornAsmAob = "8B FA 48 8B D9 E8 ? ? ? ? 39 7B 10";
            //TotalXpAddr = (Base3Addr + ",0xEE8,0x408,0x70,0x28,0x30,0x20,0x270");
        }
        private static void StartSetupFive()
        {
            xAddr = (BaseAddr + ",0x1F0,0xDB8,0x780,0x8,-0x25F0");
            WeirdAddr = (BaseAddr + ",0x1F0,0xDB8,0x780,0x8,-0x2634");
            InRaceAddr = (Base2Addr + ",0x50,0x3D8");
            InPauseAddr = (Base2Addr + ",0x50,0x480");
            InHouseAddr = (Base2Addr + ",0x50,0x368");
            TestAddr = (Base2Addr + ",0x50,0x218");
            FOVHighAddr = (Base3Addr + ",0x538,0xF0,0xD80,0x6F0");
        }
        #endregion
        public async void AoBscan()
        {
            int offsetfive = 4107;
            int offsetfivetwo = 28675;
            bool g2g = false;
            bool g2g2 = false;

            Self_Vehicle.sv.Dispatcher.Invoke(delegate ()
            {
                Self_Vehicle.sv.ScanButton.IsEnabled = false;
            });

            if (MainWindow.mw.gvp.Name == "Forza Horizon 4")
            {
                try
                {
                    while (MainAOBScanDone == false)
                    {
                        if (MainWindow.mw.gvp.Plat == "MS")
                        {
                            Aobs();
                            Thread.Sleep(1);
                            if (BaseAddr == "29A0" || BaseAddr == null || BaseAddr == "0")
                            {
                                BaseAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, BaseAob, true, true)).FirstOrDefault() + 10656;
                                BaseAddr = BaseAddrLong.ToString("X");
                                Base2AddrLong = BaseAddrLong + 4512;
                                Base2Addr = Base2AddrLong.ToString("X");
                                Base3AddrLong = BaseAddrLong - 18496;
                                Base3Addr = Base3AddrLong.ToString("X");
                                Base4AddrLong = BaseAddrLong - 58296;
                                Base4Addr = Base4AddrLong.ToString("X");
                                WorldRGBAddrLong = BaseAddrLong - 422832;
                                WorldRGBAddr = WorldRGBAddrLong.ToString("X");
                            }
                            else
                            {
                                await Self_Vehicle.sv.Dispatcher.BeginInvoke((Action)delegate ()
                                {
                                    for (int i = (int)Self_Vehicle.sv.AOBProgressBar.Value; i <= 22; i++)
                                    { Thread.Sleep(15); Self_Vehicle.sv.AOBProgressBar.Value = i; }
                                });
                                Car1AddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, Car1Aob, true, true)).FirstOrDefault() + 106;
                                Car1Addr = Car1AddrLong.ToString("X");

                                await Self_Vehicle.sv.Dispatcher.BeginInvoke((Action)delegate ()
                                {
                                    for (int i = (int)Self_Vehicle.sv.AOBProgressBar.Value; i <= 28; i++)
                                    { Thread.Sleep(15); Self_Vehicle.sv.AOBProgressBar.Value = i; }
                                });
                                Car2AddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, Car2Aob, true, true)).FirstOrDefault() - 411;
                                Car2Addr = Car2AddrLong.ToString("X");

                                await Self_Vehicle.sv.Dispatcher.BeginInvoke((Action)delegate ()
                                {
                                    for (int i = (int)Self_Vehicle.sv.AOBProgressBar.Value; i <= 33; i++)
                                    { Thread.Sleep(15); Self_Vehicle.sv.AOBProgressBar.Value = i; }
                                });
                                Wall1AddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, Wall1Aob, true, true)).FirstOrDefault() + 401;
                                Wall1Addr = Wall1AddrLong.ToString("X");

                                await Self_Vehicle.sv.Dispatcher.BeginInvoke((Action)delegate ()
                                {
                                    for (int i = (int)Self_Vehicle.sv.AOBProgressBar.Value; i <= 39; i++)
                                    { Thread.Sleep(15); Self_Vehicle.sv.AOBProgressBar.Value = i; }
                                });
                                Wall2AddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, Wall2Aob, true, true)).FirstOrDefault() - 446;
                                Wall2Addr = Wall2AddrLong.ToString("X");

                                await Self_Vehicle.sv.Dispatcher.BeginInvoke((Action)delegate ()
                                {
                                    for (int i = (int)Self_Vehicle.sv.AOBProgressBar.Value; i <= 44; i++)
                                    { Thread.Sleep(15); Self_Vehicle.sv.AOBProgressBar.Value = i; }
                                });
                                //ToolInfo.Mute.Enabled = true;
                                FOVnopOutAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, FOVOutAob, true, true)).FirstOrDefault() + 123;
                                FOVnopOutAddr = FOVnopOutAddrLong.ToString("X");

                                await Self_Vehicle.sv.Dispatcher.BeginInvoke((Action)delegate ()
                                {
                                    for (int i = (int)Self_Vehicle.sv.AOBProgressBar.Value; i <= 50; i++)
                                    { Thread.Sleep(15); Self_Vehicle.sv.AOBProgressBar.Value = i; }
                                });
                                FOVnopInAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, FOVInAob, true, true)).FirstOrDefault() + 1383;
                                FOVnopInAddr = FOVnopInAddrLong.ToString("X");

                                await Self_Vehicle.sv.Dispatcher.BeginInvoke((Action)delegate ()
                                {
                                    for (int i = (int)Self_Vehicle.sv.AOBProgressBar.Value; i <= 56; i++)
                                    { Thread.Sleep(15); Self_Vehicle.sv.AOBProgressBar.Value = i; }
                                });
                                TimeNOPAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, TimeAob, true, true)).FirstOrDefault() + 1;
                                TimeNOPAddr = TimeNOPAddrLong.ToString("X");

                                for (int i = (int)Self_Vehicle.sv.AOBProgressBar.Value; i <= 61; i++)
                                { Thread.Sleep(15); Self_Vehicle.sv.AOBProgressBar.Value = i; }
                                CheckPointxASMAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, CheckPointxASMAob, true, true)).FirstOrDefault();
                                CheckPointxASMAddr = CheckPointxASMAddrLong.ToString("X");

                                for (int i = (int)Self_Vehicle.sv.AOBProgressBar.Value; i <= 67; i++)
                                { Thread.Sleep(15); Self_Vehicle.sv.AOBProgressBar.Value = i; }
                                WayPointxASMAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, WayPointxASMAob, true, true)).FirstOrDefault();
                                WayPointxASMAddr = WayPointxASMAddrLong.ToString("X");

                                for (int i = (int)Self_Vehicle.sv.AOBProgressBar.Value; i <= 72; i++)
                                { Thread.Sleep(15); Self_Vehicle.sv.AOBProgressBar.Value = i; }
                                XPaddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, XPAob, true, true)).FirstOrDefault();
                                XPaddr = XPaddrLong.ToString("X");

                                for (int i = (int)Self_Vehicle.sv.AOBProgressBar.Value; i <= 78; i++)
                                { Thread.Sleep(15); Self_Vehicle.sv.AOBProgressBar.Value = i; }
                                XPAmountaddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, XPAmountAob, true, true)).FirstOrDefault();
                                XPAmountaddr = XPAmountaddrLong.ToString("X");

                                for (int i = (int)Self_Vehicle.sv.AOBProgressBar.Value; i <= 83; i++)
                                { Thread.Sleep(15); Self_Vehicle.sv.AOBProgressBar.Value = i; }
                                CurrentIDAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, CurrentIDAob, true, true)).FirstOrDefault() + 42;
                                CurrentIDAddr = CurrentIDAddrLong.ToString("X");

                                for (int i = (int)Self_Vehicle.sv.AOBProgressBar.Value; i <= 89; i++)
                                { Thread.Sleep(15); Self_Vehicle.sv.AOBProgressBar.Value = i; }
                                OOBnopAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, OOBAob, true, true)).FirstOrDefault();
                                OOBnopAddr = OOBnopAddrLong.ToString("X");

                                for (int i = (int)Self_Vehicle.sv.AOBProgressBar.Value; i <= 94; i++)
                                { Thread.Sleep(15); Self_Vehicle.sv.AOBProgressBar.Value = i; }
                                SuperCarAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, SuperCarAob, true, true)).FirstOrDefault();
                                SuperCarAddr = SuperCarAddrLong.ToString("X");

                                for (int i = (int)Self_Vehicle.sv.AOBProgressBar.Value; i <= 92; i++)
                                { Thread.Sleep(15); Self_Vehicle.sv.AOBProgressBar.Value = i; }
                                DiscoverRoadsAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, DiscoverRoadsAob, true, true)).FirstOrDefault();
                                DiscoverRoadsAddr = DiscoverRoadsAddrLong.ToString("X");

                                for (int i = (int)Self_Vehicle.sv.AOBProgressBar.Value; i <= 93; i++)
                                { Thread.Sleep(15); Self_Vehicle.sv.AOBProgressBar.Value = i; }
                                WaterAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, WaterAob, true, true)).FirstOrDefault() + 309;
                                WaterAddr = WaterAddrLong.ToString("X");

                                for (int i = (int)Self_Vehicle.sv.AOBProgressBar.Value; i <= 93; i++)
                                { Thread.Sleep(15); Self_Vehicle.sv.AOBProgressBar.Value = i; }
                                AIXAobAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, AIXAob, true, true)).FirstOrDefault() + 16;
                                AIXAobAddr = AIXAobAddrLong.ToString("X");
                            }
                        }
                        else
                        {
                            AobsSteam();
                            Thread.Sleep(1);
                            if (BaseAddr == "FFFFFFFFFFFFFE0B" || BaseAddr == null || BaseAddr == "0")
                            {
                                BaseAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, BaseAob, true, true)).FirstOrDefault() - 501;
                                BaseAddr = BaseAddrLong.ToString("X");
                            }
                        }
                        if (MainWindow.mw.gvp.Plat == "MS" && (BaseAddr == "29A0" || BaseAddr == null || BaseAddr == "0"
                            || Base2Addr == "3B40" || Base2Addr == null || Base2Addr == "0"
                            || Base3Addr == "FFFFFFFFFFFFF300" || Base3Addr == null || Base3Addr == "0"
                            || Base4Addr == "BA18" || Base4Addr == null || Base4Addr == "0"
                            || Car1Addr == "6A" || Car1Addr == null || Car1Addr == "0"
                            || Car2Addr == "FFFFFFFFFFFFFE65" || Car2Addr == null || Car2Addr == "0"
                            || Wall1Addr == "191" || Wall1Addr == null || Wall1Addr == "0"
                            || Wall2Addr == "FFFFFFFFFFFFFE42" || Wall2Addr == null || Wall2Addr == "0"
                            || FOVnopInAddr == "567" || FOVnopInAddr == null || FOVnopInAddr == "0"
                            || FOVnopOutAddr == "7B" || FOVnopOutAddr == null || FOVnopOutAddr == "0"
                            || CheckPointxASMAddr == null || CheckPointxASMAddr == "0"
                            || XPaddr == null || XPaddr == "0"
                            || XPAmountaddr == null || XPAmountaddr == "0"
                            || TimeNOPAddr == null || TimeNOPAddr == "0"
                            || CurrentIDAddr == "2A" || CurrentIDAddr == null || CurrentIDAddr == "0"
                            || OOBnopAddr == null || OOBnopAddr == "0"
                            || SuperCarAddr == null || SuperCarAddr == "0"
                            || DiscoverRoadsAddr == null || DiscoverRoadsAddr == "0"
                            || WaterAddr == "135" || WaterAddr == null || WaterAddr == "0"
                            || AIXAobAddr == "10" || AIXAobAddr == null || AIXAobAddr == "0")
                            )
                        {
                            ;
                        }
                        else if (MainWindow.mw.gvp.Plat == "Steam" && (BaseAddr == "FFFFFFFFFFFFFE0B" || BaseAddr == null || BaseAddr == "0"))
                        {
                            ;
                        }
                        else
                        {
                            if (MainWindow.mw.gvp.Plat == "MS")
                            {
                                CCBA = MainWindow.mw.gvp.Process.MainModule.BaseAddress;
                                CodeCave = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                                while (CodeCave == (IntPtr)0)
                                {
                                    CCBA += 500000;
                                    CodeCave = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                                }
                                CCBA2 = MainWindow.mw.gvp.Process.MainModule.BaseAddress;
                                CodeCave2 = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA2, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                                while (CodeCave2 == (IntPtr)0)
                                {
                                    CCBA2 += 500000;
                                    CodeCave2 = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA2, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                                }
                                CCBA3 = MainWindow.mw.gvp.Process.MainModule.BaseAddress;
                                CodeCave3 = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA3, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                                while (CodeCave3 == (IntPtr)0)
                                {
                                    CCBA3 += 500000;
                                    CodeCave3 = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA3, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                                }
                                CCBA4 = MainWindow.mw.gvp.Process.MainModule.BaseAddress;
                                CodeCave4 = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA4, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                                while (CodeCave4 == (IntPtr)0)
                                {
                                    CCBA4 += 500000;
                                    CodeCave4 = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA4, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                                }
                                CCBA5 = MainWindow.mw.gvp.Process.MainModule.BaseAddress;
                                CodeCave5 = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA5, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                                while (CodeCave5 == (IntPtr)0)
                                {
                                    CCBA5 += 500000;
                                    CodeCave5 = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA5, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                                }
                                CCBA6 = MainWindow.mw.gvp.Process.MainModule.BaseAddress;
                                CodeCave6 = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA5, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                                while (CodeCave6 == (IntPtr)0)
                                {
                                    CCBA6 += 500000;
                                    CodeCave6 = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA6, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                                }
                                for (int i = (int)Self_Vehicle.sv.AOBProgressBar.Value; i <= 100; i++)
                                { Thread.Sleep(15); Self_Vehicle.sv.AOBProgressBar.Value = i; }
                                AddressesFour();
                                MainAOBScanDone = true;
                            }
                            else
                            {
                                for (int i = (int)Self_Vehicle.sv.AOBProgressBar.Value; i <= 100; i++)
                                { Thread.Sleep(15); Self_Vehicle.sv.AOBProgressBar.Value = i; }
                                AddressesFourSteam();
                                MainAOBScanDone = true;
                            }
                        }
                        Thread.Sleep(1);
                    }
                }
                catch
                {
                    ;
                }
            }
            else
            {
                try
                {
                    while (MainAOBScanDone == false)
                    {
                        AobsFive();
                        if (offsetfive >= 12299)
                            offsetfive = 4107;
                        if (offsetfive == 4107 || BaseAddrLong == 0)
                        {
                            BaseAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, BaseAob, true, true)).FirstOrDefault();
                            BaseAddr = BaseAddrLong.ToString("X");
                        }
                        if (offsetfivetwo >= 32771)
                            offsetfivetwo = 28675;
                        if ((offsetfivetwo == 28675 || BaseAddrLong == 0) && g2g && !g2g2)
                        {
                            BaseAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, BaseAob, true, true)).FirstOrDefault();
                            Base2Addr = BaseAddrLong.ToString("X");
                        }
                        if ((BaseAddrLong != null || BaseAddrLong != offsetfive || BaseAddrLong != 0) && !g2g)
                        {
                            BaseAddr = (BaseAddrLong + offsetfive).ToString("X");
                            StartSetupFive();
                            offsetfive += 8;
                            try
                            {
                                if (MainWindow.mw.m.ReadFloat(xAddr) != 0
                                    && !float.IsInfinity(MainWindow.mw.m.ReadFloat(xAddr))
                                    && MainWindow.mw.m.ReadFloat(xAddr) > -10000000
                                    && MainWindow.mw.m.ReadFloat(xAddr) < 10000000
                                    && MainWindow.mw.m.ReadFloat(yAddr) > -10000
                                    && MainWindow.mw.m.ReadFloat(yAddr) < 10000
                                    && MainWindow.mw.m.ReadFloat(zAddr) > -10000000
                                    && MainWindow.mw.m.ReadFloat(zAddr) < 10000000
                                    && MainWindow.mw.m.ReadFloat(WeirdAddr) < 0.2
                                    && MainWindow.mw.m.ReadFloat(WeirdAddr) > 0.01)
                                {
                                    g2g = true;
                                }

                            }
                            catch
                            {
                                g2g = false;
                            }
                        }
                        else if ((BaseAddrLong != null || BaseAddrLong != offsetfivetwo || BaseAddrLong != 0) && g2g && !g2g2)
                        {
                            AddProgress(1);
                            Base2Addr = (BaseAddrLong + offsetfivetwo).ToString("X");
                            StartSetupFive();
                            offsetfivetwo += 8;
                            try
                            {
                                if ((MainWindow.mw.m.ReadFloat(InPauseAddr) == 1 && MainWindow.mw.m.ReadFloat(InHouseAddr) == 0)
                                    || (MainWindow.mw.m.ReadFloat(InPauseAddr) == 0 && MainWindow.mw.m.ReadFloat(InHouseAddr) == 1)
                                    || MainWindow.mw.m.ReadFloat(TestAddr) == 1)//if (MainWindow.mw.m.ReadFloat(Base2Addr + ",0x50,0x41D") == 2)
                                {
                                    g2g2 = true;
                                }
                            }
                            catch
                            {
                                g2g2 = false;
                            }
                        }
                        else
                        {
                            AddProgress(2);
                            FOVJmpAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, FOVJmpAob, true, true)).FirstOrDefault() + 3;
                            FOVJmpAddr = FOVJmpAddrLong.ToString("X");

                            AddProgress(3);
                            Car1AddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, Car1Aob, true, true)).FirstOrDefault();
                            Car1Addr = Car1AddrLong.ToString("X");

                            AddProgress(4);
                            Wall1AddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, Wall1Aob, true, true)).FirstOrDefault();
                            Wall1Addr = Wall1AddrLong.ToString("X");

                            AddProgress(5);
                            Wall2AddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, Wall2Aob, true, true)).FirstOrDefault();
                            Wall2Addr = Wall2AddrLong.ToString("X");

                            AddProgress(6);
                            TimeNOPAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, TimeAob, true, true)).FirstOrDefault() + 1;
                            TimeNOPAddr = TimeNOPAddrLong.ToString("X");

                            AddProgress(7);
                            XPaddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, XPAob, true, true)).FirstOrDefault();
                            XPaddr = XPaddrLong.ToString("X");

                            AddProgress(8);
                            XPAmountaddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, XPAmountAob, true, true)).FirstOrDefault();
                            XPAmountaddr = XPAmountaddrLong.ToString("X");

                            AddProgress(9);
                            WayPointxASMAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, WayPointxASMAob, true, true)).FirstOrDefault();
                            WayPointxASMAddr = WayPointxASMAddrLong.ToString("X");

                            AddProgress(10);
                            DiscoverRoadsAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, DiscoverRoadsAob, true, true)).FirstOrDefault();
                            DiscoverRoadsAddr = DiscoverRoadsAddrLong.ToString("X");

                            AddProgress(11);
                            WaterAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, WaterAob, true, true)).FirstOrDefault() + 309;
                            WaterAddr = WaterAddrLong.ToString("X");

                            AddProgress(12);
                            if (MainWindow.mw.gvp.Plat == "MS")
                                CheckPointxASMAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, "0F 10 89 60 02 00 00 0F 29", true, true)).FirstOrDefault();
                            else
                                CheckPointxASMAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, "0F 10 89 60 02 00 00 0F 29", true, true)).FirstOrDefault();
                            CheckPointxASMAddr = CheckPointxASMAddrLong.ToString("X");

                            AddProgress(13);
                            AIXAobAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, AIXAob, true, true)).FirstOrDefault();
                            AIXAobAddr = AIXAobAddrLong.ToString("X");

                            AddProgress(14);
                            CosmeticUnlockAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, CosmeticUnlockAob, true, true)).FirstOrDefault();
                            CosmeticUnlockAddr = CosmeticUnlockAddrLong.ToString("X");

                            AddProgress(15);
                            OOBnopAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, OOBAob, true, true)).FirstOrDefault();
                            OOBnopAddr = OOBnopAddrLong.ToString("X");

                            AddProgress(16);
                            SuperCarAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, SuperCarAob, true, true)).FirstOrDefault();
                            SuperCarAddr = SuperCarAddrLong.ToString("X");

                            AddProgress(17);
                            HornAsmAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, HornAsmAob, true, true)).LastOrDefault();
                            HornAsmAddr = HornAsmAddrLong.ToString("X");

                            AddProgress(18);
                            WorldRGBAddrLong = (await MainWindow.mw.m.AoBScan((long)MainWindow.mw.gvp.Process.MainModule.BaseAddress, (long)MainWindow.mw.gvp.Process.MainModule.BaseAddress + (long)MainWindow.mw.gvp.Process.MainModule.ModuleMemorySize, RGBAob, true, true)).LastOrDefault();
                            WorldRGBAddr = WorldRGBAddrLong.ToString("X");

                            CCBA = MainWindow.mw.gvp.Process.MainModule.BaseAddress;
                            CodeCave = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                            while (CodeCave == (IntPtr)0)
                            {
                                CCBA += 500000;
                                CodeCave = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                            }
                            AddProgress(19);
                            CCBA2 = MainWindow.mw.gvp.Process.MainModule.BaseAddress;
                            CodeCave2 = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA2, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                            while (CodeCave2 == (IntPtr)0)
                            {
                                CCBA2 += 500000;
                                CodeCave2 = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA2, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                            }
                            AddProgress(20);
                            CCBA3 = MainWindow.mw.gvp.Process.MainModule.BaseAddress;
                            CodeCave3 = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA3, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                            while (CodeCave3 == (IntPtr)0)
                            {
                                CCBA3 += 500000;
                                CodeCave3 = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA3, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                            }
                            AddProgress(21);
                            CCBA4 = MainWindow.mw.gvp.Process.MainModule.BaseAddress;
                            CodeCave4 = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA4, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                            while (CodeCave4 == (IntPtr)0)
                            {
                                CCBA4 += 500000;
                                CodeCave4 = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA4, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                            }
                            AddProgress(22);
                            CCBA5 = MainWindow.mw.gvp.Process.MainModule.BaseAddress;
                            CodeCave5 = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA5, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                            while (CodeCave5 == (IntPtr)0)
                            {
                                CCBA5 += 500000;
                                CodeCave5 = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA5, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                            }
                            AddProgress(23);
                            CCBA6 = MainWindow.mw.gvp.Process.MainModule.BaseAddress;
                            CodeCave6 = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA5, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                            while (CodeCave6 == (IntPtr)0)
                            {
                                CCBA6 += 500000;
                                CodeCave6 = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA6, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                            }
                            AddProgress(24);
                            CCBA7 = MainWindow.mw.gvp.Process.MainModule.BaseAddress;
                            CodeCave7 = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA7, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                            while (CodeCave7 == (IntPtr)0)
                            {
                                CCBA7 += 500000;
                                CodeCave7 = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA7, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                            }
                            AddProgress(25);
                            CCBA8 = MainWindow.mw.gvp.Process.MainModule.BaseAddress;
                            CodeCave8 = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA8, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                            while (CodeCave8 == (IntPtr)0)
                            {
                                CCBA8 += 500000;
                                CodeCave8 = assembly.VirtualAllocEx(MainWindow.mw.gvp.Process.Handle, CCBA8, 0x256, assembly.MEM_COMMIT | assembly.MEM_RESERVE, assembly.PAGE_EXECUTE_READWRITE);
                            }
                            AddProgress(26);
                            AddressesFive();
                            MainAOBScanDone = true;
                            Self_Vehicle.sv.Dispatcher.Invoke(delegate ()
                            {
                                Self_Vehicle.sv.AOBProgressBar.Visibility = System.Windows.Visibility.Hidden;
                                Self_Vehicle.sv.ScanButton.Content = "Done";
                                Self_Vehicle.sv.ScanButton.IsEnabled = false;
                            });
                        }
                        Thread.Sleep(1);
                    }
                }
                catch
                {
                    ;
                }
            }
        }
        private void AddProgress(int index)
        {

            int Prog = (int)(Math.Round((decimal)100 / ScanAmount) * index);
            if (Prog > 100)
                Prog = 100;
            int CurrentProg = 0;
            Self_Vehicle.sv.Dispatcher.Invoke(delegate ()
            {
                CurrentProg = (int)Self_Vehicle.sv.AOBProgressBar.Value;
            });

            for (int i = CurrentProg; i <= Prog; i++)
            {
                Self_Vehicle.sv.Dispatcher.Invoke(delegate ()
                {
                    Self_Vehicle.sv.AOBProgressBar.Value = i;
                });
                Thread.Sleep(15);
            }
        }
    }
}