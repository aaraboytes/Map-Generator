using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour {
	public int openingDirection;
	//1 Bottom Door
	//2 Top Door
	//3 Left Door
	//4 Right Door
	private RoomTemplates templates;
	private int rand;
	private bool spawned = false;

	void Start(){
		templates = GameObject.FindGameObjectWithTag ("Rooms").GetComponent<RoomTemplates> ();
		Invoke ("Spawn",0.1f);
	}
	void Spawn(){
		if (!spawned) {
			if (openingDirection == 1) {
				rand = Random.Range (0, templates.bottomRooms.Length);
				Instantiate (templates.bottomRooms [rand], transform.position, Quaternion.identity);
			} else if (openingDirection == 2) {
				rand = Random.Range (0, templates.topRooms.Length);
				Instantiate (templates.topRooms [rand], transform.position, Quaternion.identity);
			} else if (openingDirection == 3) {
				rand = Random.Range (0, templates.leftRooms.Length);
				Instantiate (templates.leftRooms [rand], transform.position, Quaternion.identity);
			} else if (openingDirection == 4) {
				rand = Random.Range (0, templates.rightRooms.Length);
				Instantiate (templates.rightRooms [rand], transform.position, Quaternion.identity);
			}
			spawned = true;
		}
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.CompareTag ("SpawnPoint")) {
			if (!other.GetComponent<RoomSpawner> ().spawned && !spawned) {
				Debug.Log ("Se encontro coincidencia");
				Destroy (gameObject);
				Instantiate (templates.block,transform.position,Quaternion.identity);
				/*if (openingDirection == 1) {
					Debug.Log ("Se necesita bottom");
					if (other.GetComponent<RoomSpawner> ().openingDirection == 2) {
						//Gen TB
						Instantiate(templates.TB,transform.position,Quaternion.identity);
					} else if (other.GetComponent<RoomSpawner> ().openingDirection == 3) {
						//Gen BL
						Instantiate(templates.BL,transform.position,Quaternion.identity);
					} else if (other.GetComponent<RoomSpawner> ().openingDirection == 4) {
						//Gen RB
						Instantiate(templates.RB,transform.position,Quaternion.identity);
					}
				} else if (openingDirection == 2) {
					Debug.Log ("Se necesita top");
					if (other.GetComponent<RoomSpawner> ().openingDirection == 1) {
						//Gen TB
						Instantiate(templates.TB,transform.position,Quaternion.identity);
					} else if (other.GetComponent<RoomSpawner> ().openingDirection == 3) {
						//Gen TL
						Instantiate(templates.TL,transform.position,Quaternion.identity);
					} else if (other.GetComponent<RoomSpawner> ().openingDirection == 4) {
						//Gen TR
						Instantiate(templates.TR,transform.position,Quaternion.identity);
					}
				} else if (openingDirection == 3) {
					Debug.Log ("Se necesita left");
					if (other.GetComponent<RoomSpawner> ().openingDirection == 1) {
						//Gen BL
						Instantiate(templates.BL,transform.position,Quaternion.identity);
					} else if (other.GetComponent<RoomSpawner> ().openingDirection == 2) {
						//Gen TL
						Instantiate(templates.TL,transform.position,Quaternion.identity);
					} else if (other.GetComponent<RoomSpawner> ().openingDirection == 4) {
						//Gen RL
						Instantiate(templates.RL,transform.position,Quaternion.identity);
					}
				} else if (openingDirection == 4) {
					Debug.Log ("Se necesita right");
					if (other.GetComponent<RoomSpawner> ().openingDirection == 1) {
						//Gen RB
						Instantiate(templates.RB,transform.position,Quaternion.identity);
					} else if (other.GetComponent<RoomSpawner> ().openingDirection == 2) {
						//Gen TR
						Instantiate(templates.TR,transform.position,Quaternion.identity);
					} else if (other.GetComponent<RoomSpawner> ().openingDirection == 3) {
						//Gen RL
						Instantiate(templates.RL,transform.position,Quaternion.identity);
					}
				}*/
			}//END if !spawned && !other.spawned
			spawned = true;
		}
	}
}
