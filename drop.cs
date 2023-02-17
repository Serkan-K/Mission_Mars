using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{
    [SerializeField] float TimetoWait = 0f;
    MeshRenderer rend;
    Rigidbody rg;

    private void Start()
    {
        rend = GetComponent<MeshRenderer>();
        rg = GetComponent<Rigidbody>();

        rend.enabled = false;
        rg.useGravity = false;
    }

    void Update()
    {
        if (Time.time > TimetoWait)
        {
            rend.enabled = true;
            rg.useGravity = true;
        }    
    }
}
