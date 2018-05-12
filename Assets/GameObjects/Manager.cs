using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	public string GameTitle = "Space Attackers!!";

	int GameState = 0;
	//GameState
	//0 - Press Any Key
	//1 - Menu (PlayGame, HighScore, Exit)
	//2 - PlayGame
	//3 - GameOver (Retry, Menu)
	//4 - HighScore

	public GameObject player;
	public GameObject enemy;

	int PlayerScore = 0;
	public int PlayerLives = 3;

	public Vector3 StartPosition;
	bool PlayerAlive = false;

	float SpawnCounter = 0.0f;
	public float SpawnDuration = 1.0f;

	void AddScore(int EnemyValue){
		PlayerScore += EnemyValue;
	}
	void SubtractLife(){
		PlayerLives -= 1;
		PlayerAlive = false;
		if (PlayerLives <= 0) {
			GameState = 3;
		}
	}

	void OnGUI(){
		//GUI.Box (new Rect (0,Screen.height - 50,100,50), "Bottom-left");
		//GUI.Box (new Rect (Screen.width - 100,Screen.height - 50,100,50), "Bottom-right");

		//GameState 0 - Press Space to Continue
		if (GameState == 0) {
			GUI.Box (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 25, 200, 60), "Space Attackers!!\n\nPress Space to continue!");
			if(Input.GetKeyDown (KeyCode.Space))
			{
				GameState = 1;
			}
		}
		//GameState 1 - Main Menu
		else if (GameState == 1) {
			GUI.Box (new Rect (Screen.width / 2 - 75, Screen.height / 2 - 75, 150, 150), "\n" + GameTitle);
			if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 20, 100, 30), "Start Game!"))
				GameState = 2;
			//if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2, 100, 30), "High Score"))
			//	GameState = 4;
			if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 35, 100, 30), "Exit"))
				Application.Quit();
		}
		else if (GameState == 2) {
			GUI.Box (new Rect (0, Screen.height - 35, 100, 35), "Score: " + PlayerScore);
			GUI.Box (new Rect (Screen.width - 100, Screen.height - 35, 100, 35), "Lives: " + PlayerLives);
		}
		else if (GameState == 3) {
			GUI.Box (new Rect (Screen.width / 2 - 75, Screen.height / 2 - 75, 150, 150), "\nGame Over!!\nYour Score: " + PlayerScore);
			if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 15, 100, 30), "Retry"))
				GameState = 2;
			if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 35, 100, 30), "Exit"))
				Application.Quit();
		}
		else if (GameState == 4) {
			GUI.Box (new Rect (0, 0, 200, 30), "Goggle Charge Level: ");
			GUI.Box (new Rect (Screen.width - 200, 0, 200, 50), "WASD to move, Mouse to look\nG - Activate Goggles");
		}

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (GameState == 2) {
			if(!PlayerAlive){
				Instantiate(player, StartPosition, transform.rotation);
				PlayerAlive = true;
			}

			SpawnCounter += 1.0f * Time.deltaTime;
			if(SpawnCounter >= SpawnDuration){
				Instantiate(enemy, new Vector3(Random.Range(-6, 7), 6.0f, 0.0f), transform.rotation);
				SpawnCounter = 0.0f;
			}
		}
	
	}
}
