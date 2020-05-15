using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickupVM : MonoBehaviour
{
    [SerializeField] int ammoAmount = 5;
    [SerializeField] AmmoType ammoType;

    public AudioClip pickupSound;

    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<AmmoVM>().IncreaseCurrentAmmo(ammoType, ammoAmount);
            AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            Destroy(gameObject);
        }
    }
}
