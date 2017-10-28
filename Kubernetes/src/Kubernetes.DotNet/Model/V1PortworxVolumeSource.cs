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
    /// PortworxVolumeSource represents a Portworx volume resource.
    /// </summary>
    [DataContract]
    public partial class V1PortworxVolumeSource :  IEquatable<V1PortworxVolumeSource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PortworxVolumeSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1PortworxVolumeSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PortworxVolumeSource" /> class.
        /// </summary>
        /// <param name="FsType">FSType represents the filesystem type to mount Must be a filesystem type supported by the host operating system. Ex. \&quot;ext4\&quot;, \&quot;xfs\&quot;. Implicitly inferred to be \&quot;ext4\&quot; if unspecified..</param>
        /// <param name="_ReadOnly">Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts..</param>
        /// <param name="VolumeID">VolumeID uniquely identifies a Portworx volume (required).</param>
        public V1PortworxVolumeSource(string FsType = default(string), bool? _ReadOnly = default(bool?), string VolumeID = default(string))
        {
            // to ensure "VolumeID" is required (not null)
            if (VolumeID == null)
            {
                throw new InvalidDataException("VolumeID is a required property for V1PortworxVolumeSource and cannot be null");
            }
            else
            {
                this.VolumeID = VolumeID;
            }
            this.FsType = FsType;
            this._ReadOnly = _ReadOnly;
        }
        
        /// <summary>
        /// FSType represents the filesystem type to mount Must be a filesystem type supported by the host operating system. Ex. \&quot;ext4\&quot;, \&quot;xfs\&quot;. Implicitly inferred to be \&quot;ext4\&quot; if unspecified.
        /// </summary>
        /// <value>FSType represents the filesystem type to mount Must be a filesystem type supported by the host operating system. Ex. \&quot;ext4\&quot;, \&quot;xfs\&quot;. Implicitly inferred to be \&quot;ext4\&quot; if unspecified.</value>
        [DataMember(Name="fsType", EmitDefaultValue=false)]
        public string FsType { get; set; }

        /// <summary>
        /// Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
        /// </summary>
        /// <value>Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</value>
        [DataMember(Name="readOnly", EmitDefaultValue=false)]
        public bool? _ReadOnly { get; set; }

        /// <summary>
        /// VolumeID uniquely identifies a Portworx volume
        /// </summary>
        /// <value>VolumeID uniquely identifies a Portworx volume</value>
        [DataMember(Name="volumeID", EmitDefaultValue=false)]
        public string VolumeID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PortworxVolumeSource {\n");
            sb.Append("  FsType: ").Append(FsType).Append("\n");
            sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
            sb.Append("  VolumeID: ").Append(VolumeID).Append("\n");
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
            return this.Equals(obj as V1PortworxVolumeSource);
        }

        /// <summary>
        /// Returns true if V1PortworxVolumeSource instances are equal
        /// </summary>
        /// <param name="other">Instance of V1PortworxVolumeSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PortworxVolumeSource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FsType == other.FsType ||
                    this.FsType != null &&
                    this.FsType.Equals(other.FsType)
                ) && 
                (
                    this._ReadOnly == other._ReadOnly ||
                    this._ReadOnly != null &&
                    this._ReadOnly.Equals(other._ReadOnly)
                ) && 
                (
                    this.VolumeID == other.VolumeID ||
                    this.VolumeID != null &&
                    this.VolumeID.Equals(other.VolumeID)
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
                if (this.FsType != null)
                    hash = hash * 59 + this.FsType.GetHashCode();
                if (this._ReadOnly != null)
                    hash = hash * 59 + this._ReadOnly.GetHashCode();
                if (this.VolumeID != null)
                    hash = hash * 59 + this.VolumeID.GetHashCode();
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