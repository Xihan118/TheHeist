using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    Rigidbody rb;
    public float bulletForce;
    public int damage;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        rb.AddForce(transform.forward * bulletForce * Time.deltaTime, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            HealthScript health = other.GetComponent<HealthScript>();
            health.ApplyDamage(damage);
        }
    }
}
