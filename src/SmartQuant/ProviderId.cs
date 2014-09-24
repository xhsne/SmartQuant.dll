// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

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

        private static Dictionary<string, byte> map;

        static ProviderId()
        {
            map = new Dictionary<string, byte>();
            map.Add("DataSimulator", DataSimulator);
            map.Add("ExecutionSimulator", ExecutionSimulator);
            map.Add("QuickFIX42", QuickFIX42);
            map.Add("IB", IB);
            map.Add("ESignal", ESignal);
            map.Add("MBTrading", MBTrading);
            map.Add("Opentick", Opentick);
            map.Add("QuoteTracker", QuoteTracker);
            map.Add("TAL", TAL);
            map.Add("TTFIX", TTFIX);
            map.Add("TTAPI", TTAPI);
            map.Add("Genesis", Genesis);
            map.Add("MyTrack", MyTrack);
            map.Add("Photon", Photon);
            map.Add("Bloomberg", Bloomberg);
            map.Add("Reuters", Reuters);
            map.Add("Yahoo", Yahoo);
            map.Add("DC", DC);
            map.Add("CSI", CSI);
            map.Add("QuantHouse", QuantHouse);
            map.Add("PATSAPI", PATSAPI);
            map.Add("OpenECry", OpenECry);
            map.Add("OpenTick", OpenTick);
            map.Add("FIX", FIX);
            map.Add("Google", Google);
            map.Add("Hotspot", Hotspot);
            map.Add("AlfaDirect", AlfaDirect);
            map.Add("Currenex", Currenex);
            map.Add("SmartCOM", SmartCOM);
            map.Add("GenericEOD", GenericEOD);
            map.Add("QUIKFIX", QUIKFIX);
            map.Add("OSLFIX", OSLFIX);
            map.Add("Nordnet", Nordnet);
            map.Add("Integral", Integral);
            map.Add("QuantBase", QuantBase);
            map.Add("QuantRouter", QuantRouter);
            map.Add("MatchingEngine", MatchingEngine);
        }

        public static void Add(string name, byte id)
        {
            map.Add(name, id);
        }

        public static void Remove(string name)
        {
            map.Remove(name);
        }

        public static byte Get(string name)
        {
            byte id;
            map.TryGetValue(name, out id);
            return id;
        }
    }
}
