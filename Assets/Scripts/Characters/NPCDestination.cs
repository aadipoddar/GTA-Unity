using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDestination : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC")
        {
            this.gameObject.transform.position = new Vector3(225, 16, 144);
        }
    }
}
