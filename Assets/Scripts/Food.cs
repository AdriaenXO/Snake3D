using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {
	void Update()
	{
		transform.Rotate (new Vector3 (0f, 0f, 100f) * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other) {
		print ("trigger");
		if (other.CompareTag("SnakeHead")){
			other.GetComponent<SnakeMovement>().AddTail();
			Destroy(gameObject);
		}
	}
}
