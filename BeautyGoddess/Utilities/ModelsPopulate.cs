using System.Collections.Generic;
using System.Linq;
using BeautyGoddess.Models.Price;
using BeautyGoddess.Models.Service;

namespace BeautyGoddess.Utilities
{
    public class ModelsPopulate
    {
        public static List<ServiceModel> ServiceModelPopulate()
        {
            var serviceList = new List<ServiceModel>
            {
                new ServiceModel {Id = 1, Title = "Veido odos procedūros", ImgUrl = "/Content/Images/Services/veido_odos_proceduros.jpg", HasUrl = true},
                new ServiceModel {Id = 2, Title = "Mezoterapija", ImgUrl = "/Content/Images/Services/mezoterapija.jpg", HasUrl = true},
                new ServiceModel {Id = 3, Title = "Biorevitalizacija", ImgUrl = "/Content/Images/Services/biorevitalizacija.jpg", HasUrl = true},
                new ServiceModel {Id = 4, Title = "Hialurono rūgšties užpildai", ImgUrl = "/Content/Images/Services/hialurono_rugsties_uzpildai.jpg", HasUrl = true},
                new ServiceModel {Id = 5, Title = "Lūpų putlinimas", ImgUrl = "/Content/Images/Services/lupu_putlinimas.jpg", HasUrl = true},
                new ServiceModel {Id = 6, Title = "Botulino injekcijos", ImgUrl = "/Content/Images/Services/botulino_injekcijos.jpg", HasUrl = true},
                new ServiceModel {Id = 7, Title = "Adatinė Dermaroler terapija", ImgUrl = "/Content/Images/Services/adatine_dermaroler_terapija.jpg", HasUrl = true},
                new ServiceModel {Id = 8, Title = "Aparatūrinės veido procedūros", ImgUrl = "/Content/Images/Services/aparaturines_veido_proceduros.jpg", HasUrl = true},
                new ServiceModel {Id = 9, Title = "Cheminis pilingas", ImgUrl = "/Content/Images/Services/cheminis_pilingas.jpg", HasUrl = true},
                new ServiceModel {Id = 10, Title = "Blakstienų priauginimas", ImgUrl = "/Content/Images/Services/blakstienu_priauginimas.jpg", HasUrl = true},
                new ServiceModel {Id = 11, Title = "Antakių ir blakstienų dažymas", ImgUrl = "/Content/Images/Services/antakiu_dazymas.jpg", HasUrl = true},
                new ServiceModel {Id = 12, Title = "Estetinis plaukų šalinimas vašku", ImgUrl = "/Content/Images/Services/estetinis_plauku_salinimas_vasku.jpg", HasUrl = true}
            };
            return serviceList;
        }
        public static List<PriceModel> PriceModelPopulate()
        {
            var priceList = new List<PriceModel>
            {
                new PriceModel {Id = 1, ServiceId = 1, Title = "Mechaninis veido valymas", Description="Demakiažas, pilingas, veido brinkinimas, mechaninis išvalymas, raminanti kaukė + poras sutraukianti kaukė, tonizavimas, kremas", Price = " 35 €", PriceWithDiscount = "30 €"},
                new PriceModel {Id = 2, ServiceId = 1, Title = "Cheminis pilingas", Description="", Price = "nuo 30 €", PriceWithDiscount = ""},
                new PriceModel {Id = 3, ServiceId = 1, Title = "Veido procedūra pagal odos poreikius (giliai drėkinanti / valomoji / maitinanti / raminanti)", Description="", Price = "20 €", PriceWithDiscount = ""},
                new PriceModel {Id = 4, ServiceId = 1, Title = "Veido odos procedūra pagal odos poreikius  + Žake-leri masažas", Description="", Price = "35 €", PriceWithDiscount = ""},
                new PriceModel {Id = 5, ServiceId = 1, Title = "Veido odos prozedūra pagal odos poreikius + Plastinis veido masažas", Description="", Price = "45 €", PriceWithDiscount = ""},
                new PriceModel {Id = 6, ServiceId = 1, Title = "Plastinis veido masažas su prabangiu drėkinančiu, atpalaiduojančiu veido serumu", Description="", Price = "28 €", PriceWithDiscount = ""},
                new PriceModel {Id = 7, ServiceId = 1, Title = "Vitamino C terapija", Description="Demakiažas, pilingas, vitamino C koncentratas, kaukė, tonizavimas, kremas", Price = "35 €", PriceWithDiscount = ""},
                new PriceModel {Id = 20, ServiceId = 2, Title = "Mezoterapija veidui /  kaklui ir dekolte", Description="", Price = "50-80€", PriceWithDiscount = ""},
                new PriceModel {Id = 21, ServiceId = 2, Title = "Paakių srities mezoterapija", Description="", Price = "35-45 €", PriceWithDiscount = ""},
                new PriceModel {Id = 22, ServiceId = 2, Title = "Lipolitinė mezoterapija dvigubo pagurklio / šlaunų / pilvo", Description="", Price = "40-60 €", PriceWithDiscount = ""},
                new PriceModel {Id = 23, ServiceId = 2, Title = "Mezoterapija skatinanti plaukų augimą", Description="", Price = "45-55 €", PriceWithDiscount = ""},
                new PriceModel {Id = 24, ServiceId = 2, Title = "Homeopatinė mezoterapija (randams post acne / pigmentinėms dėmėms / kuperozei)", Description="", Price = " 40-60 €", PriceWithDiscount = ""},
                new PriceModel {Id = 26, ServiceId = 2, Title = "Nuskausminimas procedūros metu", Description="", Price = "6 €", PriceWithDiscount = ""},
                new PriceModel {Id = 25, ServiceId = 3, Title = "Biorevitalizacija (veido / kaklo ir dekolte)", Description="", Price = "100-140 €", PriceWithDiscount = ""},
                new PriceModel {Id = 26, ServiceId = 3, Title = "Nuskausminimas procedūros metu", Description="", Price = "6 €", PriceWithDiscount = ""},
                new PriceModel {Id = 27, ServiceId = 4, Title = "Hialurono rūgšties užpildai veido raukšlėms", Description="", Price = "nuo 150 €", PriceWithDiscount = "nuo 135 €"},
                new PriceModel {Id = 29, ServiceId = 5, Title = "Lūpų putlinimas", Description="", Price = "150-280 €", PriceWithDiscount = "130-260 €", },
                new PriceModel {Id = 26, ServiceId = 5, Title = "Nuskausminimas procedūros metu", Description="", Price = "6 €", PriceWithDiscount = ""},
                new PriceModel {Id = 31, ServiceId = 7, Title = "Adatinė Dermaroler terapija", Description="", Price = "38 €", PriceWithDiscount = "32 €"},
                new PriceModel {Id = 32, ServiceId = 7, Title = "Dermorolerio įsigyjimas pirmos procedūros metu", Description="", Price = "30 €", PriceWithDiscount = "25 €"},
                new PriceModel {Id = 3, ServiceId = 8, Title = "Sonoforezė (ultragarso aparatu) + kaukė", Description="Odos renjefą lyginanti, drėkinanti,maitinanti procedūra", Price = "55 €", PriceWithDiscount = "42 €"},
                new PriceModel {Id = 4, ServiceId = 8, Title = "Sonoforezė (ultragarso aparatu)", Description="Odos renjefą lyginanti, drėkinanti,maitinanti procedūra", Price = "40 €", PriceWithDiscount = "30 €"},
                new PriceModel {Id = 5, ServiceId = 8, Title = "Jonoforezė (aktyvių medžiagų įvedimas) + kaukė", Description="Jauninanti, liftingo efekto procedūra", Price = "55 €", PriceWithDiscount = ""},
                new PriceModel {Id = 6, ServiceId = 8, Title = "Jonoforezė (aktyvių medžiagų įvedimas)", Description="Jauninanti, liftingo efekto procedūra", Price = "40 €", PriceWithDiscount = ""},
                new PriceModel {Id = 7, ServiceId = 8, Title = "Darsonvalis + kaukė", Description="Palaikanti odos turgorą ir elastingumą procedūra ", Price = "40 €", PriceWithDiscount = "32 €"},
                new PriceModel {Id = 8, ServiceId = 8, Title = "Darsonvalis", Description="Palaikanti odos turgorą ir elastingumą procedūra ", Price = "30 €", PriceWithDiscount = "26 €"},
                new PriceModel {Id = 9, ServiceId = 8, Title = "Dezinkrustacija + kaukė", Description="Švelniai, matinei odos būklei palaikyti", Price = "45 €", PriceWithDiscount = ""},
                new PriceModel {Id = 10, ServiceId = 8, Title = "Dezinkrustacija", Description="Švelniai, matinei odos būklei palaikyti", Price = "30 €", PriceWithDiscount = ""},
                new PriceModel {Id = 13, ServiceId = 9, Title = "Cheminis pilingas", Description="", Price = "nuo 30 €", PriceWithDiscount = ""},
                new PriceModel {Id = 33, ServiceId = 10, Title = "Klasikinių blakstienų priauginimas", Description="", Price = "32 €", PriceWithDiscount = ""},
                new PriceModel {Id = 33, ServiceId = 10, Title = "Blakstienų priauginimas 'Volume' 2D", Description="", Price = "35 €", PriceWithDiscount = "22 €"},
                new PriceModel {Id = 33, ServiceId = 10, Title = "Blakstienų priauginimas 'Volume' 3D", Description="", Price = "40 €", PriceWithDiscount = ""},
                new PriceModel {Id = 34, ServiceId = 10, Title = "Klasikinių blakstienų papildymas", Description="", Price = "24 €", PriceWithDiscount = ""},
                new PriceModel {Id = 35, ServiceId = 10, Title = "Blakstienų papildymas 'Volume' 2D", Description="", Price = "25 €", PriceWithDiscount = "19 €"},
                new PriceModel {Id = 35, ServiceId = 10, Title = "Blakstienų papildymas 'Volume' 3D", Description="", Price = "30 €", PriceWithDiscount = ""},
                new PriceModel {Id = 36, ServiceId = 10, Title = "Blakstienų nuėmimas", Description="", Price = "10 €", PriceWithDiscount = ""},
                new PriceModel {Id = 38, ServiceId = 11, Title = "Antakių ir blakstienų dažymas+korekcija", Description="", Price = "12 €", PriceWithDiscount = ""},
                new PriceModel {Id = 38, ServiceId = 11, Title = "Antakių korekcija pincetu ir dažymas", Description="", Price = "6 €", PriceWithDiscount = ""},
                new PriceModel {Id = 38, ServiceId = 11, Title = "Antakių korekcija vašku ir dažymas", Description="", Price = "7 €", PriceWithDiscount = ""},
                new PriceModel {Id = 38, ServiceId = 11, Title = "Antakių dažymas", Description="", Price = "3 €", PriceWithDiscount = ""},
                new PriceModel {Id = 38, ServiceId = 11, Title = "Blakstienų dažymas", Description="", Price = "4 €", PriceWithDiscount = ""},
                new PriceModel {Id = 40, ServiceId = 12, Title = "Veido zonos estetinis plaukų šalinimas vašku", Description="", Price = "5-8 €", PriceWithDiscount = "4-6 €"},
                new PriceModel {Id = 41, ServiceId = 12, Title = "Kojų stetinis plaukų šalinimas vašku", Description="", Price = "20 €", PriceWithDiscount = "16 €"},
                new PriceModel {Id = 42, ServiceId = 12, Title = "Blauzdų srities estetinis plaukų šalinimas vašku", Description="", Price = "10-12 €", PriceWithDiscount = "8-10 €"},
                new PriceModel {Id = 43, ServiceId = 12, Title = "Pažastų srities estetinis plaukų šalinimas vašku", Description="", Price = "8-10 €", PriceWithDiscount = "6-8 €"},
                new PriceModel {Id = 44, ServiceId = 12, Title = "Rankų estetinis plaukų šalinimas vašku", Description="", Price = "10-12 €", PriceWithDiscount = "8-10 €"},
                new PriceModel {Id = 45, ServiceId = 12, Title = "Bikini zonos estetinis plaukų šalinimas vašku", Description="", Price = "16-21 €", PriceWithDiscount = "13-17 €"}



                 /*new PriceModel {Id = 1, ServiceId = null, Title = "Konsultacija atliekant procedūrą pas specialistą nemokama", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                    new PriceModel {Id = 2, ServiceId = 8, Title = "Aparatūrinės veido procedūros", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                    new PriceModel {Id = 3, ServiceId = null, Title = "Sonoforezė (ultragarso aparatu) + kaukė", Description="Odos renjefą lyginanti, drėkinanti,maitinanti procedūra", Price = "55 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 4, ServiceId = null, Title = "Sonoforezė (ultragarso aparatu)", Description="Odos renjefą lyginanti, drėkinanti,maitinanti procedūra", Price = "40 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 5, ServiceId = null, Title = "Jonoforezė (aktyvių medžiagų įvedimas) + kaukė", Description="Jauninanti, liftingo efekto procedūra", Price = "55 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 6, ServiceId = null, Title = "Jonoforezė (aktyvių medžiagų įvedimas)", Description="Jauninanti, liftingo efekto procedūra", Price = "40 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 7, ServiceId = null, Title = "Darsonvalis + kaukė", Description="Palaikanti odos turgorą ir elastingumą procedūra ", Price = "40 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 8, ServiceId = null, Title = "Darsonvalis", Description="Palaikanti odos turgorą ir elastingumą procedūra ", Price = "30 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 9, ServiceId = null, Title = "Dezinkrustacija + kaukė", Description="Švelniai, matinei odos būklei palaikyti", Price = "45 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 10, ServiceId = null, Title = "Dezinkrustacija", Description="Švelniai, matinei odos būklei palaikyti", Price = "30 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 11, ServiceId = 1, Title = "Veido odos procedūros", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                    new PriceModel {Id = 12, ServiceId = null, Title = "Mechaninis veido valymas", Description="Demakiažas, pilingas, veido brinkinimas, mechaninis išvalymas, raminanti kaukė + poras sutraukianti kaukė, tonizavimas, kremas", Price = " 35 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 13, ServiceId = null, Title = "Cheminis pilingas", Description="", Price = " 30 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 14, ServiceId = null, Title = "Veido procedūra pagal odos poreikius (giliai drėkinanti / valomoji / maitinanti / raminanti)", Description="", Price = "20 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 15, ServiceId = null, Title = "Veido odos procedūra pagal odos poreikius  + Žake-leri masažas", Description="", Price = "35 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 16, ServiceId = null, Title = "Veido odos prozedūra pagal odos poreikius + Plastinis veido masažas", Description="", Price = "45 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 17, ServiceId = null, Title = "Plastinis veido masažas su prabangiu drėkinančiu, atpalaiduojančiu veido serumu", Description="", Price = "32 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 18, ServiceId = null, Title = "Vitamino C terapija", Description="Demakiažas, pilingas, vitamino C koncentratas, kaukė, tonizavimas, kremas", Price = "35 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 19, ServiceId = 2, Title = "Mezoterapija", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                    new PriceModel {Id = 20, ServiceId = null, Title = "Mezoterapija veidui /  kaklui ir dekolte", Description="", Price = "50-80€", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 21, ServiceId = null, Title = "Paakių srities mezoterapija", Description="", Price = "30 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 22, ServiceId = null, Title = "Lipolitinė mezoterapija dvigubo pagurklio / šlaunų / pilvo", Description="", Price = "50-70 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 23, ServiceId = null, Title = "Mezoterapija skatinanti plaukų augimą", Description="", Price = "50-60 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 24, ServiceId = null, Title = "Homeopatinė mezoterapija (randams post acne / pigmentinėms dėmėms / kuperozei)", Description="", Price = " 40-60 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 25, ServiceId = null, Title = "Biorevitalizacija (veido / kaklo ir dekolte)", Description="", Price = "110-150 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 26, ServiceId = null, Title = "Nuskausminimas procedūros metu", Description="", Price = "8 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 27, ServiceId = 4, Title = "Hialurono rūgšties užpildai", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                    new PriceModel {Id = 28, ServiceId = null, Title = "Veido raukšlėms", Description="", Price = "nuo 150 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 29, ServiceId = null, Title = "Lūpų putlinimas", Description="", Price = "150-280 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 30, ServiceId = 7, Title = "Adatinė Dermaroler terapija", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                    new PriceModel {Id = 31, ServiceId = null, Title = "Procedūros kaina", Description="", Price = "38 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 32, ServiceId = null, Title = "Dermorolerio įsigyjimas pirmos procedūros metu", Description="", Price = "30 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 33, ServiceId = 10, Title = "Blakstienų priauginimas 'Volume'", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                    new PriceModel {Id = 34, ServiceId = null, Title = "2D-6D blakstienų priauginimas", Description="", Price = "40-60 €", PriceWithDiscount = "25-40 €", IsGroup = false},
                    new PriceModel {Id = 35, ServiceId = null, Title = "2D-6D blakstienų korekcija", Description="", Price = "25-45 €", PriceWithDiscount = "19-29 €", IsGroup = false},
                    new PriceModel {Id = 36, ServiceId = null, Title = "Blakstienų nuėmimas", Description="", Price = "15 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 37, ServiceId = 11, Title = "Antakių dažymas", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                    new PriceModel {Id = 38, ServiceId = null, Title = "Antakių dažymas ir korekcija", Description="", Price = "3-6 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 39, ServiceId = 12, Title = "Estetinis plaukų šalinimas vašku", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                    new PriceModel {Id = 40, ServiceId = null, Title = "Veido", Description="", Price = "5-8 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 41, ServiceId = null, Title = "Kojų", Description="", Price = "20 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 42, ServiceId = null, Title = "Blauzdų sritis", Description="", Price = "10-12 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 43, ServiceId = null, Title = "Pažastų sritis", Description="", Price = "8-10 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 44, ServiceId = null, Title = "Rankų", Description="", Price = "10-12 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 45, ServiceId = null, Title = "Bikini zonos", Description="", Price = "16-21 €", PriceWithDiscount = "", IsGroup = false}*/
            };

            return priceList;
        }

