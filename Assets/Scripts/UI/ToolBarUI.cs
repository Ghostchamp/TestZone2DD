using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolBarUI : MonoBehaviour
{
    public Image firstIcon;
    public Image secondIcon;

    private Color activIcon = new(0.12f, 0.79f, 0.51f);
    private Color inActiveIcon = new(1f, 1f, 1f);

    public void ChoosenIcon(int id)
    {
        if(id == 1)
        {
            firstIcon.GetComponent<Image>().color = activIcon;
            secondIcon.GetComponent<Image>().color = inActiveIcon;
        }
        if (id == 2)
        {
            firstIcon.GetComponent<Image>().color = inActiveIcon;
            secondIcon.GetComponent<Image>().color = activIcon;
        }
    }
}
