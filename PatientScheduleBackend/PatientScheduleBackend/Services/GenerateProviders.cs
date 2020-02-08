using System;
using System.Collections.Generic;
using PatientScheduleBackend.Models;
namespace PatientScheduleBackend.Services
{
    public class GenerateProviders
    {
        public GenerateProviders()
        {
        }

        static string IMG_URL = "https://media.xconomy.com/wordpress/wp-content/images/2016/12/06160314/Depositphotos_132925148_l-2015-1100x734.jpg";

        public static string generateRandomName()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] stringChars = new char[8];
            Random random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            string finalString = new String(stringChars);
            return finalString;
        }


        public static IEnumerable<Provider> generateProviders()
        {

            IList<Provider> providers = new List<Provider>();
            for (int i = 1; i < 51; i++)
            {
                Random random = new Random();
                Provider provider = new Provider();
                provider.Id = i.ToString();
                provider.Name = generateRandomName();
                provider.Image = IMG_URL;
                provider.SpecialtyValue = random.Next(1, 7).ToString();

                providers.Add(provider);

            }

            return providers;

        }

    }
}



