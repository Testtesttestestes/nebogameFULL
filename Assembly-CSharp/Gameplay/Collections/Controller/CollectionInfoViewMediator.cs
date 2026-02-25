using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Collections.Events;
using Gameplay.Collections.Model;
using Gameplay.Collections.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Collections.Controller
{
	// Token: 0x020009E6 RID: 2534
	[Token(Token = "0x20009E6")]
	public class CollectionInfoViewMediator : AbstractViewMediator<CollectionsModel, CollectionsEvents, CollectionsController, CollectionInfoWindow>
	{
		// Token: 0x06003C7D RID: 15485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C7D")]
		[Address(RVA = "0x8B44", Offset = "0x8B44", VA = "0x8B44")]
		public CollectionInfoViewMediator(CollectionsModel model, CollectionsEvents events, CollectionsController controller, uint collectionId, uint rank)
		{
		}

		// Token: 0x17000BEC RID: 3052
		// (set) Token: 0x06003C7E RID: 15486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BEC")]
		public override CollectionInfoWindow View
		{
			[Token(Token = "0x6003C7E")]
			[Address(RVA = "0x8B45", Offset = "0x8B45", VA = "0x8B45", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003C7F RID: 15487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C7F")]
		[Address(RVA = "0x8B46", Offset = "0x8B46", VA = "0x8B46")]
		private void Init()
		{
		}

		// Token: 0x06003C80 RID: 15488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C80")]
		[Address(RVA = "0x8B47", Offset = "0x8B47", VA = "0x8B47")]
		private void PrevButtonClicked()
		{
		}

		// Token: 0x06003C81 RID: 15489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C81")]
		[Address(RVA = "0x8B48", Offset = "0x8B48", VA = "0x8B48")]
		private void NextButtonClicked()
		{
		}

		// Token: 0x06003C82 RID: 15490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C82")]
		[Address(RVA = "0x8B49", Offset = "0x8B49", VA = "0x8B49")]
		private void ValidatePrevNextButtons()
		{
		}

		// Token: 0x06003C83 RID: 15491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C83")]
		[Address(RVA = "0x8B4A", Offset = "0x8B4A", VA = "0x8B4A")]
		private void CollectionUpgradeRequestedEventHandler()
		{
		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C84")]
		[Address(RVA = "0x8B4B", Offset = "0x8B4B", VA = "0x8B4B")]
		private void UpdateWindow()
		{
		}

		// Token: 0x17000BED RID: 3053
		// (set) Token: 0x06003C85 RID: 15493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BED")]
		public override CollectionsEvents Events
		{
			[Token(Token = "0x6003C85")]
			[Address(RVA = "0x8B4C", Offset = "0x8B4C", VA = "0x8B4C", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003C86 RID: 15494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C86")]
		[Address(RVA = "0x8B4D", Offset = "0x8B4D", VA = "0x8B4D")]
		private void UserCollectionImprovedEventHandler()
		{
		}

		// Token: 0x06003C87 RID: 15495 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003C87")]
		[Address(RVA = "0x8B4E", Offset = "0x8B4E", VA = "0x8B4E")]
		private List<CollectionsModel.CollectionMaterial> GetRequirements()
		{
			return null;
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C88")]
		[Address(RVA = "0x8B4F", Offset = "0x8B4F", VA = "0x8B4F")]
		private void UpgradeButtonClickEventHandler()
		{
		}

		// Token: 0x04002178 RID: 8568
		[Token(Token = "0x4002178")]
		[FieldOffset(Offset = "0x18")]
		private CollectionData _collectionData;

		// Token: 0x04002179 RID: 8569
		[Token(Token = "0x4002179")]
		[FieldOffset(Offset = "0x1C")]
		private readonly uint _collectionId;

		// Token: 0x0400217A RID: 8570
		[Token(Token = "0x400217A")]
		[FieldOffset(Offset = "0x20")]
		private uint _rank;
	}
}
