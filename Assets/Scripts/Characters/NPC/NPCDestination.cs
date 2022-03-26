using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDestination : MonoBehaviour
{
    public int trigNum;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC")
        {
            if (trigNum == 3)
            {
                this.gameObject.transform.position = new Vector3(195, 16, 144);
                trigNum = 0;
            }

            if (trigNum == 2)
            {
                this.gameObject.transform.position = new Vector3(195, 16, 222);
                trigNum = 3;
            }

            if (trigNum == 1)
            {
                this.gameObject.transform.position = new Vector3(135, 16, 222);
                trigNum = 2;
            }

            if (trigNum == 0)
            {
                this.gameObject.transform.position = new Vector3(135, 16, 144);
                trigNum = 1;
            }
        }
    }
}
