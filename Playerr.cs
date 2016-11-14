using UnityEngine;
using UnityEngine.UI;

public class Playerr : MonoBehaviour {

    public Text countText;          //Store a reference to the UI Text component which will display the number of pickups collected.
    public Text winText;            //Store a reference to the UI Text component which will display the 'You win' message.
	public Text damageText;
	public Text card01;
	public Text card02;
	public bool atk1;
	private int count;              //Integer to store the number of pickups collected so far.
	private int damage;
	public int damage1;
	private int damage2;
    // Use this for initialization
    void Start()
    {
		resetdamage ();
        //Initialize count to zero.
        count = 100;

        //Initialze winText to a blank string since we haven't won yet at beginning.
        winText.text = "";

        //Call our SetCountText function which will update the text with the current value for count.
        SetCountText();

		damageText.text = "";
		card01.text = damage1.ToString();
		card02.text = damage2.ToString();
    }

    //This function updates the text displaying the number of objects we've collected and displays our victory message if we've collected all of them.
    void SetCountText()
    {
        //Set the text property of our our countText object to "Count: " followed by the number stored in our count variable.
        countText.text = "Count: " + count.ToString();
		damageText.text = "-" + damage.ToString ();
        //Check if we've collected all 12 pickups. If we have...
        if (count <= 0)
            //... then set the text property of our winText object to "You win!"
            winText.text = "You win!";
    }

    public void Attacking()
    {
		if (damage1 > 0)
		if (damage2 > 0) 
			damage = damage1 + damage2;
			count = count - damage;
			SetCountText ();
			resetdamage ();
    }

	public void card1()
	{
		if (damage1 > 0) {
			damage1 = 0;
			atk1 = false;
		} else {
			damage1 = Random.Range (1, 4);
			atk1 = true;
		}
		card01.text = damage1.ToString();

	}
	public void card2()
	{
		if (damage2 > 0)
			damage2 = 0;
		else
		damage2 = Random.Range (10, 20);
		card02.text = damage2.ToString();
	}
	void resetdamage()
	{
		damage = 0;
		damage1 = 0;
		damage2 = 0;
		card01.text = damage1.ToString();
		card02.text = damage2.ToString();
		atk1 = false;
	}

}