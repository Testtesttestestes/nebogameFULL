using System;
using System.Collections.Generic;
using AssetContent;
using CloudsFly;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D1A RID: 3354
	[Token(Token = "0x2000D1A")]
	public class IsleDecorationsView : BaseWorldObjectRenderer
	{
		// Token: 0x060051EA RID: 20970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051EA")]
		[Address(RVA = "0x1E15", Offset = "0x1E15", VA = "0x1E15")]
		public void AddDecoration(IsleDecorationsDic decorationsDic)
		{
		}

		// Token: 0x060051EB RID: 20971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051EB")]
		[Address(RVA = "0x1E00", Offset = "0x1E00", VA = "0x1E00")]
		public void RemoveDecoration(uint decorationId)
		{
		}

		// Token: 0x060051EC RID: 20972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051EC")]
		[Address(RVA = "0x9FC3", Offset = "0x9FC3", VA = "0x9FC3")]
		public void Clear()
		{
		}

		// Token: 0x060051ED RID: 20973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051ED")]
		[Address(RVA = "0x9FC4", Offset = "0x9FC4", VA = "0x9FC4", Slot = "8")]
		protected override void ApplySortingOrder()
		{
		}

		// Token: 0x060051EE RID: 20974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051EE")]
		[Address(RVA = "0x9FC5", Offset = "0x9FC5", VA = "0x9FC5", Slot = "9")]
		protected override void ApplySortingLayerId()
		{
		}

		// Token: 0x060051EF RID: 20975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051EF")]
		[Address(RVA = "0x9FC6", Offset = "0x9FC6", VA = "0x9FC6")]
		public IsleDecorationsView()
		{
		}

		// Token: 0x04002C88 RID: 11400
		[Token(Token = "0x4002C88")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04002C89 RID: 11401
		[Token(Token = "0x4002C89")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameAssetViewSpriteRenderer _assetRendererPrefab;

		// Token: 0x04002C8A RID: 11402
		[Token(Token = "0x4002C8A")]
		[FieldOffset(Offset = "0x2C")]
		private Dictionary<uint, GameAssetViewSpriteRenderer> _decorationsById;
	}
}
