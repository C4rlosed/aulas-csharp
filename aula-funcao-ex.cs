double media(double NI, double PI, double PO)
{
    //Console.WriteLine("");
    Double result = NI*0.2+ PI*0.3 + PO*0.5;
    return result;
    
}
String status(double media)
{
    String result;
    if (media < 2)
    {
        result = "RESPROVADO";
    }
    else if (media < 4) {
        result = "EXAME PRECISANDO DE 7.0";
    }
    else if (media < 6) {
        result = "EXAME PRECISANDO DE 6.0";
    }
    else {
        result = "APROVADO";
    }

    return result;
}
Double MyNI, MyPI, MyPO;
Console.WriteLine("Nota da NI: ");
MyNI = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Nota da PI: ");
MyPI = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Nota da PO: ");
MyPO = Convert.ToDouble(Console.ReadLine());
Double mf = media(MyNI, MyPI, MyPO);
Console.WriteLine(mf);
Console.WriteLine(status(mf));
