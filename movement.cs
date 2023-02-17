using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    //[SerializeField] float yValue=0.02f;
    [SerializeField] float speed = 0f;
    int hits=0;
 
    void Start()
    {
        
    }

    void Update()
    {
        Movement();
        print((int)Time.time+" seconds passed");
    }


    void Movement()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(-xValue, 0, -zValue);
    }


    private void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.tag != "Hit")
        {
            hits++;
            print("You hit " + hits);
        }
        
    }
}
