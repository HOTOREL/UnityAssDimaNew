using UnityEngine;

public class BikePart : MonoBehaviour
{
    [SerializeField]
    string partName = "Unnamed";

    public string PartName => partName;

    public void SetHighlighted(bool value)
    {
        Material material = GetComponent<Renderer>().material;

        material.SetColor("_EmissionColor", value ? new Color(0.5f, 0.5f, 0.5f, 1) : Color.black);
        material.EnableKeyword("_EMISSION");
    }
}
