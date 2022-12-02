using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class bullet : MonoBehaviour
{
    public float Life;

    void Awake()
    {
        Destroy(gameObject, Life);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<AgentScript>().animator.SetBool("Death_b", true);
            Destroy(other.gameObject, 3);
        }   
    }
}
