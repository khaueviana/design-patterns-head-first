using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KV.PatternComposite
{
    public class Menu : MenuComponent
    {
        List<MenuComponent> menuComponents = new List<MenuComponent>();
        private string name;
        private string description;

        public override void Add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            menuComponent.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return menuComponents[i];
        }

        public override string GetName()
        {
            return name;
        }

        public override string GetDescription()
        {
            return description;
        }
     
        public override void Print()
        {
            Console.WriteLine("\nMenu: " + name);
            Console.WriteLine("Description:  " + description);
            Console.WriteLine("--------------------");

            foreach (MenuComponent menuComponent in menuComponents)
            {
                menuComponent.Print();
            }
        }

        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
    }
}
