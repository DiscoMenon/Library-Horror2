using UnityEngine;


public class Item : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other != null && other.CompareTag("Player"))
        {
            PickUp playerPickUpClass = other.GetComponent<PickUp>();
            if (playerPickUpClass == null)
            {
                Debug.LogError("Player does not have a PickUp component attached.");
                return;
            }
            playerPickUpClass.SetOverlappingItem(gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other != null && other.CompareTag("Player"))
        {
            PickUp playerPickUpClass = other.GetComponent<PickUp>();
            playerPickUpClass.SetOverlappingItem(null);
        }
    }
}
