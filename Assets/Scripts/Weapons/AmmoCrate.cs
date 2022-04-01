using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoCrate : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        GlobalAmmo.pistolShots += 15;
        this.gameObject.SetActive(false);
    }
}
