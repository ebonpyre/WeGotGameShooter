using UnityEngine;
using System.Collections;

public class spiral : MonoBehaviour {

	// Use this for initialization
	float rotation;

	void Start () {
		rotation = 160;
	}

	public float Speed;
	float speedup = 1;
	// Update is called once per frame
	void Update () {
		transform.position += transform.up * (Speed * speedup) * Time.deltaTime;
		speedup += 1f;
		rotation += Time.deltaTime;
	}
}
