using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tool
{
   public static class controllers
    {
        static string GET = "public IHttpActionResult Get()\n{ \n    try\n    {\nusing (AIOEntities aIO = new AIOEntities())\n{\n    aIO.Configuration.LazyLoadingEnabled = false;\n    IEnumerable<{0}> _BDs = aIO.MaestroBodegas.ToList();\n    List<{1}> {2} = new List<{1}>();\n    if (_BDs.Count() >= 1)\n    {\n        foreach ({0} BD in _BDs)\n        {\n            {1} {3} = new {1}\n            {\n                {4}\n            };\n            {2}.Add({3});\n        }\n        return Ok({2});\n       \n    }\n    else\n    {\n        return NotFound();\n        }\n}\n}\n  catch (Exception ex)\n {\nreturn BadRequest(ex.ToString());\n//return Request.CreateResponse(HttpStatusCode.NotFound, ex) as IHttpActionResult;\n}\n}";
        static string getUnico = "";
        static string post = "";
        static string put = "";
        public static string get(string  )
        {

        }
    }

}
