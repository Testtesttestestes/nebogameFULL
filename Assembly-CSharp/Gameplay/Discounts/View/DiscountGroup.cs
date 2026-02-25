using System;
using Core.Data;
using Gameplay.Discounts.Model;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using Protocol.Consts;
using TMPro;
using UI;
using UnityEngine;
using Utils;

namespace Gameplay.Discounts.View
{
	// Token: 0x02000891 RID: 2193
	[Token(Token = "0x2000891")]
	public class DiscountGroup : MonoBehaviourWithStates<DiscountGroup.State>
	{
		// Token: 0x060033BC RID: 13244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033BC")]
		[Address(RVA = "0x83F6", Offset = "0x83F6", VA = "0x83F6")]
		public void Init(double coeff, DiscountTargets discountType)
		{
		}

		// Token: 0x060033BD RID: 13245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033BD")]
		[Address(RVA = "0x83F7", Offset = "0x83F7", VA = "0x83F7")]
		public void Init(double coeff, DiscountTargets discountType, string key)
		{
		}

		// Token: 0x060033BE RID: 13246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033BE")]
		[Address(RVA = "0x83F8", Offset = "0x83F8", VA = "0x83F8")]
		public void Init(DiscountData discountData)
		{
		}

		// Token: 0x060033BF RID: 13247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033BF")]
		[Address(RVA = "0x83F9", Offset = "0x83F9", VA = "0x83F9")]
		public void Init(double coeff, string key)
		{
		}

		// Token: 0x060033C0 RID: 13248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C0")]
		[Address(RVA = "0x1E28", Offset = "0x1E28", VA = "0x1E28")]
		public void Init(IDiscountArgs value)
		{
		}

		// Token: 0x060033C1 RID: 13249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C1")]
		[Address(RVA = "0x83FA", Offset = "0x83FA", VA = "0x83FA")]
		private void HandleDiscountType(DiscountTargets discountType)
		{
		}

		// Token: 0x060033C2 RID: 13250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C2")]
		[Address(RVA = "0x83FB", Offset = "0x83FB", VA = "0x83FB")]
		public void DisplayDiscountAmount(double value, string key)
		{
		}

		// Token: 0x060033C3 RID: 13251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C3")]
		[Address(RVA = "0x83FC", Offset = "0x83FC", VA = "0x83FC")]
		public void DisplayBackTime(BackTime value)
		{
		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C4")]
		[Address(RVA = "0x83FD", Offset = "0x83FD", VA = "0x83FD")]
		private void OnEnable()
		{
		}

		// Token: 0x060033C5 RID: 13253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C5")]
		[Address(RVA = "0x83FE", Offset = "0x83FE", VA = "0x83FE")]
		private void OnDisable()
		{
		}

		// Token: 0x060033C6 RID: 13254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C6")]
		[Address(RVA = "0x83FF", Offset = "0x83FF", VA = "0x83FF")]
		public DiscountGroup()
		{
		}

		// Token: 0x04001C28 RID: 7208
		[Token(Token = "0x4001C28")]
		private const string DEFAULT_DISCOUNT_KEY = "DISCOUNTS/BUY_DISCOUNT";

		// Token: 0x04001C29 RID: 7209
		[Token(Token = "0x4001C29")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _discountText;

		// Token: 0x04001C2A RID: 7210
		[Token(Token = "0x4001C2A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BacktimeRowViewDynamic _backtimeRow;

		// Token: 0x02000892 RID: 2194
		[Token(Token = "0x2000892")]
		public enum State
		{
			// Token: 0x04001C2C RID: 7212
			[Token(Token = "0x4001C2C")]
			UNKNOWN_STATE,
			// Token: 0x04001C2D RID: 7213
			[Token(Token = "0x4001C2D")]
			ENABLED,
			// Token: 0x04001C2E RID: 7214
			[Token(Token = "0x4001C2E")]
			DISABLED
		}
	}
}
