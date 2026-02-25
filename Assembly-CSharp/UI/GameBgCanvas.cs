using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	// Token: 0x020000F7 RID: 247
	[Token(Token = "0x20000F7")]
	public class GameBgCanvas : MonoBehaviour
	{
		// Token: 0x0600083D RID: 2109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083D")]
		[Address(RVA = "0x5BF8", Offset = "0x5BF8", VA = "0x5BF8")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083E")]
		[Address(RVA = "0x5BF9", Offset = "0x5BF9", VA = "0x5BF9")]
		private void Awake()
		{
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083F")]
		[Address(RVA = "0x5BFA", Offset = "0x5BFA", VA = "0x5BFA")]
		private void Start()
		{
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000840")]
		[Address(RVA = "0x5BFB", Offset = "0x5BFB", VA = "0x5BFB")]
		private void Apply()
		{
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000841")]
		[Address(RVA = "0x5BFC", Offset = "0x5BFC", VA = "0x5BFC")]
		private void ValidateSize()
		{
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000842")]
		[Address(RVA = "0x5BFD", Offset = "0x5BFD", VA = "0x5BFD")]
		public void SetTexture(Texture2D value)
		{
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000843")]
		[Address(RVA = "0x5BFE", Offset = "0x5BFE", VA = "0x5BFE")]
		public Texture GetTexture()
		{
			return null;
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000844")]
		[Address(RVA = "0x5BFF", Offset = "0x5BFF", VA = "0x5BFF")]
		public GameBgCanvas()
		{
		}

		// Token: 0x040002E4 RID: 740
		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RawImage _bgImage;

		// Token: 0x040002E5 RID: 741
		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RawImage _topSolid;

		// Token: 0x040002E6 RID: 742
		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RawImage _bottomSolid;

		// Token: 0x040002E7 RID: 743
		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RectTransform _rectTransform;

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x20")]
		private RectTransform _topSolidRectTransform;

		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x24")]
		private RectTransform _bottomSolidRectTransform;

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x28")]
		private int _bgTextureWidth;

		// Token: 0x040002EB RID: 747
		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x2C")]
		private int _bgTextureHeight;

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x30")]
		private Texture _customTexture;
	}
}
