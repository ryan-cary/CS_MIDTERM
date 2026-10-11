using UnityEngine;

public class LeviathanEntity : OverworldEntity, IGrappler
{
    [SerializeField] private Vector3 grappleOffset;

    protected void Update()
    {
        base.Update();
    }

    public bool IsAttached { get; set; }

    public void Attach()
    {
        IsAttached = true;
    }

    public void Detach()
    {
        IsAttached = false;
    }
}
