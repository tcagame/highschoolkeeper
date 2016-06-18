using UnityEngine;
using System.Collections;

public class Additional : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D cal){
		if(cal.tag == "enemy1"){
			Score.score1++;

		}
		if(cal.tag == "enemy2"){
			Score.score2++;

		}
		if(cal.tag == "enemy3"){
			Score.score3++;

		}
		if(cal.tag == "enemy4"){
			Score.score4++;

		}
		if(cal.tag == "enemy5"){
			Score.score5++;

		}
		if(cal.tag == "enemy6"){
			Score.score6++;

		}
		if(cal.tag == "enemy7"){
			Score.score7++;

		}
	}

}
