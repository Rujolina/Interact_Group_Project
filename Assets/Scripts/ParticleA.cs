using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class ParticleA : MonoBehaviour
{

    public ParticleSystem ps;

    public void OnParticle1(InputAction.CallbackContext context)

    {
        ps.Emit(1000);

    }

    public void OnParticle2 (InputAction.CallbackContext context)
    {
        if (context.interaction is HoldInteraction)
        {
            ps.Emit(1000);
        }
    }
}
