using UnityEngine;
using System.Collections;

public class MoveFeed : MonoBehaviour {

	public float speed = 4;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	 
	}

	void FixedUpdate ()

	{

		GetComponent<Rigidbody2D>().velocity = -Vector2.right * speed;

	}

	void OnTriggerEnter2D(Collider2D cal){
		if(cal.tag == "Player"){
			Destroy(gameObject);
		}
	}

}
