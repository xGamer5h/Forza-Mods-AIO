﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Linq;

namespace Forza_Mods_AIO
{
    public static class TranslateUtil
    {
        public const string ChineseTranslateFile = "zh_CN.ini";
        public static List<string> Strings = new List<string>();
        public static List<string> StringsLower = new List<string>();
        public static Dictionary<string,string> ChineseTranslate = new Dictionary<string, string>() 
        {
            #region[MainWindow.xaml]
            {"AIO Info","AIO 信息" },
            {"Autoshow/Garage","汽车展/车库" },
            {"Self/Vehicle","本人/车辆" },
            {"Tuning","转向" },
            {"Keybindings","绑定按键" },
            {"Tool Credits","赞助工具" },
            {"Donations","捐赠" },
            {"Wall Colour","背景颜色" },
            {"Lightness","明亮度" },
            {"Overlay","置顶" },
            {"On","开启" },
            {"Off","关闭" },
            #endregion

            #region[AutoShow.xaml]
            {"Scan","扫描"},
            {"Auto-show Filters","自动显示过滤"},
            {"All Cars","所有汽车"},
            {"This option will show every car in the autoshow.\nCannot be utilized simultaneously with rare cars toggle","此选项将显示车展中的每辆汽车。\n不能与稀有汽车切换同时使用。"},
            {"Rare Cars","稀有汽车"},
            {"This option will show every rare car in the autoshow.\nCannot be utilized simultaneously with all cars toggle","此选项将显示车展中的每辆稀有汽车。\n不能与所有汽车切换同时使用。"},
            {"Free Cars","免费汽车"},
            {"This option will make every car in the autoshow free.","此选项将使车展中的每辆汽车免费。"},
            {"Show Traffic/HS/Null","显示交通/HS/空"},
            {"This option enables seeing all traffic cars in the autoshow.\nYou must enable either all or rare cars for it to take effect.","此选项可以查看车展中的所有交通汽车。\n您必须启用所有或稀有汽车才能生效。"},
            {"Garage Modifications","车库修改"},
            {"Unlock Hidden Presets","解锁隐藏预设"},
            {"This option unlocks hidden presets from the games missions where you drive a pretuned car","此选项可从您驾驶预先调整的汽车的游戏任务中解锁隐藏预设"},
            {"Remove Any Car","删除任何汽车"},
            {"This option allows you to remove any car in your garage.","此选项允许您可以移除车库中的任何汽车。"},
            {"Car Pass Date Bypass","汽车通行证日期绕过"},
            {"This option bypasses date requirements on car pass cars.","此选项绕过汽车通行证汽车的日期要求。"},
            {"Clear “new” tag on cars","清除汽车上的“新”标签"},
            {"Run","运行"},
            {"This option will remove every the “new” tag and the annoying loading into a new car animation on every car in ur garage","此选项将删除车库中每辆车上的所有“新”标签以及烦人的加载到新车动画中的操作"},
            {"Clear Garage","清除车库"},
            {"All","全部"},
            {"Dupes","骗子"},
            {"Non favorites","非喜爱"},
            {"Rare cars","稀有汽车"},
            {"Auto-show cars","车展汽车"},
            {"Only untuned","仅未调整"},
            {"Non livery","无涂装"},
            {"This option will delete every car in ur garage based on the selection in the combo box","此选项将删除根据组合框中的选择，您车库中的每辆车"},
            {"Fix Thumbnails","修复缩略图"},
            {"This option will revert every thumbnail of every car in ur garage to its default","此选项会将您车库中每辆车的每个缩略图恢复为其默认值"},
            {"Other Modifications","其他修改"},
            {"Free Perf Upgrades","免费性能升级"},
            {"This option will make every performance upgrade free. Its not revert able, unless you restart the game","此选项将使每个性能免费升级。它无法恢复，除非您重新启动游戏"},
            {"Free Visual Upgrades","免费视觉升级"},
            {"Quick Add All Cars","快速添加所有汽车"},
            {"This option will add every car from the autoshow into ur garage, hidden, rare - it doesnt matter.","此选项会将车展中的每辆车添加到您的车库中，隐藏的，稀有的 - 没关系。"},
            {"Quick Add Rare Cars","快速添加稀有汽车"},
            {"This option will add rare car from the autoshow into ur garage.","此选项会将车展中的稀有汽车添加到您的车库中。"},
            #endregion

            #region[Tuning.xaml]
            {"Tires","轮胎"},
            {"PSI","PSI"},
            {"Bar","Bar"},
            {"Front Left Tire Pressure","左前轮胎胎压"},
            {"Front Right Tire Pressure","右前轮胎胎压"},
            {"Rear Left Tire Pressure","左后轮胎胎压"},
            {"Rear Right Tire Pressure","右后轮胎胎压"},
            {"Gearing","齿轮设备"},
            {"Final Drive Ratio","最终传动比"},
            {"First Gear","第一档"},
            {"Third Gear","第三档"},
            {"Fifth Gear","第五档"},
            {"Seventh Gear","第七档"},
            {"Ninth Gear","第九档"},
            {"Reverse Gear","倒档"},
            {"Second Gear","第二档"},
            {"Fourth Gear","第四档"},
            {"Sixth Gear","第六档"},
            {"Eighth Gear","第八档"},
            {"Tenth Gear","第十档"},
            {"Alignment","轮胎定位"},
            {"Negative Camber","后侧外倾角"},
            {"Positive Camber","前侧外倾角"},
            {"Negative Toe","后侧束角"},
            {"Positive Toe","后侧束角"},
            {"Springs","弹簧"},
            {"Front Restriction","前限制"},
            {"For stance/fix bouncing","用于站立/固定弹跳"},
            {"Centimeters","厘米"},
            {"Inches","英寸"},
            {"Rear Restriction","后限制"},
            {"Front Springs Min","最小前弹簧"},
            {"Front Springs Max","最大前弹簧"},
            {"Rear Springs Min","最小后弹簧"},
            {"Rear Springs Max","最大后弹簧"},
            {"Front Ride Height Min","前车身最小高度"},
            {"Front Ride Height Max","前车身最大高度"},
            {"Rear Ride Height Min","后车身最小高度"},
            {"Rear Ride Height Max","后车身最大高度"},
            {"Damping/Antiroll Bars","阻尼/防倾杆"},
            {"Front Antiroll Bars Min","前侧最小防倾杆"},
            {"Front Antiroll Bars Max","前侧最大防倾杆"},
            {"Rear Antiroll Bars Min","后侧最小防倾杆"},
            {"Rear Antiroll Bars Max","后侧最大防倾杆"},
            {"Front Rebound Stiffness Min","前最小回弹硬度"},
            {"Front Rebound Stiffness Max","前最大回弹硬度"},
            {"Rear Rebound Stiffness Min","后最小回弹硬度"},
            {"Rear Rebound Stiffness Max","后最大回弹硬度"},
            {"Front Bump Stiffness Min","前最小压缩硬度"},
            {"Front Bump Stiffness Max","前最大压缩硬度"},
            {"Rear Bump Stiffness Min","后最小压缩硬度"},
            {"Rear Bump Stiffness Max","后最大压缩硬度"},
            {"Aero","空气动力"},
            {"Front Aero Min","前侧最小下压力"},
            {"Front Aero Max","前侧最大下压力"},
            {"Rear Aero Min","后侧最小下压力"},
            {"Rear Aero Max","后侧最大下压力"},
            {"Steering","转向"},
            {"Steering Angle Max","最大转向角"},
            {"Steering Angle Max 2","最大转向角 2"},
            {"Velocity Straight","直线速度"},
            {"Velocity Turning","转向速度"},
            {"Velocity Countersteer","反向转向速度"},
            {"Velocity Dynamic Peak","速度动态峰值"},
            {"Time to Max Steering","最大转向时间"},
            {"Others","其他"},
            {"Wheelbase","轴距"},
            {"Front Width","前宽度"},
            {"Front Spacer","前垫片"},
            {"Rear Width","后宽度"},
            {"Rear Spacer","后垫片"},
            {"Rim Size Front","前轮毂尺寸"},
            {"Rim Radius Front","前轮毂半径"},
            {"Rim Size Rear","后轮毂尺寸"},
            {"Rim Radius Rear","后轮毂半径"},
            #endregion

            #region[Self-Vehicle.xaml]
            {"Mode","Mode"},
            {"Dynamic","Dynamic"},
            {"Direct","Direct"},
            {"Value","Value"},
            {"Limit","Limit"},
            {"Velocity","Velocity"},
            {"Wheel Speed","Wheel Speed"},
            {"Strength","Strength"},
            {"Interval","Interval"},
            {"Static","Static"},
            {"Linear","Linear"},
            {"Power","Power"},
            {"Random","Random"},
            {"Jitter","Jitter"},
            {"Pulse","Pulse"},
            {"Sway","Sway"},
            {"Surge","Surge"},
            {"Mixed","Mixed"},
            {"Accel","Accel"},
            {"Pull","Pull"},
            {"Gravity","Gravity"},
            {"Acceleration","Acceleration"},
            {"Turn Assist","Turn Assist"},
            {"Ratio","Ratio"},
            {"Jump Hack","Jump Hack"},
            {"Fly Hack","Fly Hack"},
            {"Movement Speed","Movement Speed"},
            {"Rotation Speed","Rotation Speed"},
            {"Super Car","Super Car"},
            {"Stop Water Drag","Stop Water Drag"},
            {"Super Brake","Super Brake"},
            {"Stop All Wheels","Stop All Wheels"},
            {"Wall Noclip","Wall Noclip"},
            {"Car Noclip","Car Noclip"},
            {"Xp On Unpause","Xp On Unpause"},
            {"This feature will add XP based on how many you set in the numeric box.","This feature will add XP based on how many you set in the numeric box."},
            {"Credits","Credits"},
            {"This feature will set your credits based on how the value you set in the numeric box. You must either spend/get some money, or do a wheelspin for it to take effect.","This feature will set your credits based on how the value you set in the numeric box. You must either spend/get some money, or do a wheelspin for it to take effect."},
            {"Normal Spins","Normal Spins"},
            {"This feature will set your normal wheelspins value based on how how many you set in the numeric box. You must do a wheelspin for it to take effect.","This feature will set your normal wheelspins value based on how how many you set in the numeric box. You must do a wheelspin for it to take effect."},
            {"Super Spins","Super Spins"},
            {"This feature will set your super wheelspins value based on how how many you set in the numeric box. You must do a wheelspin for it to take effect.","This feature will set your super wheelspins value based on how how many you set in the numeric box. You must do a wheelspin for it to take effect."},
            {"Discover All Roads","Discover All Roads"},
            {"Skill Points","Skill Points"},
            {"This feature will set your skill points value based on how how many you set in the numeric box. You must buy a perk in the skilltree for it to take effect.","This feature will set your skill points value based on how how many you set in the numeric box. You must buy a perk in the skilltree for it to take effect."},
            {"Series Points","Series Points"},
            {"Seasonal Points","Seasonal Points"},
            {"Samples","Samples"},
            {"Shutter Speed","Shutter Speed"},
            {"Aperture Scale","Aperture Scale"},
            {"Car In Focus","Car In Focus"},
            {"Time Slice","Time Slice"},
            {"No Clip","No Clip"},
            {"Turn Speed","Turn Speed"},
            {"Also modifies zoom speed","Also modifies zoom speed"},
            {"Samples Multiplier","Samples Multiplier"},
            {"Unlimited altitude","Unlimited altitude"},
            {"Increased zoom","Increased zoom"},
            {"Stat:","Stat:"},
            {"Stat value:","Stat value:"},
            {"Send","Send"},
            {"Teleport Locations:","Teleport Locations:"},
            {"Auto TP To Waypoint","Auto TP To Waypoint"},
            {"Freeze Drivatars","Freeze Drivatars"},
            {"Freezes the drivatars in your game","Freezes the drivatars in your game"},
            {"Aids Mode","Aids Mode"},
            {"This feature will make the sun's RGB rainbow.","This feature will make the sun's RGB rainbow."},
            {"Manual Time Management","Manual Time Management"},
            {"Numpad 4 OR left shift + comma to go backward","Numpad 4 OR left shift + comma to go backward"},
            {"Numpad 6 OR left shift + comma to go forward","Numpad 6 OR left shift + comma to go forward"},
            {"Holding CTRL makes it go faster","Holding CTRL makes it go faster"},
            {"Sun Red","Sun Red"},
            {"Sun Green","Sun Green"},
            {"Sun Blue","Sun Blue"},
            {"Reset","Reset"},
            {"Glowing Paint","Glowing Paint"},
            {"Glowing paint toggle, you must change the color in the in-game paint car section for it to take effect","Glowing paint toggle, you must change the color in the in-game paint car section for it to take effect"},
            {"Red","Red"},
            {"Green","Green"},
            {"Blue","Blue"},
            {"Headlight Color","Headlight Color"},
            {"This feature changes the color your headlights project onto the road","This feature changes the color your headlights project onto the road"},
            {"Dirt","Dirt"},
            {"Mud","Mud"},
            {"Dirt Level","Dirt Level"},
            {"This feature allows you to change the cleanliness of your car.","This feature allows you to change the cleanliness of your car."},
            {"Event Builder Unlimited Build Budget","Event Builder Unlimited Build Budget"},
            {"This feature removes the event builder restriction by setting the current percentage to 0.","This feature removes the event builder restriction by setting the current percentage to 0."},
            {"Unbreakable Skill Score/Skill Combo","Unbreakable Skill Score/Skill Combo"},
            {"This option makes it so score never breaks when crashed","This option makes it so score never breaks when crashed"},
            {"Spin Prize Scale","Spin Prize Scale"},
            {"This feature increases money reward prizes in the wheelspin","This feature increases money reward prizes in the wheelspin"},
            {"Wheelspin Sell Factor","Wheelspin Sell Factor"},
            {"This feature increases sell prices when you get a duplicate car in the wheelspin","This feature increases sell prices when you get a duplicate car in the wheelspin"},
            {"Skill Score Multiplier","Skill Score Multiplier"},
            {"Min Multi","Min Multi"},
            {"Max Multi","Max Multi"},
            {"Drift Score Multiplier","Drift Score Multiplier"},
            {"Skill Tree Wide-Editing","Skill Tree Wide-Editing"},
            {"This feature adjusts the modifiers for all perks within a skill tree to a target number in the numeric box","This feature adjusts the modifiers for all perks within a skill tree to a target number in the numeric box"},
            {"Skill Tree Perks Cost","Skill Tree Perks Cost"},
            {"Mission Time Scale","Mission Time Scale"},
            {"This feature multiplies the time subtract value by the value set in the numeric box. Set to 0 for freeze.","This feature multiplies the time subtract value by the value set in the numeric box. Set to 0 for freeze."},
            {"Fov Lock","Fov Lock"},
            {"Chase Min Limiter","Chase Min Limiter"},
            {"Chase Max Limiter","Chase Max Limiter"},
            {"Far Chase Min Limiter","Far Chase Min Limiter"},
            {"Far Chase Max Limiter","Far Chase Max Limiter"},
            {"Driver Min Limiter","Driver Min Limiter"},
            {"Driver Max Limiter","Driver Max Limiter"},
            {"Hood Min Limiter","Hood Min Limiter"},
            {"Hood Max Limiter","Hood Max Limiter"},
            {"Bumper Min Limiter","Bumper Min Limiter"},
            {"Bumper Max Limiter","Bumper Max Limiter"},
            {"Backfire Time","Backfire Time"},
            {"Toggle to enable or disable custom backfire time settings","Toggle to enable or disable custom backfire time settings"},
            {"Force Anti-Lag Style Backfire","Force Anti-Lag Style Backfire"},
            {"Force Normal Style Backfire","Force Normal Style Backfire"},
            {"Handling","Handling"},
            {"Unlocks","Unlocks"},
            {"Photo-mode","Photo-mode"},
            {"Stats","Stats"},
            {"Teleports","Teleports"},
            {"Environment","Environment"},
            {"Customization","Customization"},
            {"Miscellaneous","Miscellaneous"},
            {"Fov","Fov"},
            {"Backfire","Backfire"},
            #endregion

            #region[Keybindings.xaml]
            {"Overlay Keybindings","覆盖键绑定"},
            {"Handling Keybindings","处理按键绑定"},
            {"Keyboard Up Keybind","键盘上键绑定"},
            {"Controller Up Keybind","控制器上键绑定"},
            {"Keyboard Down Keybind","键盘下键绑定"},
            {"Controller Down Keybind","控制器下键绑定"},
            {"Keyboard Left Keybind","键盘左键绑定"},
            {"Controller Left Keybind","控制器左键绑定"},
            {"Keyboard Right Keybind","键盘右键绑定"},
            {"Controller Right Keybind","控制器右键绑定"},
            {"Keyboard Leave Keybind","键盘离开键绑定"},
            {"Controller Leave Keybind","控制器离开键绑定"},
            {"Keyboard Confirm Keybind","键盘确认键绑定"},
            {"Controller Confirm Keybind","控制器确认键绑定"},
            {"Keyboard Visibility Keybind","键盘可见性键绑定"},
            {"Controller Visibility Keybind","控制器可见性键绑定"},
            {"Keyboard Rapid Value Adjust","键盘快速数值调整"},
            {"Controller Rapid Value Adjust","控制器快速数值调整"},
            {"Keyboard Jump Hack Keybind","键盘跳跃修改键绑定"},
            {"Controller Jump Hack Keybind","控制器跳跃修改键绑定"},
            {"Keyboard Brake Hack Keybind","键盘刹车修改键绑定"},
            {"Controller Brake Hack Keybind","控制器刹车修改键绑定"},
            {"Keyboard Velocity Keybind","键盘速度键绑定"},
            {"Controller Velocity Keybind","控制器速度键绑定"},
            {"Keyboard Wheelspeed Keybind","键盘轮速键绑定"},
            {"Controller Wheelspeed Keybind","控制器轮速键绑定"},
            #endregion
        };
        public static void LoadTranslateDic()
        {
            string file = Path.Combine(Environment.CurrentDirectory, ChineseTranslateFile);
            if (File.Exists(file))
            {
                ChineseTranslate.Clear();
                foreach (string line in File.ReadAllLines(file))
                {
                    if(line.Trim().StartsWith("#") || line.Trim().StartsWith("[") || line.Trim() == "")
                    {
                        continue;
                    }
                    string[] tmp = line.Split("=");
                    if(tmp.Length > 1)
                    {
                        ChineseTranslate.Add(tmp[0].Trim(), tmp[1].Trim());
                    }
                }
            }
        }
        public static void Translate()
        {
            foreach(var ele in MainWindow.Mw.GetChildren().Cast<FrameworkElement>())
            {
                var x = ele.GetType().Name;
                if (ele is ComboBox box)
                {
                    for (int i = 0; i < box.Items.Count; i++)
                    {
                        var boxItem = box.Items[i] as ComboBoxItem;
                        if (ChineseTranslate.ContainsKey((string)boxItem.Content))
                        {
                            boxItem.Content = ChineseTranslate[(string)boxItem.Content];
                        }
                    }
                }
                else
                {
                    var tmp = ele.GetType().GetProperty("Content");
                    if (tmp != null)
                    {
                        if (tmp.GetValue(ele) is string key)
                        {
                            if (key == "All")
                            {

                            }
                            if (ChineseTranslate.ContainsKey(key))
                            {
                                tmp.SetValue(ele, ChineseTranslate[key]);
                            }
                        }
                    }

                    var tmp2 = ele.GetType().GetProperty("ToolTip");
                    if (tmp2 != null)
                    {
                        if (tmp2.GetValue(ele) is string key)
                        {
                            if (ChineseTranslate.ContainsKey(key))
                            {
                                tmp2.SetValue(ele, ChineseTranslate[key]);
                            }
                        }
                    }
                }
            }
        }
        public static void TranslateOutput()
        {
            foreach (var ele in MainWindow.Mw.GetChildren().Cast<FrameworkElement>())
            {
                if (ele is ComboBox box)
                {
                    for (int i = 0; i < box.Items.Count; i++)
                    {
                        var boxItem = box.Items[i] as ComboBoxItem;
                        string key = (string)boxItem.Content;
                        if (!StringsLower.Contains(key.ToLower()) && key != "")
                        {
                            Strings.Add(key);
                            StringsLower.Add(key.ToLower());
                        }
                    }
                }
                else
                {
                    var tmp = ele.GetType().GetProperty("Content");
                    if (tmp != null)
                    {
                        if (tmp.GetValue(ele) is string key)
                        {
                            if (!StringsLower.Contains(key.ToLower()) && key != "")
                            {
                                Strings.Add(key);
                                StringsLower.Add(key.ToLower());
                            }
                        }
                    }

                    var tmp2 = ele.GetType().GetProperty("ToolTip");
                    if (tmp2 != null)
                    {
                        if (tmp2.GetValue(ele) is string key)
                        {
                            if (!StringsLower.Contains(key.ToLower()) && key != "")
                            {
                                Strings.Add(key);
                                StringsLower.Add(key.ToLower());
                            }
                        }
                    }
                }
            }
        }
    }
}
