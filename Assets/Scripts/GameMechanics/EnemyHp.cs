using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyHp : MonoBehaviour
{
    public TextMeshProUGUI healthIndicator;
    private int HP = 3;

    private void Update()
    {
        healthIndicator.text = HP.ToString();
        if (!(HP > 0))
        {
            Destroy(gameObject);
        }
    }

    public void DamageHeat()
    {
        HP--;
    }

    public int GetHp()
    {
        return HP;
    }
}
