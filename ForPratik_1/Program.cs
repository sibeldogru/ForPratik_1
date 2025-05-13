for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Kendime inaniyorum, ben bu yazilim isini yaparim!");
}



for (int i = 1; i < 20; i++)
{
    Console.WriteLine(i); 
}


for (int i = 2; i < 20; i+= 2)
{
    Console.WriteLine(i);
}

{
    int toplam = 0;

    for (int i = 50; i <= 150; i++)
{
        toplam += i;
}
    Console.WriteLine("50 ile 150 arasindaki sayilarin toplami= " + toplam);

}

{
    int toplam = 0;

    for (int i = 2; i <= 120; i += 2)
    {
        toplam += i;
    }
    Console.WriteLine("1 ile 120 arasindaki cift sayilarin toplami= " + toplam);

}

{
    int toplam = 0;

    for (int i = 1; i <= 119; i += 2)
    {
        toplam += i;
    }
    Console.WriteLine("1 ile 120 arasındaki tek sayilarin toplami= " + toplam);
}

