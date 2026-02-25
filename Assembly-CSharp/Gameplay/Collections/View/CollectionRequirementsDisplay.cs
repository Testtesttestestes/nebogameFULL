using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Collections.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Collections.View
{
	// Token: 0x020009C5 RID: 2501
	[Token(Token = "0x20009C5")]
	public class CollectionRequirementsDisplay : MonoBehaviour
	{
		// Token: 0x06003BF0 RID: 15344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF0")]
		[Address(RVA = "0x8AC4", Offset = "0x8AC4", VA = "0x8AC4")]
		public void SetRequirements(IList<CollectionsModel.CollectionMaterial> materials, UserData user, bool sameUser)
		{
		}

		// Token: 0x06003BF1 RID: 15345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF1")]
		[Address(RVA = "0x8AC5", Offset = "0x8AC5", VA = "0x8AC5")]
		private void UpdateRequirements(IList<CollectionsModel.CollectionMaterial> materials, UserData user, bool sameUser)
		{
		}

		// Token: 0x06003BF2 RID: 15346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF2")]
		[Address(RVA = "0x8AC6", Offset = "0x8AC6", VA = "0x8AC6")]
		private void CreateNewRequirements(IList<CollectionsModel.CollectionMaterial> materials, UserData user, bool sameUser)
		{
		}

		// Token: 0x06003BF3 RID: 15347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF3")]
		[Address(RVA = "0x1C45", Offset = "0x1C45", VA = "0x1C45")]
		private void HandleArtikul(CollectionsModel.CollectionMaterial material, bool sameUser)
		{
		}

		// Token: 0x06003BF4 RID: 15348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF4")]
		[Address(RVA = "0x8AC7", Offset = "0x8AC7", VA = "0x8AC7")]
		private void UpdateInstance(bool sameUser, CollectionsModel.ArtikulMaterial artikulMaterial, CollectionArtikulView instance)
		{
		}

		// Token: 0x06003BF5 RID: 15349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF5")]
		[Address(RVA = "0x1C44", Offset = "0x1C44", VA = "0x1C44")]
		private void HandleMedal(CollectionsModel.CollectionMaterial material, UserData user, bool sameUser)
		{
		}

		// Token: 0x06003BF6 RID: 15350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF6")]
		[Address(RVA = "0x8AC8", Offset = "0x8AC8", VA = "0x8AC8")]
		private void UpdateInstance(UserData user, bool sameUser, CollectionsModel.MedalMaterial medalMaterial, CollectionMedalView instance)
		{
		}

		// Token: 0x06003BF7 RID: 15351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF7")]
		[Address(RVA = "0x1C43", Offset = "0x1C43", VA = "0x1C43")]
		private void HandleApr(CollectionsModel.CollectionMaterial material, UserData user, bool sameUser)
		{
		}

		// Token: 0x06003BF8 RID: 15352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF8")]
		[Address(RVA = "0x8AC9", Offset = "0x8AC9", VA = "0x8AC9")]
		private void UpdateInstance(CollectionsModel.CollectionMaterial material, UserData user, bool sameUser, CollectionAprView instance)
		{
		}

		// Token: 0x06003BF9 RID: 15353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF9")]
		[Address(RVA = "0x8ACA", Offset = "0x8ACA", VA = "0x8ACA")]
		public CollectionRequirementsDisplay()
		{
		}

		// Token: 0x04002114 RID: 8468
		[Token(Token = "0x4002114")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private CollectionArtikulView _collectionArtikulViewPrefab;

		// Token: 0x04002115 RID: 8469
		[Token(Token = "0x4002115")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private CollectionMedalView _collectionMedalViewPrefab;

		// Token: 0x04002116 RID: 8470
		[Token(Token = "0x4002116")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CollectionAprView _collectionAprViewPrefab;

		// Token: 0x04002117 RID: 8471
		[Token(Token = "0x4002117")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RectTransform _contentParent;

		// Token: 0x04002118 RID: 8472
		[Token(Token = "0x4002118")]
		[FieldOffset(Offset = "0x20")]
		private bool _hasSale;

		// Token: 0x04002119 RID: 8473
		[Token(Token = "0x4002119")]
		[FieldOffset(Offset = "0x24")]
		private IList<CollectionsModel.CollectionMaterial> _materials;

		// Token: 0x0400211A RID: 8474
		[Token(Token = "0x400211A")]
		[FieldOffset(Offset = "0x28")]
		private List<MonoBehaviour> _instances;
	}
}
