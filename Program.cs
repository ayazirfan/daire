
for (int i = 0; i < 11; i++)
{
   for (int j = 10; j >i; j--)
   {
    System.Console.Write("*");
   }
   System.Console.WriteLine("");
}


// Console.WriteLine("Lütfen bir kelime giriniz ve ardından çıkarmak istediğiniz karakterin indeksini giriniz(Aralarında virgül kullanınız.):");
//             string input = Console.ReadLine();

//             string[] input1 = input.Split(","); // Virgülü kaldırdık.
//             string kelime = input1[0]; //Kelime değişkenine dizinin virgülden önceki değeri atadık.
//             int çevirme = Convert.ToInt32(input1[1]); //Değerimiz string türündeydi, int türüne çevirdik.
//             string sonHal = kelime.Remove(çevirme, 1); //sonHal değişkenine sildiğimiz karakterli halini atadık.

//             Console.WriteLine(sonHal);