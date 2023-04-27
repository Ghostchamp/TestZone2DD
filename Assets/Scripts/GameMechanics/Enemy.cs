using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int healtPoint = 3;
    public TextMeshProUGUI healthIndicator;

    // Start is called before the first frame update
    void Start()
    {
        healthIndicator.text = healtPoint.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
