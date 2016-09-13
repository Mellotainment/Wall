using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	public int playerX, playerZ;


	// Use this for initialization
	void Start () {

		playerX = 0;
		playerZ = 12;

		transform.position= new Vector3 (playerX, 0, playerZ);



	}

	// Update is called once per frame
	void Update () {

		playerZ = (int)transform.position.z; 
		playerX = (int)transform.position.x; 

		if (Input.GetKeyDown (KeyCode.UpArrow)){
			transform.position += new Vector3 (0, 0, -1);

			if (Input.GetKeyDown (KeyCode.DownArrow))
				transform.position += new Vector3 (0, 0, 1);

			if (Input.GetKeyDown (KeyCode.LeftArrow))
				transform.position += new Vector3 (-1, 0, 0);

			if (Input.GetKeyDown (KeyCode.RightArrow))
				transform.position += new Vector3 (1, 0, 0);
		}




		if (playerX == 0&& playerZ == 2){ Debug.Log ("you reach the wall you Win");

		}
	}
}
