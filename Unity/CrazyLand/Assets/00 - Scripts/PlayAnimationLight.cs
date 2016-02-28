using UnityEngine;
using System.Collections;

public class PlayAnimationLight : MonoBehaviour {

	public Animation animation;

	public void OnTriggerEnter(Collider col)
	{
		if(!animation.isPlaying)
			animation.Play ();

	}

}
