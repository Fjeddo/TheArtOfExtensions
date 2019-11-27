namespace TheArtOfExtensions.Extensions
{
    public static class JsonSerializationSyntaxSugar
    {
        public static T As<T>(this string json) =>
            string.IsNullOrWhiteSpace(json)
                ? default
                : Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);

        public static string ToJson<T>(this T value) =>
            Newtonsoft.Json.JsonConvert.SerializeObject(value);
    }
}
