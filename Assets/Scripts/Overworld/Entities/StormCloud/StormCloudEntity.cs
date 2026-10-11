using UnityEngine;

public class StormCloudEntity : OverworldEntity
{
    [SerializeField] private GameObject mainBolt;
    [SerializeField] private GameObject[] feelerBolts;
    [SerializeField] private Transform[] feelerEnds;

    protected new void Start()
    {
        base.Start();
        
        //ensuring appropriate bolts are visible
        mainBolt.gameObject.SetActive(false);
        foreach(GameObject bolt in feelerBolts)
            bolt.gameObject.SetActive(true);
    }
}
