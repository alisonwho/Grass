using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropOrbs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject glowOrb;
    public Transform player;
    public float yOffset;
    public float objScale;
    public bool placingOrb = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && placingOrb == false)
        {
            placingOrb = true;
            StartCoroutine(DropOrb());
        }
    }

    IEnumerator DropOrb()
    {
        GameObject newObj = Instantiate(glowOrb,new Vector3(player.localPosition.x, player.localPosition.y + yOffset, player.localPosition.z), Quaternion.identity);
        newObj.transform.localScale = new Vector3(objScale, objScale, objScale);
        yield return new WaitForSeconds(0.1f);
        placingOrb = false;
    }
}
