// See https://aka.ms/new-console-template for more information
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
// pag45 c#player guide
// Console.WriteLine("The Variable Shop");

// declaration and initialization
/*
int a = 7;
byte b = 7;
short c =7;
long d = 7;
sbyte e =7;
ushort f =7;
uint g = 7;
ulong h =7;

//
char i = '7';
string j = "7";
bool k = false;
double l = 7;
float m = 7.77f;
decimal n = 7.77m;

//new value 
a = 9;
b = 9;  
c = 9;  
d = 9;  
e = 9;  
f = 9;  
g = 9;  
h = 9;
i = '9';
j = "9";
k = true;
l = 9;
m = 9.99f;
n = 9.99m;

//print screen

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);   
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine(g);
Console.WriteLine(h);
Console.WriteLine(i);
Console.WriteLine(j);
Console.WriteLine(k);
Console.WriteLine(l);
Console.WriteLine(m);
Console.WriteLine(n);
*/ 

// The Triangle Farmer pg.53

Console.WriteLine("The Triangle Farmer");
Console.WriteLine("Which is the size of your triangle base?");
string btext = Console.ReadLine();
double b = Convert.ToSingle(btext);

Console.WriteLine("Which is the Height of your triangle?");
string htext = Console.ReadLine();
double h= Convert.ToSingle(htext);

double area = b * h / 2;
Console.WriteLine(area);

