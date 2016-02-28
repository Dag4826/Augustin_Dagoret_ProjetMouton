using UnityEngine;
using System.Collections;

public class Mine : MonoBehaviour
{

    public Transform mouton;
    public Vector3 Spawn = new Vector3(0, 1, 0);
    


    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
           // Debug.Log("Coucou");
            GameObject b = Instantiate(mouton, Spawn, Quaternion.identity) as GameObject;
            Destroy(this.gameObject);
 
        }
    }
}

