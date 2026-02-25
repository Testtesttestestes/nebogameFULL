using System;
using Il2CppDummyDll;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(CanvasRenderer), typeof(ParticleSystem))]
	[AddComponentMenu("UI/Effects/Extensions/UIParticleSystemFromTextureSheet")]
	public class UIParticleSystemFromTextureSheet : MaskableGraphic
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000007")]
		public override Texture mainTexture
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x55C7", Offset = "0x55C7", VA = "0x55C7", Slot = "35")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x55C8", Offset = "0x55C8", VA = "0x55C8")]
		protected bool Initialize()
		{
			return default(bool);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x55C9", Offset = "0x55C9", VA = "0x55C9", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x55CA", Offset = "0x55CA", VA = "0x55CA", Slot = "44")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x55CB", Offset = "0x55CB", VA = "0x55CB")]
		private void Update()
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x55CC", Offset = "0x55CC", VA = "0x55CC")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x55CD", Offset = "0x55CD", VA = "0x55CD", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x55CE", Offset = "0x55CE", VA = "0x55CE")]
		public void StartParticleEmission()
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x55CF", Offset = "0x55CF", VA = "0x55CF")]
		public void StopParticleEmission()
		{
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x55D0", Offset = "0x55D0", VA = "0x55D0")]
		public void PauseParticleEmission()
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x55D1", Offset = "0x55D1", VA = "0x55D1")]
		public UIParticleSystemFromTextureSheet()
		{
		}

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x80")]
		[Tooltip("Having this enabled run the system in LateUpdate rather than in Update making it faster but less precise (more clunky)")]
		public bool fixedTime;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x81")]
		[Tooltip("Enables 3d rotation for the particles")]
		public bool use3dRotation;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x84")]
		private Transform _transform;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x88")]
		private ParticleSystem pSystem;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x8C")]
		private ParticleSystem.Particle[] particles;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x90")]
		private UIVertex[] _quad;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x94")]
		private Vector4 imageUV;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0xA4")]
		private ParticleSystem.TextureSheetAnimationModule textureSheetAnimation;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0xA8")]
		private int textureSheetAnimationFrames;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0xAC")]
		private Vector2 textureSheetAnimationFrameSize;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0xB4")]
		private ParticleSystemRenderer pRenderer;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0xB8")]
		private bool isInitialised;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0xBC")]
		private Material currentMaterial;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0xC0")]
		private Texture currentTexture;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0xC4")]
		private ParticleSystem.MainModule mainModule;
	}
}
