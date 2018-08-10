using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exception : MonoBehaviour {


 
        static int GetInt(int[] array, int index)
        {
            try
            {
                return array[index];
            }
            catch (System.IndexOutOfRangeException e)  // CS0168
            {
                print(e.Message);
                // Set IndexOutOfRangeException to the new exception's InnerException. 
                throw new System.ArgumentOutOfRangeException("index parameter is out of range.", e);
            }
        }

    int[] array_;
    private void Start()
    {
        array_ = new int[2] { 0,1,};
        for (int i = 0; i <3; i++)
        {
            print(GetInt(array_,i));
        }
    }

}
