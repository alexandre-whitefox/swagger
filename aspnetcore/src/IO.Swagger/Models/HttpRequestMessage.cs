/*
 * Onyx Domain API V1
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.1
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
    public partial class HttpRequestMessage : IEquatable<HttpRequestMessage>
    { 
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version")]
        public Version Version { get; set; }

        /// <summary>
        /// Gets or Sets VersionPolicy
        /// </summary>
        [DataMember(Name="versionPolicy")]
        public HttpVersionPolicy VersionPolicy { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content")]
        public HttpContent Content { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name="method")]
        public HttpMethod Method { get; set; }

        /// <summary>
        /// Gets or Sets RequestUri
        /// </summary>
        [DataMember(Name="requestUri")]
        public string RequestUri { get; set; }

        /// <summary>
        /// Gets or Sets Headers
        /// </summary>
        [DataMember(Name="headers")]
        public List<StringStringIEnumerableKeyValuePair> Headers { get; private set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties")]
        public Dictionary<string, > Properties { get; private set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options")]
        public Dictionary<string, > Options { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpRequestMessage {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  VersionPolicy: ").Append(VersionPolicy).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  RequestUri: ").Append(RequestUri).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return obj.GetType() == GetType() && Equals((HttpRequestMessage)obj);
        }

        /// <summary>
        /// Returns true if HttpRequestMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of HttpRequestMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HttpRequestMessage other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Version == other.Version ||
                    Version != null &&
                    Version.Equals(other.Version)
                ) && 
                (
                    VersionPolicy == other.VersionPolicy ||
                    VersionPolicy != null &&
                    VersionPolicy.Equals(other.VersionPolicy)
                ) && 
                (
                    Content == other.Content ||
                    Content != null &&
                    Content.Equals(other.Content)
                ) && 
                (
                    Method == other.Method ||
                    Method != null &&
                    Method.Equals(other.Method)
                ) && 
                (
                    RequestUri == other.RequestUri ||
                    RequestUri != null &&
                    RequestUri.Equals(other.RequestUri)
                ) && 
                (
                    Headers == other.Headers ||
                    Headers != null &&
                    Headers.SequenceEqual(other.Headers)
                ) && 
                (
                    Properties == other.Properties ||
                    Properties != null &&
                    Properties.SequenceEqual(other.Properties)
                ) && 
                (
                    Options == other.Options ||
                    Options != null &&
                    Options.SequenceEqual(other.Options)
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
                    if (Version != null)
                    hashCode = hashCode * 59 + Version.GetHashCode();
                    if (VersionPolicy != null)
                    hashCode = hashCode * 59 + VersionPolicy.GetHashCode();
                    if (Content != null)
                    hashCode = hashCode * 59 + Content.GetHashCode();
                    if (Method != null)
                    hashCode = hashCode * 59 + Method.GetHashCode();
                    if (RequestUri != null)
                    hashCode = hashCode * 59 + RequestUri.GetHashCode();
                    if (Headers != null)
                    hashCode = hashCode * 59 + Headers.GetHashCode();
                    if (Properties != null)
                    hashCode = hashCode * 59 + Properties.GetHashCode();
                    if (Options != null)
                    hashCode = hashCode * 59 + Options.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(HttpRequestMessage left, HttpRequestMessage right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(HttpRequestMessage left, HttpRequestMessage right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
