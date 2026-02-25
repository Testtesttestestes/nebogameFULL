using System;
using Gameplay.Accounts.Control;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace Gameplay.Accounts.View
{
	// Token: 0x02000DC7 RID: 3527
	[Token(Token = "0x2000DC7")]
	public class AccountsButtonView : MonoBehaviour
	{
		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x06005607 RID: 22023 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700117C")]
		public IndexButtonBasic Button
		{
			[Token(Token = "0x6005607")]
			[Address(RVA = "0xA3A7", Offset = "0xA3A7", VA = "0xA3A7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005608 RID: 22024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005608")]
		[Address(RVA = "0xA3A8", Offset = "0xA3A8", VA = "0xA3A8")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005609 RID: 22025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005609")]
		[Address(RVA = "0xA3A9", Offset = "0xA3A9", VA = "0xA3A9")]
		private void Awake()
		{
		}

		// Token: 0x0600560A RID: 22026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600560A")]
		[Address(RVA = "0xA3AA", Offset = "0xA3AA", VA = "0xA3AA")]
		public AccountsButtonView()
		{
		}

		// Token: 0x04002EA3 RID: 11939
		[Token(Token = "0x4002EA3")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private IndexButtonBasic _button;

		// Token: 0x04002EA4 RID: 11940
		[Token(Token = "0x4002EA4")]
		[FieldOffset(Offset = "0x14")]
		private AccountEntryPointViewMediator _mediator;
	}
}
