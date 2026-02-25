using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Combat.Model;
using Gameplay.Input;
using Il2CppDummyDll;
using Protocol.Common;
using UnityEngine;

namespace Gameplay.Combat.View.Spells
{
	// Token: 0x02000945 RID: 2373
	[Token(Token = "0x2000945")]
	[RequireComponent(typeof(Collider2D))]
	public class SpellFieldFigure : MonoBehaviour, IInputReleaseHandler
	{
		// Token: 0x1400017D RID: 381
		// (add) Token: 0x0600381F RID: 14367 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003820 RID: 14368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400017D")]
		public event Action OnPointerUp
		{
			[Token(Token = "0x600381F")]
			[Address(RVA = "0x87D6", Offset = "0x87D6", VA = "0x87D6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003820")]
			[Address(RVA = "0x87D7", Offset = "0x87D7", VA = "0x87D7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06003821 RID: 14369 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B10")]
		public Color[] TexturePixel
		{
			[Token(Token = "0x6003821")]
			[Address(RVA = "0x87D8", Offset = "0x87D8", VA = "0x87D8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06003822 RID: 14370 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B11")]
		public Color[] CenterTexturePixels
		{
			[Token(Token = "0x6003822")]
			[Address(RVA = "0x87D9", Offset = "0x87D9", VA = "0x87D9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06003823 RID: 14371 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003824 RID: 14372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B12")]
		public CombatSpellData Spell
		{
			[Token(Token = "0x6003823")]
			[Address(RVA = "0x87DA", Offset = "0x87DA", VA = "0x87DA")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003824")]
			[Address(RVA = "0x87DB", Offset = "0x87DB", VA = "0x87DB")]
			set
			{
			}
		}

		// Token: 0x06003825 RID: 14373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003825")]
		[Address(RVA = "0x87DC", Offset = "0x87DC", VA = "0x87DC")]
		private void HandleSpellChanged()
		{
		}

		// Token: 0x06003826 RID: 14374 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003826")]
		[Address(RVA = "0x87DD", Offset = "0x87DD", VA = "0x87DD", Slot = "5")]
		protected virtual Sprite GetSprite(CombatSpellData spell)
		{
			return null;
		}

		// Token: 0x06003827 RID: 14375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003827")]
		[Address(RVA = "0x87DE", Offset = "0x87DE", VA = "0x87DE", Slot = "6")]
		protected virtual void Draw(List<Point> points, ref Texture2D targetTexture)
		{
		}

		// Token: 0x06003828 RID: 14376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003828")]
		[Address(RVA = "0x87DF", Offset = "0x87DF", VA = "0x87DF")]
		private void Awake()
		{
		}

		// Token: 0x06003829 RID: 14377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003829")]
		[Address(RVA = "0x87E0", Offset = "0x87E0", VA = "0x87E0", Slot = "4")]
		public void HandlePressRelease(IPlayerInput input)
		{
		}

		// Token: 0x0600382A RID: 14378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600382A")]
		[Address(RVA = "0x87E1", Offset = "0x87E1", VA = "0x87E1")]
		public SpellFieldFigure()
		{
		}

		// Token: 0x04001F03 RID: 7939
		[Token(Token = "0x4001F03")]
		public const int MAX_TEMPLATE_COLUMS = 11;

		// Token: 0x04001F04 RID: 7940
		[Token(Token = "0x4001F04")]
		public const int MAX_TEMPLATE_ROWS = 11;

		// Token: 0x04001F05 RID: 7941
		[Token(Token = "0x4001F05")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Texture2D _textureCenter;

		// Token: 0x04001F06 RID: 7942
		[Token(Token = "0x4001F06")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Texture2D _texture;

		// Token: 0x04001F07 RID: 7943
		[Token(Token = "0x4001F07")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SpriteRenderer _renderer;

		// Token: 0x04001F08 RID: 7944
		[Token(Token = "0x4001F08")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private BoxCollider2D _collider;

		// Token: 0x04001F09 RID: 7945
		[Token(Token = "0x4001F09")]
		[FieldOffset(Offset = "0x20")]
		private CombatSpellData _spell;

		// Token: 0x04001F0A RID: 7946
		[Token(Token = "0x4001F0A")]
		[FieldOffset(Offset = "0x24")]
		private Dictionary<uint, Sprite> _spritesCache;

		// Token: 0x04001F0B RID: 7947
		[Token(Token = "0x4001F0B")]
		[FieldOffset(Offset = "0x28")]
		private Color[] _texturePixels;

		// Token: 0x04001F0C RID: 7948
		[Token(Token = "0x4001F0C")]
		[FieldOffset(Offset = "0x2C")]
		private Color[] _centerTexturePixels;
	}
}
