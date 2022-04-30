using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    [SerializeField] ClickablePlayer[] players;
    ClickablePlayer currentPlayer;
    // Start is called before the first frame update
    void Start()
    {
        foreach(ClickablePlayer p in players)
        {
            p.selected = false;
        }
        SetPlayer(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetPlayer(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetPlayer(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetPlayer(2);
        }
    }

    private void SetPlayer(int i)
    {
        if(currentPlayer != null)
        {
            currentPlayer.selected = false;
        }
        players[i].selected = true;
        currentPlayer = players[i];
    }
}
