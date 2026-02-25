using System;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x020013B2 RID: 5042
	[Token(Token = "0x20013B2")]
	public class RegisterGlobalParameters : MonoBehaviour, ILocalizationParamsManager
	{
		// Token: 0x060077E1 RID: 30689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077E1")]
		[Address(RVA = "0xC13C", Offset = "0xC13C", VA = "0xC13C", Slot = "5")]
		public virtual void OnEnable()
		{
		}

		// Token: 0x060077E2 RID: 30690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077E2")]
		[Address(RVA = "0xC13D", Offset = "0xC13D", VA = "0xC13D", Slot = "6")]
		public virtual void OnDisable()
		{
		}

		// Token: 0x060077E3 RID: 30691 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077E3")]
		[Address(RVA = "0xC13E", Offset = "0xC13E", VA = "0xC13E", Slot = "7")]
		public virtual string GetParameterValue(string ParamName)
		{
			return null;
		}

		// Token: 0x060077E4 RID: 30692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077E4")]
		[Address(RVA = "0xC13F", Offset = "0xC13F", VA = "0xC13F")]
		public RegisterGlobalParameters()
		{
		}
	}
}
