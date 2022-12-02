using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour
{
    public GameObject theNPC;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            theNPC.GetComponent<Animator>().Play("Dances");
        }
    }
}
