using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float Rotatespeed;
    [SerializeField] AudioClip engine;
    [SerializeField] ParticleSystem main_particle,left_particle, right_particle;

    Rigidbody rg;
    AudioSource audio_;
    
    
    void Start()
    {
        rg = GetComponent<Rigidbody>();
        audio_ = GetComponent<AudioSource>();
    }

   
    void Update()
    {
        Move();
        Rotate();
        exit();
    }


    void Move()
    {
        Moving();
    }


    void Rotate()
    {
        Rotating();
    }





    //------------------------------------------------------------


    void Moving()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rg.AddRelativeForce(Vector3.up * speed * Time.deltaTime);
            if (!audio_.isPlaying)
            {
                main_particle.Play();
                audio_.PlayOneShot(engine);
            }

        }

        else
        {
            audio_.Stop();
            main_particle.Stop();
        }
    }








    //------------------------------------------------------------






    void Rotating()
    {
        if (Input.GetKey(KeyCode.A))
        {
            RotateSpeed(Rotatespeed);
            if (!right_particle.isPlaying)
            {
                right_particle.Play();
            }

        }

        else if (Input.GetKey(KeyCode.D))
        {
            RotateSpeed(-Rotatespeed);
            if (!left_particle.isPlaying)
            {
                left_particle.Play();
            }
        }
        else
        {
            left_particle.Stop();
            right_particle.Stop();
        }
    }







    //------------------------------------------------------------







    void RotateSpeed(float Ro_speed)
    {
        rg.freezeRotation = true;
        transform.Rotate(Vector3.forward * Ro_speed * Time.deltaTime);
        rg.freezeRotation = false;
    }




    //------------------------------------------------------------



    void exit()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            print("you quitted");
            Application.Quit();
        }
    }


}
