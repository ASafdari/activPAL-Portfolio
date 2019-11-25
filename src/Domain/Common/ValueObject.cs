using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Domain.Common
{
    // Source: https://docs.microsoft.com/en-us/dotnet/standard/microservices-architecture/microservice-ddd-cqrs-patterns/implement-value-objects
    /// <summary>
    /// Base class for Data Items that do not require an identity
    /// </summary>
    public abstract class ValueObject
    {
        /// <summary>
        /// Determines if two <see cref="ValueObject"/> are equal
        /// </summary>
        protected static bool EqualOperator(ValueObject left, ValueObject right)
        {
            if (left is null ^ right is null)
            {
                return false;
            }

            return left?.Equals(right) != false;
        }

        /// <summary>
        /// Determines if two <see cref="ValueObject"/> are not equal
        /// </summary>
        protected static bool NotEqualOperator(ValueObject left, ValueObject right)
        {
            return !(EqualOperator(left, right));
        }

        /// <summary>
        /// Checks if this <see cref="ValueObject"/> equals another
        /// </summary>
        /// <param name="obj">Other <see cref="ValueObject"/></param>
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != GetType())
            {
                return false;
            }

            var other = (ValueObject)obj;
            var thisValues = GetAtomicValues().GetEnumerator();
            var otherValues = other.GetAtomicValues().GetEnumerator();

            while (thisValues.MoveNext() && otherValues.MoveNext())
            {
                if (thisValues.Current is null ^ otherValues.Current is null)
                {
                    return false;
                }

                if (thisValues.Current != null &&
                    !thisValues.Current.Equals(otherValues.Current))
                {
                    return false;
                }
            }

            return !thisValues.MoveNext() && !otherValues.MoveNext();
        }

        public override int GetHashCode()
        {
            return GetAtomicValues()
                .Select(x => x != null ? x.GetHashCode() : 0)
                .Aggregate((x, y) => x ^ y);
        }

        /// <summary>
        /// Template method to determine value of this <see cref="ValueObject"/>
        /// </summary>
        /// <returns></returns>
        protected abstract IEnumerable<object> GetAtomicValues();
    }
}