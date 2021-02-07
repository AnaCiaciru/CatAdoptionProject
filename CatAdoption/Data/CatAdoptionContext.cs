using CatAdoption.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CatAdoption.Data
{
    public class CatAdoptionContext : DbContext
    {
        public CatAdoptionContext() : base("name=CatAdoptionContext")
        {
            Database.SetInitializer<CatAdoptionContext>(new Initp());
        }

        public System.Data.Entity.DbSet<CatAdoption.Models.Cat> Cats { get; set; }

        public System.Data.Entity.DbSet<CatAdoption.Models.Owner> Owners { get; set; }

        public System.Data.Entity.DbSet<CatAdoption.Models.ContactInfo> ContactsInfo { get; set; }
        public System.Data.Entity.DbSet<CatAdoption.Models.Region> Regions { get; set; }
        public System.Data.Entity.DbSet<CatAdoption.Models.CatType> CatTypes { get; set; }
        public class Initp : DropCreateDatabaseAlways<CatAdoptionContext>
        {
            protected override void Seed(CatAdoptionContext ctx)
            {
                CatType catType1 = new CatType { Id = 100, Breed = "American Shorthair", Color = "Particolor" };
                CatType catType2 = new CatType { Id = 101, Breed = "Turkish Angora", Color = "White" };
                CatType catType3 = new CatType { Id = 102, Breed = "Persian", Color = "Black" };


                ctx.CatTypes.Add(catType1);
                ctx.CatTypes.Add(catType2);
                ctx.CatTypes.Add(catType3);

                Region region1 = new Region { RegionId = 1, Name = "Alba" };
                Region region2 = new Region { RegionId = 2, Name = "Arad" };
                Region region3 = new Region { RegionId = 3, Name = "Argeș" };
                Region region4 = new Region { RegionId = 4, Name = "Bacău" };

                ctx.Regions.Add(region1);
                ctx.Regions.Add(region2);
                ctx.Regions.Add(region3);
                ctx.Regions.Add(region4);
                
                ctx.Regions.Add(new Region { RegionId = 5, Name = "Bihor" });
                ctx.Regions.Add(new Region { RegionId = 6, Name = "Bistrița-Năsăud" });
                ctx.Regions.Add(new Region { RegionId = 7, Name = "Botoșani" });
                ctx.Regions.Add(new Region { RegionId = 8, Name = "Brașov" });
                ctx.Regions.Add(new Region { RegionId = 9, Name = "Brăila" });
                ctx.Regions.Add(new Region { RegionId = 10, Name = "Buzău" });
                ctx.Regions.Add(new Region { RegionId = 11, Name = "Caraș-Severin" });
                ctx.Regions.Add(new Region { RegionId = 12, Name = "Cluj" });
                ctx.Regions.Add(new Region { RegionId = 13, Name = "Constanța" });
                ctx.Regions.Add(new Region { RegionId = 14, Name = "Covasna" });
                ctx.Regions.Add(new Region { RegionId = 15, Name = "Dâmbovița" });
                ctx.Regions.Add(new Region { RegionId = 16, Name = "Dolj" });
                ctx.Regions.Add(new Region { RegionId = 17, Name = "Galați" });
                ctx.Regions.Add(new Region { RegionId = 18, Name = "Gorj" });
                ctx.Regions.Add(new Region { RegionId = 19, Name = "Harghita" });
                ctx.Regions.Add(new Region { RegionId = 20, Name = "Hunedoara" });
                ctx.Regions.Add(new Region { RegionId = 21, Name = "Ialomița" });
                ctx.Regions.Add(new Region { RegionId = 22, Name = "Iași" });
                ctx.Regions.Add(new Region { RegionId = 23, Name = "Ilfov" });
                ctx.Regions.Add(new Region { RegionId = 24, Name = "Maramureș" });
                ctx.Regions.Add(new Region { RegionId = 25, Name = "Mehedinți" });
                ctx.Regions.Add(new Region { RegionId = 26, Name = "Mureș" });
                ctx.Regions.Add(new Region { RegionId = 27, Name = "Neamț" });
                ctx.Regions.Add(new Region { RegionId = 28, Name = "Olt" });
                ctx.Regions.Add(new Region { RegionId = 29, Name = "Prahova" });
                ctx.Regions.Add(new Region { RegionId = 30, Name = "Satu Mare" });
                ctx.Regions.Add(new Region { RegionId = 31, Name = "Sălaj" });
                ctx.Regions.Add(new Region { RegionId = 32, Name = "Sibiu" });
                ctx.Regions.Add(new Region { RegionId = 33, Name = "Suceava" });
                ctx.Regions.Add(new Region { RegionId = 34, Name = "Teleorman" });
                ctx.Regions.Add(new Region { RegionId = 35, Name = "Timiș" });
                ctx.Regions.Add(new Region { RegionId = 36, Name = "Tulcea" });
                ctx.Regions.Add(new Region { RegionId = 37, Name = "Vaslui" });
                ctx.Regions.Add(new Region { RegionId = 38, Name = "Vâlcea" });
                ctx.Regions.Add(new Region { RegionId = 39, Name = "Vrancea" });
                ctx.Regions.Add(new Region { RegionId = 40, Name = "București" });
                ctx.Regions.Add(new Region { RegionId = 41, Name = "București-Sector 1" });
                ctx.Regions.Add(new Region { RegionId = 42, Name = "București-Sector-2" });
                ctx.Regions.Add(new Region { RegionId = 43, Name = "București-Sector-3" });
                ctx.Regions.Add(new Region { RegionId = 44, Name = "București-Sector-4" });
                ctx.Regions.Add(new Region { RegionId = 45, Name = "București-Sector 5" });
                ctx.Regions.Add(new Region { RegionId = 46, Name = "București - Sector 6" });
                ctx.Regions.Add(new Region { RegionId = 51, Name = "Călărași" });
                ctx.Regions.Add(new Region { RegionId = 52, Name = "Giurgiu" });

                ContactInfo contact1 = new ContactInfo
                {
                    PhoneNumber = "0712345678",
                    BirthDay = "16",
                    BirthMonth = "03",
                    BirthYear = 1991,
                    CNP = "2910316014007",
                    GenderType = Gender.Female,
                    Resident = false,
                    RegionId = region1.RegionId
                };

                ContactInfo contact2 = new ContactInfo
                {
                    PhoneNumber = "0713345878",
                    BirthDay = "07",
                    BirthMonth = "04",
                    BirthYear = 2002,
                    CNP = "6020407023976",
                    GenderType = Gender.Female,
                    Resident = false,
                    RegionId = region2.RegionId
                };

                ContactInfo contact3 = new ContactInfo
                {
                    PhoneNumber = "0711345678",
                    BirthDay = "30",
                    BirthMonth = "10",
                    BirthYear = 2002,
                    CNP = "5021030031736",
                    GenderType = Gender.Male,
                    Resident = false,
                    RegionId = region3.RegionId
                };

                ContactInfo contact4 = new ContactInfo
                {
                    PhoneNumber = "0712665679",
                    BirthDay = "13",
                    BirthMonth = "05",
                    BirthYear = 1986,
                    CNP = "2860513040701",
                    GenderType = Gender.Female,
                    Resident = false,
                    RegionId = region4.RegionId
                };

                ctx.ContactsInfo.Add(contact1);
                ctx.ContactsInfo.Add(contact2);
                ctx.ContactsInfo.Add(contact3);
                ctx.ContactsInfo.Add(contact4);

                Owner ow1 = new Owner { Name = "Ana Ciaciru", ContactInfo = contact1 };
                Owner ow2 = new Owner { Name = "Ioana Pravai", ContactInfo = contact2 };
                Owner ow3 = new Owner { Name = "Denisa Popa", ContactInfo = contact3 };
                Owner ow4 = new Owner { Name = "Cristi Ionescu", ContactInfo = contact4 };

                ctx.Owners.Add(ow1);
                ctx.Owners.Add(ow2);
                ctx.Owners.Add(ow3);
                ctx.Owners.Add(ow4);

                ctx.Cats.Add(new Cat
                {
                    Name = "Columb",
                    Gender = Gender.Male,
                    Description = "Un motan foarte curios dornic sa exploreze noi imprejurimi.",
                    Age = 11,
                    DateOfJoining = new DateTime(2021, 1, 12),
                    Owner = ow1,
                    CatType = catType2,
                    Characteristics = new List<Characteristic> {
                    new Characteristic { Name = "Playfulness"},
                    new Characteristic { Name = "Neutered" }
                }
                });

                ctx.Cats.Add(new Cat
                {
                    Name = "Alex",
                    Gender = Gender.Female,
                    Description = "Pisicuta jucausa, dragastoasa care ofera foarte multa iubire.",
                    Age = 11,
                    DateOfJoining = new DateTime(2021, 1, 12),
                    Owner = ow1,
                    CatType = catType2,
                    Characteristics = new List<Characteristic> {
                    new Characteristic { Name = "Playfulness"},
                    new Characteristic { Name = "Good Metabolism" },
                    new Characteristic { Name = "Sensitive" }
                }
                });

                ctx.Cats.Add(new Cat
                {
                    Name = "Nala",
                    Gender = Gender.Female,
                    Description = "O pisica care iti imbuneaza ziua.",
                    Age = 14,
                    DateOfJoining = new DateTime(2021, 1, 13),
                    Owner = ow2,
                    CatType = catType1,
                    Characteristics = new List<Characteristic> {
                    new Characteristic { Name = "Calm"},
                    new Characteristic { Name = "Neutered" },
                    new Characteristic { Name = "Clean" }
                }
                });


                ctx.Cats.Add(new Cat
                {
                    Name = "Biju",
                    Gender = Gender.Male,
                    Description = "Motan cu stil",
                    Age = 45,
                    DateOfJoining = new DateTime(2021, 1, 4),
                    Owner = ow3,
                    CatType = catType3,
                    Characteristics = new List<Characteristic> {
                    new Characteristic { Name = "Vegetarian"},
                    new Characteristic { Name = "Playfulness" }
                }
                });



                ctx.SaveChanges();
                base.Seed(ctx);
            }
        }
    }
}
