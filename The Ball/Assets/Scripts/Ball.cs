using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public float velocidad = 0.3f;
	//public float aceleracion = 0.001f;



	// Use this for initialization
	void Start () {
		


	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
			haciaIzquierda();
			//velocidad = velocidad + aceleracion;
		}

		if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
			haciaDerecha();
			//velocidad = velocidad + aceleracion;
		}

		if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
			haciaAtras();
			//velocidad = velocidad + aceleracion;
		}

		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
			haciaDelante();
			//uyvelocidad = velocidad + aceleracion;
		}
	}

	void haciaDelante(){
		this.transform.position = new Vector3 (
			this.transform.position.x,
			this.transform.position.y,
			this.transform.position.z + velocidad
		);

		/*this.transform.rotation = new Vector3 (
			this.transform.rotation.x + velocidad,
			this.transform.rotation.y,
			this.transform.rotation.z
		);*/
	}
	void haciaIzquierda(){
		this.transform.position = new Vector3 (
			this.transform.position.x - velocidad,
			this.transform.position.y,
			this.transform.position.z
		);
		/*this.transform.rotation = new Vector3 (
			this.transform.rotation.x,
			this.transform.rotation.y,
			this.transform.rotation.z + velocidad
		);*/
	}
	void haciaDerecha(){
		this.transform.position = new Vector3 (
			this.transform.position.x + velocidad,
			this.transform.position.y,
			this.transform.position.z
		);
		/*this.transform.rotation = new Vector3 (
			this.transform.rotation.x,
			this.transform.rotation.y,
			this.transform.rotation.z - velocidad
		);*/
	}
	void haciaAtras(){
		this.transform.position = new Vector3 (
			this.transform.position.x,
			this.transform.position.y,
			this.transform.position.z - velocidad
		);
		/*this.transform.rotation = new Vector3 (
			this.transform.rotation.x - velocidad,
			this.transform.rotation.y,
			this.transform.rotation.z
		);*/
	}

	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag.Equals("CilindroFinal")){
			Debug.Log ("Has ganado");
			restart ();
		}
		if(collision.gameObject.tag.Equals("Suelo")){
			Debug.Log ("Has Perdido");
			restart ();
		}
		if(collision.gameObject.tag.Equals("Teletransporte")){
			
			teletransporte ();
		}
	}

	void restart(){
		this.transform.position = new Vector3 (
			23.35f,
			2.56f,
			-22.5f
		);
	}

	void teletransporte(){
		this.transform.position = new Vector3 (
			19.1f,
			24.4f,
			16.4f
		);
	}
}
