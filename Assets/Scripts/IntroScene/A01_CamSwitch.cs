using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A01_CamSwitch : MonoBehaviour
{
    public GameObject firstCam;
    public GameObject secondCam;
    public GameObject thirdCam;
    public GameObject credLeadDes;
    public GameObject credStory;

    void Start()
    {
        StartCoroutine(CamSwitcher());
    }

    IEnumerator CamSwitcher()
    {
        yield return new WaitForSeconds(2);
        credLeadDes.SetActive(true);
        yield return new WaitForSeconds(5);
        credStory.SetActive(true);
        secondCam.SetActive(true);
        firstCam.SetActive(false);
        yield return new WaitForSeconds(5);
        thirdCam.SetActive(true);
        secondCam.SetActive(false);
    }
}
