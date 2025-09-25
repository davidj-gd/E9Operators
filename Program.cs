
Console.WriteLine("Give me a number of seconds\n");
string answer = Console.ReadLine();
int seconds = Convert.ToInt32(answer);

int days = seconds / 86400;
int whatsLeft = seconds % 86400;

int hours = whatsLeft / 3600;
whatsLeft %= 3600;

int minutes = whatsLeft / 60;
int sec = whatsLeft % 60;

//Result
Console.WriteLine($"Seconds: {sec}");
Console.WriteLine($"minutes: {minutes}");
Console.WriteLine($"hours: {hours}");
Console.WriteLine($"days: {days}");

Console.WriteLine($"{days}.{hours}:{minutes}:{sec}");

double daysfraction = seconds / 86400.0;

Console.WriteLine($"In total, that's {daysfraction:F16}"); /* not sure how to get
the 7 at the end...*/


