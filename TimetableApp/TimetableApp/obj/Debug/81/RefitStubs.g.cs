﻿// <auto-generated />
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using QuickType;
using Refit;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

#pragma warning disable
namespace TimetableApp.RefitInternalGenerated
{
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {

        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
    }
}
#pragma warning restore

namespace TimetableApp.API
{
    using TimetableApp.RefitInternalGenerated;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedITimetableAPI : ITimetableAPI
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedITimetableAPI(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<List<Welcome>> ITimetableAPI.GetAllRooms()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetAllRooms", new Type[] {  });
            return (Task<List<Welcome>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Welcome> ITimetableAPI.GetRoom(int roomid)
        {
            var arguments = new object[] { roomid };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetRoom", new Type[] { typeof(int) });
            return (Task<Welcome>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<List<Welcome>> ITimetableAPI.GetUser()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetUser", new Type[] {  });
            return (Task<List<Welcome>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<string> ITimetableAPI.GetValues()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetValues", new Type[] {  });
            return (Task<string>)func(Client, arguments);
        }
    }
}