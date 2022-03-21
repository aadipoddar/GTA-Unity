using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A01_CamSwitch : MonoBehaviour
{
    public GameObject firstCam;
    public GameObject secondCam;
    public GameObject credLeadDes;

    void Start()
    {
        StartCoroutine(CamSwitcher());
    }

    IEnumerator CamSwitcher()
    {
        yield return new WaitForSeconds(3);
        credLeadDes.SetActive(true);
        yield return new WaitForSeconds(4);
        secondCam.SetActive(true);
        firstCam.SetActive(false);
    }
}
