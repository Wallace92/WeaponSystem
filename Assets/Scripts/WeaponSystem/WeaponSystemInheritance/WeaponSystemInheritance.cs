
public class WeaponSystemInheritance : WeaponSystem<Weapon>
{
    protected override void Attack() => m_selectedWeapon.Use();
}
