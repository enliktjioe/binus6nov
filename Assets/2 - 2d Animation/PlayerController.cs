using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Animator animator;

	void Start () {
		animator = this.GetComponent<Animator>();
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)){
			animator.SetInteger("Direction", 0);
		}

		if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)){
			animator.SetInteger("Direction", 1);
		}

		if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)){
			animator.SetInteger("Direction", 2);
		}

		if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)){
			animator.SetInteger("Direction", 3);
		}


		//using vertical and horizontal axis, support both keyboard or wasd key
//		var vertical = Input.GetAxis("Vertical");
//		var horizontal = Input.GetAxis("Horizontal");
//		
//		if (vertical > 0)
//		{
//			animator.SetInteger("Direction", 2);
//		}
//		else if (vertical < 0)
//		{
//			animator.SetInteger("Direction", 0);
//		}
//		else if (horizontal > 0)
//		{
//			animator.SetInteger("Direction", 3);
//		}
//		else if (horizontal < 0)
//		{
//			animator.SetInteger("Direction", 1);
//		}
	}
}
