using UnityEngine;
using System.Collections;

public class FeedManager : MonoBehaviour {

	public GameObject feed1Object;
	public GameObject feed2Object;
	public GameObject feed3Object;
	public GameObject feed4Object;
	public GameObject feed5Object;
	public GameObject feed6Object;
	public GameObject feed7Object;

	private int feedcount = 0;

	float nextSpawnTime = 0;

	float interval = 1;

	// Use this for initialization
	void Start () {

	}

	void Update()

	{

		if( nextSpawnTime < Time.timeSinceLevelLoad)

		{

			nextSpawnTime = Time.timeSinceLevelLoad + interval;

			LocalInstantate();

		}

	}

	void LocalInstantate ()

	{

		float y = Random.Range (-3f, 3f);

		// オブジェクトの生成して子オブジェクトに登録


		switch (feedcount) {
		case 0:
			GameObject obj1 = (GameObject)GameObject.Instantiate (feed1Object);

			obj1.transform.parent = transform;

			obj1.transform.localPosition = new Vector3(9, y, 0);
			feedcount = 1;
			break;

		case 1:
			GameObject obj2 = (GameObject)GameObject.Instantiate (feed2Object);

			obj2.transform.parent = transform;


			obj2.transform.localPosition = new Vector3 (9, y, 0);
			feedcount = 2;
			break;

		case 2:
			GameObject obj3 = (GameObject)GameObject.Instantiate (feed3Object);

			obj3.transform.parent = transform;

			obj3.transform.localPosition = new Vector3(9, y, 0);
			feedcount = 3;
			break;

		case 3:
			GameObject obj4 = (GameObject)GameObject.Instantiate (feed4Object);

			obj4.transform.parent = transform;

			obj4.transform.localPosition = new Vector3(9, y, 0);
			feedcount = 4;
			break;

		case 4:
			GameObject obj5 = (GameObject)GameObject.Instantiate (feed5Object);

			obj5.transform.parent = transform;

			obj5.transform.localPosition = new Vector3(9, y, 0);
			feedcount = 5;
			break;

		case 5:
			GameObject obj6 = (GameObject)GameObject.Instantiate (feed6Object);

			obj6.transform.parent = transform;

			obj6.transform.localPosition = new Vector3(9, y, 0);
			feedcount = 6;
			break;

		case 6:
			GameObject obj7 = (GameObject)GameObject.Instantiate (feed7Object);

			obj7.transform.parent = transform;

			obj7.transform.localPosition = new Vector3(9, y, 0);
			feedcount = 0;
			break;
		}



	}

	void OnTriggerExit2D (Collider2D cal)

	{

		Destroy (cal.attachedRigidbody.gameObject);

	}


}
