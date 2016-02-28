using UnityEngine;
using System.Collections;

public class Follower : MonoBehaviour
{
    public Transform cible;
    bool hasTarget = false;
    private AudioSource source;

    //[Header("Cris des moutons")]
    //public AudioClip[] CrisAleatoire;
    //AudioClip LastUsedCrisSound;
    //AudioClip CrisSound;

    void Start()
    {
      //  source = GetComponent<AudioSource>();
    }


    void Update()
    {
        transform.LookAt(cible);

        }

    //void OnBecameVisible()
    //{
    //    do
    //    {
    //        CrisSound = CrisAleatoire[Random.Range(0, 5)];
    //    } while (CrisSound == LastUsedCrisSound);

    //    LastUsedCrisSound = CrisSound;

    //    source.PlayOneShot(CrisSound, 1f);

    //}

}