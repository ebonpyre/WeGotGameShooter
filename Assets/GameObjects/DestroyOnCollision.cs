using UnityEngine;
using System.Collections;

public class DestroyOnCollision : MonoBehaviour {

	public bool EnemyDestroy = false;
	public bool BorderDestroy = true;
	public bool Laser= false; 
	public bool BombCol= true; 
	public bool BombRekt = false;

	void OnCollisionEnter(Collision col){

		if (BorderDestroy) {
			if (col.gameObject.tag == "Border")
				Destroy (this.gameObject);
				}
		if (EnemyDestroy) {
			if (col.gameObject.tag == "Bullet"){
				Destroy (this.gameObject);
			}	
		}
		if (Laser) {
			if(col.gameObject.tag=="Laser"){
				Destroy(this.gameObject); 
			}
		}
		if (BombCol) {
			if (col.gameObject.tag == "Player") {
				Destroy (this.gameObject); 
			}
		}
		if (BombRekt) {
			if (col.gameObject.tag == "Bomb") {
				Destroy (this.gameObject); 
			}
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
