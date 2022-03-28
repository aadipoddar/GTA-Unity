using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocationDisplay : MonoBehaviour
{
    public GameObject locationDisplay;
    public string locationName;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            locationDisplay.GetComponent<Text>().text = locationName;
            locationDisplay.GetComponent<Animator>().Play("LocationDisplay");
            StartCoroutine(ResetLoc());
        }
    }

    IEnumerator ResetLoc()
    {
        yield return new WaitForSeconds(7);
        locationDisplay.GetComponent<Animator>().Play("New State");
        this.gameObject.GetComponent<BoxCollider>().enabled = true;
    }
}
