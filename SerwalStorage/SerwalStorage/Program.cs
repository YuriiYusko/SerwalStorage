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

static void AddProfile(I_WriteRepository<Profiles> repository)
{
    repository.Add(new Profiles { Cod = "P2413", Name = "Skrzydło Drzwiowe 65"});
    repository.Add(new Profiles { Cod = "P2414", Name = "Skrzydło Drzwiowe 90"});
    repository.Save();
}

static void AddProfileDodatkowe(I_WriteRepository<AuxiliaryProfiles> repository)
{
    repository.Add(new AuxiliaryProfiles { Cod = "K1102", Name = "Listwa Szklenia 10mm" });
    repository.Add(new AuxiliaryProfiles { Cod = "K3315", Name = "Domknięcie Progu"});
    repository.Save();
}

static void AddUszczelki(I_WriteRepository<Gaskets> repository)
{
    repository.Add(new Gaskets { Cod = "U103", Name = "Uszczelka" });
    repository.Add(new Gaskets { Cod = "U107", Name = "Uszczelka" });
    repository.Save();
}

static void AddAkcesoria(I_WriteRepository<Accessories> repository)
{
    repository.Add(new Accessories { Cod = "A129", Name = "Narożnik Montażowy 41.6x23.5" });
    repository.Add(new Accessories { Cod = "A130", Name = "Narożnik Montażowy 35.5x5.9" });
    repository.Save();
}

static void AddOkucia(I_WriteRepository<Accessories> repository)
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