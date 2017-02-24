using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float horizontalSpeed;
	public float verticalSpeed;
	public float amplitude;
	public Vector3 tempPosition;

	// Use this for initialization
	void Start () {
		tempPosition = transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		tempPosition.z += horizontalSpeed;
		tempPosition.y = Mathf.Sin (Time.realtimeSinceStartup * verticalSpeed) * amplitude;
		transform.position = tempPosition;
	}
}
