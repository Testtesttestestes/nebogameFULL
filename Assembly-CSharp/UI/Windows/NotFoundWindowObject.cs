using System;
using Il2CppDummyDll;

namespace UI.Windows
{
	// Token: 0x0200027C RID: 636
	[Token(Token = "0x200027C")]
	public class NotFoundWindowObject : NotFoundWindowKey
	{
		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700021B")]
		public override string Message
		{
			[Token(Token = "0x6000F3B")]
			[Address(RVA = "0x616F", Offset = "0x616F", VA = "0x616F", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F3C")]
		[Address(RVA = "0x6170", Offset = "0x6170", VA = "0x6170")]
		public NotFoundWindowObject(string windowId)
		{
		}

		// Token: 0x040007A4 RID: 1956
		[Token(Token = "0x40007A4")]
		private const string FORMAT = "Not found window GameObject. [{0}]";
	}
}
