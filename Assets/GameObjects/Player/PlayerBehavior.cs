using UnityEngine;
using System.Collections;

public class PlayerBehavior : Main {

	public GameObject Explosion;



	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Bullet" || col.gameObject.tag=="Laser") {
			Instantiate(Explosion, this.transform.position, Quaternion.identity);
			Destroy (this.gameObject);
			Main.isDead = true;

		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
