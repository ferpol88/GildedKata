using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Model
{
    internal static class ItemExtension
    {
        public const int NORMAL_DEGRADE_SPEED = 1;
        public const int OFFTIME_DEGRADE_FACTOR = 2;

        public static int GetDegradeSpeedBySellIn(this Item item) {
            return item.SellIn > 0 ? NORMAL_DEGRADE_SPEED : NORMAL_DEGRADE_SPEED * OFFTIME_DEGRADE_FACTOR;
        }

    }
}
