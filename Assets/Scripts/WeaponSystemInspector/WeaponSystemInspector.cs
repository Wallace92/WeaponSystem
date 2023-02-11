
public class WeaponSystemInspector :  WeaponSystemSelector<WeaponType> 
{
    public new void Update() => base.Update();

    protected override void Attack() => m_selectedWeapon.Use();

}
