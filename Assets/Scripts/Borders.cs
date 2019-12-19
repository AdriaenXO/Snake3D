using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Borders : MonoBehaviour {
	public string lostGameScene;
	void OnTriggerEnter(Collider other) {
		//snake head collision with a wall
		if (other.CompareTag("SnakeHead")){  
			SceneManager.LoadScene(lostGameScene);
		}
	}
}
