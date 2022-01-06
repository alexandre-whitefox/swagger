/*
 * Onyx Domain API V1
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.18
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
    public partial class CorporateActionData : IEquatable<CorporateActionData>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>

        [DataMember(Name="id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets DateEx
        /// </summary>

        [DataMember(Name="dateEx")]
        public DateTime? DateEx { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>

        [DataMember(Name="value")]
        public double? Value { get; set; }

        /// <summary>
        /// Gets or Sets Percentual
        /// </summary>

        [DataMember(Name="percentual")]
        public double? Percentual { get; set; }

        /// <summary>
        /// Gets or Sets Security
        /// </summary>

        [DataMember(Name="security")]
        public string Security { get; set; }

        /// <summary>
        /// Gets or Sets TypeId
        /// </summary>

        [DataMember(Name="typeId")]
        public int? TypeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CorporateActionData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DateEx: ").Append(DateEx).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Percentual: ").Append(Percentual).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CorporateActionData)obj);
        }

        /// <summary>
        /// Returns true if CorporateActionData instances are equal
        /// </summary>
        /// <param name="other">Instance of CorporateActionData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CorporateActionData other)
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
                    DateEx == other.DateEx ||
                    DateEx != null &&
                    DateEx.Equals(other.DateEx)
                ) && 
                (
                    Value == other.Value ||
                    Value != null &&
                    Value.Equals(other.Value)
                ) && 
                (
                    Percentual == other.Percentual ||
                    Percentual != null &&
                    Percentual.Equals(other.Percentual)
                ) && 
                (
                    Security == other.Security ||
                    Security != null &&
                    Security.Equals(other.Security)
                ) && 
                (
                    TypeId == other.TypeId ||
                    TypeId != null &&
                    TypeId.Equals(other.TypeId)
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
                    if (DateEx != null)
                    hashCode = hashCode * 59 + DateEx.GetHashCode();
                    if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                    if (Percentual != null)
                    hashCode = hashCode * 59 + Percentual.GetHashCode();
                    if (Security != null)
                    hashCode = hashCode * 59 + Security.GetHashCode();
                    if (TypeId != null)
                    hashCode = hashCode * 59 + TypeId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CorporateActionData left, CorporateActionData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CorporateActionData left, CorporateActionData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
