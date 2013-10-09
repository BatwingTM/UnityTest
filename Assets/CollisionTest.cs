using UnityEngine;
using System.Collections;

public class CollisionTest : MonoBehaviour {

	//Collision detection, the GameObject that this is attached to has collided with another
	void OnCollisionEnter(Collision theCollider){
		//this objects name
		string selfName = this.gameObject.name;
		
		if (theCollider.gameObject.name =="Floor"){
			Debug.Log(selfName + " Hit the floor");
		}
		else if (theCollider.gameObject.name =="Wall"){
			Debug.Log(selfName + " Hit the Wall");
		} 
		else {
			Debug.Log(selfName + " Hit something");	
			//if it's not a Wall of Floor, destroy it
			Destroy(theCollider.gameObject);
		}
	}
	
	// Use this for initialization
	void Start () {
		//turning Gravity off
		this.rigidbody.useGravity = false;
	}
	
	// Update is called once per frame
	//added code to drop the box when space is pressed
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			//turn gravity back on
			this.rigidbody.useGravity = true;
			//pushing the box on the Y axis (Down)
			rigidbody.AddForce(0,-10,10);
		}
	}
}
