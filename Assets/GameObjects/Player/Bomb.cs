using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {
	public GameObject Explosion;

	
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Player") {
			for (int i = 0; i<20; i++) {
				this.transform.localScale += new Vector3(2.0f, 2.0f, 2.0f);
			}
			Instantiate(Explosion, this.transform.position, Quaternion.identity);

		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
