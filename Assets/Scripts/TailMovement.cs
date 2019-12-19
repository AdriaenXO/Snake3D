using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TailMovement : MonoBehaviour {

	public float speed;

	public GameObject tailTarget;
	public Vector3 tailTargetPosition;
	
	public SnakeMovement mainSnake;
	public int numberTarget;
	public string lostGameScene;
	// Use this for initialization
	void Start () {
		mainSnake = GameObject.FindWithTag("SnakeHead").GetComponent<SnakeMovement>();
		tailTarget = mainSnake.tailObjects[mainSnake.tailObjects.Count-2];
		numberTarget = mainSnake.tailObjects.IndexOf(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		//read head speed and move the head
		speed = mainSnake.speed + 2.5f;
		tailTargetPosition = tailTarget.transform.position;
		transform.LookAt(tailTargetPosition);
		transform.position = Vector3.Lerp(transform.position, tailTargetPosition, Time.deltaTime * speed);
	}

	void OnTriggerEnter(Collider other) {
		//collision of the snake head with the tail
		if (other.CompareTag("SnakeHead") && numberTarget > 2){ 
			SceneManager.LoadScene(lostGameScene);
		}
	}
}
