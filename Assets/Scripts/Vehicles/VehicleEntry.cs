using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class VehicleEntry : MonoBehaviour
{
    public GameObject vehicleCam;
    public GameObject thePlayer;
    public GameObject liveVehicle;
    public GameObject exitTrig;
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

                StartCoroutine(ExitTrigger());
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            canEnter = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            canEnter = false;
        }
    }

    IEnumerator ExitTrigger()
    {
        yield return new WaitForSeconds(0.5f);
        exitTrig.SetActive(true);
    }
}
