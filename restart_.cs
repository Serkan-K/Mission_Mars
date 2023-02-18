using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class restart_ : MonoBehaviour
{
    


    // Update is called once per frame
    public void Restart_()
    {
        SceneManager.LoadScene("level1");
    }
}
