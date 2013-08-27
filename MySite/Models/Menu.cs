using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySite.Models
{
  public class Menu
  {
    public string Name;
    public string Controller;
    public string Action;
    public string Class;
  }

  public class MenuList
  {
    public List<Menu> menuList { get; set; }

    public MenuList(params Menu[] myMenus)
    {
      menuList = new List<Menu>();

      foreach (var menu in myMenus)
      {
        menuList.Add(menu);
      }
    }
  }
}