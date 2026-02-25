using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x0200027D RID: 637
	[Token(Token = "0x200027D")]
	public class NotFoundWindowScript : NotFoundWindowObject
	{
		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700021C")]
		public override string Message
		{
			[Token(Token = "0x6000F3D")]
			[Address(RVA = "0x6171", Offset = "0x6171", VA = "0x6171", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F3E")]
		[Address(RVA = "0x6172", Offset = "0x6172", VA = "0x6172")]
		public NotFoundWindowScript(string windowId, GameObject windowGameObject)
		{
		}

		// Token: 0x040007A5 RID: 1957
		[Token(Token = "0x40007A5")]
		private const string FORMAT = "Found window GameObject, but not found window script. [{0}] [{1}]";

		// Token: 0x040007A6 RID: 1958
		[Token(Token = "0x40007A6")]
		[FieldOffset(Offset = "0x4C")]
		public readonly GameObject WindowGameObject;
	}
}
