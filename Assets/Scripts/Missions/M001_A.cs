using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M001_A : MonoBehaviour
{
    public GameObject tonyCam;
    public GameObject thePlayer;
    public GameObject fadeIn;
    public GameObject fadeOut;
    public GameObject subText;
    public GameObject cashCount;
    public GameObject ammoCount;
    public GameObject hintBox;
    public GameObject miniMap;

    public AudioSource tonyLine;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(TonyMeet());
    }

    IEnumerator TonyMeet()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;

        fadeOut.SetActive(true);

        yield return new WaitForSeconds(1.5f);

        cashCount.SetActive(false);
        ammoCount.SetActive(false);
        hintBox.SetActive(false);
        miniMap.SetActive(false);
        tonyCam.SetActive(true);

        thePlayer.GetComponent<CharControl>().enabled = false;

        fadeIn.SetActive(true);
        fadeOut.SetActive(false);

        yield return new WaitForSeconds(1.5f);

        fadeIn.SetActive(false);
        subText.SetActive(true);
        tonyLine.Play();

        yield return new WaitForSeconds(7);

        subText.SetActive(false);

        yield return new WaitForSeconds(0.5f);

        fadeOut.SetActive(true);

        yield return new WaitForSeconds(1.5f);

        tonyCam.SetActive(false);

        thePlayer.GetComponent<CharControl>().enabled = true;

        fadeIn.SetActive(true);
        fadeOut.SetActive(false);
        cashCount.SetActive(true);
        ammoCount.SetActive(true);
        hintBox.SetActive(true);
        miniMap.SetActive(true);

        yield return new WaitForSeconds(1.5f);

        fadeIn.SetActive(false);
    }
}
