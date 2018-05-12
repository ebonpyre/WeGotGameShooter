using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	public GameObject bullet;
	
	public float countdown=0.0f; 
	public float duration=0.5f; 
	// Use this for initialization
	void Start () {
	
	}
	public int pattern;

	// Update is called once per frame
	void Update () {

		countdown += 1.0f * Time.deltaTime;

		if (countdown >= duration ) {
			countdown=0; 
			Instantiate(bullet, this.transform.position , new Quaternion(transform.rotation.x, transform.rotation.y, Random.Range(-5,5), 
				                                                             transform.rotation.w));

		}


	}
}
