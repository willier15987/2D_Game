using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("1");
	}
	/*void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Obstacle") {
			Debug.Log ("1");
		}
	}*/
}
