using UnityEngine;
using System.Collections;

public class SpacebarAction : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Animator anim = GetComponent<Animator>();

		if(Input.GetKeyDown("space")) {
			anim.SetTrigger("PerformAction");
		}
	}
}
