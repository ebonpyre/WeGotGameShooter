using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour {

	public GameObject Explosion;

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Enemy") {
			GameObject.FindGameObjectWithTag ("Manager").SendMessage ("SubtractLife");
			Instantiate(Explosion, this.transform.position, Quaternion.identity);
			Destroy (this.gameObject);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
