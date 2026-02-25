using System;
using System.Collections.Generic;
using AssetContent.Loaders;
using Il2CppDummyDll;
using Protocol.Dic;
using Protocol.Fresco;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Fresco.View
{
	// Token: 0x020007F0 RID: 2032
	[Token(Token = "0x20007F0")]
	public class FrescoField : GameRawImageLoader
	{
		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06002FBE RID: 12222 RVA: 0x00009A38 File Offset: 0x00007C38
		[Token(Token = "0x1700095C")]
		public ulong FrescoId
		{
			[Token(Token = "0x6002FBE")]
			[Address(RVA = "0x8024", Offset = "0x8024", VA = "0x8024")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FBF")]
		[Address(RVA = "0x8025", Offset = "0x8025", VA = "0x8025")]
		public void Test()
		{
		}

		// Token: 0x06002FC0 RID: 12224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC0")]
		[Address(RVA = "0x8026", Offset = "0x8026", VA = "0x8026")]
		public void RandomField()
		{
		}

		// Token: 0x06002FC1 RID: 12225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC1")]
		[Address(RVA = "0x8027", Offset = "0x8027", VA = "0x8027", Slot = "11")]
		public override void SetAsset(Texture2D asset)
		{
		}

		// Token: 0x06002FC2 RID: 12226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC2")]
		[Address(RVA = "0x8028", Offset = "0x8028", VA = "0x8028")]
		public void Init(Protocol.Fresco.Fresco fresco, Protocol.Dic.Fresco.Types.FrescoDic frescoDic)
		{
		}

		// Token: 0x06002FC3 RID: 12227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC3")]
		[Address(RVA = "0x8029", Offset = "0x8029", VA = "0x8029")]
		public void SetGrid(Texture2D texture, int sizeX, int sizeY)
		{
		}

		// Token: 0x06002FC4 RID: 12228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC4")]
		[Address(RVA = "0x802A", Offset = "0x802A", VA = "0x802A", Slot = "14")]
		public virtual void ClickHandler(FrescoFragment frescoFragment)
		{
		}

		// Token: 0x06002FC5 RID: 12229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC5")]
		[Address(RVA = "0x802B", Offset = "0x802B", VA = "0x802B", Slot = "15")]
		protected virtual void ValidateSize(int sizeX, int sizeY, FrescoSpriteSelectorSO.SpriteSelectorElement spriteElement)
		{
		}

		// Token: 0x06002FC6 RID: 12230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC6")]
		[Address(RVA = "0x802C", Offset = "0x802C", VA = "0x802C")]
		private void ClearField()
		{
		}

		// Token: 0x06002FC7 RID: 12231 RVA: 0x00009A50 File Offset: 0x00007C50
		[Token(Token = "0x6002FC7")]
		[Address(RVA = "0x802D", Offset = "0x802D", VA = "0x802D")]
		protected Vector2 SetNativeHeight(Transform target, float height)
		{
			return default(Vector2);
		}

		// Token: 0x06002FC8 RID: 12232 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002FC8")]
		[Address(RVA = "0x802E", Offset = "0x802E", VA = "0x802E")]
		protected Texture2D GetTexture(Sprite sprite)
		{
			return null;
		}

		// Token: 0x06002FC9 RID: 12233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC9")]
		[Address(RVA = "0x802F", Offset = "0x802F", VA = "0x802F")]
		public FrescoField()
		{
		}

		// Token: 0x04001A15 RID: 6677
		[Token(Token = "0x4001A15")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private FrescoFragment _fragmentPrefab;

		// Token: 0x04001A16 RID: 6678
		[Token(Token = "0x4001A16")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GridLayoutGroup _grid;

		// Token: 0x04001A17 RID: 6679
		[Token(Token = "0x4001A17")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected Image _innerBorder;

		// Token: 0x04001A18 RID: 6680
		[Token(Token = "0x4001A18")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Image _outerBorder;

		// Token: 0x04001A19 RID: 6681
		[Token(Token = "0x4001A19")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private FrescoSpriteSelectorSO _frescoSpriteSelectorSO;

		// Token: 0x04001A1A RID: 6682
		[Token(Token = "0x4001A1A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Sprite _sprite;

		// Token: 0x04001A1B RID: 6683
		[Token(Token = "0x4001A1B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Vector2Int _size;

		// Token: 0x04001A1C RID: 6684
		[Token(Token = "0x4001A1C")]
		[FieldOffset(Offset = "0x44")]
		protected readonly List<FrescoFragment> _fragments;

		// Token: 0x04001A1D RID: 6685
		[Token(Token = "0x4001A1D")]
		[FieldOffset(Offset = "0x48")]
		protected Texture2D _texture;

		// Token: 0x04001A1E RID: 6686
		[Token(Token = "0x4001A1E")]
		[FieldOffset(Offset = "0x4C")]
		protected Protocol.Fresco.Fresco _fresco;

		// Token: 0x04001A1F RID: 6687
		[Token(Token = "0x4001A1F")]
		[FieldOffset(Offset = "0x50")]
		protected Protocol.Dic.Fresco.Types.FrescoDic _frescoDic;
	}
}
