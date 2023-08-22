string projectName = "ACME";
string projectLoaction = $@"c:Exercise\{projectName}\data.txt" ;

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianMessageLocation = $@"c:\Excercise\{projectName}\ru-RU\data.txt";

Console.WriteLine($"View English output:\n  {projectLoaction}");
Console.WriteLine($"{russianMessage}:\n  {russianMessageLocation}");



int value1 = 3 + 4 * 5;
int value2 = (3 + 4)* 5;
Console.WriteLine(value1);
Console.WriteLine(value2);