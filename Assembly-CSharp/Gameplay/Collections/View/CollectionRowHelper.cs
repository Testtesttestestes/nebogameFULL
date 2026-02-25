using System;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Collections.Model;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Collections.View
{
	// Token: 0x020009C7 RID: 2503
	[Token(Token = "0x20009C7")]
	[Serializable]
	public class CollectionRowHelper
	{
		// Token: 0x06003BFC RID: 15356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BFC")]
		[Address(RVA = "0x8ACD", Offset = "0x8ACD", VA = "0x8ACD")]
		public void RenderMedalCollectionRow(MedalDicWrapper medal, ICollectionsMaterialsStorage storage)
		{
		}

		// Token: 0x06003BFD RID: 15357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BFD")]
		[Address(RVA = "0x8ACE", Offset = "0x8ACE", VA = "0x8ACE")]
		public void RenderAprCollectionRow(MedalDicWrapper medal, ICollectionsMaterialsStorage storage)
		{
		}

		// Token: 0x06003BFE RID: 15358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BFE")]
		[Address(RVA = "0x8ACF", Offset = "0x8ACF", VA = "0x8ACF")]
		private void RenderRow(MedalDicWrapper medal, ICollectionsMaterialsStorage storage, string text)
		{
		}

		// Token: 0x06003BFF RID: 15359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BFF")]
		[Address(RVA = "0x8AD0", Offset = "0x8AD0", VA = "0x8AD0")]
		public CollectionRowHelper()
		{
		}

		// Token: 0x0400211C RID: 8476
		[Token(Token = "0x400211C")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private CollectionRowView _row;
	}
}
