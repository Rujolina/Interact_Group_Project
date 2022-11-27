using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyInstant : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject myGameObject = new GameObject("Test Object"); // Make a new GO.
        Rigidbody gameObjectsRigidBody = myGameObject.AddComponent<Rigidbody>(); // Add the rigidbody.
        gameObjectsRigidBody.mass = 5; // Set the GO's mass to 5 via the Rigidbody.

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
