using System;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.Combat.View.Players
{
	// Token: 0x0200094E RID: 2382
	[Token(Token = "0x200094E")]
	public class CombatUserBalanceItemRenderer : MonoBehaviour, IToolTipDataProvider
	{
		// Token: 0x06003860 RID: 14432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003860")]
		[Address(RVA = "0x8817", Offset = "0x8817", VA = "0x8817")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003861 RID: 14433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003861")]
		[Address(RVA = "0x8818", Offset = "0x8818", VA = "0x8818")]
		public void SetValue(double value)
		{
		}

		// Token: 0x06003862 RID: 14434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003862")]
		[Address(RVA = "0x8819", Offset = "0x8819", VA = "0x8819")]
		public void SetResourcesDic(ResourcesDic dic)
		{
		}

		// Token: 0x06003863 RID: 14435 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003863")]
		[Address(RVA = "0x881A", Offset = "0x881A", VA = "0x881A", Slot = "4")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x06003864 RID: 14436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003864")]
		[Address(RVA = "0x881B", Offset = "0x881B", VA = "0x881B")]
		public CombatUserBalanceItemRenderer()
		{
		}

		// Token: 0x04001F34 RID: 7988
		[Token(Token = "0x4001F34")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x04001F35 RID: 7989
		[Token(Token = "0x4001F35")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _valueField;

		// Token: 0x04001F36 RID: 7990
		[Token(Token = "0x4001F36")]
		[FieldOffset(Offset = "0x18")]
		private double _value;

		// Token: 0x04001F37 RID: 7991
		[Token(Token = "0x4001F37")]
		[FieldOffset(Offset = "0x20")]
		private ResourcesDic _resourcesDic;
	}
}
