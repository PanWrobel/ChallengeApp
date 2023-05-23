﻿using ChallengeApp;

Employee user1 = new Employee("Kuba", "Prawy", 18);
Employee user2 = new Employee("Roman", "Lewy", 45);
Employee user3 = new Employee("Stanisław", "Środkowy", 27);

user1.Addpoints(2);
user1.Addpoints(7);
user1.Addpoints(3);
user1.Addpoints(1);
user1.Addpoints(9);

user2.Addpoints(6);
user2.Addpoints(2);
user2.Addpoints(9);
user2.Addpoints(3);
user2.Addpoints(9);

user3.Addpoints(9);
user3.Addpoints(2);
user3.Addpoints(3);
user3.Addpoints(2);
user3.Addpoints(2);

string winner = "-";
int winnerSpoints = 0;

if (user1.Sum > user2.Sum && user1.Sum > user3.Sum)
{
    winner = user1.Age + " lat " + user1.Name + " " + user1.Surname;
    winnerSpoints = user1.Sum;
}
else if (user2.Sum > user1.Sum && user2.Sum > user3.Sum)
{
    winner = user2.Age + " lat " + user2.Name + " " + user2.Surname;
    winnerSpoints = user2.Sum;
}
else if (user3.Sum > user2.Sum && user3.Sum > user1.Sum)
{
    winner = user3.Age + " lat " + user3.Name + " " + user3.Surname;
    winnerSpoints = user3.Sum;
}

Console.WriteLine("Użytkownik " + user1.Name + " zdobył " + user1.Sum + " punktów.");
Console.WriteLine("Użytkownik " + user2.Name + " zdobył " + user2.Sum + " punktów.");
Console.WriteLine("Użytkownik " + user3.Name + " zdobył " + user3.Sum + " punktów.");
Console.WriteLine("Zwyciężcą zostaje mający " + winner + ", zdobywając " + winnerSpoints + " punktów.");

