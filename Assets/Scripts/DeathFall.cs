using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeathFall : MonoBehaviour
{

    public ParticleSystem tpc;

    void Start()
    {
        tpc = gameObject.GetComponent<ParticleSystem>();
        tpc.emissionRate = 0;
        tpc.enableEmission = false;
        // None of this is working!
    }

    void Update()
    {
        if (gameObject.transform.position.y <= -20 && gameObject.transform.position.y >= -60)
        {
            tpc.emissionRate = 1;
            // This neither!
            tpc.Play();
            // And this doesn't work too!
        }
        if (gameObject.transform.position.y <= -60)
        {
            SceneManager.LoadScene(Application.loadedLevel);
            //This restarts the game
        }
    }
}