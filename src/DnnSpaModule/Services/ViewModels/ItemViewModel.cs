using Dnn.Modules.DnnSpaModule.Components;
using Newtonsoft.Json;

namespace Dnn.Modules.DnnSpaModule.Services.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ItemViewModel
    {
        public ItemViewModel(Item t)
        {
            Id = t.ItemId;
            Name = t.ItemName;
            Description = t.ItemDescription;
            AssignedUser = t.AssignedUserId;
        }

        public ItemViewModel(Item t, string editUrl)
        {
            Id = t.ItemId;
            Name = t.ItemName;
            Description = t.ItemDescription;
            EditUrl = editUrl;
        }


        public ItemViewModel() { }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("assignedUser")]
        public int AssignedUser { get; set; }

        [JsonProperty("editUrl")]
        public string EditUrl { get; }
    }
}