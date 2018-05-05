using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionComponent : MonoBehaviour {

	public AudioClip collisionClip;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other)
	{
		if(other.relativeVelocity.magnitude > 10){
			GetComponent<AudioSource>().PlayOneShot(collisionClip);
		}
	}
}
