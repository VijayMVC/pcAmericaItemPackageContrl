﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MG2Connector
{
    public class StockItem
    {

        //[JsonProperty("item_id")]
        //public int ItemId { get; set; }

        //[JsonProperty("product_id")]
        //public int ProductId { get; set; }

        //[JsonProperty("stock_id")]
        //public int StockId { get; set; }

        [JsonProperty("qty")]
        public int Qty { get; set; }

        [JsonProperty("is_in_stock")]
        public bool IsInStock { get; set; }

        [JsonProperty("is_qty_decimal")]
        public bool IsQtyDecimal { get; set; }

        //[JsonProperty("show_default_notification_message")]
        //public bool ShowDefaultNotificationMessage { get; set; }

        //[JsonProperty("use_config_min_qty")]
        //public bool UseConfigMinQty { get; set; }

        //[JsonProperty("min_qty")]
        //public int MinQty { get; set; }

        //[JsonProperty("use_config_min_sale_qty")]
        //public int UseConfigMinSaleQty { get; set; }

        //[JsonProperty("min_sale_qty")]
        //public int MinSaleQty { get; set; }

        //[JsonProperty("use_config_max_sale_qty")]
        //public bool UseConfigMaxSaleQty { get; set; }

        //[JsonProperty("max_sale_qty")]
        //public int MaxSaleQty { get; set; }

        //[JsonProperty("use_config_backorders")]
        //public bool UseConfigBackorders { get; set; }

        //[JsonProperty("backorders")]
        //public int Backorders { get; set; }

        //[JsonProperty("use_config_notify_stock_qty")]
        //public bool UseConfigNotifyStockQty { get; set; }

        //[JsonProperty("notify_stock_qty")]
        //public int NotifyStockQty { get; set; }

        //[JsonProperty("use_config_qty_increments")]
        //public bool UseConfigQtyIncrements { get; set; }

        //[JsonProperty("qty_increments")]
        //public int QtyIncrements { get; set; }

        //[JsonProperty("use_config_enable_qty_inc")]
        //public bool UseConfigEnableQtyInc { get; set; }

        //[JsonProperty("enable_qty_increments")]
        //public bool EnableQtyIncrements { get; set; }

        //[JsonProperty("use_config_manage_stock")]
        //public bool UseConfigManageStock { get; set; }

        //[JsonProperty("manage_stock")]
        //public bool ManageStock { get; set; }

        //[JsonProperty("low_stock_date")]
        //public object LowStockDate { get; set; }

        //[JsonProperty("is_decimal_divided")]
        //public bool IsDecimalDivided { get; set; }

        //[JsonProperty("stock_status_changed_auto")]
        //public int StockStatusChangedAuto { get; set; }
    }


    public class TierPrice
    {

        [JsonProperty("customer_group_id")]
        public int CustomerGroupId { get; set; }

        [JsonProperty("qty")]
        public int Qty { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        //[JsonProperty("extension_attributes")]
        //public ExtensionAttributes { get; set; }
    }


    public class CustomAttribute
    {

        [JsonProperty("attribute_code")]
        public string AttributeCode { get; set; }

        [JsonProperty("value")]
        public object Value { get; set; }
        //public string Value { get; set; }
    }

    public class CategoryLink
    {

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("category_id")]
        public string CategoryId { get; set; }
    }

    public class Content
    {

        [JsonProperty("base64_encoded_data")]
        public string base64_encoded_data { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
    }

    public class ExtensionAttributes
    {
        [JsonProperty("website_ids")]
        public IList<int> WebsiteIds { get; set; }

        [JsonProperty("category_links")]
        public IList<CategoryLink> CategoryLinks { get; set; }

        [JsonProperty("stock_item")]
        public StockItem StockItem { get; set; }
    }

    public class Product
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("attribute_set_id")]
        public int AttributeSetId { get; set; }

        [JsonProperty("price")]
        public Single Price { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; }

        [JsonProperty("type_id")]
        public string TypeId { get; set; }

        //[JsonProperty("created_at")]
        //public string CreatedAt { get; set; }

        //[JsonProperty("updated_at")]
        //public string UpdatedAt { get; set; }

        //[JsonProperty("weight")]
        //public int Weight { get; set; }

        [JsonProperty("extension_attributes")]
        public ExtensionAttributes ExtensionAttributes { get; set; }

        [JsonProperty("product_links")]
        public IList<ProductLink> ProductLinks { get; set; }

        //[JsonProperty("options")]
        //public IList<object> Options { get; set; }

        [JsonProperty("media_gallery_entries")]
        public IList<MediaGalleryEntry> MediaGalleryEntries { get; set; }

        [JsonProperty("tier_prices")]
        public IList<TierPrice> TierPrices { get; set; }

        [JsonProperty("custom_attributes")]
        public IList<CustomAttribute> CustomAttributes { get; set; }

    }
    public class MediaGalleryEntry
    {

        [JsonProperty("media_type")]
        public string MediaType { get; set; }

        [JsonProperty("label")]
        public object Label { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("types")]
        public IList<string> Types { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("content")]
        public Content Content { get; set; }
    }
    public class M2CreateProducts
    {

        [JsonProperty("product")]
        public Product Product { get; set; }

    }

    public class ProductLink
    {

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("link_type")]
        public string LinkType { get; set; }

        [JsonProperty("linked_product_sku")]
        public string LinkedProductSku { get; set; }

        [JsonProperty("linked_product_type")]
        public string LinkedProductType { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

     
        //[JsonProperty("extension_attributes")]
        //public ExtensionAttributes { get; set; }
    }


public class M2ProductGET
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("attribute_set_id")]
        public int AttributeSetId { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; }

        [JsonProperty("type_id")]
        public string TypeId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("product_links")]
        public IList<object> ProductLinks { get; set; }

        [JsonProperty("options")]
        public IList<object> Options { get; set; }

        [JsonProperty("media_gallery_entries")]
        public IList<object> MediaGalleryEntries { get; set; }

        [JsonProperty("tier_prices")]
        public IList<object> TierPrices { get; set; }

        [JsonProperty("custom_attributes")]
        public IList<CustomAttribute> CustomAttributes { get; set; }
    }

}
