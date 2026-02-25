using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Coffee.UISoftMask;
using Gameplay.Tutorial.Guide.Model;
using Gameplay.Tutorial.Guide.Model.Data.Config;
using Gameplay.Tutorial.Guide.Model.Shapes;
using Gameplay.Tutorial.Guide.View.Outline;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Tutorial.Guide.View.Components
{
	// Token: 0x02000476 RID: 1142
	[Token(Token = "0x2000476")]
	public class ShapePointer : MonoBehaviour
	{
		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004B4")]
		public Overlap Overlap
		{
			[Token(Token = "0x6001B06")]
			[Address(RVA = "0x6C90", Offset = "0x6C90", VA = "0x6C90")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06001B07 RID: 6919 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004B5")]
		public MaskingShape MaskingShape
		{
			[Token(Token = "0x6001B07")]
			[Address(RVA = "0x6C91", Offset = "0x6C91", VA = "0x6C91")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001B09 RID: 6921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B6")]
		public GuideView GuideView
		{
			[Token(Token = "0x6001B08")]
			[Address(RVA = "0x6C92", Offset = "0x6C92", VA = "0x6C92")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B09")]
			[Address(RVA = "0x6C93", Offset = "0x6C93", VA = "0x6C93")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06001B0A RID: 6922 RVA: 0x00005B38 File Offset: 0x00003D38
		// (set) Token: 0x06001B0B RID: 6923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B7")]
		public Vector3 IdlePosition
		{
			[Token(Token = "0x6001B0A")]
			[Address(RVA = "0x6C94", Offset = "0x6C94", VA = "0x6C94")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6001B0B")]
			[Address(RVA = "0x6C95", Offset = "0x6C95", VA = "0x6C95")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06001B0C RID: 6924 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004B8")]
		public Image ShapeRender
		{
			[Token(Token = "0x6001B0C")]
			[Address(RVA = "0x6C96", Offset = "0x6C96", VA = "0x6C96")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001B0D RID: 6925 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004B9")]
		public RectTransform ShapeTransform
		{
			[Token(Token = "0x6001B0D")]
			[Address(RVA = "0x6C97", Offset = "0x6C97", VA = "0x6C97")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06001B0E RID: 6926 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004BA")]
		public RectTransform OverlapTransform
		{
			[Token(Token = "0x6001B0E")]
			[Address(RVA = "0x6C98", Offset = "0x6C98", VA = "0x6C98")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B0F")]
		[Address(RVA = "0x6C99", Offset = "0x6C99", VA = "0x6C99")]
		private void OnDisable()
		{
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B10")]
		[Address(RVA = "0x6C9A", Offset = "0x6C9A", VA = "0x6C9A")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B11")]
		[Address(RVA = "0x6C9B", Offset = "0x6C9B", VA = "0x6C9B")]
		private void Awake()
		{
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x00005B50 File Offset: 0x00003D50
		[Token(Token = "0x6001B12")]
		[Address(RVA = "0x6C9C", Offset = "0x6C9C", VA = "0x6C9C")]
		public bool TryGetShapeConfig(AbstractShape shape, out ShapePointer.ShapeSpriteConfig result)
		{
			return default(bool);
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x00005B68 File Offset: 0x00003D68
		[Token(Token = "0x6001B13")]
		[Address(RVA = "0x6C9D", Offset = "0x6C9D", VA = "0x6C9D")]
		public bool TryGetShapeSprite(AbstractShape shape, out Sprite spriteOut)
		{
			return default(bool);
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B14")]
		[Address(RVA = "0x6C9E", Offset = "0x6C9E", VA = "0x6C9E")]
		public void SetSize(Vector2 value)
		{
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B15")]
		[Address(RVA = "0x6C9F", Offset = "0x6C9F", VA = "0x6C9F")]
		public void SetSize(Vector2 value, float duration)
		{
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06001B16 RID: 6934 RVA: 0x00005B80 File Offset: 0x00003D80
		// (set) Token: 0x06001B17 RID: 6935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004BB")]
		public bool IsResizeProcessNow
		{
			[Token(Token = "0x6001B16")]
			[Address(RVA = "0x6CA0", Offset = "0x6CA0", VA = "0x6CA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B17")]
			[Address(RVA = "0x6CA1", Offset = "0x6CA1", VA = "0x6CA1")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B18")]
		[Address(RVA = "0x6CA2", Offset = "0x6CA2", VA = "0x6CA2")]
		private void ReSizeStart()
		{
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B19")]
		[Address(RVA = "0x6CA3", Offset = "0x6CA3", VA = "0x6CA3")]
		private void ReSizeComplete()
		{
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B1A")]
		[Address(RVA = "0x6CA4", Offset = "0x6CA4", VA = "0x6CA4")]
		public void Move(Transform target, Vector3 value)
		{
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B1B")]
		[Address(RVA = "0x6CA5", Offset = "0x6CA5", VA = "0x6CA5")]
		public void Move(Transform target, Vector3 value, float duration)
		{
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B1C")]
		[Address(RVA = "0x6CA6", Offset = "0x6CA6", VA = "0x6CA6")]
		private void MoveUpdate()
		{
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06001B1D RID: 6941 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001B1E RID: 6942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004BC")]
		public AbstractShape Shape
		{
			[Token(Token = "0x6001B1D")]
			[Address(RVA = "0x6CA7", Offset = "0x6CA7", VA = "0x6CA7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B1E")]
			[Address(RVA = "0x6CA8", Offset = "0x6CA8", VA = "0x6CA8")]
			set
			{
			}
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B1F")]
		[Address(RVA = "0x6CA9", Offset = "0x6CA9", VA = "0x6CA9")]
		private void HandleCurrentShapeChanged(AbstractShape from, AbstractShape to)
		{
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001B20 RID: 6944 RVA: 0x00005B98 File Offset: 0x00003D98
		// (set) Token: 0x06001B21 RID: 6945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004BD")]
		public OverlapType OverlapType
		{
			[Token(Token = "0x6001B20")]
			[Address(RVA = "0x6CAA", Offset = "0x6CAA", VA = "0x6CAA")]
			get
			{
				return OverlapType.UNKNOWN;
			}
			[Token(Token = "0x6001B21")]
			[Address(RVA = "0x6CAB", Offset = "0x6CAB", VA = "0x6CAB")]
			set
			{
			}
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B22")]
		[Address(RVA = "0x6CAC", Offset = "0x6CAC", VA = "0x6CAC")]
		public void SetRect(in Rect rect)
		{
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B23")]
		[Address(RVA = "0x6CAD", Offset = "0x6CAD", VA = "0x6CAD")]
		public void StartDraw(StepLayoutConfig config, in Rect rect)
		{
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B24")]
		[Address(RVA = "0x6CAE", Offset = "0x6CAE", VA = "0x6CAE")]
		public void StartDraw(AbstractShape shape, in Rect rect)
		{
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001B25")]
		[Address(RVA = "0x6CAF", Offset = "0x6CAF", VA = "0x6CAF")]
		private AbstractGuideOutline GetCachedOutline(AbstractShape shape)
		{
			return null;
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B26")]
		[Address(RVA = "0x6CB0", Offset = "0x6CB0", VA = "0x6CB0")]
		public void StopDraw()
		{
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B27")]
		[Address(RVA = "0x6CB1", Offset = "0x6CB1", VA = "0x6CB1")]
		public void StopDraw(float duration)
		{
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B28")]
		[Address(RVA = "0x6CB2", Offset = "0x6CB2", VA = "0x6CB2")]
		public void SetShapeRenderRayCastEnabled(bool value)
		{
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B29")]
		[Address(RVA = "0x6CB3", Offset = "0x6CB3", VA = "0x6CB3")]
		public ShapePointer()
		{
		}

		// Token: 0x04000E90 RID: 3728
		[Token(Token = "0x4000E90")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Overlap _overlap;

		// Token: 0x04000E91 RID: 3729
		[Token(Token = "0x4000E91")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private MaskingShape _maskingShape;

		// Token: 0x04000E92 RID: 3730
		[Token(Token = "0x4000E92")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _outlineContainer;

		// Token: 0x04000E93 RID: 3731
		[Token(Token = "0x4000E93")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ShapePointer.ShapeSpriteConfig[] _shapeSpritesConfigs;

		// Token: 0x04000E94 RID: 3732
		[Token(Token = "0x4000E94")]
		public const float MOVE_DURATION = 0.5f;

		// Token: 0x04000E95 RID: 3733
		[Token(Token = "0x4000E95")]
		public const float CHANGE_SIZE_DURATION = 0.7f;

		// Token: 0x04000E96 RID: 3734
		[Token(Token = "0x4000E96")]
		public const float OUTLINE_START_DELAY = 0.5f;

		// Token: 0x04000E98 RID: 3736
		[Token(Token = "0x4000E98")]
		[FieldOffset(Offset = "0x24")]
		private Image _shapeRender;

		// Token: 0x04000E99 RID: 3737
		[Token(Token = "0x4000E99")]
		[FieldOffset(Offset = "0x28")]
		private RectTransform _overlapTransform;

		// Token: 0x04000E9A RID: 3738
		[Token(Token = "0x4000E9A")]
		[FieldOffset(Offset = "0x2C")]
		private RectTransform _shapeTransform;

		// Token: 0x04000E9B RID: 3739
		[Token(Token = "0x4000E9B")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<TargetPointerShape, AbstractGuideOutline> _outlinesCache;

		// Token: 0x04000E9C RID: 3740
		[Token(Token = "0x4000E9C")]
		[FieldOffset(Offset = "0x34")]
		private AbstractGuideOutline _currentOutline;

		// Token: 0x04000E9D RID: 3741
		[Token(Token = "0x4000E9D")]
		[FieldOffset(Offset = "0x38")]
		public readonly Vector2 IdleSize;

		// Token: 0x04000E9F RID: 3743
		[Token(Token = "0x4000E9F")]
		[FieldOffset(Offset = "0x4C")]
		private Dictionary<TargetPointerShape, AbstractShape> _availShapes;

		// Token: 0x04000EA1 RID: 3745
		[Token(Token = "0x4000EA1")]
		[FieldOffset(Offset = "0x54")]
		private AbstractShape _shape;

		// Token: 0x02000477 RID: 1143
		[Token(Token = "0x2000477")]
		[Serializable]
		public class ShapeSpriteConfig
		{
			// Token: 0x06001B2B RID: 6955 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001B2B")]
			[Address(RVA = "0x6CB5", Offset = "0x6CB5", VA = "0x6CB5")]
			public ShapeSpriteConfig()
			{
			}

			// Token: 0x04000EA2 RID: 3746
			[Token(Token = "0x4000EA2")]
			[FieldOffset(Offset = "0x8")]
			public TargetPointerShape Shape;

			// Token: 0x04000EA3 RID: 3747
			[Token(Token = "0x4000EA3")]
			[FieldOffset(Offset = "0xC")]
			public Sprite Sprite;

			// Token: 0x04000EA4 RID: 3748
			[Token(Token = "0x4000EA4")]
			[FieldOffset(Offset = "0x10")]
			public AbstractGuideOutline Outline;
		}
	}
}
