using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class player_pos : MonoBehaviour
{
    //vai de 0 a 8
    [SerializeField] public static int playerpos = 6;


    private void Awake()
    {
        playerpos = 4;
    }
 
    void Update()
    {
        transform.position = GameObject.Find("casas").transform.GetChild(playerpos).position;
    }
}
