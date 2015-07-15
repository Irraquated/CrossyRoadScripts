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

	}
}
