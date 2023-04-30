using BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Strategies
{
    public static class StrategyFactory
    {
        private static IEntityStrategyValidator _userStrategy;
        private static IEntityStrategyValidator _postStrategy;
        private static IEntityStrategyValidator _categoryStrategy;
        public static IEntityStrategyValidator GetStrategy(Entity theEntity)
        {
            switch (theEntity.Type)
            {
                case "User":
                    return GetUserStrategy();
                case "Post":
                    return GetPostStrategy();
                case "Category":
                    return GetCategoryStrategy();
                default:
                    throw new ArgumentException("The entity type is not valid.");
            }
        }
        private static IEntityStrategyValidator GetUserStrategy()
        {
            if (_userStrategy == null)
                _userStrategy = new UserStrategyValidator();

            return _userStrategy;
        }
        private static IEntityStrategyValidator GetPostStrategy()
        {
            if (_postStrategy == null)
                _postStrategy = new UserStrategyValidator();

            return _postStrategy;
        }
        private static IEntityStrategyValidator GetCategoryStrategy()
        {
            if (_categoryStrategy == null)
                _categoryStrategy = new UserStrategyValidator();

            return _categoryStrategy;
        }
    }
}
