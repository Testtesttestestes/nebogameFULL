using System;
using System.Runtime.CompilerServices;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using UI.Price;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B77 RID: 2935
	[Token(Token = "0x2000B77")]
	public class BossAttackOptionView : MonoBehaviour
	{
		// Token: 0x140001C1 RID: 449
		// (add) Token: 0x06004745 RID: 18245 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004746 RID: 18246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001C1")]
		public event Action<BossInfo.BossAttackOption, BossInfo.BossAttackOption.BossAttackOptionVariant> AttackButtonClickEvent
		{
			[Token(Token = "0x6004745")]
			[Address(RVA = "0x95DB", Offset = "0x95DB", VA = "0x95DB")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004746")]
			[Address(RVA = "0x95DC", Offset = "0x95DC", VA = "0x95DC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004747 RID: 18247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004747")]
		[Address(RVA = "0x95DD", Offset = "0x95DD", VA = "0x95DD")]
		private void Awake()
		{
		}

		// Token: 0x06004748 RID: 18248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004748")]
		[Address(RVA = "0x95DE", Offset = "0x95DE", VA = "0x95DE")]
		private void AttackButtonClickHandler()
		{
		}

		// Token: 0x06004749 RID: 18249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004749")]
		[Address(RVA = "0x95DF", Offset = "0x95DF", VA = "0x95DF")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600474A RID: 18250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600474A")]
		[Address(RVA = "0x95E0", Offset = "0x95E0", VA = "0x95E0")]
		private void DecrementButtonClickHandler()
		{
		}

		// Token: 0x0600474B RID: 18251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600474B")]
		[Address(RVA = "0x95E1", Offset = "0x95E1", VA = "0x95E1")]
		private void IncrementButtonClickHandler()
		{
		}

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x0600474C RID: 18252 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600474D RID: 18253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E37")]
		public BossInfo.BossAttackOption Data
		{
			[Token(Token = "0x600474C")]
			[Address(RVA = "0x95E2", Offset = "0x95E2", VA = "0x95E2")]
			get
			{
				return null;
			}
			[Token(Token = "0x600474D")]
			[Address(RVA = "0x1BA4", Offset = "0x1BA4", VA = "0x1BA4")]
			set
			{
			}
		}

		// Token: 0x0600474E RID: 18254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600474E")]
		[Address(RVA = "0x95E3", Offset = "0x95E3", VA = "0x95E3")]
		private void RenderVariant()
		{
		}

		// Token: 0x0600474F RID: 18255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600474F")]
		[Address(RVA = "0x95E4", Offset = "0x95E4", VA = "0x95E4")]
		private void ShowValuePicker()
		{
		}

		// Token: 0x06004750 RID: 18256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004750")]
		[Address(RVA = "0x95E5", Offset = "0x95E5", VA = "0x95E5")]
		private void PickerWindowOnSelectedEvent(BossInfo.BossAttackOption.BossAttackOptionVariant variant)
		{
		}

		// Token: 0x06004751 RID: 18257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004751")]
		[Address(RVA = "0x95E6", Offset = "0x95E6", VA = "0x95E6")]
		public void SelectVariant(BossInfo.BossAttackOption.BossAttackOptionVariant variant)
		{
		}

		// Token: 0x06004752 RID: 18258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004752")]
		[Address(RVA = "0x1B40", Offset = "0x1B40", VA = "0x1B40")]
		public void SelectVariant(int variantId)
		{
		}

		// Token: 0x06004753 RID: 18259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004753")]
		[Address(RVA = "0x95E7", Offset = "0x95E7", VA = "0x95E7")]
		private void PickerWindowOnClose()
		{
		}

		// Token: 0x06004754 RID: 18260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004754")]
		[Address(RVA = "0x95E8", Offset = "0x95E8", VA = "0x95E8")]
		public BossAttackOptionView()
		{
		}

		// Token: 0x04002717 RID: 10007
		[Token(Token = "0x4002717")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _attackButton;

		// Token: 0x04002718 RID: 10008
		[Token(Token = "0x4002718")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Price _price;

		// Token: 0x04002719 RID: 10009
		[Token(Token = "0x4002719")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _incrementButton;

		// Token: 0x0400271A RID: 10010
		[Token(Token = "0x400271A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _decrementButton;

		// Token: 0x0400271B RID: 10011
		[Token(Token = "0x400271B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BossAttackSkillBonusView _bossAttackSkillBonusView;

		// Token: 0x0400271C RID: 10012
		[Token(Token = "0x400271C")]
		[FieldOffset(Offset = "0x24")]
		private int _changeButtonClickNum;

		// Token: 0x0400271D RID: 10013
		[Token(Token = "0x400271D")]
		private const int CLICKS_TO_OPEN_VALUE_PICKER = 3;

		// Token: 0x0400271E RID: 10014
		[Token(Token = "0x400271E")]
		[FieldOffset(Offset = "0x28")]
		private BossAttackOptionPickerDialogWindow _pickerWindow;

		// Token: 0x04002720 RID: 10016
		[Token(Token = "0x4002720")]
		[FieldOffset(Offset = "0x30")]
		private int _currentVariantIndex;

		// Token: 0x04002721 RID: 10017
		[Token(Token = "0x4002721")]
		[FieldOffset(Offset = "0x34")]
		private BossInfo.BossAttackOption _data;
	}
}
