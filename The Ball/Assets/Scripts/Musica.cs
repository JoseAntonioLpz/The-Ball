using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Musica : MonoBehaviour {

	//private int seleccion;

	public AudioClip megalovania;
	private AudioSource audioSource;

	void Start () {
		audioSource = this.GetComponent<AudioSource>();
		audioSource.Stop ();
		audioSource.clip = megalovania;
		audioSource.Play ();
		audioSource.loop = true;
		/*seleccion = Random.Range (0, 3);
		switch (seleccion) {
		case 0:
			audioSource.PlayOneShot (audioClip , 1);
			break;
		case 1:
			audioSource.PlayOneShot (audioClip , 1);
			break;
		case 2:
			audioSource.PlayOneShot (audioClip , 1);
			break;
		case 3:
			audioSource.PlayOneShot (audioClip , 1);
			break;
		default:
			Debug.Log ("Error en la musica");
			break;

		}*/
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
