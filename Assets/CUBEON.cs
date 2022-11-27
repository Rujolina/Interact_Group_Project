using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUBEON : MonoBehaviour
{
    public float push = 20f;
    public AudioSource soundPlayer;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            this.gameObject.AddComponent<Rigidbody>();
            //this.gameObject.AddComponent<ConstantForce>();
            soundPlayer.Play();
           // if (Input.GetKeyDown(KeyCode.Mouse0))
            //{
               // bub.AddForce(-transform.forward * 500);
                //bub.useGravity = true;
            //}
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            soundPlayer.Stop();
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            soundPlayer.Pause();
        }
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            soundPlayer.UnPause();
        }


    }

}
