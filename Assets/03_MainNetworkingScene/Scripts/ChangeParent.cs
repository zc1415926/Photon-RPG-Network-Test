using UnityEngine;
using System.Collections;

public class ChangeParent : MonoBehaviour {

	void OnPhotonInstantiate(PhotonMessageInfo info)      //使用PhotonNetwork.Instantiate实例化时  
	{  
		dfFollowObject follow = GetComponent<dfFollowObject> ();
		PhotonPlayer followOwner = GetComponent<PhotonView> ().owner;

		//Debug.Log("owner " + GetComponent<PhotonView>().owner);  
		this.transform.parent = GameObject.Find ("panelPlayerNameLabels").transform;

		GameObject[] players = GameObject.FindGameObjectsWithTag ("Player");
		foreach (GameObject player in players) {
			if(player.GetComponent<PhotonView>().owner == followOwner)
			{
				follow.attach = player;
				follow.enabled = true;
				GetComponent<dfLabel>().Text = player.GetComponent<CharacterInfo>().showName;
			}
		}
	} 
}
