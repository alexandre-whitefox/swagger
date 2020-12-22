/*
 * Onyx Domain API V1
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.4
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ShareClassData : IEquatable<ShareClassData>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ManagementFee1
        /// </summary>
        [DataMember(Name="managementFee1")]
        public double? ManagementFee1 { get; set; }

        /// <summary>
        /// Gets or Sets PerformanceFee
        /// </summary>
        [DataMember(Name="performanceFee")]
        public double? PerformanceFee { get; set; }

        /// <summary>
        /// Gets or Sets ManagementFee2
        /// </summary>
        [DataMember(Name="managementFee2")]
        public double? ManagementFee2 { get; set; }

        /// <summary>
        /// Gets or Sets ManagementFee3
        /// </summary>
        [DataMember(Name="managementFee3")]
        public double? ManagementFee3 { get; set; }

        /// <summary>
        /// Gets or Sets Limit1
        /// </summary>
        [DataMember(Name="limit1")]
        public double? Limit1 { get; set; }

        /// <summary>
        /// Gets or Sets Limit2
        /// </summary>
        [DataMember(Name="limit2")]
        public double? Limit2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShareClassData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ManagementFee1: ").Append(ManagementFee1).Append("\n");
            sb.Append("  PerformanceFee: ").Append(PerformanceFee).Append("\n");
            sb.Append("  ManagementFee2: ").Append(ManagementFee2).Append("\n");
            sb.Append("  ManagementFee3: ").Append(ManagementFee3).Append("\n");
            sb.Append("  Limit1: ").Append(Limit1).Append("\n");
            sb.Append("  Limit2: ").Append(Limit2).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ShareClassData)obj);
        }

        /// <summary>
        /// Returns true if ShareClassData instances are equal
        /// </summary>
        /// <param name="other">Instance of ShareClassData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShareClassData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    ManagementFee1 == other.ManagementFee1 ||
                    ManagementFee1 != null &&
                    ManagementFee1.Equals(other.ManagementFee1)
                ) && 
                (
                    PerformanceFee == other.PerformanceFee ||
                    PerformanceFee != null &&
                    PerformanceFee.Equals(other.PerformanceFee)
                ) && 
                (
                    ManagementFee2 == other.ManagementFee2 ||
                    ManagementFee2 != null &&
                    ManagementFee2.Equals(other.ManagementFee2)
                ) && 
                (
                    ManagementFee3 == other.ManagementFee3 ||
                    ManagementFee3 != null &&
                    ManagementFee3.Equals(other.ManagementFee3)
                ) && 
                (
                    Limit1 == other.Limit1 ||
                    Limit1 != null &&
                    Limit1.Equals(other.Limit1)
                ) && 
                (
                    Limit2 == other.Limit2 ||
                    Limit2 != null &&
                    Limit2.Equals(other.Limit2)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (ManagementFee1 != null)
                    hashCode = hashCode * 59 + ManagementFee1.GetHashCode();
                    if (PerformanceFee != null)
                    hashCode = hashCode * 59 + PerformanceFee.GetHashCode();
                    if (ManagementFee2 != null)
                    hashCode = hashCode * 59 + ManagementFee2.GetHashCode();
                    if (ManagementFee3 != null)
                    hashCode = hashCode * 59 + ManagementFee3.GetHashCode();
                    if (Limit1 != null)
                    hashCode = hashCode * 59 + Limit1.GetHashCode();
                    if (Limit2 != null)
                    hashCode = hashCode * 59 + Limit2.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ShareClassData left, ShareClassData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ShareClassData left, ShareClassData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
