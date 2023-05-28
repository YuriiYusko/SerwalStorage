using GenericPower.Entities;

namespace SerwalStorage.Entities.MainEntities
{
    public class Uszczelki : EntityBase
    {
        public string? Cod { get; set; }

        public string? Name { get; set; }

        public int? Count { get; set; }

        public override string ToString() => $"Cod - {Cod} / Nazwa - {Name} / Ilość - {Count}";
    }
}
