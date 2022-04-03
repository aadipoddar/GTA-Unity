using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class VehicleEntry : MonoBehaviour
{
    public GameObject vehicleCam;
    public GameObject thePlayer;
    public GameObject liveVehicle;
    public GameObject exitTrig;
    public GameObject miniMapCam;
    public GameObject interactUI;
    public GameObject interactText;
    public bool canEnter = false;

    void Update()
    {
        if (canEnter == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                this.gameObject.GetComponent<BoxCollider>().enabled = false;

                vehicleCam.SetActive(true);
                thePlayer.SetActive(false);

                liveVehicle.GetComponent<CarController>().enabled = true;
                liveVehicle.GetComponent<CarUserControl>().enabled = true;
                liveVehicle.GetComponent<CarAudio>().enabled = true;

                canEnter = false;

                thePlayer.transform.parent = this.gameObject.transform;

                miniMapCam.transform.parent = liveVehicle.transform;
                miniMapCam.transform.localEulerAngles = new Vector3(90, 0, 0);
                miniMapCam.transform.localPosition = new Vector3(0, 25, 0);

                interactText.GetComponent<Text>().text = "";
                interactUI.SetActive(false);

                GlobalHint.hintNumber = 2;

                StartCoroutine(ExitTrigger());
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            canEnter = true;
            interactText.GetComponent<Text>().text = "Enter Vehicle";
            interactUI.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        canEnter = false;
        interactText.GetComponent<Text>().text = "";
        interactUI.SetActive(false);
    }

    IEnumerator ExitTrigger()
    {
        yield return new WaitForSeconds(0.5f);
        exitTrig.SetActive(true);
    }
}
