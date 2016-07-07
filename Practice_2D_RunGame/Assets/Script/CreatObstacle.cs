using UnityEngine;
using System.Collections;

public class CreatObstacle : MonoBehaviour {
	[SerializeField]GameObject[] obstacle;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		
		if (other.tag == "next") {
			
			Instantiate (obstacle [Random.Range (0, obstacle.Length)], transform.position, transform.rotation);
		}
	}
}
