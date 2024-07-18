using UnityEngine.UI;

public class TogglePowerCommand: ICommand
{
    private ImageDemo imageDemo;
    
    public TogglePowerCommand(ImageDemo image)
    {
        this.imageDemo = image;
    }
    public void Execute()
    {
        imageDemo.TogglePower();
    }

    public void Undo()
    {
        imageDemo.TogglePower();
    }
}
