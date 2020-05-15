using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WeaponsVM : MonoBehaviour
{
    [SerializeField] Camera FPCamera;
    [SerializeField] float range = 100f;
    [SerializeField] float damage = 30;
    [SerializeField] ParticleSystem muzzleFlash;
    [SerializeField] GameObject hitEffect;
    [SerializeField] AmmoVM ammoSlot;
    [SerializeField] AmmoType ammoType;
    [SerializeField] float timeBetweenShots = 0.5f;
    [SerializeField] TextMeshProUGUI ammoText;

    int currentWeapon;

    AudioSource pistolSound;
    AudioSource assaultSound;
    AudioSource smgSound;

    bool canShoot = true;

    private void OnEnable()
    {
        canShoot = true;
    }

    void Start()
    {
        pistolSound = GetComponent<AudioSource>();
        assaultSound = GetComponent<AudioSource>();
        smgSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        DisplayAmmo();
        if (Input.GetMouseButtonDown(0) && canShoot == true)
        {
            StartCoroutine(Shoot());
        }
    }

    private void DisplayAmmo()
    {
        int currentAmmo = ammoSlot.GetCurrentAmmo(ammoType);
        ammoText.text = currentAmmo.ToString();
    }

    IEnumerator Shoot()
    {
        canShoot = false;
        if (ammoSlot.GetCurrentAmmo(ammoType) > 0)
        {
            PlayMuzzleFlash();
            ProcessRaycast();
            ammoSlot.ReduceCurrentAmmo(ammoType);
            WeaponSounds();
        }
        yield return new WaitForSeconds(timeBetweenShots);
        canShoot = true;
    }

    public void WeaponSounds()
    {
        if (currentWeapon == 0)
        {
            assaultSound.Play();
        }

        if (currentWeapon == 1)
        {
            smgSound.Play();
        }

        if (currentWeapon == 2)
        {
            pistolSound.Play();
        }
    }

    private void PlayMuzzleFlash()
    {
        muzzleFlash.Play();
    }

    private void ProcessRaycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, range))
        {
            CreateHitImpact(hit);
            EnemyHealthVM target = hit.transform.GetComponent<EnemyHealthVM>();
            if (target == null) return;
            target.TakeDamage(damage);
        }
        else
        {
            return;
        }
    }

    private void CreateHitImpact(RaycastHit hit)
    {
        GameObject impact = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));
        Destroy(impact, .1f);
    }
}
