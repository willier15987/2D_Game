using UnityEngine;
using System.Collections;

public class Obstacle_Move : MonoBehaviour {
	[SerializeField]Animator ScremMan;

	GameObject ScremMan_Gobj;
	// Use this for initialization

	void Start () {
		ScremMan_Gobj = GameObject.FindGameObjectWithTag ("Player");
		ScremMan = ScremMan_Gobj.GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		
		//transform.Translate(-10.24f /20 * Time.deltaTime*1.3f,0,0) ;
	
		if (!ScremMan.GetCurrentAnimatorStateInfo (0).IsName ("ScremMan_Die")) {
			transform.Translate(-10.24f /20 * Time.deltaTime*1.3f,0,0) ;
		}
	
	}
}
