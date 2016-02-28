using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour {

    public AudioSource Cris;
   


    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
        //   Debug.Log("Coucou");

            Cris.Play();

            Destroy(this.gameObject);

        }
    }
}


