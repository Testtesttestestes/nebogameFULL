using System;
using Gameplay.EndlessPaymentOptionsList.Control;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace Gameplay.EndlessPaymentOptionsList.View
{
	// Token: 0x0200083A RID: 2106
	[Token(Token = "0x200083A")]
	[RequireComponent(typeof(IndexButtonBasic))]
	public class EndlessPaymentOptionsListEntryPointView : MonoBehaviour
	{
		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x0600318A RID: 12682 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009C4")]
		public IndexButtonBasic Button
		{
			[Token(Token = "0x600318A")]
			[Address(RVA = "0x81E2", Offset = "0x81E2", VA = "0x81E2")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x0600318B RID: 12683 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009C5")]
		public BacktimeViewUGUI BackTimeView
		{
			[Token(Token = "0x600318B")]
			[Address(RVA = "0x81E3", Offset = "0x81E3", VA = "0x81E3")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x0600318C RID: 12684 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009C6")]
		public Transform Widget
		{
			[Token(Token = "0x600318C")]
			[Address(RVA = "0x81E4", Offset = "0x81E4", VA = "0x81E4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600318D")]
		[Address(RVA = "0x81E5", Offset = "0x81E5", VA = "0x81E5")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600318E RID: 12686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600318E")]
		[Address(RVA = "0x81E6", Offset = "0x81E6", VA = "0x81E6")]
		private void Awake()
		{
		}

		// Token: 0x0600318F RID: 12687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600318F")]
		[Address(RVA = "0x81E7", Offset = "0x81E7", VA = "0x81E7")]
		private void SetupMediator()
		{
		}

		// Token: 0x06003190 RID: 12688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003190")]
		[Address(RVA = "0x81E8", Offset = "0x81E8", VA = "0x81E8")]
		public EndlessPaymentOptionsListEntryPointView()
		{
		}

		// Token: 0x04001B1E RID: 6942
		[Token(Token = "0x4001B1E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private BacktimeViewUGUI _backTimeView;

		// Token: 0x04001B1F RID: 6943
		[Token(Token = "0x4001B1F")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _widget;

		// Token: 0x04001B20 RID: 6944
		[Token(Token = "0x4001B20")]
		[FieldOffset(Offset = "0x18")]
		private EndlessPaymentOptionsListEntryPointViewMediator _mediator;
	}
}
