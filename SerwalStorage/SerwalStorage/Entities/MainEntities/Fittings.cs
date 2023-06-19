using GenericPower.Entities;

namespace SerwalStorage.Entities.MainEntities
{
    public class Fittings : Accessories
    {
        public string? Color { get; set; }

        public override string ToString() => $"Cod - {Cod} / Nazwa - {Name} / Kolor - {Color} / Ilość - {Count}";
    }
}
