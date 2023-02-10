using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using WeaponSystemInheritance;

[CustomEditor(typeof(WeaponInspector), true)]
public class WeaponInspectorEditor : Editor 
{
    public override void OnInspectorGUI() 
    {
        base.OnInspectorGUI();
        var script = (WeaponInspector)target;

        if (script.AvailableWeapons.Count == 0) 
            return;
        
        script.SelectedWeaponIndex = EditorGUILayout.Popup("Weapon", script.SelectedWeaponIndex, GetWeaponNames(script.AvailableWeapons));
    }

    private string[] GetWeaponNames(List<Weapon> weapons) => weapons.Select(weapon => weapon.Name).ToArray();
}

