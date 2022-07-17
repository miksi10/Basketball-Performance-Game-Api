using EntityDemo.Data;
using EntityDemo.Models;

Console.WriteLine("Hello, I am starting :)");

using GameContext gameContext = new GameContext();
/*
GamePerformance game1 = new GamePerformance()
{
    GameId = 1,
    PlayerId = 3,
    Points = 5,
    Assists = 8,
    Rebounds = 4,
    PerformanceIndex = 9.35M
};

try
{
    gameContext.GamePerformance.Add(game1);

    gameContext.SaveChanges();
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
*/
var players = gameContext.Players
    .Where(p => p.Age > 25)
    .OrderBy(p => p.PlayerId);

foreach (var player in players)
{
    Console.WriteLine(player.ToString());
}

//Update

var playerToUpdate = gameContext.Players.Where(p => p.PlayerId == 4).FirstOrDefault();

//var gameToUpdate = gameContext.GamePerformance.Where(p =>  p.PlayerId == 2 && p.GameId == 1).FirstOrDefault();
var gameToUpdate = gameContext.GamePerformance.Where(p =>  p.GamePerformanceID == 2).FirstOrDefault();

if(playerToUpdate is Players)
{
    playerToUpdate.Team = "Kragujevac";
    playerToUpdate.Nationality = "Serbia";
}


if(gameToUpdate is GamePerformance)
{
    gameToUpdate.PerformanceIndex = 10;
}

gameContext.SaveChanges();

Console.WriteLine("By, I finished!");


