using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringPistol : MonoBehaviour
{
    public bool isAiming = false;
    public static bool isFiring = false;

    public GameObject thePlayer;
    public GameObject aimingObject;

    public AudioSource pistolShot;

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            isAiming = true;
            if (isFiring == false)
            {
                thePlayer.GetComponent<Animation>().Play("Aiming1Pistol");
                aimingObject.SetActive(true);
            }
        }
        else
        {
            isAiming = false;
            aimingObject.SetActive(false);
        }

        if (isAiming == true && Input.GetMouseButtonDown(0))
        {
            isFiring = true;
            pistolShot.Play();
            thePlayer.GetComponent<Animation>().Play("Fire_1Pistol");
            StartCoroutine(FireThePistol());
        }
    }

    IEnumerator FireThePistol()
    {
        yield return new WaitForSeconds(0.4f);
        isFiring = false;
    }
}