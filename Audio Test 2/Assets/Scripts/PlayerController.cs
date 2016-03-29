	using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody> (); 
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical); 
		
			rb.AddForce (movement * speed); 

		/*IEnumerator OnTriggerEnter(Collider trigger) {

			/Collectibles 1-3 Correct Sequence
			if (isCollecting == "Beginning" && trigger.gameObject.CompareTag("PickUp1")){
				trigger.gameObject.SetActive (false);
				isCollecting = "First";
			}
			if (isCollecting == "First" && trigger.gameObject.CompareTag("PickUp2")){
				trigger.gameObject.SetActive (false);
				isCollecting = "Second";
			}

			if (isCollecting == "Second" && trigger.gameObject.CompareTag("PickUp3")){
				trigger.gameObject.SetActive (false);
				isCollecting = "Third";
				this.GetComponent<AudioSource>().Play
			}*/
	}

	void onTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag("Pickup1"))
		{ 
			other.gameObject.SetActive (false);
		}	  
	}
}