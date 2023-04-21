using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITEWiki_2
{
    [Serializable]
    public class Information : IComparable<Information>
    {
        private string name;
        private string category;
        private string structure;
        private string definition;

        public Information() { }

        public void SetName(string newName)
        {
            name = newName;
        }
        public string GetName()
        {
            return name;
        }
        public void SetCategory(string newCategory)
        {
            category = newCategory;
        }
        public string GetCategory()
        {
            return category;
        }
        public void SetStructure(string newStructure)
        {
            structure = newStructure;
        }
        public string GetStructure()
        {
            return structure;
        }
        public void SetDefinition(string newDefinition)
        {
            definition = newDefinition;
        }
        public string GetDefinition()
        {
            return definition;
        }

        public int CompareTo(Information compareClass)
        {
            return name.CompareTo(compareClass.name);
        }
    }
}
