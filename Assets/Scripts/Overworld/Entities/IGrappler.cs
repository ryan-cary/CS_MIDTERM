using UnityEngine;

public interface IGrappler
{
    public bool IsAttached { get; }

    public void Attach()
    { }

    public void Detach()
    { }
}
