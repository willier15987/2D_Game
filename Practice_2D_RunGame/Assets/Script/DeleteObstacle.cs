using UnityEngine;
using System.Collections;

public class DeleteObstacle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("1");
		if (other.tag == "next") {
			DestroyObject (other.transform.root.gameObject, 0.5f);
		}
	}
}
