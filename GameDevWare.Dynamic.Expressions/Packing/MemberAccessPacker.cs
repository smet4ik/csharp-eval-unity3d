using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GameDevWare.Dynamic.Expressions.Packing
{
	internal static class MemberAccessPacker
	{
		public static Dictionary<string, object> Pack(MemberExpression expression)
		{
			if (expression == null) throw new ArgumentNullException("expression");

			return new Dictionary<string, object>(3) {
				{Constants.EXPRESSION_TYPE_ATTRIBUTE, Constants.EXPRESSION_TYPE_PROPERTY_OR_FIELD },
				{Constants.PROPERTY_OR_FIELD_NAME_ATTRIBUTE, expression.Member.Name },
				{Constants.EXPRESSION_ATTRIBUTE, AnyPacker.Pack(expression.Expression)},
			};
		}
	}
}