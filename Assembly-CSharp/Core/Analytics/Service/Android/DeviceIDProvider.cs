using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Core.Analytics.Service.Android
{
	// Token: 0x02001292 RID: 4754
	[Token(Token = "0x2001292")]
	public class DeviceIDProvider : IDeviceIDProvider
	{
		// Token: 0x060070F9 RID: 28921 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60070F9")]
		[Address(RVA = "0xBB20", Offset = "0xBB20", VA = "0xBB20", Slot = "4")]
		public string GetDeviceId([Optional] string userId)
		{
			return null;
		}

		// Token: 0x060070FA RID: 28922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070FA")]
		[Address(RVA = "0xBB21", Offset = "0xBB21", VA = "0xBB21")]
		public DeviceIDProvider()
		{
		}

		// Token: 0x04003AF7 RID: 15095
		[Token(Token = "0x4003AF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private string _deviceID;
	}
}
