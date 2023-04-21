using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject map;
    [SerializeField] private GameObject player;

    public void OnStartGame()
    {
        map.SetActive(true); 
        player.SetActive(true);
    }
}
