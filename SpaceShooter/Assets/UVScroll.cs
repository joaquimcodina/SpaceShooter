using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UVScroll : MonoBehaviour {

	public Vector2 speed;

	//Al iniciar el joc, el background fara un efecte en el qual es mouran les estrelles
	//per donar-li una mica de realitat al joc
	void LateUpdate(){
		GetComponent<Renderer>().material.mainTextureOffset = speed * Time.time;
	}

}
