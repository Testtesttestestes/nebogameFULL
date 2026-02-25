using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace UI.Utils
{
	// Token: 0x02000120 RID: 288
	[Token(Token = "0x2000120")]
	public class LateUpdateOnceInvoker : MonoBehaviour
	{
		// Token: 0x060008F5 RID: 2293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x5C74", Offset = "0x5C74", VA = "0x5C74")]
		private void LateUpdate()
		{
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x5C75", Offset = "0x5C75", VA = "0x5C75")]
		public LateUpdateOnceInvoker()
		{
		}

		// Token: 0x04000347 RID: 839
		[Token(Token = "0x4000347")]
		[FieldOffset(Offset = "0x10")]
		public UnityEvent SomeCall;

		// Token: 0x04000348 RID: 840
		[Token(Token = "0x4000348")]
		[FieldOffset(Offset = "0x14")]
		private bool _isCall;
	}
}
