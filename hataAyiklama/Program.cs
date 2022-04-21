
   /* try
    {
        Console.WriteLine("Bir sayi giriniz : ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Girmis oldugunuz sayi: " + sayi1);
    }
    catch (Exception ex)
    {
        
        Console.WriteLine("Hata: " + ex);
    }

    finally
    {
        Console.WriteLine("Islem tamamlandi");
    }


    try
    {
        int a = int.Parse(null);
        int a = int.Parse("test");
        int a = int.Parse("-2000000000");
    }
    catch (ArgumentNullException ex)
    {
        
        Console.WriteLine("Bos deger");
        Console.WriteLine(ex);
    }
    catch(FormatException ex)
    {
        Console.WriteLine("Veri tipi uygun degil");
        Console.WriteLine(ex);
    }
    catch(OverflowException ex)
    {
        Console.WriteLine("Cok kucuk ya da cok buyuk deger girdiniz");
        Console.WriteLine(ex);
    }
    finally
    {
        Console.WriteLine("Islem tamamlandi");
    }
    */
