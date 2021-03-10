using System;
namespace NPCPerks
{
    [Flags]
    public enum Perks
    {
        Nothing     = 0,
        Stealth     = 0b0001,
        Combat      = 0b0010,
        Lockpick    = 0b0100,
        Luck        = 0b1000
    }
}
