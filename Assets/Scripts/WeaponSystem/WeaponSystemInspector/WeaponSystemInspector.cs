using UnityEngine;

public class WeaponSystemInspector :  WeaponSystemSelector<WeaponType>
{
    [SerializeField]
    private GameObject m_selectionMarker;

    protected override void Attack() => m_selectedWeapon.Use();

    private new void Awake()
    {
        base.Awake();
        OnSelectionChanged += SetSelectionMarkerPosition;
        
        SetSelectionMarkerPosition();
    }

    private new void Update() => base.Update();

    private void SetSelectionMarkerPosition() => m_selectionMarker.transform.position = m_selectedWeapon.transform.position;

    private void OnDestroy() => OnSelectionChanged -= SetSelectionMarkerPosition;
}
