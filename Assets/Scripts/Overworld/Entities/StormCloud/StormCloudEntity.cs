using UnityEngine;

public class StormCloudEntity : OverworldEntity, IGrappler
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
    
    public void Attach()
    {
        throw new System.NotImplementedException();
    }

    public void Detach()
    {
        throw new System.NotImplementedException();
    }
}
