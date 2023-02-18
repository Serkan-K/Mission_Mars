using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundtrack : MonoBehaviour
{
    public static bool musicOn;
    void Start()
    {
        if (!musicOn)
        {
            GameObject.DontDestroyOnLoad(gameObject);
            musicOn = true;
        }

        else
        {
            Destroy(gameObject);
        }



    }
}
