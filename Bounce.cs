using UnityEngine;
using System.Collections;

public class Bounce : MonoBehaviour {

	float lerpTime;
	float currentLerpTime;
	float percentage = 1;

	Vector3 startPos;
	Vector3 endPos;

	bool firstInput;
	public bool justJump;

	void Update () {
		if(Input.GetButtonDown("up") || Input.GetButtonDown("down") || Input.GetButtonDown("left") || Input.GetButtonDown("right")) {
			if (percentage == 1)
			{
				lerpTime = 1;
				currentLerpTime = 0;
				firstInput = true;
				justJump = true;
			}
		}
		startPos = gameObject.transform.position;
		if (Input.GetButtonDown ("right") && gameObject.transform.position == endPos) {
			endPos = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
		}
		if (Input.GetButtonDown ("left") && gameObject.transform.position == endPos) {
			endPos = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
		}
		if (Input.GetButtonDown ("up") && gameObject.transform.position == endPos) {
			endPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
		}
		if (Input.GetButtonDown ("down") && gameObject.transform.position == endPos) {
			endPos = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);
		}
		if (firstInput == true) {
			currentLerpTime += Time.deltaTime * 5;
			percentage = currentLerpTime / lerpTime;
			gameObject.transform.position = Vector3.Lerp (startPos, endPos, percentage);
			if (percentage > 0.8){
				percentage = 1;
			}
			if (Mathf.Round(percentage) == 1) {
				justJump = false;
			}
		}
	}
}
