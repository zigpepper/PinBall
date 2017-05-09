using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreAdd : MonoBehaviour
{
	private GameObject scoreText;
	private int score = 0;
	private int getScore = 0;
	Rect _rect = new Rect(100,100,300,300);

	void Start () {
		this.scoreText = GameObject.Find("ScoreText");

		this.scoreText.GetComponent<Text> ().text = "SCORE:" + this.score;
	}
		
	void Update () {
	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "SmallStarTag") {
			this.score += 3;
				this.scoreText.GetComponent<Text> ().text = "SCORE:" + this.score;
		} else if (other.gameObject.tag == "LargeStarTag") {
			this.score += 20;
				this.scoreText.GetComponent<Text> ().text = "SCORE:" + this.score;
		} else if (other.gameObject.tag == "SmallCloudTag") {
			this.score += 10;
				this.scoreText.GetComponent<Text> ().text = "SCORE:" + this.score;
		} else if (other.gameObject.tag == "LargeCloudTag") {
			this.score += 5;
				this.scoreText.GetComponent<Text> ().text = "SCORE:" + this.score;
		} else {
		}
	}
}