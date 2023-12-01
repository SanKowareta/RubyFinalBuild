using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerdownSpeed : MonoBehaviour
{
    public AudioClip collectedClip;
    public float speedmultiplier;

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)

            {
                controller.speed = speedmultiplier;
                // This is Arman's Change
            
                Destroy(gameObject);
            
                controller.PlaySound(collectedClip);
            }
    }
}
