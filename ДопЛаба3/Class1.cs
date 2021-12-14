using System;
using System.Collections.Generic;
using System.Text;

namespace ДопЛаба3
{
    public class RunHooks
    {
        public static void RunPreCommit()
        {
            Console.WriteLine("WriteLine HOOK!!!! HOOK!!!");
        }
    }
}
