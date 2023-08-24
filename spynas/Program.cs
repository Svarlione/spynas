string myPass = "Russ";
string userPass = "Melon";
string hackPass = "00011100011";
Console.WriteLine("Hello, please enter password");
string Pass = Console.ReadLine();
if  (Pass == myPass)
    Console.WriteLine("Sveiki, jus sekmingai prisjunget");
else if (Pass == userPass)
    Console.WriteLine("Sveiki, jus sekmingai prisijunget");
else if(Pass == hackPass)
    Console.WriteLine("!!!!!NILAUZTA!!!!");
else
    Console.WriteLine("Bandykit dar karta");