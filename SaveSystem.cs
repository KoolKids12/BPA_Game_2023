using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SaveSystem
{
    public static readonly string SAVE_FOLDER = Application.dataPath + "/Saves/"; //creates a path to a folder to put all of the saves in

    public static void Init()
    {
        if(!Directory.Exists(SAVE_FOLDER))// if the folder exists it does nothing, if it doesnt, it creates a folder
        {
            Directory.CreateDirectory(SAVE_FOLDER);
        }
    }
    public static void Save(string saveString, int i)
    {
        File.WriteAllText(SAVE_FOLDER +"/save." + i +"txt", saveString); // makes a save file with a number and writes the text given on it
    }
    public static string Load(int i)
    {
        if(File.Exists(SAVE_FOLDER + "/save." + i +"txt")) // reads the file with given number and places it in a string
        {
            string saveString = File.ReadAllText(SAVE_FOLDER + "/save." + i + "txt");
            return saveString;
        }
        else
        {
            return null;
        }
    }
}
