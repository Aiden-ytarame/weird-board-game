using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class casas_script : MonoBehaviour
{
    public int casa;
    private void OnMouseDown()
    {
        player_pos.playerpos = casa;
    }
}
