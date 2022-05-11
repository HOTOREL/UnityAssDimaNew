using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Selector : MonoBehaviour
{
    [SerializeField]
    Camera cam;

    [SerializeField]
    TextMeshPro partNameText;

    private BikePart highlighted;
    private void Start()
    {
        partNameText.gameObject.SetActive(false);
    }
    //private void Update()
    //{
    //    if (highlighted != null)
    //        highlighted.SetHighlighted(false);
    //
    //    partNameText.gameObject.SetActive(false);
    //
    //    Ray ray = cam.ScreenPointToRay(Input.mousePosition);
    //
    //    if (Physics.Raycast(ray, out RaycastHit hit))
    //    {
    //        BikePart hitPart = hit.collider.GetComponentInParent<BikePart>();
    //
    //        if (hitPart != null)
    //        {
    //            hitPart.SetHighlighted(true);
    //
    //            highlighted = hitPart;
    //
    //            partNameText.gameObject.SetActive(true);
    //
    //            partNameText.transform.position = hitPart.transform.position;
    //            partNameText.text = hitPart.PartName;                
    //        }
    //    }
    //}
    public void OnSelect(SelectEnterEventArgs Args)
    {
        partNameText.gameObject.SetActive(true);
        BikePart Wheel = Args.interactableObject.transform.GetComponent<BikePart>();
        partNameText.text = Wheel.PartName;
    }
    public void OnDeselect(SelectExitEventArgs Args)
    {
        partNameText.gameObject.SetActive(false);        
    }
}
