
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SaveAndLoad : MonoBehaviour
{
    // Start is called before the first frame updatepublic class SaveAndLoad : MonoBehaviour

    
    private string json = "";
    private int i;
    [SerializeField] public GameObject Coal1, Coal2, Coal3, Gold1, Gold2, Gold3, Oxy1, Oxy2, Oxy3, Rholium1, Rholium2, Rholium3, Builder1, Builder2, Builder3;

    private CoalGen coalGen;
    private GoldGen goldGen;
    private OxyGen oxyGen;
    private RholiumGen rholiumGenGen;

    void Awake() 
    {
        SaveSystem.Init();
        LoadGame();
        Debug.Log("Done");
    }
    public void SaveGame()
    {
        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();

        for  ( i = 0; i<= allObjects.Length - 1; i++)
        {
        
        
            SaveObject saveObject = new SaveObject
            {
                locate = allObjects[i].transform.position,

                tagg = allObjects[i].tag,

                names = allObjects[i].name,

                gold = ResourceManager.gold,
                rholium = ResourceManager.refinedHolium,
                coal = ResourceManager.coal,
                oxy= ResourceManager.oxygen,
            };
            
            json = JsonUtility.ToJson(saveObject);

            SaveSystem.Save(json, i);

                Debug.Log(json);

            
        }
        
        
        return;
        


    }

    public void LoadGame()
    {

        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();

        for  ( i = 0; i<= allObjects.Length; i++)
        {
            json = SaveSystem.Load(i);
        
            SaveObject loadedObject = JsonUtility.FromJson<SaveObject>(json);

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
            

            
            
            
            
        
            
        }
               
        Debug.Log("Loaded");
        

    }

   
}

class SaveObject
{
    public Vector3 locate;   
    public string tagg;
    public string names;
    public int oxy, gold, rholium, coal;

   // public double grunt, shockTrooper, Gobbler, brute;
}