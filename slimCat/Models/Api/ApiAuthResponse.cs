using System.Collections.Generic;

namespace slimCat.Models.Api
{
    using System.Runtime.Serialization;

    [DataContract]
    public class ApiAuthResponse
    {
        [DataMember(Name = "ticket")]
        public string Ticket { get; set; }

        [DataMember(Name = "error")]
        public string Error { get; set; }

        [DataMember(Name = "default_character_id")]
        public int? DefaultCharacterId { get; set; }

        [DataMember(Name = "characters")]
        public IList<ApiCharacter> Characters { get; set; }

        [DataMember(Name = "bookmarks")]
        public IList<ApiCharacter> Bookmarks { get; set; }

        [DataMember(Name = "friends")]
        public IList<ApiFriends> Friends { get; set; }

    }

    [DataContract]
    public class ApiCharacter
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }
    }

    [DataContract]
    public class ApiFriends
    {
        [DataMember(Name = "character")]
        public string Character { get; set; }

        [DataMember(Name = "friends")]
        public IList<ApiCharacter> Friends { get; set; }
    }
}
