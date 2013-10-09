using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
	
	void OnCollisionEnter(Collision theCollider){
		//this objects name
		string selfName = this.gameObject.name;
		
		if (theCollider.gameObject.name == "Box"){
			Debug.Log(selfName + " Destroyed by Box");
			//if this object is hit by the box, it is destroyed
			Destroy(this);
		}
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
