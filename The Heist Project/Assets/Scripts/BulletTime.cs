using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTime : MonoBehaviour
{
    public bool canSlow = true;
    public bool onStart = false;

    public AudioSource audioStart;
    public AudioSource audioEnd;
    public AudioSource audioBeat;

    public float speed;
    public float time;

    void Start()
    {
        if (onStart) {
            Time.timeScale = speed;
            canSlow = false;
            audioStart.Play();
            Invoke("Beat", 0.859f);
            StartCoroutine("EndBulletTime");
        }
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H) && canSlow) {
            Time.timeScale = speed;
            canSlow = false;
            audioStart.Play();
            Invoke("Beat", 0.859f);
            StartCoroutine("EndBulletTime");
        }
    }

    void Beat() { audioBeat.Play(); }


    IEnumerator EndBulletTime() {
        yield return new WaitForSeconds(time);
        Time.timeScale = 1;
        audioBeat.Stop();
        audioEnd.Play();
    }
}


