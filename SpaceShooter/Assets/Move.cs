using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public float speed = 5.0f; //velocitat de la nau
	
	// Update is called once per frame
	void FixedUpdate () {

		//Amb el teclat del nostre ordinador, li donarem moviment
		//a la nau
		//Es moura per a totes les direccions (horitzontal i vertical)
		//Get Input from Arrow keys, WSAD, Gamepads...
		float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw("Vertical");

		//Set the Rigidbody's velocity
		Vector2 dir = new Vector2(h, v);
		GetComponent<Rigidbody2D>().velocity = dir.normalized * speed;

		//Apliquem animacio a la nau, per que tingui un efecte de que esta volant
		//(quan es comenci a moure)
		GetComponent<Animator>().SetBool("flying", (v > 0));
	}
}
