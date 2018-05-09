using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowCom : MonoBehaviour {

	public GameObject BallPrefab;
	public float speed = 15.0f;
	public float rot;
	Quaternion rotQuat;

	void Start(){

	}

	void Update () {
		rotQuat = Quaternion.Euler(rot, 0, 0);
		if(Input.GetButtonUp("Fire1")){
			GameObject newObj = Instantiate(BallPrefab);
			newObj.GetComponent<Rigidbody>().position = transform.position;
			newObj.GetComponent<Rigidbody>().velocity = rotQuat * transform.forward * speed;
			Destroy(newObj, 3f);
		}
	}
}
