using UnityEngine;
using System.Collections;

public class Follower2 : MonoBehaviour {

    bool hasTarget = false;
    private AudioSource source;
    
    [Header("Cris des moutons")]
    public AudioClip[] CrisAleatoire;
    AudioClip LastUsedCrisSound;
    AudioClip CrisSound;

    void Start()
    {
        source = GetComponent<AudioSource>();
        //CrisAleatoire = new AudioClip[]
        //{
        //    (AudioClip)Resources.Load("01 - Son/cris1.wav"),
        //    (AudioClip)Resources.Load("01 - Son/cris2.wav"),
        //    (AudioClip)Resources.Load("01 - Son/cris3.wav"),
        //    (AudioClip)Resources.Load("01 - Son/cris4.wav"),
        //    (AudioClip)Resources.Load("01 - Son/cris5.wav"),
        //};
    }
    // Update is called once per frame
    void Update()
    {
        NavMeshAgent na = GetComponent<NavMeshAgent>();
        GetComponent<Animator>().SetBool("Go", true);
  

        if (!hasTarget)
        {
            na.destination = Camera.main.transform.position;
            hasTarget = true;
        }

            if (na.velocity.magnitude < 0.5 ||
            Vector3.Distance(na.destination, Camera.main.transform.position) > 3)
            GetComponent<Animator>().SetBool("Go", false);
        hasTarget = false;
    }
    
    void OnBecameVisible()
    {
        Debug.Log("Visible");
        do
        {
            CrisSound = CrisAleatoire[Random.Range(0, 5)];
        } while (CrisSound == LastUsedCrisSound);

        LastUsedCrisSound = CrisSound;

        source.PlayOneShot(CrisSound, 1f);

    }

    void OnBecameInvisible()
    {
        Debug.Log("InVisible");
    }

}