using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker : MonoBehaviour
{
    static Queue<ICommand> commandBuffer;

    private void Awake()
    {
        commandBuffer = new Queue<ICommand>();
    }
    void Update()
    {
        //1 command per frame

        if (commandBuffer.Count > 0)
        {
            commandBuffer.Dequeue().Execute();
        }
    }

    public static void AddCommand(ICommand command)
    {
        commandBuffer.Enqueue(command);
    }
}
