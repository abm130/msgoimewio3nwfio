using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayaText : MonoBehaviour {

	public string text;
	bool display = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider iCollide)
	{
		//Debug.Log ("ENTERED");
		if (iCollide.transform.name == "Player") 
		{
			display = true;
		}

	}

	void OnTriggerExit(Collider uCollide)
	{
		//Debug.Log ("LEFT");
		if (uCollide.transform.name == "Player") 
		{
			display = false;
		}

	}

	void OnGUI()
	{
		if (display == true)
		{
			GUI.Box (new Rect (0, 70, Screen.width, Screen.height - 570), text);
		}
	}
}
