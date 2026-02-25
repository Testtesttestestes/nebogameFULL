using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Duel.View
{
	// Token: 0x0200085F RID: 2143
	[Token(Token = "0x200085F")]
	public class SkillsComparerPowerBars : MonoBehaviour
	{
		// Token: 0x06003252 RID: 12882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003252")]
		[Address(RVA = "0x82A7", Offset = "0x82A7", VA = "0x82A7")]
		public void Init(float leftValue, float rightValue)
		{
		}

		// Token: 0x06003253 RID: 12883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003253")]
		[Address(RVA = "0x82A8", Offset = "0x82A8", VA = "0x82A8")]
		private void SetBarValue(Image bar, float percent)
		{
		}

		// Token: 0x06003254 RID: 12884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003254")]
		[Address(RVA = "0x82A9", Offset = "0x82A9", VA = "0x82A9")]
		private void AssignSprites(Sprite left, Sprite right)
		{
		}

		// Token: 0x06003255 RID: 12885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003255")]
		[Address(RVA = "0x82AA", Offset = "0x82AA", VA = "0x82AA")]
		private void AssignBarSprites(Sprite left, Sprite right)
		{
		}

		// Token: 0x06003256 RID: 12886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003256")]
		[Address(RVA = "0x82AB", Offset = "0x82AB", VA = "0x82AB")]
		public SkillsComparerPowerBars()
		{
		}

		// Token: 0x04001B8F RID: 7055
		[Token(Token = "0x4001B8F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _leftBar;

		// Token: 0x04001B90 RID: 7056
		[Token(Token = "0x4001B90")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _rightBar;

		// Token: 0x04001B91 RID: 7057
		[Token(Token = "0x4001B91")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _leftIcon;

		// Token: 0x04001B92 RID: 7058
		[Token(Token = "0x4001B92")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Image _rightIcon;

		// Token: 0x04001B93 RID: 7059
		[Token(Token = "0x4001B93")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _barGreenSprite;

		// Token: 0x04001B94 RID: 7060
		[Token(Token = "0x4001B94")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Sprite _barRedSprite;

		// Token: 0x04001B95 RID: 7061
		[Token(Token = "0x4001B95")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _greaterIconSprite;

		// Token: 0x04001B96 RID: 7062
		[Token(Token = "0x4001B96")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Sprite _lessIconSprite;

		// Token: 0x04001B97 RID: 7063
		[Token(Token = "0x4001B97")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _equalsIconSprite;

		// Token: 0x04001B98 RID: 7064
		[Token(Token = "0x4001B98")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int _minBarSize;

		// Token: 0x04001B99 RID: 7065
		[Token(Token = "0x4001B99")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int _maxBarSize;
	}
}
