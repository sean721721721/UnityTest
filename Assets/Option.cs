using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Option : MonoBehaviour {
    public bool isCorrect;
    public GameObject option1;
    public GameObject option2;
    // Use this for initialization
    void OnMouseDown()
    {
        if (isCorrect)
        {
            GetComponent<TextMesh>().color = Color.green;
            option1.GetComponent<TextMesh>().color = Color.red;
            option2.GetComponent<TextMesh>().color = Color.red;
        }
        else
        {
            GetComponent<TextMesh>().color = Color.red;
            if (option1.GetComponent<Option>().isCorrect)
            {
                option1.GetComponent<TextMesh>().color = new Color(1.0f, 0.64f, 0.0f, 1.0f);
            }
            else
            {
                option2.GetComponent<TextMesh>().color = new Color(1.0f, 0.64f, 0.0f, 1.0f);
            }

        }
    }
}
