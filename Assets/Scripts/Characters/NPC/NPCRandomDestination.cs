using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCRandomDestination : MonoBehaviour
{
    public int genPos;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC")
        {
            genPos = Random.Range(1, 5);

            if (genPos == 4)
                this.gameObject.transform.position = new Vector3(195, 16, 322);

            if (genPos == 3)
                this.gameObject.transform.position = new Vector3(195, 16, 244);

            if (genPos == 2)
                this.gameObject.transform.position = new Vector3(283, 16, 244);

            if (genPos == 1)
                this.gameObject.transform.position = new Vector3(224, 16, 144);
        }
    }
}
