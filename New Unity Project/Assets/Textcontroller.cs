using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textcontroller: MonoBehaviour 
{
	public float removeTextDelay = 1.0f;
	public float removeTyping_delay = 0.05f;
	public float addTyping_delay = 0.1f;
	public string fullText;

	private string _currentText = "";
	private Text _textfield;

	void Start() 
	{
		
		_textfield = gameObject.GetComponent<Text>();
		StartCoroutine(ShowText());
	}

	IEnumerator ShowText() 
	{
		for (int i = 0; i < fullText.Length + 1; i++) 
		{
			_currentText = fullText.Substring (0, i);
			_textfield.text = _currentText;

			yield return new WaitForSeconds(addTyping_delay);
		}

		yield return new WaitForSeconds(removeTextDelay);

		for (int i = fullText.Length; i > -1; i--) 
		{
			_currentText = fullText.Substring (0, i);
			_textfield.text = _currentText;

			yield return new WaitForSeconds(removeTyping_delay);
		}
	}

}
