// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ApplicationGateway.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Request routing rule of an application gateway.
    /// </summary>
    [JsonTransformation]
    public partial class ApplicationGatewayRequestRoutingRule : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayRequestRoutingRule class.
        /// </summary>
        public ApplicationGatewayRequestRoutingRule()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayRequestRoutingRule class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="ruleType">Rule type. Possible values are: 'Basic' and
        /// 'PathBasedRouting'. Possible values include: 'Basic',
        /// 'PathBasedRouting'</param>
        /// <param name="backendAddressPool">Backend address pool resource of
        /// the application gateway. </param>
        /// <param name="backendHttpSettings">Frontend port resource of the
        /// application gateway.</param>
        /// <param name="httpListener">Http listener resource of the
        /// application gateway. </param>
        /// <param name="urlPathMap">URL path map resource of the application
        /// gateway.</param>
        /// <param name="provisioningState">Provisioning state of the request
        /// routing rule resource. Possible values are: 'Updating', 'Deleting',
        /// and 'Failed'.</param>
        /// <param name="name">Name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public ApplicationGatewayRequestRoutingRule(string id = default(string), string ruleType = default(string), SubResource backendAddressPool = default(SubResource), SubResource backendHttpSettings = default(SubResource), SubResource httpListener = default(SubResource), SubResource urlPathMap = default(SubResource), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            RuleType = ruleType;
            BackendAddressPool = backendAddressPool;
            BackendHttpSettings = backendHttpSettings;
            HttpListener = httpListener;
            UrlPathMap = urlPathMap;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets rule type. Possible values are: 'Basic' and
        /// 'PathBasedRouting'. Possible values include: 'Basic',
        /// 'PathBasedRouting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.ruleType")]
        public string RuleType { get; set; }

        /// <summary>
        /// Gets or sets backend address pool resource of the application
        /// gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendAddressPool")]
        public SubResource BackendAddressPool { get; set; }

        /// <summary>
        /// Gets or sets frontend port resource of the application gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendHttpSettings")]
        public SubResource BackendHttpSettings { get; set; }

        /// <summary>
        /// Gets or sets http listener resource of the application gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.httpListener")]
        public SubResource HttpListener { get; set; }

        /// <summary>
        /// Gets or sets URL path map resource of the application gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.urlPathMap")]
        public SubResource UrlPathMap { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the request routing rule
        /// resource. Possible values are: 'Updating', 'Deleting', and
        /// 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets name of the resource that is unique within a resource
        /// group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
