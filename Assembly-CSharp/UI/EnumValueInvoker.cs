using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI
{
	// Token: 0x020000F4 RID: 244
	[Token(Token = "0x20000F4")]
	public class EnumValueInvoker<T> : MonoBehaviour where T : Enum
	{
		// Token: 0x0600082C RID: 2092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600082C")]
		public EnumValueInvoker()
		{
		}

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x0")]
		public T Value;
	}
}
