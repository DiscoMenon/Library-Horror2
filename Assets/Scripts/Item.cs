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
            playerPickUpClass.SetOverlappingItem(gameObject);
        }
    }
}
