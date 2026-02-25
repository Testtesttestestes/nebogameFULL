using System;
using Il2CppDummyDll;

namespace Core.Analytics
{
	// Token: 0x02001284 RID: 4740
	[Token(Token = "0x2001284")]
	public interface IDeviceIDProvider
	{
		// Token: 0x060070AD RID: 28845
		[Token(Token = "0x60070AD")]
		string GetDeviceId(string userId);
	}
}
