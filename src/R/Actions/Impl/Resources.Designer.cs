﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.R.Actions {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.R.Actions.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Cannot find R binaries in {0}. Please verify path to the R installation folder. It typically looks like C:\Program Files\R\R-3.2.x..
        /// </summary>
        internal static string Error_CannotFindRBinariesFormat {
            get {
                return ResourceManager.GetString("Error_CannotFindRBinariesFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to access path {0}. Exception: {1}..
        /// </summary>
        internal static string Error_ExceptionAccessingPath {
            get {
                return ResourceManager.GetString("Error_ExceptionAccessingPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Timeout installing package {0}.
        /// </summary>
        internal static string Error_InstallTimeout_Format {
            get {
                return ResourceManager.GetString("Error_InstallTimeout_Format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to determine location of R binaries. If R is not installed please install Microsoft R Open and restart Visual Studio. If R is installed please specify path to R binaries in Tools | Options | R Tools..
        /// </summary>
        internal static string Error_UnableToFindR {
            get {
                return ResourceManager.GetString("Error_UnableToFindR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to R {0}.{1}.{2} is not compatible with R Tools for Visual Studio. Supported versions are {3}.{4}.{5} - {6}.{7}.{8}..
        /// </summary>
        internal static string Error_UnsupportedRVersion {
            get {
                return ResourceManager.GetString("Error_UnsupportedRVersion", resourceCulture);
            }
        }
    }
}
