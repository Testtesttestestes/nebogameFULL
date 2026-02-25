using System;
using System.Collections.Generic;
using Gameplay.Tutorial.Guide.View;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Common;
using UI;
using UnityEngine;

namespace Gameplay.Combat.View.GameField
{
	// Token: 0x02000966 RID: 2406
	[Token(Token = "0x2000966")]
	public class GuideTurnHint : MonoBehaviour, IRectProvider, IOverrideGuideShapePointer, IOverrideGuideGraphicPointerAnimationState, IOverrideGuideGraphicPointerPosition
	{
		// Token: 0x06003930 RID: 14640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003930")]
		[Address(RVA = "0x88C5", Offset = "0x88C5", VA = "0x88C5")]
		public void Show(ProtoShowHintEvt data)
		{
		}

		// Token: 0x06003931 RID: 14641 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003931")]
		[Address(RVA = "0x88C6", Offset = "0x88C6", VA = "0x88C6")]
		public Texture2D GetTexture(List<Point> points, int radius)
		{
			return null;
		}

		// Token: 0x06003932 RID: 14642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003932")]
		[Address(RVA = "0x88C7", Offset = "0x88C7", VA = "0x88C7")]
		public void Show()
		{
		}

		// Token: 0x06003933 RID: 14643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003933")]
		[Address(RVA = "0x88C8", Offset = "0x88C8", VA = "0x88C8")]
		public void Hide()
		{
		}

		// Token: 0x06003934 RID: 14644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003934")]
		[Address(RVA = "0x88C9", Offset = "0x88C9", VA = "0x88C9")]
		public void DbgDraw()
		{
		}

		// Token: 0x06003935 RID: 14645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003935")]
		[Address(RVA = "0x88CA", Offset = "0x88CA", VA = "0x88CA")]
		public void Test()
		{
		}

		// Token: 0x06003936 RID: 14646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003936")]
		[Address(RVA = "0x88CB", Offset = "0x88CB", VA = "0x88CB")]
		public void TestGuideCaptureTarget()
		{
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06003937 RID: 14647 RVA: 0x0000B598 File Offset: 0x00009798
		[Token(Token = "0x17000B3D")]
		public Bounds Bounds
		{
			[Token(Token = "0x6003937")]
			[Address(RVA = "0x88CC", Offset = "0x88CC", VA = "0x88CC")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06003938 RID: 14648 RVA: 0x0000B5B0 File Offset: 0x000097B0
		[Token(Token = "0x17000B3E")]
		public Rect Rect
		{
			[Token(Token = "0x6003938")]
			[Address(RVA = "0x88CD", Offset = "0x88CD", VA = "0x88CD", Slot = "4")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x06003939 RID: 14649 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003939")]
		[Address(RVA = "0x88CE", Offset = "0x88CE", VA = "0x88CE", Slot = "5")]
		public Sprite GetShape()
		{
			return null;
		}

		// Token: 0x0600393A RID: 14650 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600393A")]
		[Address(RVA = "0x88CF", Offset = "0x88CF", VA = "0x88CF", Slot = "6")]
		public string GetState()
		{
			return null;
		}

		// Token: 0x0600393B RID: 14651 RVA: 0x0000B5C8 File Offset: 0x000097C8
		[Token(Token = "0x600393B")]
		[Address(RVA = "0x88D0", Offset = "0x88D0", VA = "0x88D0", Slot = "7")]
		public Vector3 GetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600393C RID: 14652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600393C")]
		[Address(RVA = "0x88D1", Offset = "0x88D1", VA = "0x88D1")]
		public GuideTurnHint()
		{
		}

		// Token: 0x04001FA2 RID: 8098
		[Token(Token = "0x4001FA2")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SpriteRenderer _spriteRenderer;

		// Token: 0x04001FA3 RID: 8099
		[Token(Token = "0x4001FA3")]
		[FieldOffset(Offset = "0x14")]
		[NonSerialized]
		private bool _isDbgDraw;

		// Token: 0x04001FA4 RID: 8100
		[Token(Token = "0x4001FA4")]
		[FieldOffset(Offset = "0x18")]
		private ProtoShowHintEvt _data;

		// Token: 0x04001FA5 RID: 8101
		[Token(Token = "0x4001FA5")]
		[FieldOffset(Offset = "0x1C")]
		private int _minX;

		// Token: 0x04001FA6 RID: 8102
		[Token(Token = "0x4001FA6")]
		[FieldOffset(Offset = "0x20")]
		private int _minY;

		// Token: 0x04001FA7 RID: 8103
		[Token(Token = "0x4001FA7")]
		[FieldOffset(Offset = "0x24")]
		private int _maxX;

		// Token: 0x04001FA8 RID: 8104
		[Token(Token = "0x4001FA8")]
		[FieldOffset(Offset = "0x28")]
		private int _maxY;

		// Token: 0x04001FA9 RID: 8105
		[Token(Token = "0x4001FA9")]
		[FieldOffset(Offset = "0x2C")]
		private Color[] _cachedCellColor;
	}
}
