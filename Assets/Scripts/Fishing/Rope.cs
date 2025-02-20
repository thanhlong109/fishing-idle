using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    [SerializeField] private Transform[] points;

    private LineRenderer lineRenderer;
    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    private void Start()
    {
        MatchPoint();
    }


    void Update()
    {
        
    }

    private void MatchPoint()
    {
        for(int i = 0; i < points.Length; i++)
        {
            lineRenderer.SetPosition(i, points[i].position);
            if(i < points.Length - 1)
            {
                float distance = Vector3.Distance(points[i].position, points[i+1].position);
                lineRenderer.material.mainTextureScale = new Vector2(1, distance * 5);
            }
            
        }

        
    }
}
