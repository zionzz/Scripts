using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class card1script : MonoBehaviour {
	
	public Sprite image01;
	public bool condition;

	private Button card1;

	void Start()
	{
		card1 = GetComponent<Button> ();

	}
	void Update()
	{
		if (GameObject.Find ("Pickup").GetComponent<Playerr> ().atk1 == true) {
			card1.image.overrideSprite = image01;
	
		} 
		else {
			card1.image.overrideSprite = null;
		}
	}
}
