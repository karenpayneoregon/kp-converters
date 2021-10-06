# About

### Experiments

Testing ground for initial write up of some half-baked ideas


### Working with .NET 6, C#10 DateOnly and TimeOnly.

Not part of this solution and will be removed later.

```csharp
public class Person 
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    [JsonConverter(typeof(DateOnlyJsonConverter))]
    public DateOnly BirthDateOnly { get; set; }
    [JsonIgnore]
    public DateTime BirthDate 
        => new(BirthDateOnly.Year, BirthDateOnly.Month, BirthDateOnly.Day);

}
```

**DateOnly** `converter` for `json`

```csharp
public sealed class DateOnlyJsonConverter : JsonConverter<DateOnly>
{
    public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return DateOnly.FromDateTime(reader.GetDateTime());
    }

    public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
    {
        var isoDate = value.ToString("O");
        writer.WriteStringValue(isoDate);
    }
}
```

