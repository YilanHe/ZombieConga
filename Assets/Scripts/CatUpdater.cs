using UnityEngine;

public class CatUpdater : MonoBehaviour {
	private CatController catController;

	// Use this for initialization
	void Start () {
		catController = transform.parent.GetComponent<CatController> ();
	}
	
	// Update is called once per frame
	void UpdateTargetPosition () {
		catController.UpdateTargetPosition();
	}

	void OnBecameInvisible(){
		catController.OnBecameInvisible ();
	}

	void GrantCatTheSweetReleaseOfDeath (){
		catController.GrantCatTheSweetReleaseOfDeath();
	}
}