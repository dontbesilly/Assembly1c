using System.Collections.Generic;

namespace Assembly
{
    struct Description
    {
        public string name;
        public bool use;
    }

    class Route
    {
        string name;
        List<Description> list = new List<Description>();
        public string Name { get { return name; } }
        public List<Description> List { get { return list; } }

        public Route(string name)
        {
            this.name = name;

            foreach (var item in Iteration.iterationArray)
            {
                list.Add(new Description { name = item, use = false });
            }
        }

        public string ContentForSettings()
        {
            string str = string.Empty;
            foreach (var item in list)
            {
                str += $"{item.name}={item.use}\n";
            }
            return str;
        }

    }
}
