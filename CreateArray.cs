using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for CreateArray
    /// </summary>
	//Click Edit Button
	//Click Action class
	// Click Drop down
	
	//Changes ade by Brijendra
	//add summarynew times
    [TestClass]
    public class CreateArray
    {
        public  void VerfiyCreateArray()
        {
            int[] arr = new int[5];
            arr[0] = 10;
            arr[1] = 50;
            arr[2] = 30;
            arr[3] = 40;
            arr[4] = 50;

            for(int i=0; i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }

        }



        [TestMethod]
        public void TestMethod1()
        {
            CreateArray ca = new CreateArray();
            ca.VerfiyCreateArray();

        }
    }

}
