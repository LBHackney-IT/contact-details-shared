namespace Hackney.Shared.ContactDetail.Domain
{
    public class AddressExtended
    {
        public string UPRN { get; set; }

        public bool IsOverseasAddress { get; set; }

        public string OverseasAddress { get; set; }
    }
}
