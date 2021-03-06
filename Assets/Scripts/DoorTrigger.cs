﻿using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {
	public Door door;
	public bool ignoreTrigger;

	void OnTriggerEnter2D(Collider2D target) {
		if (target.gameObject.tag == "Player" && !ignoreTrigger)
			door.Open();
	}

	void OnTriggerExit2D(Collider2D target) {
		if (target.gameObject.tag == "Player" && !ignoreTrigger)
			door.Close();
	}

	public void Toggle(bool value) {
		if (value)
			door.Open();
		else
			door.Close();
	}

	void OnDrawGizmos() {
		Gizmos.color = ignoreTrigger ? Color.gray : Color.green;

		var bc2d = GetComponent<BoxCollider2D>();
		var bc2dPos = bc2d.transform.position;
		var newPos = new Vector2(bc2dPos.x + bc2d.offset.x, bc2dPos.y + bc2d.offset.y);
		Gizmos.DrawWireCube(newPos, new Vector2(bc2d.size.x, bc2d.size.y));
	}
}
