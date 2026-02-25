using System;
using Core.Data.Skills;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Duel.View
{
	// Token: 0x0200085E RID: 2142
	[Token(Token = "0x200085E")]
	public class SkillsComparer : MonoBehaviour
	{
		// Token: 0x06003250 RID: 12880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003250")]
		[Address(RVA = "0x82A5", Offset = "0x82A5", VA = "0x82A5")]
		public void Init(SkillCollection leftSkills, SkillCollection rightSkills, Dictionaries dict)
		{
		}

		// Token: 0x06003251 RID: 12881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003251")]
		[Address(RVA = "0x82A6", Offset = "0x82A6", VA = "0x82A6")]
		public SkillsComparer()
		{
		}

		// Token: 0x04001B8C RID: 7052
		[Token(Token = "0x4001B8C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SkillCompareRow _rowPrefab;

		// Token: 0x04001B8D RID: 7053
		[Token(Token = "0x4001B8D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x04001B8E RID: 7054
		[Token(Token = "0x4001B8E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SkillsComparerPowerBars _powerBars;
	}
}
