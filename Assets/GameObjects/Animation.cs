using UnityEngine;
using System.Collections;

public class Animation : MonoBehaviour {

	public Texture2D[] runningman;

	int i = 0;

	float count = 0.0f, down = 0.25f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position += Vector3.right * 0.5f * Time.deltaTime;

		//	Debug.Log("animframe" + i);

		count += 1.0f * Time.deltaTime;
		if (count >= down) {
						count = 0.0f;
						i += 1;
				}

			if(i >= runningman.Length)
				i = 0;

		GetComponent<Renderer>().material.mainTexture = runningman [i];



	
	}
}
