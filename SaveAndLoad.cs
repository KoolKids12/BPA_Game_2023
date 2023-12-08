using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAndLoad : MonoBehaviour
{
    // Start is called before the first frame updatepublic class SaveAndLoad : MonoBehaviour

    
    private string json = "";
     private int i;
    [SerializeField] public GameObject thingprefab, thingprefab2, thingprefab3;


    void Awake() 
    {
        SaveSystem.Init();
        LoadGame();
        Debug.Log("Done");
    }
    public void SaveGame()
    {
        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();

        for  ( i = 0; i<= allObjects.Length; i++)
        {
            SaveObject saveObject = new SaveObject
            {
                locate = allObjects[i].transform.position,

                tagg = allObjects[i].tag,

                names = allObjects[i].name
            };
            
            json = JsonUtility.ToJson(saveObject);

            SaveSystem.Save(json, i);

                Debug.Log(json);

            
        }
        
        

        


    }

    public void LoadGame()
    {
        GameObject[] remover;

        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();

        for  ( i = 0; i<= allObjects.Length; i++)
        {
            json = SaveSystem.Load(i);
        
            SaveObject loadedObject = JsonUtility.FromJson<SaveObject>(json);
            
            remover = GameObject.FindGameObjectsWithTag(loadedObject.tagg);

           //Debug.Log(remover[i]);

            //Destroy(remover[i-1]);
            
            if(loadedObject.tagg == "RefinedHolium1")
            {
                Instantiate(thingprefab, loadedObject.locate, Quaternion.identity);
            }
            if(loadedObject.tagg == "RefinedHolium2")
            {
                Instantiate(thingprefab2, loadedObject.locate, Quaternion.identity);
            }
            if(loadedObject.tagg == "RefinedHolium3")
            {
            Instantiate(thingprefab3, loadedObject.locate, Quaternion.identity);
            }

            
        }
               
        Debug.Log("Loaded");
        

    }

   
}

class SaveObject
{
    public Vector3 locate;   
    public string tagg;
    public string names;
}
