using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAndLoad : MonoBehaviour
{
    // Start is called before the first frame updatepublic class SaveAndLoad : MonoBehaviour

    
    public string json = "";
     public int i;


    void Awake() 
    {
        SaveSystem.Init();
        FakeSave();
        //LoadGame();
        Debug.Log("Done");
    }
    public void SaveGame()
    {
        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();

        for  ( i = 1; i<= allObjects.Length; i++)
        {
            SaveObject saveObject = new SaveObject
            {
                locate = allObjects[i].transform.position

                
            };
            
            allObjects[i].name = i.ToString();
            
            json = JsonUtility.ToJson(saveObject);

            SaveSystem.Save(json, i);

                Debug.Log(json);

            
        }
        
        

        


    }

       
    
    public void FakeSave()
    {
        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();

        for  ( i = 1; i<= allObjects.Length; i++)
        {
            SaveObject saveObject = new SaveObject
            {
                locate = allObjects[i].transform.position

                
            };
            
            allObjects[i].name = i.ToString();
            
            json = JsonUtility.ToJson(saveObject);
            
        }
        
        



    }
    public void LoadGame()
    {

        GameObject gameObject;
        

        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();

        for  ( i = 1; i<= allObjects.Length; i++)
        {
            allObjects[i].name = i.ToString();

            json = SaveSystem.Load(i);
        
            SaveObject loadedObject = JsonUtility.FromJson<SaveObject>(json);
            
            gameObject = allObjects[i];

               Debug.Log(gameObject.name);
          

                gameObject.transform.position = loadedObject.locate;
            
            
        }
               
        Debug.Log("Loaded");
        

    }

   
}

class SaveObject
{
    public Vector3 locate;   
}