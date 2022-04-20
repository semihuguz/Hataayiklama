byte b = 5;   // 1byte
sbyte c = 6; // 1byte

short s = 5;  //2byte
ushort ss = 5; //byte

Int16 i16 = 2;  // 2byte
int i = 2;      // 4byte
Int32 i32 =2;   // 4byte
Int64 i64 = 2;  // 8byte

uint ui = 2;     // 4byte   
long l = 4;     // 4byte 
ulong u; = 4;   // 8byte

//Reel Sayilar

float f = 4;    // 4byte
double d = 4;   // 8byte
decimal de = 4;  //16byte

char ch = '2';      //2byte
string str = "Merhaba"  //sinirsiz

bool b1 = true;
bool b2 = false;

DateTime dt = DateTime.Now;


object o1 = "x";
object o2 = 'y';
object o3 = 4;
object o4 = 3.4;


// string ifadeler 

string str1 = string.Empty;
str1 = "Abuzer Komurcu";
string ad  = "Abuzer";
string soyad = "Komurcu";
string adSoyad = ad + " " + soyad;

//integer tanimlama

int int1 = 5;
int int2 = 3;
int int3 = int1*int2;

//Boolean ifadeler

bool b = 10 < 2 ;

//Degisken donusumleri 

string str22 = "22";
int num =20;
string yeniDeger = num.ToString() + str22;
//cikti 2022

int i21 = num + Convert.ToInt32(str22);
//ciktisi 42

//Datetime 
string dateTime = DateTime.Now.ToString("dd,MM,yyyy");





