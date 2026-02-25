using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x0200027E RID: 638
	[Token(Token = "0x200027E")]
	public class IncorrectWindowTypeFound : NotFoundWindowScript
	{
		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700021D")]
		public override string Message
		{
			[Token(Token = "0x6000F3F")]
			[Address(RVA = "0x6173", Offset = "0x6173", VA = "0x6173", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F40")]
		[Address(RVA = "0x6174", Offset = "0x6174", VA = "0x6174")]
		public IncorrectWindowTypeFound(string windowId, GameObject windowGameObject, Type target, Type found)
		{
		}

		// Token: 0x040007A7 RID: 1959
		[Token(Token = "0x40007A7")]
		private const string FORMAT = "Found window GameObject, but found window script [{3}] not equal with target [{2}]. [{0}] [{1}]";

		// Token: 0x040007A8 RID: 1960
		[Token(Token = "0x40007A8")]
		[FieldOffset(Offset = "0x50")]
		public readonly Type Target;

		// Token: 0x040007A9 RID: 1961
		[Token(Token = "0x40007A9")]
		[FieldOffset(Offset = "0x54")]
		public readonly Type Found;
	}
}
