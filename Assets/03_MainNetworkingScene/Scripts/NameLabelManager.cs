using UnityEngine;
using System.Collections;

public class NameLabelManager : MonoBehaviour {

	public GameObject NameLabel;

	public void onInstantiateNameLabelActivated(GameObject nameLabelOwner)
	{

		GameObject characterNameLabel = PhotonNetwork.Instantiate ("PlayerNameNetwork", new Vector3(0f, 0f, 0f), Quaternion.identity, 0);//Instantiate (NameLabel);
//		Debug.Log ("viewID"+characterNameLabel.GetComponent<PhotonView>().viewID);
		characterNameLabel.transform.parent = gameObject.transform;
		//characterNameLabel.GetComponent<dfLabel> ().Text = "!!!";//nameLabelOwner.GetComponent<Character> ().showName;
		
		dfFollowObject characterNameFollow = characterNameLabel.GetComponent<dfFollowObject> ();
		characterNameFollow.attach = nameLabelOwner;
		characterNameFollow.enabled = true;
	}

	/*public void onDestoryCharacterActivated(GameObject destory)
	{
		Debug.Log ("onDestoryCharacterActivated: " + destory);
		dfFollowObject[] follows = gameObject.GetComponentsInChildren<dfFollowObject> ();
		foreach (dfFollowObject follow in follows) {
			Debug.Log("follow.attach" + follow.attach);
			if(follow.attach == destory){
				Debug.Log("Destroy");
				Destroy(follow.gameObject);
			}
		}
	}*/
}
