﻿using System;

namespace kOS.Safe.Encapsulation
{
    [kOS.Safe.Utilities.KOSNomenclature("Structure", KOSToCSharp = false)]
    public abstract class PrimitiveStructure : Structure
    {
        public abstract object ToPrimitive();
    }
}

