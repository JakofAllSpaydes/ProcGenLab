using UnityEngine;
using System.Collections;

public class PathMaker : MonoBehaviour {
	
	private int counter; 
	public Transform floorPrefab;
	public Transform pathmakerSpherePrefab;
	static int tileCount;


	// Use this for initialization
	void Start () {
		counter = 0;
	}
	
	// Update is called once per frame
	void Update () {

		if (counter < 50 && tileCount <= 500) {
			float randomNumber = Random.Range (0f, 1f);

			if (randomNumber < 0.25f) {
				transform.Rotate (0f, 90f, 0f);

			} else if (randomNumber >= 0.25f && randomNumber <= 0.5f) {
				transform.Rotate (0f, -90f, 0f);

			} else if (randomNumber >= 0.99f) {
				Instantiate (pathmakerSpherePrefab, transform.position, Quaternion.identity);
			}

			Instantiate (floorPrefab, transform.position, Quaternion.identity);

			transform.Translate (0f, 0f, 5f);
			counter++;
			tileCount++;

		} else {
			Destroy (gameObject);
		}
			
	}
}
