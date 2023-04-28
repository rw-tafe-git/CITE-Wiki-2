using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITEWiki
{
    //6.1 Create a separate class file to hold the four data items of the Data Structure (use the Data Structure Matrix as a guide). Use private properties for the fields which must be of type “string”. The class file must have separate setters and getters, add an appropriate IComparable for the Name attribute. Save the class as “Information.cs”.

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
