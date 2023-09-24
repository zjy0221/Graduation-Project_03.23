using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.U2D.Animation;

public class dolumi : MonoBehaviour
{
    public List<SpriteResolver> spriteResolvers = new List<SpriteResolver>();
    public GameObject arm;
    public GameObject tool;
    // Start is called before the first frame update
    SpriteResolver toolResolver;
    void Start()
    {
        foreach (var resolver in FindObjectsOfType<SpriteResolver>())
        {
            spriteResolvers.Add(resolver);

        }
    }

    // Update is called once per frame
    // void Update()
    // {

    //     if(Input.GetKeyDown(KeyCode.A)){
    //         foreach (var resolver in FindObjectsOfType<SpriteResolver>())
    //         {
    //             resolver.SetCategoryAndLabel(resolver.GetCategory(),"normal");
    //         }
    //     }

    //     if(Input.GetKeyDown(KeyCode.B)){
    //         foreach (var resolver in FindObjectsOfType<SpriteResolver>())
    //         {
    //             resolver.SetCategoryAndLabel(resolver.GetCategory(),"sleep");
    //         }
    //     }

    //     if(Input.GetKeyDown(KeyCode.C)){
    //         foreach (var resolver in FindObjectsOfType<SpriteResolver>())
    //         {
    //             resolver.SetCategoryAndLabel(resolver.GetCategory(),"god");
    //         }
    //     }

    //     if(Input.GetKeyDown(KeyCode.D)){
    //         foreach (var resolver in FindObjectsOfType<SpriteResolver>())
    //         {
    //             resolver.SetCategoryAndLabel(resolver.GetCategory(),"day");
    //         }
    //     }

    //     if(Input.GetKeyDown(KeyCode.Q)){
    //         if(arm.activeInHierarchy == true){
    //             tool.SetActive(true);
    //         arm.SetActive(false);
    //         }
    //     }

    //     if(Input.GetKeyDown(KeyCode.Q)){
    //         if(arm.activeInHierarchy == false){
    //              tool.SetActive(false);
    //         arm.SetActive(true);
    //         }
    //     }



    // }


}
