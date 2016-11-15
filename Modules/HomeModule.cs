using Nancy;
using Triangle.Objects;
using System.Collections.Generic;

namespace Triangle
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/form"] = _ => {
        return View["form.cshtml"];
      };
      Get["/back"] = _ => {
        return View["form.cshtml"];
      };
      Get["/story"] = _ => {
        TriangleVariables myTriangleVariables = new TriangleVariables();
        myTriangleVariables.SetSideA(Request.Query["sideA"]);
        myTriangleVariables.SetSideB(Request.Query["sideB"]);
        myTriangleVariables.SetSideC(Request.Query["sideC"]);
        return View["output.cshtml", myTriangleVariables];
      };
    }
  }
}
