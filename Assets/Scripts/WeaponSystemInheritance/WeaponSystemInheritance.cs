namespace WeaponSystemInheritance
{
    public class WeaponSystemInheritance : WeaponSystemBase<Weapon>
    {
        protected override void Attack() => m_selectedWeapon.Use();
    }
}