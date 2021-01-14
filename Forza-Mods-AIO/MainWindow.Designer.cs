﻿
namespace Forza_Mods_AIO
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.BTN_TabInfo = new System.Windows.Forms.Button();
            this.BTN_TabAddCars = new System.Windows.Forms.Button();
            this.BTN_TabLiveTuning = new System.Windows.Forms.Button();
            this.BTN_TabSaveswap = new System.Windows.Forms.Button();
            this.BTN_TabStatsEditor = new System.Windows.Forms.Button();
            this.BTN_TabSpeedhack = new System.Windows.Forms.Button();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.Panel_Info = new System.Windows.Forms.Panel();
            this.Panel_StatsEditor = new System.Windows.Forms.Panel();
            this.Panel_Speedhack = new System.Windows.Forms.Panel();
            this.Panel_AddCars = new System.Windows.Forms.Panel();
            this.Panel_Saveswap = new System.Windows.Forms.Panel();
            this.Panel_LiveTuning = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_Attached = new System.Windows.Forms.Label();
            this.Tab_1Info = new System.Windows.Forms.Panel();
            this.Tab_2AddCars = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Tab_4Saveswap = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Tab_5LiveTuning = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Tab_3StatsEditor = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Tab_6Speedhack = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TopPanel.SuspendLayout();
            this.Tab_1Info.SuspendLayout();
            this.Tab_2AddCars.SuspendLayout();
            this.Tab_4Saveswap.SuspendLayout();
            this.Tab_5LiveTuning.SuspendLayout();
            this.Tab_3StatsEditor.SuspendLayout();
            this.Tab_6Speedhack.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Black;
            this.TopPanel.Controls.Add(this.LBL_Title);
            this.TopPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TopPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1000, 35);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // LBL_Title
            // 
            this.LBL_Title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Title.Font = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_Title.ForeColor = System.Drawing.Color.White;
            this.LBL_Title.Location = new System.Drawing.Point(389, 0);
            this.LBL_Title.Margin = new System.Windows.Forms.Padding(0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(223, 30);
            this.LBL_Title.TabIndex = 8;
            this.LBL_Title.Text = "Forza Mods AIO Tool";
            this.LBL_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.LBL_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.LBL_Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // BTN_TabInfo
            // 
            this.BTN_TabInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTN_TabInfo.FlatAppearance.BorderSize = 0;
            this.BTN_TabInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.BTN_TabInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.BTN_TabInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_TabInfo.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_TabInfo.ForeColor = System.Drawing.Color.White;
            this.BTN_TabInfo.Location = new System.Drawing.Point(0, 35);
            this.BTN_TabInfo.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_TabInfo.Name = "BTN_TabInfo";
            this.BTN_TabInfo.Size = new System.Drawing.Size(172, 30);
            this.BTN_TabInfo.TabIndex = 1;
            this.BTN_TabInfo.Text = "Tool Information";
            this.BTN_TabInfo.UseVisualStyleBackColor = false;
            this.BTN_TabInfo.Click += new System.EventHandler(this.BTN_TabInfo_Click);
            // 
            // BTN_TabAddCars
            // 
            this.BTN_TabAddCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BTN_TabAddCars.FlatAppearance.BorderSize = 0;
            this.BTN_TabAddCars.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.BTN_TabAddCars.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.BTN_TabAddCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_TabAddCars.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_TabAddCars.ForeColor = System.Drawing.Color.White;
            this.BTN_TabAddCars.Location = new System.Drawing.Point(172, 35);
            this.BTN_TabAddCars.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_TabAddCars.Name = "BTN_TabAddCars";
            this.BTN_TabAddCars.Size = new System.Drawing.Size(166, 30);
            this.BTN_TabAddCars.TabIndex = 2;
            this.BTN_TabAddCars.Text = "Add Cars";
            this.BTN_TabAddCars.UseVisualStyleBackColor = false;
            this.BTN_TabAddCars.Click += new System.EventHandler(this.BTN_TabAddCars_Click);
            // 
            // BTN_TabLiveTuning
            // 
            this.BTN_TabLiveTuning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BTN_TabLiveTuning.FlatAppearance.BorderSize = 0;
            this.BTN_TabLiveTuning.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.BTN_TabLiveTuning.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.BTN_TabLiveTuning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_TabLiveTuning.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_TabLiveTuning.ForeColor = System.Drawing.Color.White;
            this.BTN_TabLiveTuning.Location = new System.Drawing.Point(670, 35);
            this.BTN_TabLiveTuning.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_TabLiveTuning.Name = "BTN_TabLiveTuning";
            this.BTN_TabLiveTuning.Size = new System.Drawing.Size(166, 30);
            this.BTN_TabLiveTuning.TabIndex = 3;
            this.BTN_TabLiveTuning.Text = "Live Tuning";
            this.BTN_TabLiveTuning.UseVisualStyleBackColor = false;
            this.BTN_TabLiveTuning.Click += new System.EventHandler(this.BTN_TabLiveTuning_Click);
            // 
            // BTN_TabSaveswap
            // 
            this.BTN_TabSaveswap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BTN_TabSaveswap.FlatAppearance.BorderSize = 0;
            this.BTN_TabSaveswap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.BTN_TabSaveswap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.BTN_TabSaveswap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_TabSaveswap.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_TabSaveswap.ForeColor = System.Drawing.Color.White;
            this.BTN_TabSaveswap.Location = new System.Drawing.Point(504, 35);
            this.BTN_TabSaveswap.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_TabSaveswap.Name = "BTN_TabSaveswap";
            this.BTN_TabSaveswap.Size = new System.Drawing.Size(166, 30);
            this.BTN_TabSaveswap.TabIndex = 4;
            this.BTN_TabSaveswap.Text = "Saveswapper";
            this.BTN_TabSaveswap.UseVisualStyleBackColor = false;
            this.BTN_TabSaveswap.Click += new System.EventHandler(this.BTN_TabSaveswap_Click);
            // 
            // BTN_TabStatsEditor
            // 
            this.BTN_TabStatsEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BTN_TabStatsEditor.FlatAppearance.BorderSize = 0;
            this.BTN_TabStatsEditor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.BTN_TabStatsEditor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.BTN_TabStatsEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_TabStatsEditor.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_TabStatsEditor.ForeColor = System.Drawing.Color.White;
            this.BTN_TabStatsEditor.Location = new System.Drawing.Point(338, 35);
            this.BTN_TabStatsEditor.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_TabStatsEditor.Name = "BTN_TabStatsEditor";
            this.BTN_TabStatsEditor.Size = new System.Drawing.Size(166, 30);
            this.BTN_TabStatsEditor.TabIndex = 5;
            this.BTN_TabStatsEditor.Text = "Stats Editor";
            this.BTN_TabStatsEditor.UseVisualStyleBackColor = false;
            this.BTN_TabStatsEditor.Click += new System.EventHandler(this.BTN_TabStatsEditor_Click);
            // 
            // BTN_TabSpeedhack
            // 
            this.BTN_TabSpeedhack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BTN_TabSpeedhack.FlatAppearance.BorderSize = 0;
            this.BTN_TabSpeedhack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.BTN_TabSpeedhack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.BTN_TabSpeedhack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_TabSpeedhack.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_TabSpeedhack.ForeColor = System.Drawing.Color.White;
            this.BTN_TabSpeedhack.Location = new System.Drawing.Point(836, 35);
            this.BTN_TabSpeedhack.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_TabSpeedhack.Name = "BTN_TabSpeedhack";
            this.BTN_TabSpeedhack.Size = new System.Drawing.Size(164, 30);
            this.BTN_TabSpeedhack.TabIndex = 6;
            this.BTN_TabSpeedhack.Text = "Speedhack";
            this.BTN_TabSpeedhack.UseVisualStyleBackColor = false;
            this.BTN_TabSpeedhack.Click += new System.EventHandler(this.BTN_TabSpeedhack_Click);
            // 
            // BTN_Close
            // 
            this.BTN_Close.BackColor = System.Drawing.Color.Black;
            this.BTN_Close.FlatAppearance.BorderSize = 0;
            this.BTN_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BTN_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Close.Font = new System.Drawing.Font("Open Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Close.ForeColor = System.Drawing.Color.Red;
            this.BTN_Close.Location = new System.Drawing.Point(965, 0);
            this.BTN_Close.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(35, 35);
            this.BTN_Close.TabIndex = 7;
            this.BTN_Close.Text = "X";
            this.BTN_Close.UseVisualStyleBackColor = false;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // Panel_Info
            // 
            this.Panel_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(11)))), ((int)(((byte)(166)))));
            this.Panel_Info.Location = new System.Drawing.Point(0, 65);
            this.Panel_Info.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Info.Name = "Panel_Info";
            this.Panel_Info.Size = new System.Drawing.Size(172, 5);
            this.Panel_Info.TabIndex = 9;
            // 
            // Panel_StatsEditor
            // 
            this.Panel_StatsEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Panel_StatsEditor.Location = new System.Drawing.Point(338, 65);
            this.Panel_StatsEditor.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_StatsEditor.Name = "Panel_StatsEditor";
            this.Panel_StatsEditor.Size = new System.Drawing.Size(166, 5);
            this.Panel_StatsEditor.TabIndex = 10;
            // 
            // Panel_Speedhack
            // 
            this.Panel_Speedhack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Panel_Speedhack.Location = new System.Drawing.Point(834, 65);
            this.Panel_Speedhack.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Speedhack.Name = "Panel_Speedhack";
            this.Panel_Speedhack.Size = new System.Drawing.Size(166, 5);
            this.Panel_Speedhack.TabIndex = 11;
            // 
            // Panel_AddCars
            // 
            this.Panel_AddCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Panel_AddCars.Location = new System.Drawing.Point(172, 65);
            this.Panel_AddCars.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_AddCars.Name = "Panel_AddCars";
            this.Panel_AddCars.Size = new System.Drawing.Size(166, 5);
            this.Panel_AddCars.TabIndex = 11;
            // 
            // Panel_Saveswap
            // 
            this.Panel_Saveswap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Panel_Saveswap.Location = new System.Drawing.Point(504, 65);
            this.Panel_Saveswap.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Saveswap.Name = "Panel_Saveswap";
            this.Panel_Saveswap.Size = new System.Drawing.Size(166, 5);
            this.Panel_Saveswap.TabIndex = 11;
            // 
            // Panel_LiveTuning
            // 
            this.Panel_LiveTuning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Panel_LiveTuning.Location = new System.Drawing.Point(670, 65);
            this.Panel_LiveTuning.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_LiveTuning.Name = "Panel_LiveTuning";
            this.Panel_LiveTuning.Size = new System.Drawing.Size(166, 5);
            this.Panel_LiveTuning.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(359, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Information Tab";
            // 
            // LBL_Attached
            // 
            this.LBL_Attached.AutoSize = true;
            this.LBL_Attached.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_Attached.ForeColor = System.Drawing.Color.Red;
            this.LBL_Attached.Location = new System.Drawing.Point(12, 2);
            this.LBL_Attached.Name = "LBL_Attached";
            this.LBL_Attached.Size = new System.Drawing.Size(120, 17);
            this.LBL_Attached.TabIndex = 13;
            this.LBL_Attached.Text = "Not Attached to FH4";
            // 
            // Tab_1Info
            // 
            this.Tab_1Info.AutoScroll = true;
            this.Tab_1Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tab_1Info.Controls.Add(this.richTextBox1);
            this.Tab_1Info.Controls.Add(this.LBL_Attached);
            this.Tab_1Info.Controls.Add(this.label1);
            this.Tab_1Info.Location = new System.Drawing.Point(9, 80);
            this.Tab_1Info.Margin = new System.Windows.Forms.Padding(0);
            this.Tab_1Info.Name = "Tab_1Info";
            this.Tab_1Info.Size = new System.Drawing.Size(1000, 445);
            this.Tab_1Info.TabIndex = 14;
            // 
            // Tab_2AddCars
            // 
            this.Tab_2AddCars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tab_2AddCars.Controls.Add(this.label6);
            this.Tab_2AddCars.Location = new System.Drawing.Point(1036, 80);
            this.Tab_2AddCars.Margin = new System.Windows.Forms.Padding(0);
            this.Tab_2AddCars.Name = "Tab_2AddCars";
            this.Tab_2AddCars.Size = new System.Drawing.Size(1000, 445);
            this.Tab_2AddCars.TabIndex = 14;
            this.Tab_2AddCars.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Add Cars Tab";
            // 
            // Tab_4Saveswap
            // 
            this.Tab_4Saveswap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tab_4Saveswap.Controls.Add(this.label4);
            this.Tab_4Saveswap.Location = new System.Drawing.Point(1036, 535);
            this.Tab_4Saveswap.Margin = new System.Windows.Forms.Padding(0);
            this.Tab_4Saveswap.Name = "Tab_4Saveswap";
            this.Tab_4Saveswap.Size = new System.Drawing.Size(1000, 445);
            this.Tab_4Saveswap.TabIndex = 15;
            this.Tab_4Saveswap.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Saveswapping Tab";
            // 
            // Tab_5LiveTuning
            // 
            this.Tab_5LiveTuning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tab_5LiveTuning.Controls.Add(this.label3);
            this.Tab_5LiveTuning.Location = new System.Drawing.Point(9, 989);
            this.Tab_5LiveTuning.Margin = new System.Windows.Forms.Padding(0);
            this.Tab_5LiveTuning.Name = "Tab_5LiveTuning";
            this.Tab_5LiveTuning.Size = new System.Drawing.Size(1000, 445);
            this.Tab_5LiveTuning.TabIndex = 15;
            this.Tab_5LiveTuning.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Live Tuning Tab";
            // 
            // Tab_3StatsEditor
            // 
            this.Tab_3StatsEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tab_3StatsEditor.Controls.Add(this.label5);
            this.Tab_3StatsEditor.Location = new System.Drawing.Point(9, 535);
            this.Tab_3StatsEditor.Margin = new System.Windows.Forms.Padding(0);
            this.Tab_3StatsEditor.Name = "Tab_3StatsEditor";
            this.Tab_3StatsEditor.Size = new System.Drawing.Size(1000, 445);
            this.Tab_3StatsEditor.TabIndex = 15;
            this.Tab_3StatsEditor.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Stats Editing Tab";
            // 
            // Tab_6Speedhack
            // 
            this.Tab_6Speedhack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tab_6Speedhack.Controls.Add(this.label2);
            this.Tab_6Speedhack.Location = new System.Drawing.Point(1036, 989);
            this.Tab_6Speedhack.Margin = new System.Windows.Forms.Padding(0);
            this.Tab_6Speedhack.Name = "Tab_6Speedhack";
            this.Tab_6Speedhack.Size = new System.Drawing.Size(1000, 445);
            this.Tab_6Speedhack.TabIndex = 15;
            this.Tab_6Speedhack.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(421, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Speedhack Tab";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Open Sans", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(455, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(512, 337);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(2065, 1460);
            this.Controls.Add(this.Tab_3StatsEditor);
            this.Controls.Add(this.Tab_4Saveswap);
            this.Controls.Add(this.Tab_6Speedhack);
            this.Controls.Add(this.Tab_1Info);
            this.Controls.Add(this.Panel_Saveswap);
            this.Controls.Add(this.Panel_AddCars);
            this.Controls.Add(this.Panel_LiveTuning);
            this.Controls.Add(this.Panel_Speedhack);
            this.Controls.Add(this.Panel_StatsEditor);
            this.Controls.Add(this.Panel_Info);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.BTN_TabSpeedhack);
            this.Controls.Add(this.BTN_TabStatsEditor);
            this.Controls.Add(this.BTN_TabSaveswap);
            this.Controls.Add(this.BTN_TabLiveTuning);
            this.Controls.Add(this.BTN_TabAddCars);
            this.Controls.Add(this.BTN_TabInfo);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.Tab_5LiveTuning);
            this.Controls.Add(this.Tab_2AddCars);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.Tab_1Info.ResumeLayout(false);
            this.Tab_1Info.PerformLayout();
            this.Tab_2AddCars.ResumeLayout(false);
            this.Tab_2AddCars.PerformLayout();
            this.Tab_4Saveswap.ResumeLayout(false);
            this.Tab_4Saveswap.PerformLayout();
            this.Tab_5LiveTuning.ResumeLayout(false);
            this.Tab_5LiveTuning.PerformLayout();
            this.Tab_3StatsEditor.ResumeLayout(false);
            this.Tab_3StatsEditor.PerformLayout();
            this.Tab_6Speedhack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button BTN_TabInfo;
        private System.Windows.Forms.Button BTN_TabAddCars;
        private System.Windows.Forms.Button BTN_TabLiveTuning;
        private System.Windows.Forms.Button BTN_TabSaveswap;
        private System.Windows.Forms.Button BTN_TabStatsEditor;
        private System.Windows.Forms.Button BTN_TabSpeedhack;
        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Panel Panel_Info;
        private System.Windows.Forms.Panel Panel_StatsEditor;
        private System.Windows.Forms.Panel Panel_Speedhack;
        private System.Windows.Forms.Panel Panel_AddCars;
        private System.Windows.Forms.Panel Panel_Saveswap;
        private System.Windows.Forms.Panel Panel_LiveTuning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_Attached;
        private System.Windows.Forms.Panel Tab_1Info;
        private System.Windows.Forms.Panel Tab_2AddCars;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel Tab_4Saveswap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Tab_5LiveTuning;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Tab_3StatsEditor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel Tab_6Speedhack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

