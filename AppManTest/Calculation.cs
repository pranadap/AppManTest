using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace AppManTest
{
    public class Calculation
    {
        public double Cal(string expression)
        {
            var xsltExpression =
            string.Format("number({0})",
                new Regex(@"([\+\-\*])").Replace(expression, " ${1} ")
                                        .Replace("/", " div "));

            return (double)new System.Xml.XPath.XPathDocument
            (new System.IO.StringReader("<r/>"))
                .CreateNavigator()
                .Evaluate(xsltExpression);
        }
    }
}