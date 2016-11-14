using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class card1script : MonoBehaviour {
	
	public Sprite image01;
	public Sprite image02;
	public bool condition;
	private Button card1;
	public Vector2 myVac;
	public Vector2 myVacold;

	void Start()
	{
		card1 = GetComponent<Button> ();
	}

	void Update()
	{
		if (GameObject.Find ("Pickup").GetComponent<Playerr> ().atk1 == true) {
			card1.image.overrideSprite = image01;
			transform.localPosition = myVac;
		} 	
		else {
			card1.image.overrideSprite = null;
			transform.localPosition = myVacold;
		}
		if (GameObject.Find ("Pickup").GetComponent<Playerr> ().damage1 == 1) {
			card1.image.overrideSprite = image02;
		}
	}
}
