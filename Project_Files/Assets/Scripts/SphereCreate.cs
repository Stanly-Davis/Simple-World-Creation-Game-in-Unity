
using UnityEngine;

public class SphereCreate : MonoBehaviour
{
    public GameObject[] sphere = new GameObject[5]; //5 cubes
    public int sphere_no=0;
    int sphere_pos=-3;
    public void makeSphere()
    {

            if(sphere_no <= 4)
            {
                
                sphere[sphere_no] = new GameObject();
                sphere[sphere_no].name= "sphere"+" "+ sphere_no;

                // Mesh filter
                Mesh cubeMesh = Resources.GetBuiltinResource<Mesh>("Sphere.fbx");
                sphere[sphere_no].AddComponent<MeshFilter>().mesh = cubeMesh;

                // MeshRenderer
                MeshRenderer cubeRenderer =sphere[sphere_no].AddComponent<MeshRenderer>();
                Material cubeMaterial = new Material(Shader.Find("Standard"));
                cubeMaterial.color = Color.blue;
                cubeRenderer.sharedMaterial = cubeMaterial;

                // Scaling and position
                sphere[sphere_no].transform.localScale = new Vector3(1f,1f,1f);
                sphere[sphere_no].transform.position = new Vector3(0, 4f,sphere_pos);

                // Box collider is needed to detect Mouse operatoins
                sphere[sphere_no].AddComponent<BoxCollider>();

                // Attach DragDrop script
                sphere[sphere_no].AddComponent<DraggingDropping>();

                // Objects should be taken to next scene
                DontDestroyOnLoad(sphere[sphere_no]);

                sphere_no = sphere_no+1;
                sphere_pos = sphere_pos+2;

            }
    }
}
