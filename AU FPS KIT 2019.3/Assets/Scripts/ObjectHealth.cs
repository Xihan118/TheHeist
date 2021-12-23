using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHealth : MonoBehaviour
{
    public float hitPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }



    public void ApplyDamage(int damage)
    {
        if (hitPoints <= 0) return;

        hitPoints -= damage;
        if (hitPoints <= 0) { 
        
        }
    }
}
