using System;
using UnityEngine;
using WeaponSystemInheritance;

[Serializable]
public class WeaponRotator
{
    [SerializeField]
    private Vector3 m_rotationSpeed = new Vector3(0, 45, 0);
    
    
    public void RotateObject(Weapon weapon)
    {
        if (weapon == null)
            return;
            
        weapon.transform.localRotation *= Quaternion.Euler(m_rotationSpeed * Time.deltaTime);
    }
}