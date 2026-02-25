using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace I2.Loc
{
	// Token: 0x020013A0 RID: 5024
	[Token(Token = "0x20013A0")]
	[AddComponentMenu("I2/Localization/I2 Localize Callback")]
	public class CustomLocalizeCallback : MonoBehaviour
	{
		// Token: 0x060077A3 RID: 30627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077A3")]
		[Address(RVA = "0xC101", Offset = "0xC101", VA = "0xC101")]
		public void OnEnable()
		{
		}

		// Token: 0x060077A4 RID: 30628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077A4")]
		[Address(RVA = "0xC102", Offset = "0xC102", VA = "0xC102")]
		public void OnDisable()
		{
		}

		// Token: 0x060077A5 RID: 30629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077A5")]
		[Address(RVA = "0xC103", Offset = "0xC103", VA = "0xC103")]
		public void OnLocalize()
		{
		}

		// Token: 0x060077A6 RID: 30630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077A6")]
		[Address(RVA = "0xC104", Offset = "0xC104", VA = "0xC104")]
		public CustomLocalizeCallback()
		{
		}

		// Token: 0x04003E72 RID: 15986
		[Token(Token = "0x4003E72")]
		[FieldOffset(Offset = "0x10")]
		public UnityEvent _OnLocalize;
	}
}
