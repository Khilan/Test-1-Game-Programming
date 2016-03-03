using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public int tankCount;
	public GameObject tank;

	public Text ScoreLabel;
	public Text LivesLabel;
	public Text GameOverLabel;
	public PlayerController Tank;
	public EnemyController enemy;

	private int _livesValue;
	private int _scoreValue;

	[SerializeField]
	private AudioSource _gameOverSound;


	public int ScoreValue{
		get{
			return this._scoreValue;
		}
		set{
			this._scoreValue = value;
			this.ScoreLabel.text = "Score: " + this._scoreValue;
		}
	}


	public int LivesValue{
		get{
			return this._livesValue;
		}
		set{
			this._livesValue = value;
			if (this._livesValue <= 0) {
				this._endGame ();
			} else {
				this.LivesLabel.text = "Lives: " + this._livesValue;
			}
			
		}
	}


	
	// Use this for initialization
	void Start () {


		this._GenerateTanks ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// generate Clouds
	private void _GenerateTanks() {

		this.ScoreValue = 0;
		this.LivesValue = 5;
		this.GameOverLabel.gameObject.SetActive (false);

		for (int count=0; count < this.tankCount; count++) {
			Instantiate(tank);
		}

	}

	private void _endGame(){

		this.ScoreLabel.gameObject.SetActive (false);
		this.LivesLabel.gameObject.SetActive (false);
		this.GameOverLabel.gameObject.SetActive (true);
		this.Tank.gameObject.SetActive (false);
	}
}
