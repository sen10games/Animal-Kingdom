using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxhealth;
    [HideInInspector]
    public float currenthealth;
    Ragdoll ragdoll;
    void Start()
    {
        ragdoll = GetComponent<Ragdoll>();
        currenthealth = maxhealth;
    }

   
    public void TakeDamage(float amount)
    {
        currenthealth -=amount;
        if (currenthealth <= 0.0f ){
            Die();
        }
    }
    private void Die(){
        ragdoll.ActivateRagdoll();
    }
}
