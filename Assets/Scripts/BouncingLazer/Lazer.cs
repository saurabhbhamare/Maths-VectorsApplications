using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Vector2 origin = transform.position;
        Vector2 dir = transform.right;
        Ray ray = new Ray(origin, dir);
        Gizmos.DrawLine(origin, origin + dir);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Gizmos.DrawSphere(hit.point, 0.2f);
        }
        Vector2 reflected = Reflect(ray.direction, hit.normal);
        Gizmos.DrawLine(hit.point, (Vector2)hit.point + reflected);
    }
    private Vector2 Reflect(Vector2 inDir, Vector2 n)
    {
        float proj = Vector2.Dot(inDir, n);
        Vector2 reflectedRay = inDir - 2 * proj * n;
        return reflectedRay;
    }
}
