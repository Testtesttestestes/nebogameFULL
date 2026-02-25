using System;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.VortexRating.View
{
	// Token: 0x02000383 RID: 899
	[Token(Token = "0x2000383")]
	public class RankView : MonoBehaviour
	{
		// Token: 0x060014F5 RID: 5365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F5")]
		[Address(RVA = "0x66B7", Offset = "0x66B7", VA = "0x66B7")]
		private void Awake()
		{
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F6")]
		[Address(RVA = "0x66B8", Offset = "0x66B8", VA = "0x66B8")]
		public void SetPlace(uint place)
		{
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F7")]
		[Address(RVA = "0x66B9", Offset = "0x66B9", VA = "0x66B9")]
		public RankView()
		{
		}

		// Token: 0x04000B0E RID: 2830
		[Token(Token = "0x4000B0E")]
		private const uint MAX_RANK = 6U;

		// Token: 0x04000B0F RID: 2831
		[Token(Token = "0x4000B0F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private uint _place;

		// Token: 0x04000B10 RID: 2832
		[Token(Token = "0x4000B10")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameRawImage _rankImage;

		// Token: 0x04000B11 RID: 2833
		[Token(Token = "0x4000B11")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _label;
	}
}
