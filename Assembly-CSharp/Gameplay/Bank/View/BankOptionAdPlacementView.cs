using System;
using Core.Gameplay.Managers.Ad.Placements.BankOptions;
using Gameplay.Bank.Controller;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C37 RID: 3127
	[Token(Token = "0x2000C37")]
	public class BankOptionAdPlacementView : MonoBehaviour
	{
		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x06004C3C RID: 19516 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F5C")]
		public Button WatchButton
		{
			[Token(Token = "0x6004C3C")]
			[Address(RVA = "0x9A7F", Offset = "0x9A7F", VA = "0x9A7F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x06004C3D RID: 19517 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F5D")]
		public GameObject LoadingGroup
		{
			[Token(Token = "0x6004C3D")]
			[Address(RVA = "0x9A80", Offset = "0x9A80", VA = "0x9A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004C3E RID: 19518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C3E")]
		[Address(RVA = "0x9A81", Offset = "0x9A81", VA = "0x9A81")]
		public void Init(BankOptionsAdPlacementManager manager, BankOptionData bankOptionData)
		{
		}

		// Token: 0x06004C3F RID: 19519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C3F")]
		[Address(RVA = "0x9A82", Offset = "0x9A82", VA = "0x9A82")]
		public void Release()
		{
		}

		// Token: 0x06004C40 RID: 19520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C40")]
		[Address(RVA = "0x9A83", Offset = "0x9A83", VA = "0x9A83")]
		private void SetupMVC(BankOptionsAdPlacementManager manager, BankOptionData bankOptionData)
		{
		}

		// Token: 0x06004C41 RID: 19521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C41")]
		[Address(RVA = "0x9A84", Offset = "0x9A84", VA = "0x9A84")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004C42 RID: 19522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C42")]
		[Address(RVA = "0x9A85", Offset = "0x9A85", VA = "0x9A85")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06004C43 RID: 19523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C43")]
		[Address(RVA = "0x9A86", Offset = "0x9A86", VA = "0x9A86")]
		public BankOptionAdPlacementView()
		{
		}

		// Token: 0x0400298A RID: 10634
		[Token(Token = "0x400298A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _watchButton;

		// Token: 0x0400298B RID: 10635
		[Token(Token = "0x400298B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _loadingGroup;

		// Token: 0x0400298C RID: 10636
		[Token(Token = "0x400298C")]
		[FieldOffset(Offset = "0x18")]
		private BankOptionAdPlacementViewMediator _mediator;

		// Token: 0x0400298D RID: 10637
		[Token(Token = "0x400298D")]
		[FieldOffset(Offset = "0x1C")]
		private bool _mvcSetup;
	}
}
