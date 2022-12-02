using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changecolor : MonoBehaviour
{

    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {

        rend.material.color = GetRandomColor();
    }

    Color GetRandomColor()
    {
        return new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }
}