using System.Linq.Expressions;
using AutoMapper.Internal;

namespace AutoMapper.Mappers
{
    using static CollectionMapperExpressionFactory;

    public class EnumerableToReadOnlyDictionaryMapper : IObjectMapper
    {
        public bool IsMatch(TypePair context) => context.SourceType.IsEnumerableType() && context.DestinationType.IsReadOnlyDictionaryType();
        public Expression MapExpression(IGlobalConfiguration configurationProvider, ProfileMap profileMap,
            IMemberMap memberMap, Expression sourceExpression, Expression destExpression, Expression contextExpression) =>
            MapToReadOnlyDictionary(configurationProvider, profileMap, memberMap, sourceExpression, destExpression, contextExpression, MapItemExpr);
    }
}