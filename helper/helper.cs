using System.Runtime.InteropServices.WindowsRuntime;
using RaftModLoader;
﻿using UnityEngine;
using HMLLibrary;

public class Helper : Mod
{
    public void Start()
    {
        RConsole.Log("Helper loaded");
        RegisterCommands();
    }

    public  void OnModUnload()
    {
        Debug.Log("Mod Helper has been unloaded!");
    }

    private void RegisterCommands()
    {
   
    }

    private static void TeleportRaft(string[] args)
    {
        if (args.Length != 3)
        {
            RConsole.Log("Verwendung: /tpraft <x> <y> <z>");
            return;
        }

        if (float.TryParse(args[0], out float x) && float.TryParse(args[1], out float y) && 
            float.TryParse(args[2], out float z))
        {
            GameObject raft = GameObject.Find("Raft");

            if (raft != null)
            {
                raft.transform.position = new Vector3(x, y, z);
                RConsole.Log($"Floß teleportiert zu: {x}, {y}, {z}");
            }
            else
            {
                RConsole.Log("Floß nicht gefunden.");
            }
        }
        else
        {
            RConsole.Log("Ungültige Koordinaten. Verwendung: /tpraft <x> <y> <z>");
        }
    }
}