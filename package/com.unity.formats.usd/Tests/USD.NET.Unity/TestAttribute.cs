using UnityEngine;
using USD.NET.Unity;
using NUnit.Framework;
using Assert = UnityEngine.Assertions.Assert;

namespace USD.NET.Unity.Tests
{
    public class TestPreserveAttribute: UsdTests
    {
        static bool HasPreserveAttribute(System.Reflection.MethodInfo method) {
            Debug.Log("Checking " + method.Name + " ...");
            Assert.AreNotEqual(method, null);
            foreach (object attr in method.GetCustomAttributes(true)) {
                Debug.Log("    " + attr.GetType().Name);
                if (attr.GetType().Name == "PreserveAttribute") {
                    return true;
                }
            }

            return false;
        }
        
        [Test]
        public static void HasPreserveAttrsTest()
        {
            Debug.Log("\nUnity Type Converter\n");
            foreach (var method in typeof(UnityTypeConverter).GetMethods())
            {
                var name = method.Name;
                if (name.Contains("ToVt") || name.Contains("FromVt"))
                {
                    Assert.IsTrue(HasPreserveAttribute(method));
                }
            }
        }
    }
}