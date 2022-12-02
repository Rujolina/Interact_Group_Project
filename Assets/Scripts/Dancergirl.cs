using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dancergirl : MonoBehaviour
{
    private Animator anim;

    IEnumerator Start()
    {
        anim = GetComponent<Animator>();

        while (true)
        {
            yield return new WaitForSeconds(2);

            anim.SetInteger("DanceIndex", Random.Range(0, 6));
            anim.SetTrigger("Dance");
        }
    }

}
