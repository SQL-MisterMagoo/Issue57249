
using System.Text.Json.Serialization;
namespace Issue57249;
[JsonSerializable(typeof(MyJsonData))]
internal partial class MyJsonContext : JsonSerializerContext
{
}