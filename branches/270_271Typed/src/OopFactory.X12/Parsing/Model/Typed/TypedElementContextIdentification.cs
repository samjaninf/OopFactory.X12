﻿using System.Linq;
namespace OopFactory.X12.Parsing.Model.Typed
{
    public class TypedElementContextIdentification : BaseElementReference
    {
        public TypedElementContextIdentification(Segment segment, int elementNumber)
            : base(segment, elementNumber)
        {
            if (0 < SubElements.Count()) _1_ContextName = SubElements.ElementAt(0);
            if (1 < SubElements.Count()) _2_ContextReference = SubElements.ElementAt(1);
        }

        public override string ToString()
        {
            string value = string.Format("{1}{0}{2}",
                 Segment._delimiters.SubElementSeparator,
                 _1_ContextName,
                 _2_ContextReference);
            value = value.TrimEnd(Segment._delimiters.SubElementSeparator);
            return value;
        }
        public string _1_ContextName { get; set; }

        public string _2_ContextReference { get; set; }
    }
}