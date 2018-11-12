using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartBoardBehavior : MonoBehaviour {

	void OnTriggerEnter(Collider col)
	{
		if (col.tag.Equals("Dart")) 
		{
			col.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
		}
	}
}
