using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace spg4Net
{
    public class Class1
    {


        public int test( int a, int b)
        {
            var py = Python.CreateEngine();
            var ipy = Python.CreateRuntime();
            try
            {

                //py.ExecuteFile("test.py");
               // dynamic q = ipy.UseFile("test.py");

                ScriptEngine engine = Python.CreateEngine();
                ScriptSource source = engine.CreateScriptSourceFromFile("test.py");
                ScriptScope scope = engine.CreateScope();
                source.Execute(scope);

                dynamic Calculator = scope.GetVariable("Calculator");
                dynamic calc = Calculator();
                int result = calc.add(a, b);

                return result;

            }
            catch (Exception ex)
            {
                Console.WriteLine(
                   "Oops! We couldn't execute the script because of an exception: " + ex.Message);
            }
            return 0;
        }
    }
}
