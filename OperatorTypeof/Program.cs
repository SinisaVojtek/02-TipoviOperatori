using System;
using System.Reflection;

namespace CSharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(System.DateTime);
            

           foreach (MemberInfo mi in t.GetMembers())
           {
                
               Console.WriteLine($"{mi.Name} {mi.MemberType.ToString()}");
              

            }

            foreach (System.Reflection.MethodInfo mInfo in t.GetMethods())
            {
                Console.WriteLine(mInfo.ToString());
                Console.WriteLine("Members:");
                System.Reflection.MemberInfo[] memberInfo = t.GetMembers();
            }

            foreach (MethodInfo mi in t.GetMethods())
            {
                Console.WriteLine($"{mi.ReturnType.ToString()} {mi.Name}");
                foreach (var parameter in mi.GetParameters())
                {
                    Console.WriteLine($"  {parameter.ParameterType.ToString()} {parameter.Name}");
                }
            }

            Console.ReadKey();
        }
    }
}
