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

    public class buildingProvidesInfrastructure : DefModExtension
    {
        public bool infrastructureProvided;
    }

    public class Infrastructure : Building
    {
        bool providesInfrastructure => def.GetModExtension<buildingProvidesInfrastructure>().infrastructureProvided;
    }
   // public class Scaffolding : Infrastructure
   // {
   // }
}
