using UnityEngine;
using System.Collections;
//using UnityStandardAssets.Cameras;

public class CreatePlayer : MonoBehaviour {

	PhotonView m_PhotonView;

	void Start()
	{
		m_PhotonView = GetComponent<PhotonView>();
	}

	void OnJoinedRoom()
	{
		CreatePlayerObj ();
	}

	void CreatePlayerObj ()
	{
		GameObject player = PhotonNetwork.Instantiate ("EthanNetwork", new Vector3 (Random.Range(-20f, 20f), 1f, Random.Range(-20f, 20f)), Quaternion.identity, 0);


		if(m_PhotonView.isMine)
		{
			GameObject camera = PhotonNetwork.Instantiate ("FreeCamera", new Vector3 (0f, 1f, 0f), Quaternion.identity, 0);
			camera.name = "freeCamera";
			//camera.GetComponent<FreeLookCamera> ().SetTarget (player.transform);

			//Debug.Log(player);
		}



	}
}
