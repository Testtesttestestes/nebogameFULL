using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Elements.RatingElements
{
	// Token: 0x02000214 RID: 532
	[Token(Token = "0x2000214")]
	public class RatingsDescription : MonoBehaviour
	{
		// Token: 0x170001BE RID: 446
		// (set) Token: 0x06000D53 RID: 3411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BE")]
		public string Title
		{
			[Token(Token = "0x6000D53")]
			[Address(RVA = "0x6036", Offset = "0x6036", VA = "0x6036")]
			set
			{
			}
		}

		// Token: 0x170001BF RID: 447
		// (set) Token: 0x06000D54 RID: 3412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BF")]
		public string Description
		{
			[Token(Token = "0x6000D54")]
			[Address(RVA = "0x6037", Offset = "0x6037", VA = "0x6037")]
			set
			{
			}
		}

		// Token: 0x170001C0 RID: 448
		// (set) Token: 0x06000D55 RID: 3413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C0")]
		public string Description2
		{
			[Token(Token = "0x6000D55")]
			[Address(RVA = "0x6038", Offset = "0x6038", VA = "0x6038")]
			set
			{
			}
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D56")]
		[Address(RVA = "0x6039", Offset = "0x6039", VA = "0x6039")]
		public RatingsDescription()
		{
		}

		// Token: 0x0400069A RID: 1690
		[Token(Token = "0x400069A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400069B RID: 1691
		[Token(Token = "0x400069B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x0400069C RID: 1692
		[Token(Token = "0x400069C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _description2;
	}
}
