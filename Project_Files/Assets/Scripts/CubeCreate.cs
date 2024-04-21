
using UnityEngine;

public class CubeCreate : MonoBehaviour
{
    public GameObject[] cube = new GameObject[5]; //5 cubes
    public int cube_no=0;
    int cube_pos=-2;
    public void makeCube()
    {
            if(cube_no <= 4)
            {
                
                cube[cube_no] = new GameObject();
                cube[cube_no].name= "cube"+" "+ cube_no;

                // Mesh filter
                Mesh cubeMesh = Resources.GetBuiltinResource<Mesh>("Cube.fbx");
                cube[cube_no].AddComponent<MeshFilter>().mesh = cubeMesh;

                // MeshRenderer
                MeshRenderer cubeRenderer = cube[cube_no].AddComponent<MeshRenderer>();
                Material cubeMaterial = new Material(Shader.Find("Standard"));
                cubeMaterial.color = Color.red;
                cubeRenderer.sharedMaterial = cubeMaterial;

                // Scaling and position
                cube[cube_no].transform.localScale = new Vector3(1f,1f,1f);
                cube[cube_no].transform.position = new Vector3(1, 5f, cube_pos);

                // Box collider is needed to detect Mouse operatoins
                cube[cube_no].AddComponent<BoxCollider>();

                // Attach DragDrop script
                cube[cube_no].AddComponent<DraggingDropping>();

                // Objects should be taken to next scene
                DontDestroyOnLoad(cube[cube_no]);

                cube_no = cube_no+1;
                cube_pos = cube_pos+2;

            }
    }
}
