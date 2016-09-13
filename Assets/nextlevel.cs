using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public  class nextlevel : MonoBehaviour {




	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "player"){
			
			SceneManager.LoadScene("1");

	}
}
} 