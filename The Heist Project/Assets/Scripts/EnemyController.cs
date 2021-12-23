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


    void Start()
    {

    }

    
    void Update()
    {
        if (TriggerDetection)
        {
            OnDetected.Invoke();
            anim.SetBool("Triggered", true);

            if (timeBtwShot <= 0)
            {
                muzzleFlash.SetActive(true);
                Instantiate(ShotAudio, shotPos);
                timeBtwShot = startTimeBtwShot;
                WeaponAnim.SetTrigger("Shoot");
            }
            else {
                timeBtwShot -= Time.deltaTime;
            }
        }
        else {
            OnIdle.Invoke();
        }
    }
}

