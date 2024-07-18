using UnityEngine;
using UnityEngine.UI;

public class ChangeColorCommand: ICommand
{
    private ImageDemo imageDemo;
    
    private Color periousColor;
    public ChangeColorCommand(ImageDemo image)
    {
        this.imageDemo = image;
        periousColor = imageDemo.GetComponent<Image>().color;
    }
    public void Execute()
    {
        imageDemo.ChangeRandomColor();
    }
    public void Undo()
    {
        imageDemo.SetColor(periousColor);
    }
}
