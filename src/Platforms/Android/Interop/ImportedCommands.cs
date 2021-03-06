/* Please note that this file is generated by the VulkanSharp's generator. Do not edit directly.

   Licensed under the MIT license.

   Copyright 2016 Xamarin Inc

   This notice may not be removed from any source distribution.
   See LICENSE file for licensing details.
*/

using System;
using System.Runtime.InteropServices;
using Vulkan.Interop;

namespace Vulkan.Android.Interop
{
	internal static class NativeMethods
	{
		const string VulkanLibrary = "vulkan";

		[DllImport (VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
		internal static unsafe extern Result vkCreateAndroidSurfaceKHR (IntPtr instance, AndroidSurfaceCreateInfoKhr* pCreateInfo, Vulkan.Interop.AllocationCallbacks* pAllocator, UInt64* pSurface);

	}
}
