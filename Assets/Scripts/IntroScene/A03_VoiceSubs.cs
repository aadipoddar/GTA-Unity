using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class A03_VoiceSubs : MonoBehaviour
{
    public GameObject subText;
    public AudioSource voiceLine01;
    public AudioSource voiceLine02;
    public AudioSource voiceLine03;
    public AudioSource voiceLine04;
    public AudioSource voiceLine05;
    public AudioSource loudBang;

    public GameObject fullBack;
    public GameObject deathObject;
    public GameObject theSack;
    public GameObject theCop;
    public GameObject theChar;
    public GameObject theGun;
    public GameObject thirdCam;
    public GameObject fourCam;
    public GameObject fadeIn;
    public GameObject fadeOut;

    void Start()
    {
        StartCoroutine(IntroSubs());
    }

    IEnumerator IntroSubs()
    {
        yield return new WaitForSeconds(8);
        subText.GetComponent<Text>().text = "You asked for this George.";
        voiceLine01.Play();
        subText.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        subText.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(0.8f);
        subText.GetComponent<Text>().text = "Lorenzo, I swear it wasn't me.";
        voiceLine02.Play();
        yield return new WaitForSeconds(2.1f);
        subText.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(0.5f);
        subText.GetComponent<Text>().text = "You squeal on Horseface, you sleepin' with the fishes.";
        voiceLine03.Play();
        yield return new WaitForSeconds(3);
        subText.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(0.1f);
        subText.GetComponent<Text>().text = "Lorenzo! Please!";
        voiceLine04.Play();
        yield return new WaitForSeconds(0.7f);
        subText.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(0.3f);
        loudBang.Play();
        fullBack.SetActive(true);
        deathObject.SetActive(true);
        theChar.SetActive(false);
        theCop.SetActive(false);
        theSack.SetActive(false);
        theGun.SetActive(false);
        yield return new WaitForSeconds(2);
        subText.GetComponent<Text>().text = "My name is Steve Lorenzo";
        voiceLine05.Play();
        yield return new WaitForSeconds(2);
        fadeIn.SetActive(false);
        fadeIn.SetActive(true);
        fullBack.SetActive(false);
        thirdCam.SetActive(false);
        fourCam.SetActive(true);
        subText.GetComponent<Text>().text = "Three years ago Jimmy Horseface tries to have me whacked. Set me up.";
        yield return new WaitForSeconds(5);
        subText.GetComponent<Text>().text = "Now it's time for me to return that favour.";
        yield return new WaitForSeconds(3);
        subText.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }
}
