using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour {
    public GameController controller;
    // Use this for initialization
    void OnMouseDown()
    {
        controller.GenerateQuestion();
    }
}
