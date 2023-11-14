using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAndLoad : MonoBehaviour
{
    // Start is called before the first frame updatepublic class SaveAndLoad : MonoBehaviour

    
    public string json = "";
    public void SaveGame()
    {

        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
        for  (int i = 1; i<= allObjects.Length -1; i++)
        {
            SaveObject saveObject = new SaveObject
            {
        
                temp = allObjects[i],
                locate = allObjects[i].transform.position

               
            };
            
             if(LoadGame() == true)
                {
                    allObjects[i].transform.position = (saveObject.locate);
                }
            json = JsonUtility.ToJson(saveObject);

                Debug.Log(json);
        }
        
        

        


    }

       
    
    
    public bool LoadGame()
    {
        SaveObject loadedObject = JsonUtility.FromJson<SaveObject>(json);

        Debug.Log("Loaded");

        return true;
    }

   
}

class SaveObject
{
    public GameObject temp;
    
    public Vector3 locate;
    
}