//
// Author: Alex Lee <lu.lee05@gmail.com>
//

using System.Collections.Generic;

namespace SmartQuant
{
    public class ProviderId
    {
        public const byte DataSimulator = 1;
        public const byte ExecutionSimulator = 2;
        public const byte QuickFIX42 = 3;
        public const byte IB = 4;
        public const byte ESignal = 5;
        public const byte MBTrading = 6;
        public const byte Opentick = 7;
        public const byte QuoteTracker = 8;
        public const byte TAL = 9;
        public const byte TTFIX = 10;
        public const byte TTAPI = 11;
        public const byte Genesis = 12;
        public const byte MyTrack = 13;
        public const byte Photon = 14;
        public const byte Bloomberg = 15;
        public const byte Reuters = 16;
        public const byte Yahoo = 17;
        public const byte DC = 18;
        public const byte CSI = 19;
        public const byte QuantHouse = 20;
        public const byte PATSAPI = 21;
        public const byte OpenECry = 22;
        public const byte OpenTick = 23;
        public const byte FIX = 24;
        public const byte Google = 25;
        public const byte Hotspot = 26;
        public const byte AlfaDirect = 27;
        public const byte Currenex = 28;
        public const byte SmartCOM = 29;
        public const byte GenericEOD = 30;
        public const byte QUIKFIX = 31;
        public const byte OSLFIX = 32;
        public const byte Nordnet = 33;
        public const byte Integral = 35;
        public const byte QuantBase = 36;
        public const byte QuantRouter = 38;
        public const byte MatchingEngine = 100;

        private static Dictionary<string, byte> providerMap;

        static ProviderId()
        {
            providerMap = new Dictionary<string, byte>();
            providerMap.Add("DataSimulator", ProviderId.DataSimulator);
            providerMap.Add("ExecutionSimulator", ProviderId.ExecutionSimulator);
            providerMap.Add("QuickFIX42", ProviderId.QuickFIX42);
            providerMap.Add("IB", ProviderId.IB);
            providerMap.Add("ESignal", ProviderId.ESignal);
            providerMap.Add("MBTrading", ProviderId.MBTrading);
            providerMap.Add("Opentick", ProviderId.Opentick);
            providerMap.Add("QuoteTracker", ProviderId.QuoteTracker);
            providerMap.Add("TAL", ProviderId.TAL);
            providerMap.Add("TTFIX", ProviderId.TTFIX);
            providerMap.Add("TTAPI", ProviderId.TTAPI);
            providerMap.Add("Genesis", ProviderId.Genesis);
            providerMap.Add("MyTrack", ProviderId.MyTrack);
            providerMap.Add("Photon", ProviderId.Photon);
            providerMap.Add("Bloomberg", ProviderId.Bloomberg);
            providerMap.Add("Reuters", ProviderId.Reuters);
            providerMap.Add("Yahoo", ProviderId.Yahoo);
            providerMap.Add("DC", ProviderId.DC);
            providerMap.Add("CSI", ProviderId.CSI);
            providerMap.Add("QuantHouse", ProviderId.QuantHouse);
            providerMap.Add("PATSAPI", ProviderId.PATSAPI);
            providerMap.Add("OpenECry", ProviderId.OpenECry);
            providerMap.Add("OpenTick", ProviderId.OpenTick);
            providerMap.Add("FIX", ProviderId.FIX);
            providerMap.Add("Google", ProviderId.Google);
            providerMap.Add("Hotspot", ProviderId.Hotspot);
            providerMap.Add("AlfaDirect", ProviderId.AlfaDirect);
            providerMap.Add("Currenex", ProviderId.Currenex);
            providerMap.Add("SmartCOM", ProviderId.SmartCOM);
            providerMap.Add("GenericEOD", ProviderId.GenericEOD);
            providerMap.Add("QUIKFIX", ProviderId.QUIKFIX);
            providerMap.Add("OSLFIX", ProviderId.OSLFIX);
            providerMap.Add("Nordnet", ProviderId.Nordnet);
            providerMap.Add("Integral", ProviderId.Integral);
            providerMap.Add("QuantBase", ProviderId.QuantBase);
            providerMap.Add("QuantRouter", ProviderId.QuantRouter);
            providerMap.Add("MatchingEngine", ProviderId.MatchingEngine);
        }

        public static void Add(string name, byte id)
        {
            providerMap.Add(name, id);
        }

        public static void Remove(string name)
        {
            providerMap.Remove(name);
        }

        public static byte Get(string name)
        {
            byte id;
            providerMap.TryGetValue(name, out id);
            return id;
        }
    }
}
