using System.Collections;
using UnityEngine;

public class FoodGeneration : MonoBehaviour {

	public float xSize = 14.0f;
	public float zSize = 9.0f;

	public GameObject foodPrefab;
	public GameObject currentFood;
	public Vector3 currentFoodPosition;

	void AddNewFood(){
		RandomPosition();
		currentFood = GameObject.Instantiate(foodPrefab, currentFoodPosition, Quaternion.Euler(90, 0, 0)) as GameObject;

	}
	void RandomPosition(){
		currentFoodPosition = new Vector3(Random.Range(-xSize, xSize), 0.5f, Random.Range(-zSize, zSize));

	}
	// Update is called once per frame
	void Update () {
		if(!currentFood){
			AddNewFood();
		}
	}
}
