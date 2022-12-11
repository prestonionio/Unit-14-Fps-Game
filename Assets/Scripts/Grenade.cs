using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    //variables
    public GameObject explosionEffect;
    public float delay = 3f;

    public float explosionForce = 10f;
    public float radius = 20f;

    void Start()
    {
        Invoke("Explode", delay);
    }

    void Explode()
    {
        //Checking nearby coliders
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        //Applying force
        foreach(Collider near in colliders)
        {
            Rigidbody rig = near.GetComponent<Rigidbody>();
            
            if(rig!=null)
            rig.AddExplosionForce(explosionForce, transform.position, radius ,1f, ForceMode.Impulse);
        }

        //Explosion effect
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
