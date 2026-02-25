using System;
using Gameplay.Collections.Model;
using Gameplay.Inventory.View;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.Collections.View
{
	// Token: 0x020009D0 RID: 2512
	[Token(Token = "0x20009D0")]
	public class CollectionArtikulView : ArtikulView
	{
		// Token: 0x06003C23 RID: 15395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C23")]
		[Address(RVA = "0x8AF2", Offset = "0x8AF2", VA = "0x8AF2")]
		public void Init(CollectionsModel.ArtikulMaterial material, bool sameUser)
		{
		}

		// Token: 0x06003C24 RID: 15396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C24")]
		[Address(RVA = "0x8AF3", Offset = "0x8AF3", VA = "0x8AF3", Slot = "23")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06003C25 RID: 15397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C25")]
		[Address(RVA = "0x8AF4", Offset = "0x8AF4", VA = "0x8AF4")]
		public CollectionArtikulView()
		{
		}

		// Token: 0x0400213A RID: 8506
		[Token(Token = "0x400213A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected LoaderValueRowView _valueRow;

		// Token: 0x0400213B RID: 8507
		[Token(Token = "0x400213B")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private GameObject _marketIndicator;

		// Token: 0x0400213C RID: 8508
		[Token(Token = "0x400213C")]
		[FieldOffset(Offset = "0x50")]
		private CollectionsModel.ArtikulMaterial _artikulMaterial;
	}
}
