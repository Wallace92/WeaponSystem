
public class WeaponSystemScriptable : WeaponSystem<Damageable>
{
    protected override void Attack() => m_selectedWeapon.Use();
}
