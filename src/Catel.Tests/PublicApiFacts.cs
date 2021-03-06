﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PublicApiFacts.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Tests
{
    using System.Runtime.CompilerServices;
    using ApiApprover;
    using Catel.MVVM;
    using Catel.Runtime.Serialization.Json;
    using NUnit.Framework;

    [TestFixture]
    public class PublicApiFacts
    {
        [Test, MethodImpl(MethodImplOptions.NoInlining)]
        public void Catel_Core_HasNoBreakingChanges()
        {
            var assembly = typeof(Argument).Assembly;

            PublicApiApprover.ApprovePublicApi(assembly);
        }

        [Test, MethodImpl(MethodImplOptions.NoInlining)]
        public void Catel_MVVM_HasNoBreakingChanges()
        {
            var assembly = typeof(ViewModelBase).Assembly;

            PublicApiApprover.ApprovePublicApi(assembly);
        }

        [Test, MethodImpl(MethodImplOptions.NoInlining)]
        public void Catel_Serialization_Json_HasNoBreakingChanges()
        {
            var assembly = typeof(JsonSerializer).Assembly;

            PublicApiApprover.ApprovePublicApi(assembly);
        }
    }
}