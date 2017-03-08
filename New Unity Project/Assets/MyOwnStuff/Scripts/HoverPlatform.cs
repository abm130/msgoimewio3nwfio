using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverPlatform : MonoBehaviour {

	public float hoverForce = 1f;

	void OnTriggerEnter (Collider other)
	{
		Debug.Log ("Object entered trigga");
	}
	void OnTriggerStay(Collider other)
	{
		Debug.Log ("Object is within trigga");
		other.GetComponent<Rigidbody>().AddForce(Vector3.up * hoverForce);﻿
	}
	void OnTriggerExit (Collider other)
	{
		Debug.Log ("Object Exited trigger");
	}


}
