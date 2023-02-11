using System.Collections.Generic;
using System.Linq;
using UnityEditor;

[CustomEditor(typeof(WeaponType), true)]
public class WeaponTypeEditor : Editor
{
    private int m_selectedWeaponIndex;
    
    public override void OnInspectorGUI() 
    {
        base.OnInspectorGUI();
        var weaponType = (WeaponType)target;
        
        if (weaponType.AvailableWeapons == null)
            return;

        if (weaponType.AvailableWeapons.Count == 0) 
            return;
        
        m_selectedWeaponIndex = EditorGUILayout.Popup("Weapon", m_selectedWeaponIndex, GetWeaponNames(weaponType.AvailableWeapons));
        weaponType.SelectedWeapon = weaponType.AvailableWeapons[m_selectedWeaponIndex];
    }

    private string[] GetWeaponNames(List<Weapon> weapons) => weapons.Select(weapon => weapon.Name).ToArray();
}

