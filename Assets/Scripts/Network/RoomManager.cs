using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class RoomManager : MonoBehaviourPunCallbacks
{
    [SerializeField] GameObject player;
    [SerializeField] Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("connectin ...");

        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();

        Debug.Log("connected to server");

        PhotonNetwork.JoinLobby();
         
    }

    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();

        PhotonNetwork.JoinOrCreateRoom("test", null, null);

        Debug.Log("we are in a looby");

    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();

        Debug.Log("we are in a room");

        GameObject localPlayer = PhotonNetwork.Instantiate(player.name, spawnPoint.position, Quaternion.identity);

        localPlayer.GetComponent<PlayerSetup>().setup();
    }

}
