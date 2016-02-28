using UnityEngine;
using System.Collections;

public class Cam2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
       
        float temps = Time.deltaTime * -2;
        transform.Translate(temps, 0, 0);


        Debug.Log(transform.position);
        //Camera.main.transform.position = Vector3(50,50,50);
    }

}
