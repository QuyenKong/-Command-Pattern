using UnityEngine;
using UnityEngine.UI;

public class ImageDemo: MonoBehaviour
{
    private bool isActive;
    public void TogglePower()
    {
        if (isActive)
        {
            GetComponent<Image>().gameObject.SetActive(false);
            isActive = false;
        }else
        {
            GetComponent<Image>().gameObject.SetActive(true);
            isActive = true;
        }
    }

    public void ChangeRandomColor()
    {
        GetComponent<Image>().color = new Color(RandomNumber(), RandomNumber(), RandomNumber());
    }

    public void SetColor(Color color)
    {
        GetComponent<Image>().color = color;
    }
    
    //random number from 0 to 255
    private static float RandomNumber()
    {
        return Random.Range(0f, 1f);
    }
}
