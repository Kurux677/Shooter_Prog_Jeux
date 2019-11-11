using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class SpawnManager : NetworkBehaviour {
    public GameObject scoreDisplayerPrefab;
    public GameObject playerRespawnManagerPrefab;
    public GameObject middleOscillatorPrefab;
    public GameObject RedSide;
    public GameObject BlueSide;
    // Use this for initialization
    void Start () {
       
    }
    [Command]
    public void CmdSpawnManager()
    {
        GameObject scoreDisplayer = (GameObject)Instantiate(scoreDisplayerPrefab);
        NetworkServer.Spawn(scoreDisplayer);
        GameObject playerRespawnManager = (GameObject)Instantiate(playerRespawnManagerPrefab);
        NetworkServer.Spawn(playerRespawnManager);
    }

    [Command]
    public void CmdSpawnOscillator()
    {
        GameObject middleOscilator = (GameObject)Instantiate(middleOscillatorPrefab,RedSide.transform);
        middleOscilator.transform.localPosition = new Vector3(12.5f, 0, 23);
        NetworkServer.Spawn(middleOscilator);
        middleOscilator = (GameObject)Instantiate(middleOscillatorPrefab, BlueSide.transform);
        middleOscilator.transform.localPosition = new Vector3(12.5f, 0, 23);
        NetworkServer.Spawn(middleOscilator);
    }
	
	
    
    
}
