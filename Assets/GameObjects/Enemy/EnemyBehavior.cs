using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {

	public GameObject Explosion;
	public int EnemyValue = 10;

	int AlienTex = 1;

	public Texture2D ali1, ali2, ali3, ali4;

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "None") {
			GameObject.FindGameObjectWithTag ("Manager").SendMessage ("AddScore", EnemyValue);
			Instantiate(Explosion, this.transform.position, new Quaternion(Quaternion.identity.x, Quaternion.identity.y, Random.Range(0, 180), Quaternion.identity.w));
			Destroy (this.gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		AlienTex = Random.Range (1, 5);
	}
	
	// Update is called once per frame
	void Update () {

		if (AlienTex == 1) 
			GetComponent<Renderer>().material.mainTexture = ali1;
		else if (AlienTex == 2) 
			GetComponent<Renderer>().material.mainTexture = ali2;
		else if (AlienTex == 3) 
			GetComponent<Renderer>().material.mainTexture = ali3;
		else if (AlienTex == 4) 
			GetComponent<Renderer>().material.mainTexture = ali4;
	}
}
