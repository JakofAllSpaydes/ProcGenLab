using UnityEngine;
using System.Collections;


public class PathMaker : MonoBehaviour {
	
	private int counter; 
	public Transform floorPrefab;
	public Transform floor2Prefab;
	public Transform floor3Prefab;
	public Transform pathmakerSpherePrefab;
	static int tileCount;
	public int tileReset;
	public int lifeSpan;
	public float turn1;
	public float turn2;
	public float turn3;
	public float tileSelect;


	// Use this for initialization
	void Start () {
		counter = 0;
		lifeSpan = (Random.Range(50, 200));
		turn1 = (Random.Range(0.15f, 0.3f));
		turn2 = (Random.Range (0.3f, 0.6f));
		turn3 = (Random.Range (0.6f, 0.85f));
		tileSelect = (Random.Range (0f, 1f));

		tileCount = tileReset;
	}
	
	// Update is called once per frame
	void Update () {


		tileReset = tileCount;

		if (counter < lifeSpan && tileCount <= 500) {
			float randomNumber = Random.Range (0f, 1f);

			if (randomNumber < turn1) {
				transform.Rotate (0f, 90f, 0f);

			} else if (randomNumber >= turn2 && randomNumber <= turn3) {
				transform.Rotate (0f, -90f, 0f);

			} else if (randomNumber >= turn3) {
				Instantiate (pathmakerSpherePrefab, transform.position, Quaternion.identity);
			}


			if (tileSelect <= 0.3) {
				Instantiate (floorPrefab, transform.position, Quaternion.identity);

			} else if (tileSelect > 0.3f && tileSelect < 0.7f) {
				Instantiate (floor2Prefab, transform.position, Quaternion.identity);

			} else if (tileSelect >= 0.7f) {
				Instantiate (floor3Prefab, transform.position, Quaternion.identity);
			}

			transform.Translate (0f, 0f, 5f);
			counter++;
			tileCount++;

		} else {
			Destroy (gameObject);
		}
			
	}
}
