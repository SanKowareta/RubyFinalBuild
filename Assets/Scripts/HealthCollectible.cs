using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HealthCollectible : MonoBehaviour
{
    public AudioClip collectedClip;
    public GameObject PickupParticlesPrefab;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            if (controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                GameObject PickupParticlesObject = Instantiate(PickupParticlesPrefab, transform.position, Quaternion.identity);
                // ParticleSystem particleSystem = PickupParticleObject.GetComponent<ParticleSystem>();
                // particleSystem.Start();
                Destroy(gameObject);
            
                controller.PlaySound(collectedClip);
            }
        }

    }
}