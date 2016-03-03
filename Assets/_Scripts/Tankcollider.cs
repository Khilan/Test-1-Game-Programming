using UnityEngine;
using System.Collections;

public class Tankcollider : MonoBehaviour {

	private AudioSource[] _audioSource;
	private AudioSource _isTank;
	private AudioSource _enemyTank;

	public GameController gamecontroller;

	// Use this for initialization
	void Start () {
//		this._audioSource = gameObject.GetComponent<AudioSource> ();
		this._isTank = this._audioSource [1];
		this._enemyTank = this._audioSource [2];
	
	}
	public void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("Enemy")) {
			//this._isTank.Play ();
			this.gamecontroller.LivesValue -= 1;
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}




}
