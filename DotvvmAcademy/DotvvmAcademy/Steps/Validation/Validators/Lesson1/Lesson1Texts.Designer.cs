﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotvvmAcademy.Steps.Validation.Validators.Lesson1 {
    using System;
    using System.Reflection;
    
    
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
    public class Lesson1Texts {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Lesson1Texts() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotvvmAcademy.Steps.Validation.Validators.Lesson1.Lesson1Texts", typeof(Lesson1Texts).GetTypeInfo().Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must set the Text property of the Button!.
        /// </summary>
        public static string ButtonDoesNotHaveText {
            get {
                return ResourceManager.GetString("ButtonDoesNotHaveText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must call the Calculate() method in the command binding!.
        /// </summary>
        public static string CalculateMethodNotCalled {
            get {
                return ResourceManager.GetString("CalculateMethodNotCalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Calculate method does not return a correct result!.
        /// </summary>
        public static string CommandResultError {
            get {
                return ResourceManager.GetString("CommandResultError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There should be 1 Button control in the page!.
        /// </summary>
        public static string OneButtonControlError {
            get {
                return ResourceManager.GetString("OneButtonControlError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There should be 3 TextBox controls in the page!.
        /// </summary>
        public static string ThreeTextBoxControlsError {
            get {
                return ResourceManager.GetString("ThreeTextBoxControlsError", resourceCulture);
            }
        }
    }
}
