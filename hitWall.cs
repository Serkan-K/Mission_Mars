using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitWall : MonoBehaviour
{


    void OnCollisionEnter(Collision w)
    {
        if (w.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;

            gameObject.tag = "Hit";
        }
    }
}
