using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowCom : MonoBehaviour {

	public GameObject BallPrefab;
	public float speed = 15.0f;

	void Update () {
		if(Input.GetButtonUp("Fire1")){
			GameObject newObj = Instantiate(BallPrefab);
			newObj.GetComponent<Rigidbody>().position = transform.position;
			newObj.GetComponent<Rigidbody>().velocity = transform.forward * speed;

			Destroy(newObj, 3f);
		}
	}
}
