using UnityEngine;
using System.Collections;

public class HeartManager : MonoBehaviour {

	public GameObject[] hearts;

	public int Health = 3;

	int i = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		for (; i < hearts.Length; i += 1) {
				
			Debug.Log("asdf" + i);

		}

	
	}
}
