﻿namespace Forza_Mods_AIO.Overlay.Options;

public class MenuOption
{
    public string Name { get; protected init; } = string.Empty;
    public string? Description { get; protected init; }
    public bool IsEnabled { get; set; }
}