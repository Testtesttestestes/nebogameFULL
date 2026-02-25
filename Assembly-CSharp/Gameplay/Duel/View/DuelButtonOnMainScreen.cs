using System;
using Gameplay.Duel.Controller;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Duel.View
{
	// Token: 0x02000856 RID: 2134
	[Token(Token = "0x2000856")]
	public class DuelButtonOnMainScreen : MonoBehaviour
	{
		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06003231 RID: 12849 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009E5")]
		public Button DuelButton
		{
			[Token(Token = "0x6003231")]
			[Address(RVA = "0x8287", Offset = "0x8287", VA = "0x8287")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003232 RID: 12850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003232")]
		[Address(RVA = "0x8288", Offset = "0x8288", VA = "0x8288")]
		private void Awake()
		{
		}

		// Token: 0x06003233 RID: 12851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003233")]
		[Address(RVA = "0x8289", Offset = "0x8289", VA = "0x8289")]
		private void OnEnable()
		{
		}

		// Token: 0x06003234 RID: 12852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003234")]
		[Address(RVA = "0x828A", Offset = "0x828A", VA = "0x828A")]
		private void OnDisable()
		{
		}

		// Token: 0x06003235 RID: 12853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003235")]
		[Address(RVA = "0x828B", Offset = "0x828B", VA = "0x828B")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003236 RID: 12854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003236")]
		[Address(RVA = "0x828C", Offset = "0x828C", VA = "0x828C")]
		public DuelButtonOnMainScreen()
		{
		}

		// Token: 0x04001B6C RID: 7020
		[Token(Token = "0x4001B6C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _duelButton;

		// Token: 0x04001B6D RID: 7021
		[Token(Token = "0x4001B6D")]
		[FieldOffset(Offset = "0x14")]
		private DuelEnterPointViewMediator _mediator;
	}
}
