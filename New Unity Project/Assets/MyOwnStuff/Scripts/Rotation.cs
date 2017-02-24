using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
	public float xspeed = 0.05f;
	public float yspeed = 0.05f;
	public float zspeed = 0.05f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (xspeed, yspeed, zspeed);
	}
}
