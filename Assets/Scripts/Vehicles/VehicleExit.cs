using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class VehicleExit : MonoBehaviour
{
    public GameObject vehicleCam;
    public GameObject thePlayer;
    public GameObject liveVehicle;
    public GameObject entryTrig;
    public GameObject miniMapCam;
    public GameObject playerPoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            thePlayer.SetActive(true);
            vehicleCam.SetActive(false);
            playerPoint.SetActive(false);

            liveVehicle.GetComponent<CarController>().enabled = false;
            liveVehicle.GetComponent<CarUserControl>().enabled = false;
            liveVehicle.GetComponent<CarAudio>().enabled = false;

            thePlayer.transform.parent = null;

            miniMapCam.transform.parent = thePlayer.transform;
            miniMapCam.transform.localEulerAngles = new Vector3(90, 0, 0);
            miniMapCam.transform.localPosition = new Vector3(0, 25, 0);

            CharControl.isStepping = false;

            StartCoroutine(EnterAgain());
        }
    }

    IEnumerator EnterAgain()
    {
        yield return new WaitForSeconds(0.5f);
        entryTrig.gameObject.GetComponent<BoxCollider>().enabled = true;
        this.gameObject.SetActive(false);
    }
}
