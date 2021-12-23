using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyController : MonoBehaviour
{
    public Transform Target;
    public bool TriggerDetection;
    public Animator anim;
    public float orientationOffset;

    public UnityEvent OnIdle;
    public UnityEvent OnDetected;

    public float rotationSpeed;

    float timeBtwShot;
    public float startTimeBtwShot;
    public GameObject ShotAudio;
    public Animator WeaponAnim;
    public Transform shotPos;
    public GameObject muzzleFlash;

    public bool canFire = true;
    public int Damage;

    void Start()
    {

    }

    
    void Update()
    {
        if (TriggerDetection)
        {
            OnDetected.Invoke();
            anim.SetBool("Triggered", true);

            if (timeBtwShot <= 0 && canFire)
            {
                muzzleFlash.SetActive(true);
                Instantiate(ShotAudio, shotPos);
                timeBtwShot = startTimeBtwShot;
                WeaponAnim.SetTrigger("Shoot");

                
                RaycastHit hit;
                if (Physics.Raycast(shotPos.position, shotPos.forward, out hit, 1000)) {
                    if (hit.transform.tag == "Player") {
                        HealthScript health = hit.transform.GetComponent<HealthScript>();
                        health.ApplyDamage(Damage);
                    }
                }

            }
            else {
                timeBtwShot -= Time.deltaTime;
            }
        }
        else {
            OnIdle.Invoke();
        }
    }

    public void CantFire() {
        canFire = false;
    }

}

