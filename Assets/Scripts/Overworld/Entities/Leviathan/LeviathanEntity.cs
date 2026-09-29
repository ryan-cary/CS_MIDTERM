using UnityEngine;

public class LeviathanEntity : OverworldEntity, IGrappler
{
    [SerializeField] private Vector3 grappleOffset;

    protected void Update()
    {
        base.Update();
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
