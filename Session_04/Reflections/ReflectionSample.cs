using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Session_04.Reflections
{
    public class ReflectionSample
    {
        public ReflectionSample()
        {
            // Assembly executingAssembly = Assembly.LoadFile("c:/work/dll");
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            // Can inspect the assembly types using
            var assemblyTypes = executingAssembly.GetTypes();

            //Parameter can be (namespace.class) via assembly qualified name
            Type T = executingAssembly.GetType("Session_04.Reflections.ReflectionSample+Cat"); 
            object catInstance = Activator.CreateInstance(T, null);
            MethodInfo talkMethodInfo = T.GetMethod("Talk");
            talkMethodInfo.Invoke(catInstance, null);




            // To Get all public property
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine($"{property.PropertyType.Name} {property.Name}");
            }

            // To Get all public methods
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine($"{method.ReturnType.Name} {method.Name}");
            }
        }

        public class Cat
        {
            public void Talk()
            {
                Console.WriteLine("Meow");
            }
        }

        public class Dog
        {
            public void Talk()
            {
                Console.WriteLine("Wooof");
            }
        }
    }
}
