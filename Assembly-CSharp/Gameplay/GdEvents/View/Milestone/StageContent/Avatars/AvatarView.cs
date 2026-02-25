using System;
using Gameplay.Aprs.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.GdEvents.View.Milestone.StageContent.Avatars
{
	// Token: 0x0200072F RID: 1839
	[Token(Token = "0x200072F")]
	public class AvatarView : MonoBehaviour
	{
		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06002BEA RID: 11242 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700085B")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6002BEA")]
			[Address(RVA = "0x7C7B", Offset = "0x7C7B", VA = "0x7C7B")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06002BEB RID: 11243 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700085C")]
		public AprView Apr
		{
			[Token(Token = "0x6002BEB")]
			[Address(RVA = "0x7C7C", Offset = "0x7C7C", VA = "0x7C7C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002BEC RID: 11244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BEC")]
		[Address(RVA = "0x7C7D", Offset = "0x7C7D", VA = "0x7C7D")]
		public AvatarView()
		{
		}

		// Token: 0x0400180C RID: 6156
		[Token(Token = "0x400180C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400180D RID: 6157
		[Token(Token = "0x400180D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private AprView _apr;
	}
}
