using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetup : MonoBehaviour
{
    [SerializeField] StrikerController controller;
    [SerializeField] CircleCollider2D circleCollider;
    [SerializeField] CircleCollider2D circleCollider2;
    public void setup()
    {
        controller.enabled = true;
        circleCollider.enabled = true;
        circleCollider2.enabled = true;    
    }
}
