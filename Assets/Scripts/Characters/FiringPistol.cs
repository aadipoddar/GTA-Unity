using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringPistol : MonoBehaviour
{
    public bool isAiming = false;
    public GameObject thePlayer;
    
    void Update()
    {
        if(Input.GetMouseButton(1))
        {
            isAiming = true;
            thePlayer.GetComponent<Animation>().Play("Aiming1Pistol");
        }
        else
            isAiming = false;
    }
}
