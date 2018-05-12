using UnityEngine;
using System.Collections;

public class PShoot : MonoBehaviour {
	public GameObject bullet;
	public float countdown=0.0f; 
	public float duration=2.0f; 
	public int pattern;
	public float torotate = 0.0f;

	// Use this for initialization
	void Start () {
		
	}

	Transform a; 
	void Spiral(){

		 
		for (int i=0; i<25; ++i) {
			transform.Rotate (0, 0, 15); 
			Instantiate(bullet, this.transform.position ,this.transform.rotation);
		}
	}

	void Laser(){
		transform.Rotate (0, 0, 15); 
		//Instantiate(Laser, this.transform.position ,this.transform.rotation);

	}
	
	// Update is called once per frame
	void Update () {
		
		countdown += 1.0f * Time.deltaTime;
		
		if (countdown >= duration ) {
			countdown=0; 
			pattern=Random.Range(1,4);
			
			if(pattern==1){
				Instantiate(bullet, this.transform.position , new Quaternion(transform.rotation.x, transform.rotation.y, Random.Range(-5,5), 
				                                                             transform.rotation.w));
			}
			else if (pattern==2){
				
				Spiral();

			}
			else if(pattern==3){
				
			}
			else if (pattern==4) {
				
			}
			
			
		}
		
		
	}

}
