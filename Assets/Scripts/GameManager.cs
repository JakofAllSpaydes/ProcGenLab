using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public GameObject Creator;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.R)){
			SceneManager.LoadScene(0);
			Creator.GetComponent<PathMaker>().tileReset = 0;
		}

	}
}
