using UnityEngine;
using System.Collections;

public class AnimationC : MonoBehaviour {

	Animator anim;
	public GameObject player;
	
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
	
	}

	void Update () {
		Bounce bounceScript = player.GetComponent<Bounce> ();
		if(bounceScript.justJump == true) {
			anim.SetBool ("Jumping",true);
		}else{
			anim.SetBool ("Jumping",false);
		}
		if (Input.GetButtonDown ("right")) {
			gameObject.transform.rotation = Quaternion.Euler(0,180,0);
		}
		if (Input.GetButtonDown ("left")) {
			gameObject.transform.rotation = Quaternion.Euler(0,0,0);
		}
		if (Input.GetButtonDown ("up")) {
			gameObject.transform.rotation = Quaternion.Euler(0,90,0);
		}
		if (Input.GetButtonDown ("down")) {
			gameObject.transform.rotation = Quaternion.Euler(0,-90,0);
		}

	}
}
