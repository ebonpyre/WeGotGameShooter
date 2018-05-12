using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public bool Active = true;
	public Texture2D heart;
	public Texture2D red;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Active = true) {
		
			GetComponent<Renderer>().material.mainTexture = heart;

		}
	
	}
}
