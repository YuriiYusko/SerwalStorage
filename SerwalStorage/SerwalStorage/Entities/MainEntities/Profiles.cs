using GenericPower.Entities;

namespace SerwalStorage.Entities.MainEntities
{
    public class Profiles : EntityBase
    {
        public string? Cod { get; set; }

        public string? Name { get; set; }

        public string? Color { get; set; }

        public int? BaseLength { get; set; }

        public int? Count { get; set; }

        public override string ToString() => $"Cod - {Cod} / Nazwa - {Name} / Kolor - {Color} / Długość - {BaseLength} / Ilość - {Count}";
    }
}
