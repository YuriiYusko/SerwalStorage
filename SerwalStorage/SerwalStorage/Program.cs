using GenericPower.Data;
using GenericPower.Entities;
using GenericPower.Repositories;
using SerwalStorage.Entities.MainEntities;

var ProfileRepository = new SQLRepository<Profiles>(new SerwalDbContext());
AddProfile(ProfileRepository);
AddProfileDodatkowe(ProfileRepository);
WriteAll(ProfileRepository);

var UszczelkiRepository = new SQLRepository<Gaskets>(new SerwalDbContext());
AddUszczelki(UszczelkiRepository);
WriteAll(UszczelkiRepository);

var AkcesoriaRepository = new SQLRepository<Accessories>(new SerwalDbContext());
AddAkcesoria(AkcesoriaRepository);
AddOkucia(AkcesoriaRepository);
WriteAll(AkcesoriaRepository);

static void AddProfile(IRepository<Profiles> repository)
{
    var profiles = new[]
    {
        new Profiles { Cod = "P2413", Name = "Skrzydło Drzwiowe 65"},
        new Profiles { Cod = "P2414", Name = "Skrzydło Drzwiowe 90"},
        new Profiles { Cod = "P2601", Name = "Próg" }
    };
    AddBatch(repository, profiles);
}

static void AddBatch<T>(IRepository<T> repository, T[] items)
    where T: class, IEntity
{
    foreach (var item in items)
    {
        repository.Add(item);
    }
    repository.Save();
}

static void AddProfileDodatkowe(IRepository<AuxiliaryProfiles> repository)
{
    repository.Add(new AuxiliaryProfiles { Cod = "K1102", Name = "Listwa Szklenia 10mm" });
    repository.Add(new AuxiliaryProfiles { Cod = "K3315", Name = "Domknięcie Progu"});
    repository.Save();
}

static void AddUszczelki(IRepository<Gaskets> repository)
{
    repository.Add(new Gaskets { Cod = "U103", Name = "Uszczelka" });
    repository.Add(new Gaskets { Cod = "U107", Name = "Uszczelka" });
    repository.Save();
}

static void AddAkcesoria(IRepository<Accessories> repository)
{
    repository.Add(new Accessories { Cod = "A129", Name = "Narożnik Montażowy 41.6x23.5" });
    repository.Add(new Accessories { Cod = "A130", Name = "Narożnik Montażowy 35.5x5.9" });
    repository.Save();
}

static void AddOkucia(IRepository<Accessories> repository)
{
    repository.Add(new Fittings { Cod = ".S00000008", Name = "Szyld (INOX)" });
    repository.Add(new Fittings { Cod = ".S00000020", Name = "Klamka (Inox)" });
    repository.Save();
}

static void WriteAll(I_ReadRepository<IEntity> repository)
{
    foreach (var item in repository.GetAll())
    {
        Console.WriteLine(item);
    }
}