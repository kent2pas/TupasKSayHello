//Kent Tupas
// 10/17/2022
// github mini challenge #1 "What is your name"
// update and uploading work to github
//

Console.Clear();
Console.WriteLine("__________________________________________________");
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
while(string.IsNullOrEmpty(name)){
    Console.WriteLine("Name can't be empty! Please enter a name");
    name = Console.ReadLine();
}
while(name != "end"){
Console.WriteLine($"Good Afternoon {name}");

Console.WriteLine("How you been doing? ");
Console.ReadLine();
Console.WriteLine("Type end to stop or type in another name");
name = Console.ReadLine();
Console.WriteLine("__________________________________________________");
}
