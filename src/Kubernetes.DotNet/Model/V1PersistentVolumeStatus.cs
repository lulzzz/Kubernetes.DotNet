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
    /// PersistentVolumeStatus is the current status of a persistent volume.
    /// </summary>
    [DataContract]
    public partial class V1PersistentVolumeStatus :  IEquatable<V1PersistentVolumeStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PersistentVolumeStatus" /> class.
        /// </summary>
        /// <param name="Message">A human-readable message indicating details about why the volume is in this state..</param>
        /// <param name="Phase">Phase indicates if a volume is available, bound to a claim, or released by a claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#phase.</param>
        /// <param name="Reason">Reason is a brief CamelCase string that describes any failure and is meant for machine parsing and tidy display in the CLI..</param>
        public V1PersistentVolumeStatus(string Message = default(string), string Phase = default(string), string Reason = default(string))
        {
            this.Message = Message;
            this.Phase = Phase;
            this.Reason = Reason;
        }
        
        /// <summary>
        /// A human-readable message indicating details about why the volume is in this state.
        /// </summary>
        /// <value>A human-readable message indicating details about why the volume is in this state.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Phase indicates if a volume is available, bound to a claim, or released by a claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#phase
        /// </summary>
        /// <value>Phase indicates if a volume is available, bound to a claim, or released by a claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#phase</value>
        [DataMember(Name="phase", EmitDefaultValue=false)]
        public string Phase { get; set; }

        /// <summary>
        /// Reason is a brief CamelCase string that describes any failure and is meant for machine parsing and tidy display in the CLI.
        /// </summary>
        /// <value>Reason is a brief CamelCase string that describes any failure and is meant for machine parsing and tidy display in the CLI.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PersistentVolumeStatus {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Phase: ").Append(Phase).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return this.Equals(obj as V1PersistentVolumeStatus);
        }

        /// <summary>
        /// Returns true if V1PersistentVolumeStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of V1PersistentVolumeStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PersistentVolumeStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Phase == other.Phase ||
                    this.Phase != null &&
                    this.Phase.Equals(other.Phase)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
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
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Phase != null)
                    hash = hash * 59 + this.Phase.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
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
