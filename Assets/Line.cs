using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public LineRenderer linerenderer;
    public EdgeCollider2D edgecollider2d;

    List<Vector2> points;

    private void Start()
    {

        edgecollider2d = GetComponent<EdgeCollider2D>();
    }
    public void UpdateLine(Vector2 mousepos)
    {
        if (points==null)
        {
            points = new List<Vector2>();
            setPoints(mousepos);
            return;
        }
        if(Vector2.Distance(points.Last(),mousepos)>0.1f)
        {
            setPoints(mousepos);
        }
    }

    public void setPoints(Vector2 point)
    {
        points.Add(point);
        linerenderer.positionCount = points.Count;
        linerenderer.SetPosition(points.Count - 1, point);
        if (points.Count>1)
 
        edgecollider2d .points = points.ToArray();
    }
}
