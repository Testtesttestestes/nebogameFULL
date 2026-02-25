using System;
using Gameplay.Bank.Controller;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C32 RID: 3122
	[Token(Token = "0x2000C32")]
	public class AdOptionInBankValidatorView : MonoBehaviour
	{
		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x06004C24 RID: 19492 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F58")]
		public GameObject AdMarker
		{
			[Token(Token = "0x6004C24")]
			[Address(RVA = "0x9A68", Offset = "0x9A68", VA = "0x9A68")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004C25 RID: 19493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C25")]
		[Address(RVA = "0x9A69", Offset = "0x9A69", VA = "0x9A69")]
		private void Start()
		{
		}

		// Token: 0x06004C26 RID: 19494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C26")]
		[Address(RVA = "0x9A6A", Offset = "0x9A6A", VA = "0x9A6A")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004C27 RID: 19495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C27")]
		[Address(RVA = "0x9A6B", Offset = "0x9A6B", VA = "0x9A6B")]
		public AdOptionInBankValidatorView()
		{
		}

		// Token: 0x04002975 RID: 10613
		[Token(Token = "0x4002975")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameObject _adMarker;

		// Token: 0x04002976 RID: 10614
		[Token(Token = "0x4002976")]
		[FieldOffset(Offset = "0x14")]
		private AdOptionInBankValidatorViewMediator _mediator;
	}
}
