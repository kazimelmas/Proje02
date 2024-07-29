using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharInfo : MonoBehaviour
{
    public string charName = "";
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshPro>().text = charName;
    }
}
