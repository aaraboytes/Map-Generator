using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplates : MonoBehaviour {
	public GameObject[] rightRooms;
	public GameObject[] leftRooms;
	public GameObject[] topRooms;
	public GameObject[] bottomRooms;
	[Header("Corners")]
	public GameObject TL;
	public GameObject TR;
	public GameObject TB;
	public GameObject RB;
	public GameObject RL;
	public GameObject BL;
	[Header("Block")]
	public GameObject block;
}
