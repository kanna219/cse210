class Program
{
    static void Main()
    {
        GetCharacter myHero = new GetCharacter("Hero", 100);
        myHero.GetName();
        myHero.DisplayInfo();
        myHero.TakeDamage(20);
        myHero.DisplayInfo();
    }
}