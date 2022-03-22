using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class A03_VoiceSubs : MonoBehaviour
{
    public GameObject subText;
    public AudioSource voiceLine01;
    public AudioSource voiceLine02;

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
        yield return new WaitForSeconds(1);
        subText.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
        subText.GetComponent<Text>().text = "Lorenzo, I swear it wasn't me.";
        voiceLine02.Play();
        yield return new WaitForSeconds(1.5f);
        subText.GetComponent<Text>().text = "";
    }
}
