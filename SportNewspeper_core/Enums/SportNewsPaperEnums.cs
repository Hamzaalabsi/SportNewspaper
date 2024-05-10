using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SportNewspeper_core.Enums
{
    public static class SportNewsPaperEnums
    {

        public enum Continent
        {
            Africa=1,
            Asia,
            Europe,
            NorthAmerica,
            Australia,
            SouthAmerica
        }
        public enum Countries
        {
            Continental= 101,
            Spain,
            Germany,
            England,
            France,
            Italy,
            SaudiArabia,
            Japan,
            Jordan,
            SouthKorea,
            Iran,
            Australia,
            America,
            Canda,
            Brazil,
            Argentina,
            Uruguay,
            Egypt,
            Algeria,
            Ghana,
            Morocco,
        }

        public enum Sports
        {
            Football =201,
            Basketball,
            Tennis,
            Cricket,
            AmericanFootball,
        }
        public enum SubscriptionType
        {
            Annual=301,
            Monthly,
            Daily
        }
    }
    
}

