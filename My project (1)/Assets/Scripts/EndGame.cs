using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{


	public void EndPlay(){
		Collectable.count = 0;
		Collectable.total = 0;
		TotalPoints.score = 0;
		SceneManager.LoadScene(1);
	}
}
