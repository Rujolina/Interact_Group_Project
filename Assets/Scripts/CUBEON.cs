using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUBEON : MonoBehaviour
{

    Rigidbody m_Rigidbody;
    public AudioSource soundPlayer;


    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            soundPlayer.Play();
            m_Rigidbody.constraints = RigidbodyConstraints.None;
            //this.GetComponent<Changecolor>().enabled = true;


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

    void OnMouseDown()
    {

    }

}
