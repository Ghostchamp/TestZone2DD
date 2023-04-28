using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight2D : MonoBehaviour
{
    static GameObject NearTarget(Vector3 position, Collider2D[] array)
    {
        Collider2D current = null;
        float dist = Mathf.Infinity;

        foreach(Collider2D coll in array)
        {
            float curDist = Vector3.Distance(position, coll.transform.position);

            if (curDist < dist)
            {
                current = coll;
                dist = curDist;
            }    
        }

        return (current != null) ? current.gameObject : null;
    }

    public static void Action(Vector2 point, float radius, bool allTargets)
    {
        Collider2D[] coliders = Physics2D.OverlapCircleAll(point, radius);

        if(!allTargets)
        {
            GameObject obj = NearTarget(point, coliders);
            if(obj != null && obj.GetComponent<EnemyHp>())
            {
                Debug.Log("Hit");
                obj.GetComponent<EnemyHp>().DamageHeat();
            }
            return;
        }

        foreach (Collider2D hit in coliders)
        {
            if(hit.GetComponent<EnemyHp>())
            {
                hit.GetComponent<EnemyHp>().DamageHeat();
            }
        }
    }
}
