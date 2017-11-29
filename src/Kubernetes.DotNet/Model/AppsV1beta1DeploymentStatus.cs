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
    /// DeploymentStatus is the most recently observed status of the Deployment.
    /// </summary>
    [DataContract]
    public partial class AppsV1beta1DeploymentStatus :  IEquatable<AppsV1beta1DeploymentStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppsV1beta1DeploymentStatus" /> class.
        /// </summary>
        /// <param name="AvailableReplicas">Total number of available pods (ready for at least minReadySeconds) targeted by this deployment..</param>
        /// <param name="CollisionCount">Count of hash collisions for the Deployment. The Deployment controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ReplicaSet..</param>
        /// <param name="Conditions">Represents the latest available observations of a deployment&#39;s current state..</param>
        /// <param name="ObservedGeneration">The generation observed by the deployment controller..</param>
        /// <param name="ReadyReplicas">Total number of ready pods targeted by this deployment..</param>
        /// <param name="Replicas">Total number of non-terminated pods targeted by this deployment (their labels match the selector)..</param>
        /// <param name="UnavailableReplicas">Total number of unavailable pods targeted by this deployment..</param>
        /// <param name="UpdatedReplicas">Total number of non-terminated pods targeted by this deployment that have the desired template spec..</param>
        public AppsV1beta1DeploymentStatus(int? AvailableReplicas = default(int?), long? CollisionCount = default(long?), List<AppsV1beta1DeploymentCondition> Conditions = default(List<AppsV1beta1DeploymentCondition>), long? ObservedGeneration = default(long?), int? ReadyReplicas = default(int?), int? Replicas = default(int?), int? UnavailableReplicas = default(int?), int? UpdatedReplicas = default(int?))
        {
            this.AvailableReplicas = AvailableReplicas;
            this.CollisionCount = CollisionCount;
            this.Conditions = Conditions;
            this.ObservedGeneration = ObservedGeneration;
            this.ReadyReplicas = ReadyReplicas;
            this.Replicas = Replicas;
            this.UnavailableReplicas = UnavailableReplicas;
            this.UpdatedReplicas = UpdatedReplicas;
        }
        
        /// <summary>
        /// Total number of available pods (ready for at least minReadySeconds) targeted by this deployment.
        /// </summary>
        /// <value>Total number of available pods (ready for at least minReadySeconds) targeted by this deployment.</value>
        [DataMember(Name="availableReplicas", EmitDefaultValue=false)]
        public int? AvailableReplicas { get; set; }

        /// <summary>
        /// Count of hash collisions for the Deployment. The Deployment controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ReplicaSet.
        /// </summary>
        /// <value>Count of hash collisions for the Deployment. The Deployment controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ReplicaSet.</value>
        [DataMember(Name="collisionCount", EmitDefaultValue=false)]
        public long? CollisionCount { get; set; }

        /// <summary>
        /// Represents the latest available observations of a deployment&#39;s current state.
        /// </summary>
        /// <value>Represents the latest available observations of a deployment&#39;s current state.</value>
        [DataMember(Name="conditions", EmitDefaultValue=false)]
        public List<AppsV1beta1DeploymentCondition> Conditions { get; set; }

        /// <summary>
        /// The generation observed by the deployment controller.
        /// </summary>
        /// <value>The generation observed by the deployment controller.</value>
        [DataMember(Name="observedGeneration", EmitDefaultValue=false)]
        public long? ObservedGeneration { get; set; }

        /// <summary>
        /// Total number of ready pods targeted by this deployment.
        /// </summary>
        /// <value>Total number of ready pods targeted by this deployment.</value>
        [DataMember(Name="readyReplicas", EmitDefaultValue=false)]
        public int? ReadyReplicas { get; set; }

        /// <summary>
        /// Total number of non-terminated pods targeted by this deployment (their labels match the selector).
        /// </summary>
        /// <value>Total number of non-terminated pods targeted by this deployment (their labels match the selector).</value>
        [DataMember(Name="replicas", EmitDefaultValue=false)]
        public int? Replicas { get; set; }

        /// <summary>
        /// Total number of unavailable pods targeted by this deployment.
        /// </summary>
        /// <value>Total number of unavailable pods targeted by this deployment.</value>
        [DataMember(Name="unavailableReplicas", EmitDefaultValue=false)]
        public int? UnavailableReplicas { get; set; }

        /// <summary>
        /// Total number of non-terminated pods targeted by this deployment that have the desired template spec.
        /// </summary>
        /// <value>Total number of non-terminated pods targeted by this deployment that have the desired template spec.</value>
        [DataMember(Name="updatedReplicas", EmitDefaultValue=false)]
        public int? UpdatedReplicas { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppsV1beta1DeploymentStatus {\n");
            sb.Append("  AvailableReplicas: ").Append(AvailableReplicas).Append("\n");
            sb.Append("  CollisionCount: ").Append(CollisionCount).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  ObservedGeneration: ").Append(ObservedGeneration).Append("\n");
            sb.Append("  ReadyReplicas: ").Append(ReadyReplicas).Append("\n");
            sb.Append("  Replicas: ").Append(Replicas).Append("\n");
            sb.Append("  UnavailableReplicas: ").Append(UnavailableReplicas).Append("\n");
            sb.Append("  UpdatedReplicas: ").Append(UpdatedReplicas).Append("\n");
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
            return this.Equals(obj as AppsV1beta1DeploymentStatus);
        }

        /// <summary>
        /// Returns true if AppsV1beta1DeploymentStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of AppsV1beta1DeploymentStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppsV1beta1DeploymentStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AvailableReplicas == other.AvailableReplicas ||
                    this.AvailableReplicas != null &&
                    this.AvailableReplicas.Equals(other.AvailableReplicas)
                ) && 
                (
                    this.CollisionCount == other.CollisionCount ||
                    this.CollisionCount != null &&
                    this.CollisionCount.Equals(other.CollisionCount)
                ) && 
                (
                    this.Conditions == other.Conditions ||
                    this.Conditions != null &&
                    this.Conditions.SequenceEqual(other.Conditions)
                ) && 
                (
                    this.ObservedGeneration == other.ObservedGeneration ||
                    this.ObservedGeneration != null &&
                    this.ObservedGeneration.Equals(other.ObservedGeneration)
                ) && 
                (
                    this.ReadyReplicas == other.ReadyReplicas ||
                    this.ReadyReplicas != null &&
                    this.ReadyReplicas.Equals(other.ReadyReplicas)
                ) && 
                (
                    this.Replicas == other.Replicas ||
                    this.Replicas != null &&
                    this.Replicas.Equals(other.Replicas)
                ) && 
                (
                    this.UnavailableReplicas == other.UnavailableReplicas ||
                    this.UnavailableReplicas != null &&
                    this.UnavailableReplicas.Equals(other.UnavailableReplicas)
                ) && 
                (
                    this.UpdatedReplicas == other.UpdatedReplicas ||
                    this.UpdatedReplicas != null &&
                    this.UpdatedReplicas.Equals(other.UpdatedReplicas)
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
                if (this.AvailableReplicas != null)
                    hash = hash * 59 + this.AvailableReplicas.GetHashCode();
                if (this.CollisionCount != null)
                    hash = hash * 59 + this.CollisionCount.GetHashCode();
                if (this.Conditions != null)
                    hash = hash * 59 + this.Conditions.GetHashCode();
                if (this.ObservedGeneration != null)
                    hash = hash * 59 + this.ObservedGeneration.GetHashCode();
                if (this.ReadyReplicas != null)
                    hash = hash * 59 + this.ReadyReplicas.GetHashCode();
                if (this.Replicas != null)
                    hash = hash * 59 + this.Replicas.GetHashCode();
                if (this.UnavailableReplicas != null)
                    hash = hash * 59 + this.UnavailableReplicas.GetHashCode();
                if (this.UpdatedReplicas != null)
                    hash = hash * 59 + this.UpdatedReplicas.GetHashCode();
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