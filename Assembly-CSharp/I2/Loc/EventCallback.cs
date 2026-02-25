using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x02001356 RID: 4950
	[Token(Token = "0x2001356")]
	[Serializable]
	public class EventCallback
	{
		// Token: 0x0600758B RID: 30091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600758B")]
		[Address(RVA = "0xBF1B", Offset = "0xBF1B", VA = "0xBF1B")]
		public void Execute([Optional] UnityEngine.Object Sender)
		{
		}

		// Token: 0x0600758C RID: 30092 RVA: 0x000152D0 File Offset: 0x000134D0
		[Token(Token = "0x600758C")]
		[Address(RVA = "0xBF1C", Offset = "0xBF1C", VA = "0xBF1C")]
		public bool HasCallback()
		{
			return default(bool);
		}

		// Token: 0x0600758D RID: 30093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600758D")]
		[Address(RVA = "0xBF1D", Offset = "0xBF1D", VA = "0xBF1D")]
		public EventCallback()
		{
		}

		// Token: 0x04003D60 RID: 15712
		[Token(Token = "0x4003D60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public MonoBehaviour Target;

		// Token: 0x04003D61 RID: 15713
		[Token(Token = "0x4003D61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string MethodName;
	}
}
