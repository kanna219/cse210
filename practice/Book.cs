using System;
using System.IO.Pipes;
class GameCharacter
{
    private string name;
    private int hp;
    public GameCharacter(string characterName, int charcterHp)
    {
        name = characterName;
        hp = characterHp;
    }

    public string GetName()
    {
        return name;
    }

    public void TakeDamage(int damage)
    {
        if (hp > 0)
        {
            hp -= damage;
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, HP: {hp}");
    }
}
