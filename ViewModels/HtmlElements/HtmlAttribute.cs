using System;
using System.Linq.Expressions;
using System.Reflection;

namespace AbstractSite.ViewModels.HtmlElements
{
    public class HtmlAttribute
    {
        public string Value { get; set; }
        public string Text { get; set; }
        public string Disabled { get; set; }
        public string Hidden { get; set; }

        public string Readonly { get; set; }
        public HtmlAttribute()
        {
            SetDefaultValues();
        }
        public HtmlAttribute(string value, string text)
        {
            Value = value;
            Text = text;
        }
        public HtmlAttribute Set<TProperty>(Expression<Func<HtmlAttribute, TProperty>> expression, TProperty value)
        {
            var memberExpression = expression.Body as MemberExpression;
            if (memberExpression == null)
                throw new ArgumentException("Expression must be a member expression");
            var propertyInfo = memberExpression.Member as PropertyInfo;
            if (propertyInfo == null)
                throw new ArgumentException("Expression must be a member expression");
            propertyInfo.SetValue(this, value, null);
            return this;
        }
        private void SetDefaultValues()
        {
            var properties = this.GetType().GetProperties();
            foreach (var property in properties)
            {
                if (property.PropertyType == typeof(string))
                {
                    var value = property.GetValue(this);
                    if (value == null)
                    {
                        property.SetValue(this, "");
                    }
                }
                else if (property.PropertyType == typeof(bool))
                {
                    var value = property.GetValue(this);
                    if (value == null)
                    {
                        property.SetValue(this, false);
                    }
                }
                else if (property.PropertyType == typeof(int))
                {
                    var value = property.GetValue(this);
                    if (value == null)
                    {
                        property.SetValue(this, 0);
                    }
                }
            }
        }
    }

}
