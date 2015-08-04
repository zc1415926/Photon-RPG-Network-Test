using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour {

	public delegate void InstantiateGameObjectEventHandler(GameObject character);
	public event InstantiateGameObjectEventHandler InstantiateNameLabelActivated;

	//public delegate void DestoryGameObjectEventHandler();
	//public event InstantiateGameObjectEventHandler DestoryCharacterActivated;

	public void CastInstantiatePlayerNameLabel(GameObject nameLabelOwner){
		InstantiateNameLabelActivated (nameLabelOwner);
	}

	/*public void CastDestoryCharacter(GameObject destory)
	{
		Debug.Log ("CastDestoryCharacter");
		DestoryCharacterActivated (destory);
	}*/
}
