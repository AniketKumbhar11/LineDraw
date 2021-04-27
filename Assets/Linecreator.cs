using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linecreator : MonoBehaviour
{
    public GameObject LinePrefab;
    Line ActiveLine;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           GameObject LinePre= Instantiate(LinePrefab);
           ActiveLine= LinePre.GetComponent<Line>();
        }
        if (ActiveLine!=null)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            ActiveLine.UpdateLine(mousePos);
        }
        if (Input.GetMouseButtonUp(0))
        {
            ActiveLine = null; 
        }
    }
}
