using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetNPC : MonoBehaviour
{
    public AudioClip CatClip;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController >();

        if (controller != null)
        {
            controller.PlaySound(CatClip);
        }
    }
}
