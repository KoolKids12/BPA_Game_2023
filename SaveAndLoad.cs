
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveAndLoad : MonoBehaviour
{
    // Start is called before the first frame updatepublic class SaveAndLoad : MonoBehaviour

    // sets all the generators and gameobjects to instances of prefabricated objects
    private string json = "";
    private int i;
    [SerializeField] public GameObject Coal1, Coal2, Coal3, Gold1, Gold2, Gold3, Oxy1, Oxy2, Oxy3, Rholium1, Rholium2, Rholium3, Builder1, Builder2, Builder3, Ballista, PumpkinLauncher, Bridge1, Bridge2, Bridge3, Masher, wall;

    private CoalGen coalGen;
    private GoldGen goldGen;
    private OxyGen oxyGen;
    private RholiumGen rholiumGenGen;

    void Awake() // it will start up the save system, and load the saved files if there are any
    {
        SaveSystem.Init();
        LoadGame();
        Debug.Log("Done");
    }
    public void SaveGame()
    {
        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();   // an array of all the objects in the scene

        for  ( i = 0; i<= allObjects.Length - 1; i++)   // goes through the list entry by entry
        {
        
        
            SaveObject saveObject = new SaveObject  // gets all the crucial information for recreation of the object on loading and saves the recources and troops 
            {
                locate = allObjects[i].transform.position,

                tagg = allObjects[i].tag,

                names = allObjects[i].name,

                gold = ResourceManager.gold,
                rholium = ResourceManager.refinedHolium,
                coal = ResourceManager.coal,
                oxy= ResourceManager.oxygen,
                grunt = ResourceManager.grunt,
                gobbler = ResourceManager.gobbler,
                shocktrooper = ResourceManager.shocktrooper,
                mech = ResourceManager.mech,
            };
            
            json = JsonUtility.ToJson(saveObject);

            SaveSystem.Save(json, i);

                Debug.Log(json);

            
        }
        


    }

    public void LoadGame()
    {

        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();    // an array of all the objects in the scene

        for  ( i = 0; i<= allObjects.Length; i++)   // goes through the list entry by entry
        {
        {
            json = SaveSystem.Load(i);
        
            SaveObject loadedObject = JsonUtility.FromJson<SaveObject>(json);   // // gets all the crucial information from the file and loads the object, the recources and troops 

            // this checks the file for what the object is and loads the correct object by the tag

            if(loadedObject.tagg == "Coal1")   
            {
                Instantiate(Coal1, loadedObject.locate, Quaternion.identity);
            }
            if(loadedObject.tagg == "Coal2")
            {
                Instantiate(Coal2, loadedObject.locate, Quaternion.identity);
            }
            if(loadedObject.tagg == "Coal3")
            {
            Instantiate(Coal3, loadedObject.locate, Quaternion.identity);
            }
            
            if(loadedObject.tagg == "Gold1")
            {
                Instantiate(Gold1, loadedObject.locate, Quaternion.identity);
            }
            if(loadedObject.tagg == "Gold2")
            {
                Instantiate(Gold2, loadedObject.locate, Quaternion.identity);
            }
            if(loadedObject.tagg == "Gold3")
            {
            Instantiate(Gold3, loadedObject.locate, Quaternion.identity);
            } 

            if(loadedObject.tagg == "Oxygen1")
            {
                Instantiate(Oxy1, loadedObject.locate, Quaternion.identity);
            }
            if(loadedObject.tagg == "Oxygen2")
            {
                Instantiate(Oxy2, loadedObject.locate, Quaternion.identity);
            }
            if(loadedObject.tagg == "Oxygen3")
            {
            Instantiate(Oxy3, loadedObject.locate, Quaternion.identity);
            }

            if(loadedObject.tagg == "RefinedHolium1")
            {
                Instantiate(Rholium1, loadedObject.locate, Quaternion.identity);
            }
            if(loadedObject.tagg == "RefinedHolium2")
            {
                Instantiate(Rholium2, loadedObject.locate, Quaternion.identity);
            }
            if(loadedObject.tagg == "RefinedHolium3")
            {
            Instantiate(Rholium3, loadedObject.locate, Quaternion.identity);
            }
            if(loadedObject.tagg == "Bridge1")
            {
            Instantiate(Bridge1, loadedObject.locate, Quaternion.identity);
            }
            if(loadedObject.tagg == "Bridge2")
            {
            Instantiate(Bridge2, loadedObject.locate, Quaternion.identity);
            }
            if(loadedObject.tagg == "Bridge3")
            {
            Instantiate(Bridge3, loadedObject.locate, Quaternion.identity);
            }
            if(loadedObject.tagg == "Wall")
            {
            Instantiate(wall, loadedObject.locate, Quaternion.identity);
            }
            if(loadedObject.tagg == "Pumpkin")
            {
            Instantiate(PumpkinLauncher, loadedObject.locate, Quaternion.identity);
            }
            if(loadedObject.tagg == "Masher")
            {
            Instantiate(Masher, loadedObject.locate, Quaternion.identity);
            }
            if(loadedObject.tagg == "Ballista")
            {
            Instantiate(Ballista, loadedObject.locate, Quaternion.identity);
            }

            GameObject coalob1;
            coalob1 = GameObject.FindGameObjectWithTag("Coal1");
            if(coalob1 != null)
            {
                coalGen = coalob1.GetComponent<CoalGen>();
                coalGen.coal = loadedObject.coal;

            }
            

            ResourceManager.coal = loadedObject.coal;
            ResourceManager.gold = loadedObject.gold;
            ResourceManager.oxygen = loadedObject.oxy;
            ResourceManager.refinedHolium = loadedObject.rholium;
            ResourceManager.grunt = loadedObject.grunt;
            ResourceManager.gobbler = loadedObject.gobbler;
            ResourceManager.shocktrooper = loadedObject.shocktrooper;
            ResourceManager.mech = loadedObject.mech;

            
            
            
        
            
        }
            return;
               
        Debug.Log("Loaded");
        

    }

    }
}

class SaveObject // holds the crucial data for saving and loading
{
    public Vector3 locate;   
    public string tagg;
    public string names;
    public int oxy, gold, rholium, coal;

    public int grunt, gobbler, shocktrooper, mech;
}