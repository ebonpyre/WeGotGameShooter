using UnityEngine;
using System.Collections;

public class WeGotGameMovement : MonoBehaviour {

	public float Speed = 1.0f;

	void OnCollisionEnter(Collision col){

		Destroy (this.gameObject);
	
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position += new Vector3 (0.0f, 1.0f, 0.0f) * Speed * Time.deltaTime;
	
	}
}
