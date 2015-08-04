using UnityEngine;
using System.Collections;
//using UnityStandardAssets.Cameras;

public class CreatePlayer : MonoBehaviour {

	PhotonView m_PhotonView;
	public GameObject[] characters;

	void Start()
	{
		m_PhotonView = GetComponent<PhotonView>();
	}

	void OnJoinedRoom()
	{
		Debug.Log ("on joined room: " + m_PhotonView.isMine);

		CreatePlayerObj ();
	}

	void CreatePlayerObj ()
	{
		/*if(m_PhotonView.isMine)
		{
			GameObject camera = PhotonNetwork.Instantiate ("FreeCamera", new Vector3 (0f, 1f, 0f), Quaternion.identity, 0);
			camera.name = "freeCamera";
			//camera.GetComponent<FreeLookCamera> ().SetTarget (player.transform);
			
			//Debug.Log(player);
		}*/


		GameObject player;
		if (PlayerPrefs.GetString ("SelectedCharacter") != null) {
			player = PhotonNetwork.Instantiate (PlayerPrefs.GetString ("SelectedCharacter"), new Vector3 (Random.Range (-20f, 20f), 1f, Random.Range (-20f, 20f)), Quaternion.identity, 0);
		} else {
			player = PhotonNetwork.Instantiate ("WaitressNetwork", new Vector3 (Random.Range (-20f, 20f), 1f, Random.Range (-20f, 20f)), Quaternion.identity, 0);
		}

		EventManager manager = FindObjectOfType (typeof(EventManager)) as EventManager;
		manager.CastInstantiatePlayerNameLabel (player);






	}
}
