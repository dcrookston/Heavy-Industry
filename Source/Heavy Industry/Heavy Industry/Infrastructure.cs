using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;

namespace OBE_Heavy
{
    public class requiresInfrastructure : DefModExtension
    {
        public bool reqInf = false;
        //public string infrastructureRequired;
    }

    abstract class Infrastructure : ThingDef
    {
        public bool InfrastructureProvided;
        //public int SupportRange;
    }
   // public class Scaffolding : Infrastructure
   // {
   // }
}
