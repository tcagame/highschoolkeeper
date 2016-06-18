using UnityEngine;
using System.Collections;

public class PlayerControllerr : MonoBehaviour {

	private bool isJumpRequest;
	private bool isJumpflag;
	public float power = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if( Input.GetMouseButtonDown (0) && isJumpflag == true ){

			isJumpRequest = true;

		}

	}

	void FixedUpdate () {

		if (isJumpRequest) {

			isJumpRequest = false;
			isJumpflag = false;

			GetComponent<Rigidbody2D>().velocity = Vector2.up * power;

		}

	}

	void OnTriggerEnter2D(Collider2D cal){
		if(cal.tag == "Ground"){
			isJumpflag = true;
		}
	}

}
