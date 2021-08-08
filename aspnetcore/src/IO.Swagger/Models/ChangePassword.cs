/*
 * Onyx Domain API V1
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.11
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
    public partial class ChangePassword : IEquatable<ChangePassword>
    { 
        /// <summary>
        /// Gets or Sets Email
        /// </summary>

        [DataMember(Name="email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets CurrentPassword
        /// </summary>

        [DataMember(Name="currentPassword")]
        public string CurrentPassword { get; set; }

        /// <summary>
        /// Gets or Sets NewPassword
        /// </summary>

        [DataMember(Name="newPassword")]
        public string NewPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangePassword {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  CurrentPassword: ").Append(CurrentPassword).Append("\n");
            sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ChangePassword)obj);
        }

        /// <summary>
        /// Returns true if ChangePassword instances are equal
        /// </summary>
        /// <param name="other">Instance of ChangePassword to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangePassword other)
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
                    CurrentPassword == other.CurrentPassword ||
                    CurrentPassword != null &&
                    CurrentPassword.Equals(other.CurrentPassword)
                ) && 
                (
                    NewPassword == other.NewPassword ||
                    NewPassword != null &&
                    NewPassword.Equals(other.NewPassword)
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
                    if (CurrentPassword != null)
                    hashCode = hashCode * 59 + CurrentPassword.GetHashCode();
                    if (NewPassword != null)
                    hashCode = hashCode * 59 + NewPassword.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ChangePassword left, ChangePassword right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ChangePassword left, ChangePassword right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}