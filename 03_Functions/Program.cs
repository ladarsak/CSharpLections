//void 1: Не принимают, не возвращают
void Copyright(){
    Console.WriteLine("Made by me");
}
    //Вызов: Copyright();

//void 2:Принимают, не возвращают
void GiveMeSmth(string smth){
    Console.WriteLine(smth);
}
    //Вызов: GiveMeSmth("What's on tap?");

//Не принимают, возвращают
int SuchMuch(){
    return DateTime.Now.Year;
}
    //Вызов: int year = SuchMuch();
    //Console.WriteLine(year);

//Принимают и возвращают
string Ccc(int count, string c){
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}
    //string res = Ccc(5, "next");
    //Console.WriteLine(res);

/////////////////////////////////////////////////////////////////////////
//Таблица умножения
/*for (int i = 1; i < 11; i++)
{
    for (int j = 1; j < 11; j++)
    {
    
        Console.WriteLine($"{i} x {j} = {i * j} ");
    }
    Console.WriteLine();
}*/

//Замена символов строки
string Replace(string text, char oldValue, char newValue){
    string res = String.Empty;
    for (int i = 0; i < text.Length; i++)
    {
        
        if(text[i] == oldValue) {res = res + $"{newValue}";}
        else{res = res + $"{text[i]}";}
    }
    return res;
}
string qwerty = "qwerty";
string res = Replace(qwerty, 'q', 'r');
Console.WriteLine(res);
