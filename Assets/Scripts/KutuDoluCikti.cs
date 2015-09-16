using UnityEngine;
using System.Collections;

public class KutuDoluCikti : MonoBehaviour {
	public Renderer rend;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnMouseDown(){
		
		rend.material.color = Color.green;
		
	}
}
