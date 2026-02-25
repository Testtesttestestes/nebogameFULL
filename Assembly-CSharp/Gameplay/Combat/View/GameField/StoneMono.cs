using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Materials;
using Il2CppDummyDll;
using Protocol.Combat;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.U2D;
using Utils.Cache;

namespace Gameplay.Combat.View.GameField
{
	// Token: 0x02000969 RID: 2409
	[Token(Token = "0x2000969")]
	public class StoneMono : SerializedMonoBehaviour, IPoolElement<StoneMono>, IGrayscalable
	{
		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06003946 RID: 14662 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003947 RID: 14663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B41")]
		public StoneMono.StoneSkinProvider Skin
		{
			[Token(Token = "0x6003946")]
			[Address(RVA = "0x88D8", Offset = "0x88D8", VA = "0x88D8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003947")]
			[Address(RVA = "0x88D9", Offset = "0x88D9", VA = "0x88D9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06003948 RID: 14664 RVA: 0x0000B640 File Offset: 0x00009840
		// (set) Token: 0x06003949 RID: 14665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B42")]
		public Vector3 IdlePosition
		{
			[Token(Token = "0x6003948")]
			[Address(RVA = "0x88DA", Offset = "0x88DA", VA = "0x88DA")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6003949")]
			[Address(RVA = "0x88DB", Offset = "0x88DB", VA = "0x88DB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x0600394A RID: 14666 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600394B RID: 14667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B43")]
		public ObjectPool<StoneMono> Pool
		{
			[Token(Token = "0x600394A")]
			[Address(RVA = "0x88DC", Offset = "0x88DC", VA = "0x88DC", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600394B")]
			[Address(RVA = "0x88DD", Offset = "0x88DD", VA = "0x88DD", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x0600394C RID: 14668 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B44")]
		public SpriteRenderer SpriteRenderer
		{
			[Token(Token = "0x600394C")]
			[Address(RVA = "0x88DE", Offset = "0x88DE", VA = "0x88DE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x0600394D RID: 14669 RVA: 0x0000B658 File Offset: 0x00009858
		// (set) Token: 0x0600394E RID: 14670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B45")]
		public int Row
		{
			[Token(Token = "0x600394D")]
			[Address(RVA = "0x88DF", Offset = "0x88DF", VA = "0x88DF")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600394E")]
			[Address(RVA = "0x88E0", Offset = "0x88E0", VA = "0x88E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x0600394F RID: 14671 RVA: 0x0000B670 File Offset: 0x00009870
		// (set) Token: 0x06003950 RID: 14672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B46")]
		public int Col
		{
			[Token(Token = "0x600394F")]
			[Address(RVA = "0x88E1", Offset = "0x88E1", VA = "0x88E1")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003950")]
			[Address(RVA = "0x88E2", Offset = "0x88E2", VA = "0x88E2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06003951 RID: 14673 RVA: 0x0000B688 File Offset: 0x00009888
		// (set) Token: 0x06003952 RID: 14674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B47")]
		public bool Selected
		{
			[Token(Token = "0x6003951")]
			[Address(RVA = "0x88E3", Offset = "0x88E3", VA = "0x88E3")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003952")]
			[Address(RVA = "0x88E4", Offset = "0x88E4", VA = "0x88E4")]
			set
			{
			}
		}

		// Token: 0x06003953 RID: 14675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003953")]
		[Address(RVA = "0x88E5", Offset = "0x88E5", VA = "0x88E5")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003954 RID: 14676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003954")]
		[Address(RVA = "0x88E6", Offset = "0x88E6", VA = "0x88E6")]
		public void Init()
		{
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06003955 RID: 14677 RVA: 0x0000B6A0 File Offset: 0x000098A0
		// (set) Token: 0x06003956 RID: 14678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B48")]
		public StonesTypes StoneType
		{
			[Token(Token = "0x6003955")]
			[Address(RVA = "0x88E7", Offset = "0x88E7", VA = "0x88E7")]
			get
			{
				return StonesTypes.Empty;
			}
			[Token(Token = "0x6003956")]
			[Address(RVA = "0x88E8", Offset = "0x88E8", VA = "0x88E8")]
			set
			{
			}
		}

		// Token: 0x06003957 RID: 14679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003957")]
		[Address(RVA = "0x88E9", Offset = "0x88E9", VA = "0x88E9")]
		private void HandleStoneTypeChanged()
		{
		}

		// Token: 0x06003958 RID: 14680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003958")]
		[Address(RVA = "0x88EA", Offset = "0x88EA", VA = "0x88EA")]
		private void Impact(Vector2 impact, float delay)
		{
		}

		// Token: 0x06003959 RID: 14681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003959")]
		[Address(RVA = "0x88EB", Offset = "0x88EB", VA = "0x88EB")]
		public void Impact(IList<Vector2> sources, float delay)
		{
		}

		// Token: 0x0600395A RID: 14682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600395A")]
		[Address(RVA = "0x88EC", Offset = "0x88EC", VA = "0x88EC")]
		public void ShowDestroyAnimation(float duration, float delay, IStoneParticles stoneParticles)
		{
		}

		// Token: 0x0600395B RID: 14683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600395B")]
		[Address(RVA = "0x88ED", Offset = "0x88ED", VA = "0x88ED")]
		public void DoFade(float endValue, float duration, float delay = 0f)
		{
		}

		// Token: 0x0600395C RID: 14684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600395C")]
		[Address(RVA = "0x88EE", Offset = "0x88EE", VA = "0x88EE", Slot = "12")]
		public void Release()
		{
		}

		// Token: 0x0600395D RID: 14685 RVA: 0x0000B6B8 File Offset: 0x000098B8
		[Token(Token = "0x600395D")]
		[Address(RVA = "0x88EF", Offset = "0x88EF", VA = "0x88EF")]
		public bool SetPos(int col, int row)
		{
			return default(bool);
		}

		// Token: 0x0600395E RID: 14686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600395E")]
		[Address(RVA = "0x88F0", Offset = "0x88F0", VA = "0x88F0", Slot = "13")]
		public void SetGrayscale(float value)
		{
		}

		// Token: 0x0600395F RID: 14687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600395F")]
		[Address(RVA = "0x88F1", Offset = "0x88F1", VA = "0x88F1")]
		public StoneMono()
		{
		}

		// Token: 0x04001FAF RID: 8111
		[Token(Token = "0x4001FAF")]
		private const float MAX_SQR_DISTANCE = 6f;

		// Token: 0x04001FB0 RID: 8112
		[Token(Token = "0x4001FB0")]
		private const float EXPLOSION_POWER = 10f;

		// Token: 0x04001FB1 RID: 8113
		[Token(Token = "0x4001FB1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SpriteRenderer _spriteRenderer;

		// Token: 0x04001FB2 RID: 8114
		[Token(Token = "0x4001FB2")]
		[FieldOffset(Offset = "0x34")]
		private bool _selected;

		// Token: 0x04001FB3 RID: 8115
		[Token(Token = "0x4001FB3")]
		[FieldOffset(Offset = "0x35")]
		private bool _destroyed;

		// Token: 0x04001FB4 RID: 8116
		[Token(Token = "0x4001FB4")]
		[FieldOffset(Offset = "0x38")]
		private float _grayscale;

		// Token: 0x04001FBA RID: 8122
		[Token(Token = "0x4001FBA")]
		[FieldOffset(Offset = "0x58")]
		private StonesTypes _stoneType;

		// Token: 0x0200096A RID: 2410
		[Token(Token = "0x200096A")]
		[Serializable]
		public class StoneAppearanceRecord
		{
			// Token: 0x06003960 RID: 14688 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003960")]
			[Address(RVA = "0x88F2", Offset = "0x88F2", VA = "0x88F2")]
			public StoneAppearanceRecord()
			{
			}

			// Token: 0x04001FBB RID: 8123
			[Token(Token = "0x4001FBB")]
			[FieldOffset(Offset = "0x8")]
			public StonesTypes StoneType;

			// Token: 0x04001FBC RID: 8124
			[Token(Token = "0x4001FBC")]
			[FieldOffset(Offset = "0xC")]
			public Sprite Sprite;

			// Token: 0x04001FBD RID: 8125
			[Token(Token = "0x4001FBD")]
			[FieldOffset(Offset = "0x10")]
			public Color Color;

			// Token: 0x04001FBE RID: 8126
			[Token(Token = "0x4001FBE")]
			[FieldOffset(Offset = "0x20")]
			public Material ParticlesMaterial;

			// Token: 0x04001FBF RID: 8127
			[Token(Token = "0x4001FBF")]
			[FieldOffset(Offset = "0x24")]
			public Material ShardsMaterial;
		}

		// Token: 0x0200096B RID: 2411
		[Token(Token = "0x200096B")]
		public class StoneSkinProvider : IDisposable
		{
			// Token: 0x06003961 RID: 14689 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003961")]
			[Address(RVA = "0x88F3", Offset = "0x88F3", VA = "0x88F3", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x06003962 RID: 14690 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003962")]
			[Address(RVA = "0x88F4", Offset = "0x88F4", VA = "0x88F4")]
			public void SetAtlas(SpriteAtlas atlas)
			{
			}

			// Token: 0x06003963 RID: 14691 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003963")]
			[Address(RVA = "0x2A40", Offset = "0x2A40", VA = "0x2A40")]
			public void AddColor(StonesTypes stonesType, in Color color)
			{
			}

			// Token: 0x06003964 RID: 14692 RVA: 0x0000B6D0 File Offset: 0x000098D0
			[Token(Token = "0x6003964")]
			[Address(RVA = "0x88F5", Offset = "0x88F5", VA = "0x88F5")]
			private bool TryGetSprite(string name, out Sprite sprite)
			{
				return default(bool);
			}

			// Token: 0x06003965 RID: 14693 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6003965")]
			[Address(RVA = "0x88F6", Offset = "0x88F6", VA = "0x88F6")]
			private Texture2D GetTexture(Sprite sprite)
			{
				return null;
			}

			// Token: 0x06003966 RID: 14694 RVA: 0x0000B6E8 File Offset: 0x000098E8
			[Token(Token = "0x6003966")]
			[Address(RVA = "0x88F7", Offset = "0x88F7", VA = "0x88F7")]
			public bool TryGetSprite(StonesTypes stonesType, out Sprite sprite)
			{
				return default(bool);
			}

			// Token: 0x06003967 RID: 14695 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003967")]
			[Address(RVA = "0x88F8", Offset = "0x88F8", VA = "0x88F8")]
			public void GetColor(StonesTypes stonesType, out Color color)
			{
			}

			// Token: 0x06003968 RID: 14696 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003968")]
			[Address(RVA = "0x88F9", Offset = "0x88F9", VA = "0x88F9")]
			public void SetupShardsMaterialProps(StonesTypes stonesType, ParticleSystemRenderer renderer)
			{
			}

			// Token: 0x06003969 RID: 14697 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003969")]
			[Address(RVA = "0x88FA", Offset = "0x88FA", VA = "0x88FA")]
			public void SetupParticleMaterialProps(StonesTypes stonesType, ParticleSystemRenderer renderer)
			{
			}

			// Token: 0x0600396A RID: 14698 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600396A")]
			[Address(RVA = "0x88FB", Offset = "0x88FB", VA = "0x88FB")]
			public StoneSkinProvider()
			{
			}

			// Token: 0x04001FC0 RID: 8128
			[Token(Token = "0x4001FC0")]
			[FieldOffset(Offset = "0x8")]
			private readonly Dictionary<string, MaterialPropertyBlock> _cache;

			// Token: 0x04001FC1 RID: 8129
			[Token(Token = "0x4001FC1")]
			[FieldOffset(Offset = "0xC")]
			private readonly Dictionary<string, Texture2D> _textureCache;

			// Token: 0x04001FC2 RID: 8130
			[Token(Token = "0x4001FC2")]
			[FieldOffset(Offset = "0x10")]
			private readonly Dictionary<StonesTypes, Color> _colors;

			// Token: 0x04001FC3 RID: 8131
			[Token(Token = "0x4001FC3")]
			[FieldOffset(Offset = "0x14")]
			private SpriteAtlas _atlas;
		}
	}
}
