using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public Vector2 gunDirection;

    public float force;
    public GameObject PointsPrefab;
    public GameObject[] Points;

    public int numberOfpoints;
    void Start()
    {
        Points = new GameObject[numberOfpoints];

        for (int i = 0; i < numberOfpoints; i++)
        {
            Points[i] = Instantiate(PointsPrefab, transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 gunPos = transform.position;

        gunDirection = MousePos - gunPos;
        FaceMouse();
        
        for (int i = 0; i < Points.Length; i++)
        {
            Points[i].transform.position = PointPosition(i * 0.05f);
        }
    }

    void FaceMouse()
    {
        transform.right = gunDirection;
    }

    Vector2 PointPosition(float t)
    {
        Vector2 currentPointPos = (Vector2)transform.position + (gunDirection.normalized * force * t);

        return currentPointPos;
    }
}
