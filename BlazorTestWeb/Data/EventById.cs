﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Runtime.Serialization;
using BlazorTestWeb.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using VisitPikeville2.Domain;
//
//    var eventById = EventById.FromJson(jsonString);

namespace BlazorTestWeb.Data
{

    public partial class EventById
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("field_announcement_description", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldAnnouncementDescription { get; set; }

        [JsonProperty("field_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldType { get; set; }

        [JsonProperty("field_website", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldWebsite { get; set; }

        [JsonProperty("field_event_address_organization", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldEventAddressOrganization { get; set; }

        [JsonProperty("field_event_address_address_line1", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldEventAddressAddressLine1 { get; set; }

        [JsonProperty("field_event_address_address_line2", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldEventAddressAddressLine2 { get; set; }

        [JsonProperty("field_event_assets", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldEventAssets { get; set; }

        [JsonProperty("field_event_description", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldEventDescription { get; set; }

        [JsonProperty("field_event_date", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldEventDate { get; set; }

        [JsonProperty("field_event_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldEventEndDate { get; set; }

        [JsonProperty("field_event_image", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldEventImage { get; set; }

        [JsonProperty("field_event_link", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldEventLink { get; set; }

        [JsonProperty("field_event_map_coordinates", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldEventMapCoordinates { get; set; }

        [JsonProperty("field_event_phone", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldEventPhone { get; set; }

        [JsonProperty("field_event_address_postal_code", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldEventAddressPostalCode { get; set; }

        [OnDeserialized]
        private void SetExtraData(StreamingContext context)
        {
            FieldEventImage = $"{Constants.BaseUrl}{FieldEventImage}";
        }
    }

    public partial class EventById
    {
        public static ObservableCollection<EventById> FromJson(string json) => JsonConvert.DeserializeObject<ObservableCollection<EventById>>(json, EventByIdConverter.Settings);
    }

    public static class EventByIdSerialize
    {
        public static string ToJson(this ObservableCollection<EventById> self) => JsonConvert.SerializeObject(self, EventByIdConverter.Settings);
    }

    internal static class EventByIdConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
