﻿//Implict Conversion  - Bilincsiz Donusum
Console.WriteLine("**************Implict Conversion  - Bilincsiz Donusum*********************");
byte a = 5;
sbyte b = 30;
short c = 10;

int d = a+b+c;
Console.WriteLine("d : "+  d);

long h =d;
Console.WriteLine("h : "+  h);

float i = h;
Console.WriteLine("i:"+ i);

string e = "Merhaba";
char f = 'k';
object g = e+f+d;
Console.WriteLine("g:"+ g);
//Explicit Conversion  - Bilincli Donusum
Console.WriteLine("***************Explicit Conversion  - Bilincli Donusum******************");

int x =4;
byte y = (byte)x;
Console.WriteLine("y:"+ y);

int z =100;
byte t = (byte)z;
Console.WriteLine("t:"+ t);

float w = 10.3f;
byte v = (byte)w;
Console.WriteLine("v:"+ v);

//Tostring

Console.WriteLine("*******ToString Metodu ***************");

int xx = 66;
string yy = xx.ToString();
Console.WriteLine("yy : " + yy);

string zz  = 12.5f.ToString();
Console.WriteLine("zz:" + zz);

//System.Convert

Console.WriteLine("******System.Convert Sinifi*********");

string s1 = "10", s2="20";
int sayi1, sayi2;
int toplam;

sayi1 = Convert.ToInt32(s1);
sayi2 = Convert.ToInt32(s2);

toplam = sayi1+sayi2;
Console.WriteLine("Toplam :" + toplam );

//Parse 
Console.WriteLine("*****Parse Metodu*****");

string metin1 = "10";
string metin2 = "10,25";
int rakam1;
double double1;
rakam1= Int32.Parse(metin1);
double1 = Double.Parse(metin2);
Console.WriteLine("rakam1: "+ rakam1);
Console.WriteLine("rakam2: "+ double1);

