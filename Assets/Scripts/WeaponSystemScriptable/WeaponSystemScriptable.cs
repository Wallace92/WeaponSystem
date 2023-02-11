namespace WeaponSystemScriptable
{
    public class WeaponSystemScriptable : WeaponSystemBase<Damageable>
    {
        protected override void Attack() => m_selectedWeapon.Use();
    }
}