﻿using GenericPower.Entities;
using System.Drawing;

namespace SerwalStorage.Entities.MainEntities
{
    public class Akcesoria : EntityBase
    {
        public string? Cod { get; set; }

        public string? Name { get; set; }

        public int? Count { get; set; }

        public override string ToString() => $"Cod - {Cod} / Nazwa - {Name} / Ilość - {Count}";
    }
}
