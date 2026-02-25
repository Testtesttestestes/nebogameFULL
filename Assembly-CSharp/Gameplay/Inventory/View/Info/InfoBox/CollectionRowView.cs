using System;
using System.Collections.Generic;
using Gameplay.Collections.View;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Inventory.View.Info.InfoBox
{
	// Token: 0x02000677 RID: 1655
	[Token(Token = "0x2000677")]
	public class CollectionRowView : TitleRowView
	{
		// Token: 0x06002823 RID: 10275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002823")]
		[Address(RVA = "0x7948", Offset = "0x7948", VA = "0x7948", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002824")]
		[Address(RVA = "0x7949", Offset = "0x7949", VA = "0x7949")]
		public CollectionRowView()
		{
		}

		// Token: 0x0400161D RID: 5661
		[Token(Token = "0x400161D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private CollectionView _collectionViewPrefab;

		// Token: 0x0400161E RID: 5662
		[Token(Token = "0x400161E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x0400161F RID: 5663
		[Token(Token = "0x400161F")]
		[FieldOffset(Offset = "0x2C")]
		private List<GameObject> _instances;
	}
}
