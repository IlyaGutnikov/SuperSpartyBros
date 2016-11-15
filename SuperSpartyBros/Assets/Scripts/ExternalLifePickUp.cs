using UnityEngine;
using System.Collections;

public class ExternalLifePickUp : MonoBehaviour {

	public GameObject explosion;

	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Player")
		{
			// if explosion prefab is provide, then instantiate it
			if (explosion)
			{
				Instantiate(explosion,transform.position,transform.rotation);
			}

			GameManager.gm.AddExternalLife ();

			// destroy the heart
			DestroyObject(this.gameObject);
		}
	}
}
