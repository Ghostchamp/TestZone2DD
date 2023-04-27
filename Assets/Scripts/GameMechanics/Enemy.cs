using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int healtPoint = 3;
    private SpawnManager spawnManager;
    public TextMeshProUGUI healthIndicator;

    // Start is called before the first frame update
    void Start()
    {
        healthIndicator.text = healtPoint.ToString();
        spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            if(healtPoint > 1)
            {
                healtPoint--;
                healthIndicator.text = healtPoint.ToString();
            }
            else
            {
                Destroy(gameObject.gameObject);
                spawnManager.SpawnEnemies();
            }
        }
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }
}
