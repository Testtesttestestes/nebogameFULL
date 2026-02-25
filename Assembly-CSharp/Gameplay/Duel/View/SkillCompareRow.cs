using System;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Duel.View
{
	// Token: 0x0200085D RID: 2141
	[Token(Token = "0x200085D")]
	public class SkillCompareRow : MonoBehaviour
	{
		// Token: 0x170009EF RID: 2543
		// (set) Token: 0x0600324C RID: 12876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009EF")]
		public int Index
		{
			[Token(Token = "0x600324C")]
			[Address(RVA = "0x82A2", Offset = "0x82A2", VA = "0x82A2")]
			set
			{
			}
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600324D")]
		[Address(RVA = "0x1BBB", Offset = "0x1BBB", VA = "0x1BBB")]
		public void Init(UserSkillDic dic, long leftValue, long rightValue)
		{
		}

		// Token: 0x0600324E RID: 12878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600324E")]
		[Address(RVA = "0x82A3", Offset = "0x82A3", VA = "0x82A3")]
		private void AssignSprites(Sprite left, Sprite right)
		{
		}

		// Token: 0x0600324F RID: 12879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600324F")]
		[Address(RVA = "0x82A4", Offset = "0x82A4", VA = "0x82A4")]
		public SkillCompareRow()
		{
		}

		// Token: 0x04001B81 RID: 7041
		[Token(Token = "0x4001B81")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _bg;

		// Token: 0x04001B82 RID: 7042
		[Token(Token = "0x4001B82")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _leftStatus;

		// Token: 0x04001B83 RID: 7043
		[Token(Token = "0x4001B83")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _rightStatus;

		// Token: 0x04001B84 RID: 7044
		[Token(Token = "0x4001B84")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameImage _icon;

		// Token: 0x04001B85 RID: 7045
		[Token(Token = "0x4001B85")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _leftValue;

		// Token: 0x04001B86 RID: 7046
		[Token(Token = "0x4001B86")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _rightValue;

		// Token: 0x04001B87 RID: 7047
		[Token(Token = "0x4001B87")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _lessSprite;

		// Token: 0x04001B88 RID: 7048
		[Token(Token = "0x4001B88")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Sprite _greaterSprite;

		// Token: 0x04001B89 RID: 7049
		[Token(Token = "0x4001B89")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _equalsSprite;

		// Token: 0x04001B8A RID: 7050
		[Token(Token = "0x4001B8A")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Sprite _lighBg;

		// Token: 0x04001B8B RID: 7051
		[Token(Token = "0x4001B8B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _darkBg;
	}
}
