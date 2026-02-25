using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View.Ratings
{
	// Token: 0x0200030B RID: 779
	[Token(Token = "0x200030B")]
	[Serializable]
	public class MultipleScoresViewElement
	{
		// Token: 0x06001227 RID: 4647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001227")]
		[Address(RVA = "0x6422", Offset = "0x6422", VA = "0x6422")]
		public void Init(int count)
		{
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001228")]
		[Address(RVA = "0x6423", Offset = "0x6423", VA = "0x6423")]
		public void UpdateScores(IList<int> indexes, IList<long> scores)
		{
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001229")]
		[Address(RVA = "0x6424", Offset = "0x6424", VA = "0x6424")]
		public MultipleScoresViewElement()
		{
		}

		// Token: 0x04000992 RID: 2450
		[Token(Token = "0x4000992")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private TextMeshProUGUI _scorePrefab;

		// Token: 0x04000993 RID: 2451
		[Token(Token = "0x4000993")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private RectTransform _scoreParent;

		// Token: 0x04000994 RID: 2452
		[Token(Token = "0x4000994")]
		[FieldOffset(Offset = "0x10")]
		private TextMeshProUGUI[] _scores;
	}
}
