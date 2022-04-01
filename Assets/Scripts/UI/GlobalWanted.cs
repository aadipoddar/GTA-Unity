using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalWanted : MonoBehaviour
{
    public GameObject[] wantedStars;
    public bool addingStar;
    public static int wantedLevel;
    public static bool activateStar;

    void Update()
    {
        if (addingStar == false && activateStar == true)
        {
            activateStar = false;
            addingStar = true;
            StartCoroutine(AddStar());
        }
    }

    IEnumerator AddStar()
    {
        wantedStars[wantedLevel - 1].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        wantedStars[wantedLevel - 1].SetActive(false);
        yield return new WaitForSeconds(0.5f);
        wantedStars[wantedLevel - 1].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        wantedStars[wantedLevel - 1].SetActive(false);
        yield return new WaitForSeconds(0.5f);
        wantedStars[wantedLevel - 1].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        wantedStars[wantedLevel - 1].SetActive(false);
        yield return new WaitForSeconds(0.5f);
        wantedStars[wantedLevel - 1].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        wantedStars[wantedLevel - 1].SetActive(false);
        yield return new WaitForSeconds(0.5f);
        wantedStars[wantedLevel - 1].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        wantedStars[wantedLevel - 1].SetActive(false);
        yield return new WaitForSeconds(0.5f);
        wantedStars[wantedLevel - 1].SetActive(true);
    }
}
