/*
 * Onyx Domain API V1
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.7
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
    public partial class BasicLoginParameters : IEquatable<BasicLoginParameters>
    { 
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets ComputerUserName
        /// </summary>
        [DataMember(Name="computerUserName")]
        public string ComputerUserName { get; set; }

        /// <summary>
        /// Gets or Sets ComputerName
        /// </summary>
        [DataMember(Name="computerName")]
        public string ComputerName { get; set; }

        /// <summary>
        /// Gets or Sets AppVersion
        /// </summary>
        [DataMember(Name="appVersion")]
        public string AppVersion { get; set; }

        /// <summary>
        /// Gets or Sets SingleUse
        /// </summary>
        [DataMember(Name="singleUse")]
        public int? SingleUse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BasicLoginParameters {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  ComputerUserName: ").Append(ComputerUserName).Append("\n");
            sb.Append("  ComputerName: ").Append(ComputerName).Append("\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  SingleUse: ").Append(SingleUse).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BasicLoginParameters)obj);
        }

        /// <summary>
        /// Returns true if BasicLoginParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of BasicLoginParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BasicLoginParameters other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Email == other.Email ||
                    Email != null &&
                    Email.Equals(other.Email)
                ) && 
                (
                    Password == other.Password ||
                    Password != null &&
                    Password.Equals(other.Password)
                ) && 
                (
                    ComputerUserName == other.ComputerUserName ||
                    ComputerUserName != null &&
                    ComputerUserName.Equals(other.ComputerUserName)
                ) && 
                (
                    ComputerName == other.ComputerName ||
                    ComputerName != null &&
                    ComputerName.Equals(other.ComputerName)
                ) && 
                (
                    AppVersion == other.AppVersion ||
                    AppVersion != null &&
                    AppVersion.Equals(other.AppVersion)
                ) && 
                (
                    SingleUse == other.SingleUse ||
                    SingleUse != null &&
                    SingleUse.Equals(other.SingleUse)
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
                    if (Email != null)
                    hashCode = hashCode * 59 + Email.GetHashCode();
                    if (Password != null)
                    hashCode = hashCode * 59 + Password.GetHashCode();
                    if (ComputerUserName != null)
                    hashCode = hashCode * 59 + ComputerUserName.GetHashCode();
                    if (ComputerName != null)
                    hashCode = hashCode * 59 + ComputerName.GetHashCode();
                    if (AppVersion != null)
                    hashCode = hashCode * 59 + AppVersion.GetHashCode();
                    if (SingleUse != null)
                    hashCode = hashCode * 59 + SingleUse.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BasicLoginParameters left, BasicLoginParameters right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BasicLoginParameters left, BasicLoginParameters right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
