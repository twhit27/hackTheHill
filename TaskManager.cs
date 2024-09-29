using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;
using System;
using System.Threading.Tasks;

public class TaskManager : MonoBehaviour
{
    // object for the user task
    public TMP_InputField taskInputField; 
    // object for the task level
    public TMP_InputField valueInputField;

    public Button submitButton; 
    public GameObject taskItemPrefab; 
    public Transform taskListParent; 

    public List<string> taskName = new List<string>();
    public List<string> taskValue = new List<string>();

    // begins the work of the script by waiting for user to hit submit button
    void Start()
    {
        submitButton.onClick.AddListener(AddTask); // Add listener to button
    }


    // will store the task from the user, then intiate the update to the scroll list
    public void AddTask()
    {
        // store data
        string newTask = taskInputField.text;
        string newvalue = valueInputField.text;

        // Safely convert the input to an integer (task level)
        if (!string.IsNullOrEmpty(newTask))
        {
            // Add the new task and level to the lists
            taskName.Add(newTask);
            taskValue.Add(newvalue);
            UpdateTaskList();

            // Clear input fields after adding the task
            taskInputField.text = "";
            valueInputField.text = "";
        }
    }

    public void UpdateTaskList()
    {
        // Remove all current items from the task list in the UI
        foreach (Transform child in taskListParent)
        {
            Destroy(child.gameObject);
        }

        // Loop through taskName and taskValue lists and create new items in the UI
        for (int i = 0; i < taskName.Count; i++)
        {
            string taskText = taskName[i];
            string taskLevel = taskValue[i];

            // Instantiate a new task item prefab and set its text
            GameObject taskItem = Instantiate(taskItemPrefab, taskListParent);
            TMP_Text textComponent = taskItem.GetComponent<TMP_Text>();

            if (textComponent != null)
            {
                textComponent.text = taskText + " - Level " + taskLevel;
            }
            else
            {
                Debug.LogError("TMP_Text component not found on the prefab.");
            }
        }
    }

}
