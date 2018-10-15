using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player_Controller : MonoBehaviour {

	public float speed;
	//public Text countText;
	//public Text winText;
	//public Text timeText;
	//public Text loseText;
	//public Text endTimeText;
	//public Text readyText;

	private Rigidbody rb;
	//private int count;
	//private int time;
	//private bool timeset;
	//private bool setStart = false;
	//private string timetext;
	

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		//timeset = (true);
		//count = 7;
		//time = 0;
		//SetCountText ();
		//winText.text = "";
		//loseText.text = "";
		//timeText.text = "";
		//endTimeText.text = "";
		//InvokeRepeating ("SetTimeText", 0.0f, 1.0f);
		//readyText.text = "Press space to start";

	}
	

	void FixedUpdate ()
	{
		//if (Input.GetButton("Jump"))
		//{
		//	setStart = true;
		//	readyText.text = "";
		//}
		if (true)
		{
			float moveHorizontal = Input.GetAxis ("Horizontal");
			float moveVertical = Input.GetAxis ("Vertical");

			Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

			rb.AddForce (movement * speed);
		}
	}
}