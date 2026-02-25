using System;
using Il2CppDummyDll;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	public class UIPrimitiveBase : MaskableGraphic, ILayoutElement, ICanvasRaycastFilter
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000012")]
		public Sprite sprite
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x55F1", Offset = "0x55F1", VA = "0x55F1")]
			get
			{
				return null;
			}
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x55F2", Offset = "0x55F2", VA = "0x55F2")]
			set
			{
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600012F RID: 303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000013")]
		public Sprite overrideSprite
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x55F3", Offset = "0x55F3", VA = "0x55F3")]
			get
			{
				return null;
			}
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x55F4", Offset = "0x55F4", VA = "0x55F4")]
			set
			{
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000014")]
		protected Sprite activeSprite
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x55F5", Offset = "0x55F5", VA = "0x55F5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00002310 File Offset: 0x00000510
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000015")]
		public float eventAlphaThreshold
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x55F6", Offset = "0x55F6", VA = "0x55F6")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x55F7", Offset = "0x55F7", VA = "0x55F7")]
			set
			{
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00002328 File Offset: 0x00000528
		// (set) Token: 0x06000134 RID: 308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000016")]
		public ResolutionMode ImproveResolution
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x55F8", Offset = "0x55F8", VA = "0x55F8")]
			get
			{
				return ResolutionMode.None;
			}
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x55F9", Offset = "0x55F9", VA = "0x55F9")]
			set
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00002340 File Offset: 0x00000540
		// (set) Token: 0x06000136 RID: 310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000017")]
		public float Resoloution
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x55FA", Offset = "0x55FA", VA = "0x55FA")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x55FB", Offset = "0x55FB", VA = "0x55FB")]
			set
			{
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00002358 File Offset: 0x00000558
		// (set) Token: 0x06000138 RID: 312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000018")]
		public bool UseNativeSize
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x55FC", Offset = "0x55FC", VA = "0x55FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x55FD", Offset = "0x55FD", VA = "0x55FD")]
			set
			{
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x55FE", Offset = "0x55FE", VA = "0x55FE")]
		protected UIPrimitiveBase()
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000019")]
		public static Material defaultETC1GraphicMaterial
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x55FF", Offset = "0x55FF", VA = "0x55FF")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700001A")]
		public override Texture mainTexture
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x5600", Offset = "0x5600", VA = "0x5600", Slot = "35")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x1700001B")]
		public bool hasBorder
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x5601", Offset = "0x5601", VA = "0x5601")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x1700001C")]
		public float pixelsPerUnit
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x5602", Offset = "0x5602", VA = "0x5602")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600013F RID: 319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001D")]
		public override Material material
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x5603", Offset = "0x5603", VA = "0x5603", Slot = "32")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x5604", Offset = "0x5604", VA = "0x5604", Slot = "33")]
			set
			{
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x5605", Offset = "0x5605", VA = "0x5605")]
		protected UIVertex[] SetVbo(Vector2[] vertices, Vector2[] uvs)
		{
			return null;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x5606", Offset = "0x5606", VA = "0x5606")]
		protected Vector2[] IncreaseResolution(Vector2[] input)
		{
			return null;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x5607", Offset = "0x5607", VA = "0x5607", Slot = "75")]
		protected virtual void GeneratedUVs()
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x5608", Offset = "0x5608", VA = "0x5608", Slot = "76")]
		protected virtual void ResolutionToNativeSize(float distance)
		{
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x5609", Offset = "0x5609", VA = "0x5609", Slot = "77")]
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x560A", Offset = "0x560A", VA = "0x560A", Slot = "78")]
		public virtual void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000146 RID: 326 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x1700001E")]
		public virtual float minWidth
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x560B", Offset = "0x560B", VA = "0x560B", Slot = "79")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000147 RID: 327 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x1700001F")]
		public virtual float preferredWidth
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x560C", Offset = "0x560C", VA = "0x560C", Slot = "80")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000148 RID: 328 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x17000020")]
		public virtual float flexibleWidth
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x560D", Offset = "0x560D", VA = "0x560D", Slot = "81")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000149 RID: 329 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x17000021")]
		public virtual float minHeight
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x560E", Offset = "0x560E", VA = "0x560E", Slot = "82")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x17000022")]
		public virtual float preferredHeight
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x560F", Offset = "0x560F", VA = "0x560F", Slot = "83")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x17000023")]
		public virtual float flexibleHeight
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x5610", Offset = "0x5610", VA = "0x5610", Slot = "84")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x17000024")]
		public virtual int layoutPriority
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x5611", Offset = "0x5611", VA = "0x5611", Slot = "85")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x5612", Offset = "0x5612", VA = "0x5612", Slot = "86")]
		public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
		{
			return default(bool);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x5613", Offset = "0x5613", VA = "0x5613")]
		private Vector2 MapCoordinate(Vector2 local, Rect rect)
		{
			return default(Vector2);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x5614", Offset = "0x5614", VA = "0x5614")]
		private Vector4 GetAdjustedBorders(Vector4 border, Rect rect)
		{
			return default(Vector4);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x5615", Offset = "0x5615", VA = "0x5615", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x0")]
		protected static Material s_ETC1DefaultUI;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Sprite m_Sprite;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x84")]
		[NonSerialized]
		private Sprite m_OverrideSprite;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x88")]
		internal float m_EventAlphaThreshold;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private ResolutionMode m_improveResolution;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		protected float m_Resolution;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private bool m_useNativeSize;
	}
}
