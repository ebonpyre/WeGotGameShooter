using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public static bool isDead=false; 
	int a;
	void OnGUI(){
		if (!isDead) {
			a = (int)Time.realtimeSinceStartup;
			GUI.Box (new Rect (0, Screen.height - 35, 100, 35), "Score: " + a);
		}
		else{
			GUI.Box (new Rect (0, Screen.height/2 + 20, 100, 35), "Game Over: " + a);

		}
		      	

	}
}
