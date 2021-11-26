using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
	public Transform destination;
	public GameObject player;


	private void OnTriggerStay(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			player.transform.position = destination.position;
			Debug.Log("Teleport");
		}
	}
}