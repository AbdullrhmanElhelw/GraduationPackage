using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq.Expressions;

namespace Infrastructure.Configurations;

internal static class ConfigrationExtentions
{
    public static EntityTypeBuilder<T> IsUnique<T>(this EntityTypeBuilder<T> builder,
       params Expression<Func<T, object>>[] propertyExpressions) where T : class
    {
        foreach (var propertyExpression in propertyExpressions)
        {
            builder.HasIndex(propertyExpression!).IsUnique();
        }
        return builder;
    }

    public static PropertyBuilder<string> HasMinLength(this PropertyBuilder<string> propertyBuilder, int minLength)
    {
        if (minLength < 0)
        {
            throw new ArgumentException("Minimum Length Must be non-negative.");
        }
        propertyBuilder
            .IsRequired()
            .HasAnnotation("MinLength", minLength);
        return propertyBuilder;
    }
}
