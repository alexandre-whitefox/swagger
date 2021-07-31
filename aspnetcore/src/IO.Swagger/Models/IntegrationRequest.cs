/*
 * Onyx Domain API V1
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.10
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
    public partial class IntegrationRequest : IEquatable<IntegrationRequest>
    { 
        /// <summary>
        /// Gets or Sets UserEmail
        /// </summary>

        [DataMember(Name="userEmail")]
        public string UserEmail { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>

        [DataMember(Name="password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets CurrentTradeId
        /// </summary>

        [DataMember(Name="currentTradeId")]
        public int? CurrentTradeId { get; set; }

        /// <summary>
        /// Gets or Sets CurrentTransferTradeId
        /// </summary>

        [DataMember(Name="currentTransferTradeId")]
        public int? CurrentTransferTradeId { get; set; }

        /// <summary>
        /// Gets or Sets CurrentCorporateActionId
        /// </summary>

        [DataMember(Name="currentCorporateActionId")]
        public int? CurrentCorporateActionId { get; set; }

        /// <summary>
        /// Gets or Sets CurrentDividendId
        /// </summary>

        [DataMember(Name="currentDividendId")]
        public int? CurrentDividendId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntegrationRequest {\n");
            sb.Append("  UserEmail: ").Append(UserEmail).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  CurrentTradeId: ").Append(CurrentTradeId).Append("\n");
            sb.Append("  CurrentTransferTradeId: ").Append(CurrentTransferTradeId).Append("\n");
            sb.Append("  CurrentCorporateActionId: ").Append(CurrentCorporateActionId).Append("\n");
            sb.Append("  CurrentDividendId: ").Append(CurrentDividendId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((IntegrationRequest)obj);
        }

        /// <summary>
        /// Returns true if IntegrationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of IntegrationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegrationRequest other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    UserEmail == other.UserEmail ||
                    UserEmail != null &&
                    UserEmail.Equals(other.UserEmail)
                ) && 
                (
                    Password == other.Password ||
                    Password != null &&
                    Password.Equals(other.Password)
                ) && 
                (
                    CurrentTradeId == other.CurrentTradeId ||
                    CurrentTradeId != null &&
                    CurrentTradeId.Equals(other.CurrentTradeId)
                ) && 
                (
                    CurrentTransferTradeId == other.CurrentTransferTradeId ||
                    CurrentTransferTradeId != null &&
                    CurrentTransferTradeId.Equals(other.CurrentTransferTradeId)
                ) && 
                (
                    CurrentCorporateActionId == other.CurrentCorporateActionId ||
                    CurrentCorporateActionId != null &&
                    CurrentCorporateActionId.Equals(other.CurrentCorporateActionId)
                ) && 
                (
                    CurrentDividendId == other.CurrentDividendId ||
                    CurrentDividendId != null &&
                    CurrentDividendId.Equals(other.CurrentDividendId)
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
                    if (UserEmail != null)
                    hashCode = hashCode * 59 + UserEmail.GetHashCode();
                    if (Password != null)
                    hashCode = hashCode * 59 + Password.GetHashCode();
                    if (CurrentTradeId != null)
                    hashCode = hashCode * 59 + CurrentTradeId.GetHashCode();
                    if (CurrentTransferTradeId != null)
                    hashCode = hashCode * 59 + CurrentTransferTradeId.GetHashCode();
                    if (CurrentCorporateActionId != null)
                    hashCode = hashCode * 59 + CurrentCorporateActionId.GetHashCode();
                    if (CurrentDividendId != null)
                    hashCode = hashCode * 59 + CurrentDividendId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(IntegrationRequest left, IntegrationRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(IntegrationRequest left, IntegrationRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
