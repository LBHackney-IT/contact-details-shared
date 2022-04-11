using System.Text.Json.Serialization;

namespace Hackney.Shared.ContactDetail.Domain
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TargetType
    {
        person,
        organisation
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]

    public enum ContactType
    {
        phone,
        email,
        address
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]

    public enum SubType
    {
        correspondenceAddress,
        mobile,
        home,
        work,
        other,
        landline
    }
}
