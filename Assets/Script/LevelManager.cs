using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    public Transform respawnPoint;
    public GameObject player1Prefab;
    private void Awake()
    {
        instance = this;
    }
  
    public void Respawn () {
        Instantiate(player1Prefab, respawnPoint.position, Quaternion.identity);
    }
}
