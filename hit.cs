
using UnityEngine;
using UnityEngine.SceneManagement;

public class hit : MonoBehaviour
{
    [SerializeField] AudioClip crash, success;
    [SerializeField] ParticleSystem crash_particle, success_particle;

    AudioSource audioo_;
    ParticleSystem particle_;
    bool transitating = false;
    bool collison_disabled=false;


    void Start()
    {
        audioo_ = GetComponent<AudioSource>();
        
    }


    void Update()
    {
        Cheat_codes();
    }





    void OnCollisionEnter(Collision h)
    {

        if (transitating || collison_disabled) { return; }
        {
            switch (h.gameObject.tag)
            {


                case "friendly":
                    print("friend");
                    break;
                case "Finish":
                    delay_next();
                    break;
                case "fuel":
                    print("fueled");
                    break;
                default:
                    print("blew up");
                    delay_restart();
                    break;
            }
        }
    }


    void delay_restart()
    {
        transitating = true;
        audioo_.Stop();
        audioo_.PlayOneShot(crash);
        crash_particle.Play();

        GetComponent<Movement>().enabled = false;
        Invoke("level",0.5f);
    }

    void delay_next()
    {
        transitating = true;
        audioo_.Stop();
        audioo_.PlayOneShot(success);
        success_particle.Play();

        GetComponent<Movement>().enabled = false;
        Invoke("next_level", 0.5f);
    }



    void level()
    {
        int level_number = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(level_number);
    }


    void next_level()
    {
        audioo_.PlayOneShot(success);
        int level_number = SceneManager.GetActiveScene().buildIndex;
        int next_level_number = level_number + 1;

        if (next_level_number== SceneManager.sceneCountInBuildSettings)
        {
            next_level_number = 0;
        }

        SceneManager.LoadScene(next_level_number);
    }


    void Cheat_codes()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            next_level();
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            collison_disabled = !collison_disabled;
        }
    }



}
