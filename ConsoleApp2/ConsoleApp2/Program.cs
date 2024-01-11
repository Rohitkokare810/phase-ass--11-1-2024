// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

List<Movies> movies = new List<Movies>()
{
    new Movies() { MId=1,MTitle="KGF",RDate=new DateTime(day:12,month:11,year:2020)},
    new Movies() { MId=2,MTitle="KGF2",RDate=new DateTime(day:12,month:11,year:2021)},
    new Movies() { MId=3,MTitle="KGF3",RDate=new DateTime(day:12,month:11,year:2025)},
    new Movies() { MId=4,MTitle="SALAAR",RDate=new DateTime(day:12,month:11,year:2023)},
};

string title;
Console.WriteLine("Enter title");
title = Console.ReadLine();

foreach (Movies mov in movies)
{
    if (title == mov.MTitle)
    {
        Console.WriteLine(mov.MId);
        Console.WriteLine(mov.MTitle);
        Console.WriteLine(mov.RDate);
    }

}

