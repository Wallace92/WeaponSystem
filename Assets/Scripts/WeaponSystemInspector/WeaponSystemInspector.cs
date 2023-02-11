using UnityEngine;

public class WeaponSystemInspector :  WeaponSystemSelector<WeaponType>
{
    [SerializeField]
    private GameObject m_selectionMarker;

    private new void Awake()
    {
        base.Awake();
        OnSelectionChanged += SetSelectionMarkerPosition;
        
        SetSelectionMarkerPosition();
    }
    public new void Update() => base.Update();

    private void SetSelectionMarkerPosition() => m_selectionMarker.transform.position = m_selectedWeapon.transform.position;

    protected override void Attack() => m_selectedWeapon.Use();

    private void OnDestroy() => OnSelectionChanged -= SetSelectionMarkerPosition;
}
