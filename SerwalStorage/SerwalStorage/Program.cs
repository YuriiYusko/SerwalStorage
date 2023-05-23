using GenericPower.Data;
using GenericPower.Entities;
using GenericPower.Repositories;
using SerwalStorage.Entities.MainEntities;

var ProfileRepository = new SQLRepository<Profile>(new SerwalDbContext());
AddProfile(ProfileRepository);
AddProfileDodatkowe(ProfileRepository);
WriteAll(ProfileRepository);

var UszczelkiRepository = new SQLRepository<Uszczelki>(new SerwalDbContext());
AddUszczelki(UszczelkiRepository);
WriteAll(UszczelkiRepository);

var AkcesoriaRepository = new SQLRepository<Akcesoria>(new SerwalDbContext());
AddAkcesoria(AkcesoriaRepository);
AddOkucia(AkcesoriaRepository);
WriteAll(AkcesoriaRepository);

static void AddProfile(I_WriteRepository<Profile> repository)
{
    repository.Add(new Profile { Cod = "P2413", Name = "Skrzydło Drzwiowe 65"});
    repository.Add(new Profile { Cod = "P2414", Name = "Skrzydło Drzwiowe 90"});
    repository.Save();
}

static void AddProfileDodatkowe(I_WriteRepository<ProfileDodatkowe> repository)
{
    repository.Add(new ProfileDodatkowe { Cod = "K1102", Name = "Listwa Szklenia 10mm" });
    repository.Add(new ProfileDodatkowe { Cod = "K3315", Name = "Domknięcie Progu"});
    repository.Save();
}

static void AddUszczelki(I_WriteRepository<Uszczelki> repository)
{
    repository.Add(new Uszczelki { Cod = "U103", Name = "Uszczelka" });
    repository.Add(new Uszczelki { Cod = "U107", Name = "Uszczelka" });
    repository.Save();
}

static void AddAkcesoria(I_WriteRepository<Akcesoria> repository)
{
    repository.Add(new Akcesoria { Cod = "A129", Name = "Narożnik Montażowy 41.6x23.5" });
    repository.Add(new Akcesoria { Cod = "A130", Name = "Narożnik Montażowy 35.5x5.9" });
    repository.Save();
}

static void AddOkucia(I_WriteRepository<Akcesoria> repository)
{
    repository.Add(new Okucia { Cod = ".S00000008", Name = "Szyld (INOX)" });
    repository.Add(new Okucia { Cod = ".S00000020", Name = "Klamka (Inox)" });
    repository.Save();
}

static void WriteAll(I_ReadRepository<IEntity> repository)
{
    foreach (var item in repository.GetAll())
    {
        Console.WriteLine(item);
    }
}