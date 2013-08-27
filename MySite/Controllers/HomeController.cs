using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MySite.Models;

namespace MySite.Controllers
{
  public class HomeController : Controller
  {

    MenuList homeMenuList;

    void buildMenuList(string activeItem)
    {
      Menu index = new Menu();
      index.Name = "Home";
      index.Controller = "Home";
      index.Action = "Index";
      if (activeItem == "Index")
        index.Class = "active";

      Menu community = new Menu();
      community.Name = "Community";
      community.Controller = "Home";
      community.Action = "Community";
      if (activeItem == "Community")
        community.Class = "active";

      Menu gettingStarted = new Menu();
      gettingStarted.Name = "Getting Started";
      gettingStarted.Controller = "Home";
      gettingStarted.Action = "GettingStarted";
      if (activeItem == "GettingStarted")
        gettingStarted.Class = "active";

      homeMenuList = new MenuList(index, community, gettingStarted);
    }

    //
    // GET: /Home/

    public ActionResult Index()
    {
      buildMenuList("Index");
      ViewBag.Message = "This is the landing page for your ASP.NET MVC application on OpenShift.";

      return View(homeMenuList);
    }

    //
    // GET: /Home/GettingStarted

    public ActionResult GettingStarted()
    {
      buildMenuList("GettingStarted");
      ViewBag.Message = "This page will go through the steps of getting you up and running.";
      ViewBag.GitURL = "ssh://" + Environment.GetEnvironmentVariable("OPENSHIFT_GEAR_UUID") + "@" +
      Environment.GetEnvironmentVariable("OPENSHIFT_GEAR_DNS") + "/~/git/" +
      Environment.GetEnvironmentVariable("OPENSHIFT_GEAR_NAME") + ".git";

      return View(homeMenuList);
    }

    //
    // GET: /Home/Community

    public ActionResult Community()
    {
      buildMenuList("Community");
      ViewBag.Message = "Your gateway to the OpenShift Community.";

      return View(homeMenuList);
    }

  }
}
