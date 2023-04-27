using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float horizontalInput;
    [SerializeField] float verticalInput;
    [SerializeField] float speed = 10f;
    private Vector2 bulPos;

    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        GunShot();
        Use();
    }

    void Move()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector2.right * horizontalInput * speed * Time.deltaTime, Camera.main.transform);
        transform.Translate(Vector2.up * verticalInput * speed * Time.deltaTime, Camera.main.transform);
    }

    void GunShot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bullet.transform.position = new Vector2(transform.position.x, transform.position.y + 2f);
            
            Instantiate(bullet, bulPos, Quaternion.identity);
        }
    }

    void Use()
    {

    }

}
