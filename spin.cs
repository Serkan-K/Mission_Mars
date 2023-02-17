using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
   [SerializeField] float xAngle;
   [SerializeField] float yAngle;
   [SerializeField] float zAngle;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(xAngle,yAngle,zAngle);
    }
}
