using System;
using Gameplay.GdEvents.Model.Milestone;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.GdEvents.View.Milestone.StageContent.Gifts
{
	// Token: 0x0200072D RID: 1837
	[Token(Token = "0x200072D")]
	public class GiftsStageContentGroupView : AbstractStageContentGroupView<SocialGiftDic>
	{
		// Token: 0x06002BE2 RID: 11234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE2")]
		[Address(RVA = "0x7C73", Offset = "0x7C73", VA = "0x7C73")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE3")]
		[Address(RVA = "0x7C74", Offset = "0x7C74", VA = "0x7C74", Slot = "4")]
		protected override void HandleDataChanged(StageContentData<SocialGiftDic> fromData, StageContentData<SocialGiftDic> toData)
		{
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE4")]
		[Address(RVA = "0x7C75", Offset = "0x7C75", VA = "0x7C75")]
		private void HandleClickEvent(SocialGiftDic data)
		{
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE5")]
		[Address(RVA = "0x7C76", Offset = "0x7C76", VA = "0x7C76")]
		public GiftsStageContentGroupView()
		{
		}

		// Token: 0x0400180A RID: 6154
		[Token(Token = "0x400180A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GiftView _giftPrefab;
	}
}
