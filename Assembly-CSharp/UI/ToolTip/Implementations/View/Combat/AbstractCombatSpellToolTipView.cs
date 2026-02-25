using System;
using Gameplay.Combat.Model;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using TMPro;
using UI.Price;
using UnityEngine;

namespace UI.ToolTip.Implementations.View.Combat
{
	// Token: 0x02000157 RID: 343
	[Token(Token = "0x2000157")]
	public abstract class AbstractCombatSpellToolTipView<T> : BaseToolTip<T> where T : CombatSpellData
	{
		// Token: 0x060009D8 RID: 2520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D8")]
		public override void Dispose()
		{
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D9")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009DA")]
		protected virtual void HandleTitle()
		{
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009DB")]
		protected virtual void HandleDescription()
		{
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009DC")]
		protected virtual void HandlePriceOfUse()
		{
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009DD")]
		protected virtual void HandleModifiers()
		{
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009DE")]
		protected AbstractCombatSpellToolTipView()
		{
		}

		// Token: 0x040003FE RID: 1022
		[Token(Token = "0x40003FE")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected TextMeshProUGUI _title;

		// Token: 0x040003FF RID: 1023
		[Token(Token = "0x40003FF")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected TextMeshProUGUI _subTitle;

		// Token: 0x04000400 RID: 1024
		[Token(Token = "0x4000400")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected TextMeshProUGUI _descriptionField;

		// Token: 0x04000401 RID: 1025
		[Token(Token = "0x4000401")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected Transform _modifiersRoot;

		// Token: 0x04000402 RID: 1026
		[Token(Token = "0x4000402")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected Transform _modifiersContainer;

		// Token: 0x04000403 RID: 1027
		[Token(Token = "0x4000403")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected Transform _priceOfUsageContainer;

		// Token: 0x04000404 RID: 1028
		[Token(Token = "0x4000404")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected PriceItemRenderer _manaPriceOfUsage;

		// Token: 0x04000405 RID: 1029
		[Token(Token = "0x4000405")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected Price _priceOfUsage;

		// Token: 0x04000406 RID: 1030
		[Token(Token = "0x4000406")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected ModifierRowView _modifierRowPrefab;
	}
}
