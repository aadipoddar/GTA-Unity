using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AA_Opening : MonoBehaviour
{
    public GameObject fadeIn;
    public GameObject theText;
    public GameObject initialCamera;
    public GameObject fadeOut;
    public GameObject thePlayer;
    public GameObject killerFake;
    public GameObject cashCount;
    public GameObject ammoCount;
    public GameObject hintBox;
    public GameObject miniMap;

    void Start()
    {
        StartCoroutine(OpenBegin());
    }

    IEnumerator OpenBegin()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        yield return new WaitForSeconds(1);

        theText.SetActive(true);

        yield return new WaitForSeconds(7);

        fadeIn.GetComponent<Animator>().enabled = true;
        initialCamera.GetComponent<Animator>().enabled = true;

        yield return new WaitForSeconds(3);

        fadeOut.SetActive(true);
        fadeIn.SetActive(false);

        yield return new WaitForSeconds(2.5f);

        killerFake.SetActive(false);
        thePlayer.SetActive(true);
        initialCamera.SetActive(false);

        yield return new WaitForSeconds(0.5f);

        fadeOut.SetActive(false);
        fadeIn.SetActive(true);

        cashCount.SetActive(true);
        ammoCount.SetActive(true);
        hintBox.SetActive(true);
        miniMap.SetActive(true);

        fadeIn.GetComponent<Animator>().Play("FadeInAnim");

        yield return new WaitForSeconds(4);
        fadeIn.SetActive(false);

        GlobalHint.hintNumber = 1;

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
