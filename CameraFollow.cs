using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject chickenPlayer;
	Vector3 shouldPos;

	// Update is called once per frame
	void Update () {
		shouldPos = Vector3.Lerp (gameObject.transform.position, chickenPlayer.transform.position, Time.deltaTime);
		gameObject.transform.position = new Vector3 (shouldPos.x, 1, shouldPos.z);
	
	}
}
