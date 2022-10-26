int[] sayilar = new int[10];

int tekadettoplam = 0;
int ciftadettoplam = 0;

int teksayilartoplami = 0;
int ciftsayilartoplami = 0;

int deger;

for (int i = 0; i < sayilar.Length; i++)

{
    Console.Write((i + 0) + ". index degerini giriniz : ");
    deger = Convert.ToInt32(Console.ReadLine());
    sayilar[i] = deger;
}


for (int j = 0; j < sayilar.Length; j++)
{
    if (sayilar[j] % 2 == 0)
    {
        ciftadettoplam++;
        ciftsayilartoplami += sayilar[j];
    }

    else
    {
        tekadettoplam++;
        teksayilartoplami += sayilar[j];
    }


}

Console.WriteLine("*****************************************");

if (ciftsayilartoplami > teksayilartoplami)
{
    Console.WriteLine("Çift sayıların toplamı büyüktür.");
}
else
{
    Console.WriteLine("Tek sayıların toplamı büyüktür. ");
}
Console.WriteLine("*****************************************");


Console.WriteLine("Cift sayıların toplamı : " + ciftsayilartoplami);
Console.WriteLine("Cift sayıların adedi : " + ciftadettoplam);

Console.WriteLine("*****************************************");

Console.WriteLine("Tek sayıların toplamı : " + teksayilartoplami);
Console.WriteLine("Tek sayıların adedi : " + tekadettoplam);

Console.WriteLine("*****************************************");