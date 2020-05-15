using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitcherVM : MonoBehaviour
{
    //public AudioClip pistolSound;
    //public AudioClip assaultSound;
    //public AudioClip smgSound;
    //[SerializeField] [Range(0, 1)] float SoundVolume = 0.7f;

    [SerializeField] int currentWeapon = 0;

    void Start()
    {
        SetWeaponActive();
    }

    void Update()
    {
        int previousWeapon = currentWeapon;

        ProcessKeyInput();

        if (previousWeapon != currentWeapon)
        {
            SetWeaponActive();
        }
    }

    public void ProcessKeyInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentWeapon = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentWeapon = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentWeapon = 2;
        }
    }

    private void SetWeaponActive()
    {
        int weaponIndex = 0;

        foreach (Transform weapon in transform)
        {
            if (weaponIndex == currentWeapon)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            weaponIndex++;
        }

    }
}
