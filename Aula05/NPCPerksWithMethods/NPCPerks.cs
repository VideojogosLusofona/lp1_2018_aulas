using System;

namespace Aula05
{
    [Flags]
    enum NPCPerks
    {
        Stealth = 1 << 0,
        Combat = 1 << 1,
        Lockpick = 1 << 2,
        Luck = 1 << 3
    }
}