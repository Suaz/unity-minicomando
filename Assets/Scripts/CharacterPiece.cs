using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPiece : MonoBehaviour
{
    public string description;
    public bool active;

    // Update is called once per frame
    void Update()
    {
        this.enabled = active;
    }
}
