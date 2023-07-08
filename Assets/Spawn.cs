using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RosSharp.RosBridgeClient;
using RosSharp.RosBridgeClient.MessageTypes.Std;

public class Spawn : MonoBehaviour
{
    private RosSocket rosSocket;
    private string robotDescription;

    // Start is called before the first frame update
    void Start()
    {
        // Create the WebSocketNetProtocol object
        var webSocketNetProtocol = new RosSharp.RosBridgeClient.Protocols.WebSocketNetProtocol("ws://127.0.0.1:9090");

        // Create the RosSocket object using the WebSocketNetProtocol
        rosSocket = new RosSocket(webSocketNetProtocol);
    }

    // Update is called once per frame
    void PublishRobotDescription()
    {
        String message = new String
        {
            data = robotDescription
        };

        rosSocket.Publish("/robot_description", message);
    }
}

