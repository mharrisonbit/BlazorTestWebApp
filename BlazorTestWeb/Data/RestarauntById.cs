﻿using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using BlazorTestWeb.Data;
//
//    var restarauntById = RestarauntById.FromJson(jsonString);

namespace BlazorTestWeb.Data
{

    public partial class RestarauntById
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("field_restaurant_address_address_line1", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldRestaurantAddressAddressLine1 { get; set; }

        [JsonProperty("field_restaurant_address_address_line2", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldRestaurantAddressAddressLine2 { get; set; }

        [JsonProperty("field_restaurant_address_organization", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldRestaurantAddressOrganization { get; set; }

        [JsonProperty("field_restaurant_address_postal_code", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldRestaurantAddressPostalCode { get; set; }

        [JsonProperty("field_restaurant_description", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldRestaurantDescription { get; set; }

        [JsonProperty("field_restaurant_email", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldRestaurantEmail { get; set; }

        [JsonProperty("field_restaurant_hours", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldRestaurantHours { get; set; }

        [JsonProperty("field_restaurant_items", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldRestaurantItems { get; set; }

        [JsonProperty("field_restaurant_link", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldRestaurantLink { get; set; }

        [JsonProperty("field_restaurant_logo", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldRestaurantLogo { get; set; }

        [JsonProperty("field_restaurant_coordinates", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldRestaurantCoordinates { get; set; }

        [JsonProperty("field_restaurant_online_ordering", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldRestaurantOnlineOrdering { get; set; }

        [JsonProperty("field_restaurant_phone", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldRestaurantPhone { get; set; }

        [JsonProperty("field_restaurant_search_keywords", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldRestaurantSearchKeywords { get; set; }
    }

    public partial class RestarauntById
    {
        public static List<RestarauntById> FromJson(string json) => JsonConvert.DeserializeObject<List<RestarauntById>>(json, RestarauntByIdConverter.Settings);
    }

    public static class RestarauntByIdSerialize
    {
        public static string ToJson(this List<RestarauntById> self) => JsonConvert.SerializeObject(self, RestarauntByIdConverter.Settings);
    }

    internal static class RestarauntByIdConverter
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
