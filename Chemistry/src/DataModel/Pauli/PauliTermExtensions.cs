﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;


namespace Microsoft.Quantum.Chemistry.Pauli
{

    /// <summary>
    /// Extensions For Pauli objects.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Construct PauliTTermValue that implements the ITermValue interface. 
        /// </summary>
        /// <param name="x">Input double.</param>
        /// <returns>PauliTTermValue representing the input double.</returns>
        public static PauliTTermValue ToPauliTTermValue(this double x)
        {
            return new PauliTTermValue(x);
        }

        /// <summary>
        /// Construct PauliTTermValue that implements the ITermValue interface. 
        /// </summary>
        /// <param name="x">Input double  sequence.</param>
        /// <returns>PauliTTermValue representing the input double sequence.</returns>
        public static PauliTTermValue ToPauliTTermValue(this IEnumerable<double> x)
        {
            return new PauliTTermValue(x);
        }
    }
}

