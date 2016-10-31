using UnityEngine;
using System.Collections;

public class PathMaker : MonoBehaviour {
	
	private int counter; 
	public Transform floorPrefab;
	public Transform pathmakerSpherePrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (counter < 50) {
			float randomNumber = Random.Range (0f, 1f);
			if (randomNumber < 0.25f) {
				transform.Rotate (Quaternion.Euler (0f, 90f, 0f));
			} else {
				if (randomNumber >= 0.25f && randomNumber <= 0.5f) {
					transform.Rotate (Quaternion.Euler (0f, -90f, 0f));
				} else {
					if (randomNumber >= 0.99f) {
						GameObject newClone = (GameObject)Instantiate (pathmakerSpherePrefab, 
							                      new Vector3 (pathmakerSpherePrefab.transform.position.x, pathmakerSpherePrefab.transform.position.y, 0f));
					}
				}
			}

			GameObject floorClone = (GameObject)Instantiate (floorPrefab, 
				                        new Vector3 (pathmakerSpherePrefab.transform.position.x, pathmakerSpherePrefab.transform.position.y, 0f));

			transform.Translate (0f, 0f, 5f);
			counter++;
		} else {
			Destroy (gameObject);
		}
			
	}
}
