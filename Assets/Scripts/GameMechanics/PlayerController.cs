using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float horizontalInput;
    [SerializeField] float verticalInput;
    [SerializeField] float speed = 10f;

    public GameObject UI;
    private Vector2 bulPos;
    public Transform punch;
    [SerializeField] private int chooseTool = 1;
    
    private float punchRadius = 0.2f;

    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        UI.GetComponent<ToolBarUI>().ChoosenIcon(chooseTool);
    }

    // Update is called once per frame
    void Update()
    {
        ChooseTool();
        Move();
        CheckTool();
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
            bulPos = new Vector2(transform.position.x, transform.position.y);
            Instantiate(bullet, bulPos, Quaternion.identity);
        }
    }

    void Punch()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Fight2D.Action(punch.position, punchRadius, false);
        }
    }

    void ChooseTool()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            chooseTool = 1;
            UI.GetComponent<ToolBarUI>().ChoosenIcon(chooseTool);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            chooseTool = 2;
            UI.GetComponent<ToolBarUI>().ChoosenIcon(chooseTool);
        }
    }

    private void CheckTool()
    {
        if(chooseTool == 1)
        {
            GunShot();
        }
        if(chooseTool == 2)
        {
            Punch();
        }
    }
}
