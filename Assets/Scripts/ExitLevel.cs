﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour {
	public string scene;

	void OnTriggerEnter2D(Collider2D target) {
		if (target.gameObject.tag == "Player") {
			Destroy(target.gameObject);
			SceneManager.LoadScene(scene);
		}
	}
}
