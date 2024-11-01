using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthColllectable : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
         NewBehaviourScript controller = other.GetComponent<NewBehaviourScript>();
        if (controller != null)
        {
            if (controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
            }
        
        }
     
    }
}
