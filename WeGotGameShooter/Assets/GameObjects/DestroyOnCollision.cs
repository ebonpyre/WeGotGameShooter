using UnityEngine;
using System.Collections;

public class DestroyOnCollision : MonoBehaviour {

	public bool EnemyDestroy = false;
	public bool BorderDestroy = true;

	void OnCollisionEnter(Collision col){

		if (BorderDestroy) {
			if (col.gameObject.tag == "Border")
				Destroy (this.gameObject);
				}
		if (EnemyDestroy) {
			if (col.gameObject.tag == "Enemy")
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
