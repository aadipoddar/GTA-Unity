using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A01_CamSwitch : MonoBehaviour
{
    public GameObject firstCam;
    public GameObject secondCam;

    void Start()
    {
        StartCoroutine(CamSwitcher());
    }

    IEnumerator CamSwitcher()
    {
        yield return new WaitForSeconds(7);
        secondCam.SetActive(true);
        firstCam.SetActive(false);
    }
}
