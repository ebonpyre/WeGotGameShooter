using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public GameObject bullet;
	public bool CanShoot = true;
	float reloadCount = 0.0f;
	public float reloadTime = 0.0f;

	public float Speed = 5.0f;
	public bool MoveUp = false, MoveDown = false, MoveRight = false, MoveLeft = false;
	public bool custommove= true; 

	public bool PlayerControlled = false;
	public bool lockHorizontal = false;
	public bool lockVertical = false;
	public Vector3 BoundaryMin = new Vector2(-6.0f, 0.0f);
	public Vector3 BoundaryMax = new Vector2(6.0f, 0.0f);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!PlayerControlled) {
		
						if (MoveUp)
								transform.position += Vector3.up * Speed * Time.deltaTime;
						if (MoveDown)
								transform.position += Vector3.down * Speed * Time.deltaTime;
						if (MoveLeft)
								transform.position += Vector3.left * Speed * Time.deltaTime;
						if (MoveRight)
								transform.position += Vector3.right * Speed * Time.deltaTime;
						if(custommove){
							transform.position += transform.up * Speed * Time.deltaTime;
						}
		
				}
		else {
			if(!lockVertical){
			if (((Input.GetKey(KeyCode.W))|(Input.GetKey(KeyCode.UpArrow)))){
				if (Input.GetKey(KeyCode.LeftShift)){
					transform.position += Vector3.up * Speed/2 * Time.deltaTime;
				}
				else {
					transform.position += Vector3.up * Speed * Time.deltaTime;
				}
			}
			if (((Input.GetKey(KeyCode.S))|(Input.GetKey(KeyCode.DownArrow)))){
						if (Input.GetKey(KeyCode.LeftShift)){
							transform.position += Vector3.down * Speed/2 * Time.deltaTime;
						}
						else {
							transform.position += Vector3.down * Speed * Time.deltaTime;
						}
						}
			}
			if(!lockHorizontal){
			if (((Input.GetKey(KeyCode.A))|(Input.GetKey(KeyCode.LeftArrow)))&&(transform.position.x > BoundaryMin.x))
					if (Input.GetKey(KeyCode.LeftShift)){
						transform.position += Vector3.left * Speed/2 * Time.deltaTime;
					}
					else {
					transform.position += Vector3.left * Speed * Time.deltaTime;
					}
			if (((Input.GetKey(KeyCode.D))|(Input.GetKey(KeyCode.RightArrow)))&&(transform.position.x < BoundaryMax.x))
				if (Input.GetKey(KeyCode.LeftShift)){
					transform.position += Vector3.right * Speed/2 * Time.deltaTime;
				}
				else {
					transform.position += Vector3.right * Speed * Time.deltaTime;
				}
			}

			reloadCount += 1.0f * Time.deltaTime;
			if((Input.GetKeyDown(KeyCode.Space))&&(reloadCount >= reloadTime)){
				Instantiate(bullet, this.transform.position, transform.rotation);
				reloadCount = 0.0f;
			}


		}
	
	}
}
