using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSView : MonoBehaviour
{
    private FPSCount count = null;

    private void Awake()
    {
        Application.targetFrameRate = 60;

        count = new FPSCount();
        
    }

    private void Update()
    {
        count.CountUpDate();
    }

    void OnGUI()
    {
        string str;


        str = "FPS:";
        str += count.getfps().ToString();

        GUI.Label(new Rect(100, 0, 100, 50), str);
    }
}