        public static List<PriceGroupModel> PriceGroupModelPopulate()
        {
            var services = ServiceModelPopulate();
            var prices = PriceModelPopulate();

            var priceGroupList = new List<PriceGroupModel>();
            var counter = 0;
            foreach (var service in services)
            {
                counter++;
                var priceGroup = new PriceGroupModel
                {
                    Id = counter,
                    Title = service.Title,
                    HasUrl = service.HasUrl,
                    Prices = prices.Where(x => x.ServiceId == service.Id).ToList()
                };
                priceGroupList.Add(priceGroup);
            }

            return priceGroupList;
        }

            /*public static List<PriceModel> PriceModelPopulate()
            {
                var priceList = new List<PriceModel>
                {
                    new PriceModel {Id = 1, ServiceId = null, Title = "Konsultacija atliekant procedūrą pas specialistą nemokama", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                    new PriceModel {Id = 2, ServiceId = 8, Title = "Aparatūrinės veido procedūros", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                    new PriceModel {Id = 3, ServiceId = null, Title = "Sonoforezė (ultragarso aparatu) + kaukė", Description="Odos renjefą lyginanti, drėkinanti,maitinanti procedūra", Price = "55 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 4, ServiceId = null, Title = "Sonoforezė (ultragarso aparatu)", Description="Odos renjefą lyginanti, drėkinanti,maitinanti procedūra", Price = "40 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 5, ServiceId = null, Title = "Jonoforezė (aktyvių medžiagų įvedimas) + kaukė", Description="Jauninanti, liftingo efekto procedūra", Price = "55 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 6, ServiceId = null, Title = "Jonoforezė (aktyvių medžiagų įvedimas)", Description="Jauninanti, liftingo efekto procedūra", Price = "40 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 7, ServiceId = null, Title = "Darsonvalis + kaukė", Description="Palaikanti odos turgorą ir elastingumą procedūra ", Price = "40 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 8, ServiceId = null, Title = "Darsonvalis", Description="Palaikanti odos turgorą ir elastingumą procedūra ", Price = "30 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 9, ServiceId = null, Title = "Dezinkrustacija + kaukė", Description="Švelniai, matinei odos būklei palaikyti", Price = "45 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 10, ServiceId = null, Title = "Dezinkrustacija", Description="Švelniai, matinei odos būklei palaikyti", Price = "30 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 11, ServiceId = 1, Title = "Veido odos procedūros", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                    new PriceModel {Id = 12, ServiceId = null, Title = "Mechaninis veido valymas", Description="Demakiažas, pilingas, veido brinkinimas, mechaninis išvalymas, raminanti kaukė + poras sutraukianti kaukė, tonizavimas, kremas", Price = " 35 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 13, ServiceId = null, Title = "Cheminis pilingas", Description="", Price = " 30 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 14, ServiceId = null, Title = "Veido procedūra pagal odos poreikius (giliai drėkinanti / valomoji / maitinanti / raminanti)", Description="", Price = "20 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 15, ServiceId = null, Title = "Veido odos procedūra pagal odos poreikius  + Žake-leri masažas", Description="", Price = "35 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 16, ServiceId = null, Title = "Veido odos prozedūra pagal odos poreikius + Plastinis veido masažas", Description="", Price = "45 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 17, ServiceId = null, Title = "Plastinis veido masažas su prabangiu drėkinančiu, atpalaiduojančiu veido serumu", Description="", Price = "32 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 18, ServiceId = null, Title = "Vitamino C terapija", Description="Demakiažas, pilingas, vitamino C koncentratas, kaukė, tonizavimas, kremas", Price = "35 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 19, ServiceId = 2, Title = "Mezoterapija", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                    new PriceModel {Id = 20, ServiceId = null, Title = "Mezoterapija veidui /  kaklui ir dekolte", Description="", Price = "50-80€", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 21, ServiceId = null, Title = "Paakių srities mezoterapija", Description="", Price = "30 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 22, ServiceId = null, Title = "Lipolitinė mezoterapija dvigubo pagurklio / šlaunų / pilvo", Description="", Price = "50-70 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 23, ServiceId = null, Title = "Mezoterapija skatinanti plaukų augimą", Description="", Price = "50-60 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 24, ServiceId = null, Title = "Homeopatinė mezoterapija (randams post acne / pigmentinėms dėmėms / kuperozei)", Description="", Price = " 40-60 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 25, ServiceId = null, Title = "Biorevitalizacija (veido / kaklo ir dekolte)", Description="", Price = "110-150 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 26, ServiceId = null, Title = "Nuskausminimas procedūros metu", Description="", Price = "8 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 27, ServiceId = 4, Title = "Hialurono rūgšties užpildai", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                    new PriceModel {Id = 28, ServiceId = null, Title = "Veido raukšlėms", Description="", Price = "nuo 150 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 29, ServiceId = null, Title = "Lūpų putlinimas", Description="", Price = "150-280 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 30, ServiceId = 7, Title = "Adatinė Dermaroler terapija", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                    new PriceModel {Id = 31, ServiceId = null, Title = "Procedūros kaina", Description="", Price = "38 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 32, ServiceId = null, Title = "Dermorolerio įsigyjimas pirmos procedūros metu", Description="", Price = "30 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 33, ServiceId = 10, Title = "Blakstienų priauginimas 'Volume'", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                    new PriceModel {Id = 34, ServiceId = null, Title = "2D-6D blakstienų priauginimas", Description="", Price = "40-60 €", PriceWithDiscount = "25-40 €", IsGroup = false},
                    new PriceModel {Id = 35, ServiceId = null, Title = "2D-6D blakstienų korekcija", Description="", Price = "25-45 €", PriceWithDiscount = "19-29 €", IsGroup = false},
                    new PriceModel {Id = 36, ServiceId = null, Title = "Blakstienų nuėmimas", Description="", Price = "15 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 37, ServiceId = 11, Title = "Antakių dažymas", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                    new PriceModel {Id = 38, ServiceId = null, Title = "Antakių dažymas ir korekcija", Description="", Price = "3-6 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 39, ServiceId = 12, Title = "Estetinis plaukų šalinimas vašku", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                    new PriceModel {Id = 40, ServiceId = null, Title = "Veido", Description="", Price = "5-8 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 41, ServiceId = null, Title = "Kojų", Description="", Price = "20 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 42, ServiceId = null, Title = "Blauzdų sritis", Description="", Price = "10-12 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 43, ServiceId = null, Title = "Pažastų sritis", Description="", Price = "8-10 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 44, ServiceId = null, Title = "Rankų", Description="", Price = "10-12 €", PriceWithDiscount = "", IsGroup = false},
                    new PriceModel {Id = 45, ServiceId = null, Title = "Bikini zonos", Description="", Price = "16-21 €", PriceWithDiscount = "", IsGroup = false}
                };
                return priceList;
            }*/
        }
}