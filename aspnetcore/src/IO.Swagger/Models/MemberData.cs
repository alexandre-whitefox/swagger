/*
 * Onyx Domain API V1
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.6
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
    public partial class MemberData : IEquatable<MemberData>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Analyst
        /// </summary>
        [DataMember(Name="analyst")]
        public bool? Analyst { get; set; }

        /// <summary>
        /// Gets or Sets Trader
        /// </summary>
        [DataMember(Name="trader")]
        public bool? Trader { get; set; }

        /// <summary>
        /// Gets or Sets Disabled
        /// </summary>
        [DataMember(Name="disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MemberData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Analyst: ").Append(Analyst).Append("\n");
            sb.Append("  Trader: ").Append(Trader).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MemberData)obj);
        }

        /// <summary>
        /// Returns true if MemberData instances are equal
        /// </summary>
        /// <param name="other">Instance of MemberData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MemberData other)
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
                    Code == other.Code ||
                    Code != null &&
                    Code.Equals(other.Code)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Email == other.Email ||
                    Email != null &&
                    Email.Equals(other.Email)
                ) && 
                (
                    Analyst == other.Analyst ||
                    Analyst != null &&
                    Analyst.Equals(other.Analyst)
                ) && 
                (
                    Trader == other.Trader ||
                    Trader != null &&
                    Trader.Equals(other.Trader)
                ) && 
                (
                    Disabled == other.Disabled ||
                    Disabled != null &&
                    Disabled.Equals(other.Disabled)
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
                    if (Code != null)
                    hashCode = hashCode * 59 + Code.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Email != null)
                    hashCode = hashCode * 59 + Email.GetHashCode();
                    if (Analyst != null)
                    hashCode = hashCode * 59 + Analyst.GetHashCode();
                    if (Trader != null)
                    hashCode = hashCode * 59 + Trader.GetHashCode();
                    if (Disabled != null)
                    hashCode = hashCode * 59 + Disabled.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MemberData left, MemberData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MemberData left, MemberData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
