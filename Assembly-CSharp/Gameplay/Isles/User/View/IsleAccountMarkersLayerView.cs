using System;
using System.Collections.Generic;
using AssetContent;
using CloudsFly;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D11 RID: 3345
	[Token(Token = "0x2000D11")]
	public class IsleAccountMarkersLayerView : BaseWorldObjectRenderer
	{
		// Token: 0x0600519E RID: 20894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600519E")]
		[Address(RVA = "0x9F7A", Offset = "0x9F7A", VA = "0x9F7A")]
		private void Awake()
		{
		}

		// Token: 0x0600519F RID: 20895 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600519F")]
		[Address(RVA = "0x1E07", Offset = "0x1E07", VA = "0x1E07")]
		public GameAssetViewSpriteRenderer GetView(string assetId)
		{
			return null;
		}

		// Token: 0x060051A0 RID: 20896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051A0")]
		[Address(RVA = "0x9F7B", Offset = "0x9F7B", VA = "0x9F7B")]
		public void Show(string assetId)
		{
		}

		// Token: 0x060051A1 RID: 20897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051A1")]
		[Address(RVA = "0x9F7C", Offset = "0x9F7C", VA = "0x9F7C")]
		public void Hide(string assetId)
		{
		}

		// Token: 0x060051A2 RID: 20898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051A2")]
		[Address(RVA = "0x9F7D", Offset = "0x9F7D", VA = "0x9F7D")]
		public void HideAll()
		{
		}

		// Token: 0x060051A3 RID: 20899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051A3")]
		[Address(RVA = "0x9F7E", Offset = "0x9F7E", VA = "0x9F7E", Slot = "8")]
		protected override void ApplySortingOrder()
		{
		}

		// Token: 0x060051A4 RID: 20900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051A4")]
		[Address(RVA = "0x9F7F", Offset = "0x9F7F", VA = "0x9F7F", Slot = "9")]
		protected override void ApplySortingLayerId()
		{
		}

		// Token: 0x060051A5 RID: 20901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051A5")]
		[Address(RVA = "0x9F80", Offset = "0x9F80", VA = "0x9F80")]
		public IsleAccountMarkersLayerView()
		{
		}

		// Token: 0x04002C5F RID: 11359
		[Token(Token = "0x4002C5F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameAssetViewSpriteRenderer _accountMarkerPrefab;

		// Token: 0x04002C60 RID: 11360
		[Token(Token = "0x4002C60")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, GameAssetViewSpriteRenderer> _views;
	}
}
