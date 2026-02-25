using System;
using Il2CppDummyDll;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(CanvasRenderer), typeof(ParticleSystem))]
	[AddComponentMenu("UI/Effects/Extensions/UIParticleSystem")]
	public class UIParticleSystem : MaskableGraphic
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000006")]
		public override Texture mainTexture
		{
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x55BC", Offset = "0x55BC", VA = "0x55BC", Slot = "35")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x55BD", Offset = "0x55BD", VA = "0x55BD")]
		protected bool Initialize()
		{
			return default(bool);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x55BE", Offset = "0x55BE", VA = "0x55BE", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x55BF", Offset = "0x55BF", VA = "0x55BF", Slot = "44")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x55C0", Offset = "0x55C0", VA = "0x55C0")]
		private void Update()
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x55C1", Offset = "0x55C1", VA = "0x55C1")]
		private void LateUpdate()
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x55C2", Offset = "0x55C2", VA = "0x55C2", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x55C3", Offset = "0x55C3", VA = "0x55C3")]
		public void StartParticleEmission()
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x55C4", Offset = "0x55C4", VA = "0x55C4")]
		public void StopParticleEmission()
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x55C5", Offset = "0x55C5", VA = "0x55C5")]
		public void PauseParticleEmission()
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x55C6", Offset = "0x55C6", VA = "0x55C6")]
		public UIParticleSystem()
		{
		}

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x80")]
		[Tooltip("Having this enabled run the system in LateUpdate rather than in Update making it faster but less precise (more clunky)")]
		public bool fixedTime;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x81")]
		[Tooltip("Enables 3d rotation for the particles")]
		public bool use3dRotation;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x84")]
		private Transform _transform;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x88")]
		private ParticleSystem pSystem;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x8C")]
		private ParticleSystem.Particle[] particles;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x90")]
		private UIVertex[] _quad;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x94")]
		private Vector4 imageUV;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0xA4")]
		private ParticleSystem.TextureSheetAnimationModule textureSheetAnimation;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0xA8")]
		private int textureSheetAnimationFrames;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0xAC")]
		private Vector2 textureSheetAnimationFrameSize;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0xB4")]
		private ParticleSystemRenderer pRenderer;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0xB8")]
		private bool isInitialised;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0xBC")]
		private Material currentMaterial;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0xC0")]
		private Texture currentTexture;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0xC4")]
		private ParticleSystem.MainModule mainModule;
	}
}
