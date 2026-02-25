using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Net
{
	// Token: 0x02000E90 RID: 3728
	[Token(Token = "0x2000E90")]
	public static class ServiceFactory
	{
		// Token: 0x06005A98 RID: 23192 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005A98")]
		public static T GetService<T>() where T : AbstractService, new()
		{
			return null;
		}

		// Token: 0x0400317A RID: 12666
		[Token(Token = "0x400317A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ProtocolCommandInfoProvider ProtocolInfoProvider;

		// Token: 0x0400317B RID: 12667
		[Token(Token = "0x400317B")]
		[FieldOffset(Offset = "0x4")]
		private static readonly Dictionary<Type, AbstractService> _services;
	}
}
