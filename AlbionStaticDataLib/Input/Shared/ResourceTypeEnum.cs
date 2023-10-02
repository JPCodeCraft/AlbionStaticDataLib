namespace AlbionStaticDataLib.Input.Shared
{
    [JsonConverter(typeof(JsonStringEnumConverter<ResourceTypeEnum>))]
    public enum ResourceTypeEnum
    {
        CROP, HERB, PRODUCTS, FISH, TOKEN, ARENA_TOKEN, OTHER, MEAT,
        WOOD, WOOD_LEVEL1, WOOD_LEVEL2, WOOD_LEVEL3, WOOD_LEVEL4,
        ROCK, ROCK_LEVEL1, ROCK_LEVEL2, ROCK_LEVEL3,
        ORE, ORE_LEVEL1, ORE_LEVEL2, ORE_LEVEL3, ORE_LEVEL4,
        HIDE, HIDE_LEVEL1, HIDE_LEVEL2, HIDE_LEVEL3, HIDE_LEVEL4,
        FIBER, FIBER_LEVEL1, FIBER_LEVEL2, FIBER_LEVEL3, FIBER_LEVEL4,
        ESSENCE, RUNE, SOUL, RELIC,
        SHARD,
        CRYSTAL_LEAGUE_TOKEN
    };
}
