﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestfulMVC {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class RestfulContent {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal RestfulContent() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RestfulMVC.RestfulContent", typeof(RestfulContent).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The resource {0} could not be resolved by the bucket.
        /// </summary>
        internal static string BucketResourceNotFound {
            get {
                return ResourceManager.GetString("BucketResourceNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to application/{0}.
        /// </summary>
        internal static string ContentTypeApplication {
            get {
                return ResourceManager.GetString("ContentTypeApplication", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Content type of {0} is not supported.
        /// </summary>
        internal static string ContentTypeNotSupported {
            get {
                return ResourceManager.GetString("ContentTypeNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expect.
        /// </summary>
        internal static string Expect {
            get {
                return ResourceManager.GetString("Expect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The serializer cannot use the object.
        /// </summary>
        internal static string InvalidObjectTypeForSerializer {
            get {
                return ResourceManager.GetString("InvalidObjectTypeForSerializer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object is not serializable.
        /// </summary>
        internal static string ObjectNotSerializable {
            get {
                return ResourceManager.GetString("ObjectNotSerializable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Response serialization failed to complete.
        /// </summary>
        internal static string ResponseSerializationFailed {
            get {
                return ResourceManager.GetString("ResponseSerializationFailed", resourceCulture);
            }
        }
    }
}
