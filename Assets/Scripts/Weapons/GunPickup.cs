using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPickup : MonoBehaviour
{
    public GameObject ourPistol;
    public GameObject pistolFireObj;

    public AudioSource gunPickup;

    void OnTriggerEnter(Collider other)
    {
        gunPickup.Play();
        ourPistol.SetActive(true);
        pistolFireObj.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
