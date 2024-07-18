using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using Unity.VisualScripting;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    // Start is called before the first frame update
    public ImageDemo imageDemo;
    private ImageApp imageApp;
    void Start()
    {
        imageApp = new ImageApp();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                ICommand toggleCommand = new TogglePowerCommand(imageDemo);
                imageApp.AddCommand(toggleCommand);
            }
            else if(Input.GetKeyDown(KeyCode.C))
            {
                ICommand changeColorCommand = new ChangeColorCommand(imageDemo);
                imageApp.AddCommand(changeColorCommand);
            }
            else if(Input.GetKeyDown(KeyCode.U))
            {
                imageApp.Undo();
            }
        }
    }
}
