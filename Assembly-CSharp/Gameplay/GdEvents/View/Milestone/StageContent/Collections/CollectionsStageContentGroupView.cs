using System;
using Core.Data;
using Gameplay.Collections.View;
using Gameplay.GdEvents.Model.Milestone;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.GdEvents.View.Milestone.StageContent.Collections
{
	// Token: 0x0200072E RID: 1838
	[Token(Token = "0x200072E")]
	public class CollectionsStageContentGroupView : AbstractStageContentGroupView<CollectionData>
	{
		// Token: 0x06002BE6 RID: 11238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE6")]
		[Address(RVA = "0x7C77", Offset = "0x7C77", VA = "0x7C77")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE7")]
		[Address(RVA = "0x7C78", Offset = "0x7C78", VA = "0x7C78", Slot = "4")]
		protected override void HandleDataChanged(StageContentData<CollectionData> fromData, StageContentData<CollectionData> toData)
		{
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE8")]
		[Address(RVA = "0x7C79", Offset = "0x7C79", VA = "0x7C79")]
		private void HandleItemClickEvent(PointerEventData pointerData)
		{
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE9")]
		[Address(RVA = "0x7C7A", Offset = "0x7C7A", VA = "0x7C7A")]
		public CollectionsStageContentGroupView()
		{
		}

		// Token: 0x0400180B RID: 6155
		[Token(Token = "0x400180B")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private CollectionView _collectionPrefb;
	}
}
