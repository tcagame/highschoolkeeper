using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static int score1 = 0;
	public static int score2 = 0;
	public static int score3 = 0;
	public static int score4 = 0;
	public static int score5 = 0;
	public static int score6 = 0;
	public static int score7 = 0;
	public Text score1Text;
	public Text score2Text;
	public Text score3Text;
	public Text score4Text;
	public Text score5Text;
	public Text score6Text;
	public Text score7Text;

	// Use this for initialization
	void Start () {
	
		score1Text.text = "Score1: 0";
		score2Text.text = "Score2: 0";
		score3Text.text = "Score3: 0";
		score4Text.text = "Score4: 0";
		score5Text.text = "Score5: 0";
		score6Text.text = "Score6: 0";
		score7Text.text = "Score7: 0";
	}
	
	// Update is called once per frame
	void Update () {
		score1Text.text = "Score1: " + score1.ToString();
		score2Text.text = "Score2: " + score2.ToString();
		score3Text.text = "Score3: " + score3.ToString();
		score4Text.text = "Score4: " + score4.ToString();
		score5Text.text = "Score5: " + score5.ToString();
		score6Text.text = "Score6: " + score6.ToString();
		score7Text.text = "Score7: " + score7.ToString();
	}

}
