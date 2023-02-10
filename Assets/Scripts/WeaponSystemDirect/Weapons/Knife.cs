using System;

[Serializable]
public class Knife : WhiteWeapon
{
    public int SpeedModifier = 10;
    
    public Knife()
    {
        Name = "Knife";
        Damage = 10;
    }
    public string DealDamage()
    {
        return $"Knife speed * {SpeedModifier}";
    }
}