using UnityEngine;
using System.Collections;

public class Cam1 : MonoBehaviour
{

  


   

    void Start()
    {

      
    }
    // Update is called once per frame
    void Update()
    {
        //NavMeshAgent na = GetComponent<NavMeshAgent>();
        //Vector3 newPosition = this.transform.position;

        float temps = Time.deltaTime * -2;
        transform.Translate(0, temps, 0);


        Debug.Log(transform.position);
        //Camera.main.transform.position = Vector3(50,50,50);
    } 

   

}