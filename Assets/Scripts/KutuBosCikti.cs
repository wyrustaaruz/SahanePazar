using UnityEngine;
using System.Collections;

public class KutuBosCikti : MonoBehaviour {
	public Renderer rend;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnMouseDown(){
			
		rend.material.color = Color.red;
	
	}
}