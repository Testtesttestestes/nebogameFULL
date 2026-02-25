using System;
using Il2CppDummyDll;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	[AddComponentMenu("UI/Extensions/Primitives/UILineRenderer")]
	[RequireComponent(typeof(RectTransform))]
	public class UILineRenderer : UIPrimitiveBase
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00002298 File Offset: 0x00000498
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000C")]
		public float LineThickness
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x55DF", Offset = "0x55DF", VA = "0x55DF")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x55E0", Offset = "0x55E0", VA = "0x55E0")]
			set
			{
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600011C RID: 284 RVA: 0x000022B0 File Offset: 0x000004B0
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000D")]
		public bool RelativeSize
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x55E1", Offset = "0x55E1", VA = "0x55E1")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x55E2", Offset = "0x55E2", VA = "0x55E2")]
			set
			{
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600011E RID: 286 RVA: 0x000022C8 File Offset: 0x000004C8
		// (set) Token: 0x0600011F RID: 287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000E")]
		public bool LineList
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x55E3", Offset = "0x55E3", VA = "0x55E3")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x55E4", Offset = "0x55E4", VA = "0x55E4")]
			set
			{
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000120 RID: 288 RVA: 0x000022E0 File Offset: 0x000004E0
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000F")]
		public bool LineCaps
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x55E5", Offset = "0x55E5", VA = "0x55E5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x55E6", Offset = "0x55E6", VA = "0x55E6")]
			set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000122 RID: 290 RVA: 0x000022F8 File Offset: 0x000004F8
		// (set) Token: 0x06000123 RID: 291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000010")]
		public int BezierSegmentsPerCurve
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x55E7", Offset = "0x55E7", VA = "0x55E7")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x55E8", Offset = "0x55E8", VA = "0x55E8")]
			set
			{
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000011")]
		public Vector2[] Points
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x55E9", Offset = "0x55E9", VA = "0x55E9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x55EA", Offset = "0x55EA", VA = "0x55EA")]
			set
			{
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x55EB", Offset = "0x55EB", VA = "0x55EB", Slot = "44")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x55EC", Offset = "0x55EC", VA = "0x55EC")]
		private UIVertex[] CreateLineCap(Vector2 start, Vector2 end, UILineRenderer.SegmentType type)
		{
			return null;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x55ED", Offset = "0x55ED", VA = "0x55ED")]
		private UIVertex[] CreateLineSegment(Vector2 start, Vector2 end, UILineRenderer.SegmentType type)
		{
			return null;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x55EE", Offset = "0x55EE", VA = "0x55EE", Slot = "75")]
		protected override void GeneratedUVs()
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x55EF", Offset = "0x55EF", VA = "0x55EF", Slot = "76")]
		protected override void ResolutionToNativeSize(float distance)
		{
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x55F0", Offset = "0x55F0", VA = "0x55F0")]
		public UILineRenderer()
		{
		}

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		private const float MIN_MITER_JOIN = 0.2617994f;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		private const float MIN_BEVEL_NICE_JOIN = 0.5235988f;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x0")]
		private static Vector2 UV_TOP_LEFT;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x8")]
		private static Vector2 UV_BOTTOM_LEFT;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x10")]
		private static Vector2 UV_TOP_CENTER_LEFT;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x18")]
		private static Vector2 UV_TOP_CENTER_RIGHT;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x20")]
		private static Vector2 UV_BOTTOM_CENTER_LEFT;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x28")]
		private static Vector2 UV_BOTTOM_CENTER_RIGHT;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x30")]
		private static Vector2 UV_TOP_RIGHT;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x38")]
		private static Vector2 UV_BOTTOM_RIGHT;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x40")]
		private static Vector2[] startUvs;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x44")]
		private static Vector2[] middleUvs;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x48")]
		private static Vector2[] endUvs;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x4C")]
		private static Vector2[] fullUvs;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Tooltip("Points to draw lines between\n Can be improved using the Resolution Option")]
		internal Vector2[] m_points;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		[Tooltip("Thickness of the line")]
		internal float lineThickness;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Tooltip("Use the relative bounds of the Rect Transform (0,0 -> 0,1) or screen space coordinates")]
		internal bool relativeSize;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0xA1")]
		[SerializeField]
		[Tooltip("Do the points identify a single line or split pairs of lines")]
		internal bool lineList;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0xA2")]
		[SerializeField]
		[Tooltip("Add end caps to each line\nMultiple caps when used with Line List")]
		internal bool lineCaps;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		[Tooltip("Resolution of the Bezier curve, different to line Resolution")]
		internal int bezierSegmentsPerCurve;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0xA8")]
		[Tooltip("The type of Join used between lines, Square/Mitre or Curved/Bevel")]
		public UILineRenderer.JoinType LineJoins;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0xAC")]
		[Tooltip("Bezier method to apply to line, see docs for options\nCan't be used in conjunction with Resolution as Bezier already changes the resolution")]
		public UILineRenderer.BezierType BezierMode;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		public bool drivenExternally;

		// Token: 0x02000017 RID: 23
		[Token(Token = "0x2000017")]
		private enum SegmentType
		{
			// Token: 0x04000085 RID: 133
			[Token(Token = "0x4000085")]
			Start,
			// Token: 0x04000086 RID: 134
			[Token(Token = "0x4000086")]
			Middle,
			// Token: 0x04000087 RID: 135
			[Token(Token = "0x4000087")]
			End,
			// Token: 0x04000088 RID: 136
			[Token(Token = "0x4000088")]
			Full
		}

		// Token: 0x02000018 RID: 24
		[Token(Token = "0x2000018")]
		public enum JoinType
		{
			// Token: 0x0400008A RID: 138
			[Token(Token = "0x400008A")]
			Bevel,
			// Token: 0x0400008B RID: 139
			[Token(Token = "0x400008B")]
			Miter
		}

		// Token: 0x02000019 RID: 25
		[Token(Token = "0x2000019")]
		public enum BezierType
		{
			// Token: 0x0400008D RID: 141
			[Token(Token = "0x400008D")]
			None,
			// Token: 0x0400008E RID: 142
			[Token(Token = "0x400008E")]
			Quick,
			// Token: 0x0400008F RID: 143
			[Token(Token = "0x400008F")]
			Basic,
			// Token: 0x04000090 RID: 144
			[Token(Token = "0x4000090")]
			Improved,
			// Token: 0x04000091 RID: 145
			[Token(Token = "0x4000091")]
			Catenary
		}
	}
}
