using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using IronPython.Modules;

namespace spg4Net
{
    public class Vangard
    {


        public void RunStandardVangardTest()
        {

            //>>> from sgp4.earth_gravity import wgs72
            //>>> from sgp4.io import twoline2rv
            //>>>
            //>>> line1 = ('1 00005U 58002B   00179.78495062  '
            //...          '.00000023  00000-0  28098-4 0  4753')
            //>>> line2 = ('2 00005  34.2682 348.7242 1859667 '
            //...          '331.7664  19.3264 10.82419157413667')
            //>>>
            //>>> satellite = twoline2rv(line1, line2, wgs72)
            //>>> position, velocity = satellite.propagate(
            //...     2000, 6, 29, 12, 50, 19)
            //>>>
            //>>> print(satellite.error)    # nonzero on error
            //0
            //>>> print(satellite.error_message)
            //None
            //>>> print(position)
            //(5576.056952..., -3999.371134..., -1521.957159...)
            //>>> print(velocity)
            //(4.772627..., 5.119817..., 4.275553...)


            //String line1 = "1 00005U 58002B   00179.78495062  .00000023  00000-0  28098-4 0  4753";
            //String line2 = "2 00005  34.2682 348.7242 1859667 331.7664  19.3264 10.82419157413667";



            //var py = Python.CreateEngine();
            //      py.ExecuteFile("vanguard.py");
            // dynamic q = ipy.UseFile("test.py");

            ScriptEngine engine = Python.CreateEngine();

            
           // engine.ImportModule("collections");

            var paths = engine.GetSearchPaths();
            paths.Add("Lib");
            paths.Add("spg4Python");
           // paths.Add(@"C:\Program Files (x86)\IronPython 2.7\Lib");
            //paths.Add("spg4Python/spg4");
            engine.SetSearchPaths(paths);


            ScriptSource source = engine.CreateScriptSourceFromFile("vanguard.py");

            ScriptScope scope = engine.CreateScope();
            source.Execute(scope);

            dynamic vanguard = scope.GetVariable("Vanguard");
            dynamic van = vanguard();
             van.calc();

            //return result;




        }



    }
}
