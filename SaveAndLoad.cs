
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
    private ResourceManager resourceManager;

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
            
            GameObject coalob1;
            coalob1 = GameObject.FindGameObjectWithTag("Coal1");

             coalGen = coalob1.GetComponent<CoalGen>();

            GameObject goldob1;
            goldob1 = GameObject.FindGameObjectWithTag("Gold1");

            goldGen = goldob1.GetComponent<GoldGen>();
            
            GameObject oxyob1;
            oxyob1 = GameObject.FindGameObjectWithTag("Oxygen1");

            oxyGen = oxyob1.GetComponent<OxyGen>();
            
            GameObject rholiumob1;
            rholiumob1 = GameObject.FindGameObjectWithTag("RefinedHolium1");

            rholiumGenGen = rholiumob1.GetComponent<RholiumGen>();


            
        
        
            SaveObject saveObject = new SaveObject
            {
                locate = allObjects[i].transform.position,

                tagg = allObjects[i].tag,

                names = allObjects[i].name,

                gold = resourceManager.gold,
                rholium = resourceManager.refinedHolium,
                coal = resourceManager.coal,
                oxy= resourceManager.oxygen,
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
            

            GameObject goldob1;
            goldob1 = GameObject.FindGameObjectWithTag("Gold1");
            if(goldob1 != null)
            {
                goldGen = goldob1.GetComponent<GoldGen>();
                goldGen.gold = loadedObject.gold;  
            }
            
            
            GameObject oxyob1;
            oxyob1 = GameObject.FindGameObjectWithTag("Oxygen1");
            if(oxyob1 != null)
            {
                oxyGen = oxyob1.GetComponent<OxyGen>();
                oxyGen.oxygen = loadedObject.oxy;
            }
            
            
            GameObject rholiumob1;
            rholiumob1 = GameObject.FindGameObjectWithTag("RefinedHolium1");
            if(rholiumob1 != null)
            {
                rholiumGenGen = rholiumob1.GetComponent<RholiumGen>();
                rholiumGenGen.refinedholium = loadedObject.rholium;

            }
            
            GameObject coalob2;
            coalob2 = GameObject.FindGameObjectWithTag("Coal2");
            if(coalob2 != null)
            {
                coalGen = coalob2.GetComponent<CoalGen>();
                coalGen.coal = loadedObject.coal;
            }
            

            GameObject goldob2;
            goldob2 = GameObject.FindGameObjectWithTag("Gold2");
            if(goldob2 != null)
            {
                goldGen = goldob2.GetComponent<GoldGen>();
                goldGen.gold =loadedObject.gold;  
            }
            
            
            GameObject oxyob2;
            oxyob2 = GameObject.FindGameObjectWithTag("Oxygen2");
            if(oxyob2 != null)
            {
                oxyGen = oxyob2.GetComponent<OxyGen>();
                oxyGen.oxygen = loadedObject.oxy;
            }
            
            
            GameObject rholiumob2;
            rholiumob2 = GameObject.FindGameObjectWithTag("RefinedHolium2");
            if(rholiumob2 != null)
            {
                rholiumGenGen = rholiumob2.GetComponent<RholiumGen>();
                rholiumGenGen.refinedholium = loadedObject.rholium;
            }
            GameObject coalob3;
            coalob3 = GameObject.FindGameObjectWithTag("Coal3");
            if(coalob3 != null)
            {
                coalGen = coalob3.GetComponent<CoalGen>();
                coalGen.coal = loadedObject.coal;
            }
            

            GameObject goldob3;
            goldob3 = GameObject.FindGameObjectWithTag("Gold3");
            if(goldob3 != null)
            {
                goldGen = goldob3.GetComponent<GoldGen>();
                goldGen.gold =loadedObject.gold;  
            }
            
            
            GameObject oxyob3;
            oxyob3 = GameObject.FindGameObjectWithTag("Oxygen3");
            if(oxyob3 != null)
            {
                oxyGen = oxyob3.GetComponent<OxyGen>();
                oxyGen.oxygen = loadedObject.oxy;
            }
            
            
            GameObject rholiumob3;
            rholiumob3 = GameObject.FindGameObjectWithTag("RefinedHolium3");
            if(rholiumob3 != null)
            {
                rholiumGenGen = rholiumob3.GetComponent<RholiumGen>();
                rholiumGenGen.refinedholium = loadedObject.rholium;
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
    public int oxy, gold, rholium, coal;

   // public double grunt, shockTrooper, Gobbler, brute;
}