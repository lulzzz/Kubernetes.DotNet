/* 
 * Kubernetes
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.7.10
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Kubernetes.DotNet.Client.SwaggerDateConverter;

namespace Kubernetes.DotNet.Model
{
    /// <summary>
    /// NetworkPolicySpec provides the specification of a NetworkPolicy
    /// </summary>
    [DataContract]
    public partial class V1NetworkPolicySpec :  IEquatable<V1NetworkPolicySpec>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1NetworkPolicySpec" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1NetworkPolicySpec() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1NetworkPolicySpec" /> class.
        /// </summary>
        /// <param name="Ingress">List of ingress rules to be applied to the selected pods. Traffic is allowed to a pod if there are no NetworkPolicies selecting the pod (and cluster policy otherwise allows the traffic), OR if the traffic source is the pod&#39;s local node, OR if the traffic matches at least one ingress rule across all of the NetworkPolicy objects whose podSelector matches the pod. If this field is empty then this NetworkPolicy does not allow any traffic (and serves solely to ensure that the pods it selects are isolated by default).</param>
        /// <param name="PodSelector">Selects the pods to which this NetworkPolicy object applies. The array of ingress rules is applied to any pods selected by this field. Multiple network policies can select the same set of pods. In this case, the ingress rules for each are combined additively. This field is NOT optional and follows standard label selector semantics. An empty podSelector matches all pods in this namespace. (required).</param>
        public V1NetworkPolicySpec(List<V1NetworkPolicyIngressRule> Ingress = default(List<V1NetworkPolicyIngressRule>), V1LabelSelector PodSelector = default(V1LabelSelector))
        {
            // to ensure "PodSelector" is required (not null)
            if (PodSelector == null)
            {
                throw new InvalidDataException("PodSelector is a required property for V1NetworkPolicySpec and cannot be null");
            }
            else
            {
                this.PodSelector = PodSelector;
            }
            this.Ingress = Ingress;
        }
        
        /// <summary>
        /// List of ingress rules to be applied to the selected pods. Traffic is allowed to a pod if there are no NetworkPolicies selecting the pod (and cluster policy otherwise allows the traffic), OR if the traffic source is the pod&#39;s local node, OR if the traffic matches at least one ingress rule across all of the NetworkPolicy objects whose podSelector matches the pod. If this field is empty then this NetworkPolicy does not allow any traffic (and serves solely to ensure that the pods it selects are isolated by default)
        /// </summary>
        /// <value>List of ingress rules to be applied to the selected pods. Traffic is allowed to a pod if there are no NetworkPolicies selecting the pod (and cluster policy otherwise allows the traffic), OR if the traffic source is the pod&#39;s local node, OR if the traffic matches at least one ingress rule across all of the NetworkPolicy objects whose podSelector matches the pod. If this field is empty then this NetworkPolicy does not allow any traffic (and serves solely to ensure that the pods it selects are isolated by default)</value>
        [DataMember(Name="ingress", EmitDefaultValue=false)]
        public List<V1NetworkPolicyIngressRule> Ingress { get; set; }

        /// <summary>
        /// Selects the pods to which this NetworkPolicy object applies. The array of ingress rules is applied to any pods selected by this field. Multiple network policies can select the same set of pods. In this case, the ingress rules for each are combined additively. This field is NOT optional and follows standard label selector semantics. An empty podSelector matches all pods in this namespace.
        /// </summary>
        /// <value>Selects the pods to which this NetworkPolicy object applies. The array of ingress rules is applied to any pods selected by this field. Multiple network policies can select the same set of pods. In this case, the ingress rules for each are combined additively. This field is NOT optional and follows standard label selector semantics. An empty podSelector matches all pods in this namespace.</value>
        [DataMember(Name="podSelector", EmitDefaultValue=false)]
        public V1LabelSelector PodSelector { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1NetworkPolicySpec {\n");
            sb.Append("  Ingress: ").Append(Ingress).Append("\n");
            sb.Append("  PodSelector: ").Append(PodSelector).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as V1NetworkPolicySpec);
        }

        /// <summary>
        /// Returns true if V1NetworkPolicySpec instances are equal
        /// </summary>
        /// <param name="other">Instance of V1NetworkPolicySpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1NetworkPolicySpec other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Ingress == other.Ingress ||
                    this.Ingress != null &&
                    this.Ingress.SequenceEqual(other.Ingress)
                ) && 
                (
                    this.PodSelector == other.PodSelector ||
                    this.PodSelector != null &&
                    this.PodSelector.Equals(other.PodSelector)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Ingress != null)
                    hash = hash * 59 + this.Ingress.GetHashCode();
                if (this.PodSelector != null)
                    hash = hash * 59 + this.PodSelector.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
