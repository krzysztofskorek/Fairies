using UnityEngine;

public class WeaponSlot : MonoBehaviour
{
    GameObject m_Weapon { get { return m_Weapon; } set { m_Weapon = value; } }



    public void StartWeapon()
    {
        Instantiate(m_Weapon, transform.position, Quaternion.identity);
    }
}
