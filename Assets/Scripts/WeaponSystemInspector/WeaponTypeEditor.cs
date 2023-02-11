using System.Collections.Generic;
using System.Linq;
using UnityEditor;

[CustomEditor(typeof(WeaponType), true)]
public class WeaponTypeEditor : Editor 
{
    public override void OnInspectorGUI() 
    {
        base.OnInspectorGUI();
        var script = (WeaponType)target;
        
        if (script.AvailableWeapons == null)
            return;

        if (script.AvailableWeapons.Count == 0) 
            return;
        
        script.SelectedWeaponIndex = EditorGUILayout.Popup("Weapon", script.SelectedWeaponIndex, GetWeaponNames(script.AvailableWeapons));
    }

    private string[] GetWeaponNames(List<Weapon> weapons) => weapons.Select(weapon => weapon.Name).ToArray();
}

