using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

// TASKS:
// include toggle for completion
// generate coin reward 
public class checkbox : MonoBehaviour
{
    public Text taskText;
    public Toggle taskToggle;
    private TaskManager taskManager;



    public void SetTask(TaskManager tasker)
    {
        //taskText.text = $"{task} - {number}";
        taskToggle.isOn = false; // Default state of the toggle
        taskManager = tasker;
    }

    public void OnToggleChanged(bool isChecked)
    {
        if (isChecked)
        {
            if (isChecked)
            {
                Destroy(gameObject);
                taskManager.UpdateTaskList();
            }
        }

    }
}
