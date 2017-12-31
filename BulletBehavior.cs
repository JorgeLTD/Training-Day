using UnityEngine;
using System.Collections;

public class BulletBehavior : MonoBehaviour {
	public float lifeTime = 3.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		lifeTime -= Time.deltaTime;
		if (lifeTime <= 0) {
			Delete ();
		}
	}

	public void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "Target") {
			TargetBehavior tarScript = col.gameObject.GetComponent<TargetBehavior> (); 
			tarScript.Impact ();
			Delete ();
			Destroy (col.collider);
		}
	}
	void Delete(){
		Destroy(gameObject);
	}
}
