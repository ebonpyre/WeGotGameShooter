using UnityEngine;
using System.Collections;

public class ExplosionBehavior : MonoBehaviour {

	float ExploCount = 0.0f;
	public float Duration = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		ExploCount += 1.0f * Time.deltaTime;
		if (ExploCount >= Duration) {
			Destroy(this.gameObject);
		}
	
	}
}
