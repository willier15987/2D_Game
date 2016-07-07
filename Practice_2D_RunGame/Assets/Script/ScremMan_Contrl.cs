using UnityEngine;
using System.Collections;

public class ScremMan_Contrl : MonoBehaviour {
	[SerializeField] Animator animtor,treeAnimation,groundAnimation,skyAnimation;

	//GameObject G_Obstacel;
	int score = 0;
	// Use this for initialization
	void Start () {
		
		/*G_Obstacel = GameObject.FindGameObjectWithTag ("level");
		if (G_Obstacel != null) {
			obstacle = G_Obstacel.GetComponent<Obstacle_Move> ();
		}*/
	}
	
	// Update is called once per frame
	void Update () {
		//Jump
		if (Input.GetMouseButtonDown (0) && animtor.GetCurrentAnimatorStateInfo (0).IsName ("ScremMan_Jump") ) {
			animtor.Play ("ScremMan_DoubleJump");
		}
		else if (Input.GetMouseButtonDown (0)&&!animtor.GetCurrentAnimatorStateInfo (0).IsName ("ScremMan_DoubleJump")&& !animtor.GetCurrentAnimatorStateInfo (0).IsName ("ScremMan_Die")) {
			animtor.Play ("ScremMan_Jump");
		}
		//Slide
		if (Input.GetMouseButton (1)&& !animtor.GetCurrentAnimatorStateInfo (0).IsName ("ScremMan_Die")) {
			animtor.SetBool ("Slide", true);

		}
		if (Input.GetMouseButtonUp (1)) {
			animtor.SetBool ("Slide", false);
		}
	}
	void OnTriggerEnter2D(Collider2D other){
		
		if (other.tag == "Obstacle") {
			
			animtor.Play("ScremMan_Die");
			treeAnimation.enabled = false;
			groundAnimation.enabled = false;
			skyAnimation.enabled = false;

		}
		if (other.tag == "Score") {
			score = score + 1;
			Debug.Log (score);

			other.gameObject.SetActive(false);
		}

	}
}
