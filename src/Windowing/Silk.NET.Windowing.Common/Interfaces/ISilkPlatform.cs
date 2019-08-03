// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Windowing.Common
{
    /// <summary>
    /// An interface that provides windowing for its respective native backend.
    /// </summary>
    public interface ISilkPlatform
    {
        /// <summary>
        /// Gets a value indicating whether this <see cref="ISilkPlatform"/> should be used, based on the
        /// current runtime/environment.
        /// </summary>
        bool IsApplicable { get; }

        /// <summary>
        /// Creates a window with the given options.
        /// </summary>
        /// <param name="options">The initial settings this window should open with.</param>
        /// <returns>An implementation of <see cref="IWindow"/></returns>
        IWindow GetWindow(WindowOptions options);

        /// <summary>
        /// Gets a function pointer for the given function in the given API.
        /// </summary>
        /// <param name="api">The API to which the function belongs.</param>
        /// <param name="name">The function name.</param>
        /// <returns>The function pointer.</returns>
        IntPtr GetProcAddress(ContextAPI api, string name);
    }
}