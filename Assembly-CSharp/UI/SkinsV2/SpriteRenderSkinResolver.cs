using System;
using System.Threading;
using Core.Gameplay.Managers.Skins;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.SkinsV2
{
	// Token: 0x0200018A RID: 394
	[Token(Token = "0x200018A")]
	[AddComponentMenu("SkinsV2/SpriteRenderSkin (Skin Resolver)")]
	[DisallowMultipleComponent]
	public class SpriteRenderSkinResolver : AbstractSkinResolver<SpriteRenderer, Sprite>
	{
		// Token: 0x06000B07 RID: 2823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x5E29", Offset = "0x5E29", VA = "0x5E29", Slot = "4")]
		protected override void GetDefaultContent(SpriteRenderer component, out AbstractSkinResolver<SpriteRenderer, Sprite>.ContentInfo content)
		{
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x5E2A", Offset = "0x5E2A", VA = "0x5E2A", Slot = "5")]
		protected override void Rollback(SpriteRenderer component, Sprite content)
		{
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00003A98 File Offset: 0x00001C98
		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x5E2B", Offset = "0x5E2B", VA = "0x5E2B", Slot = "6")]
		protected override UniTask<bool> TryResolve(SpriteRenderer component, Skin skin, CancellationToken cancellationToken)
		{
			return default(UniTask<bool>);
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0x5E2C", Offset = "0x5E2C", VA = "0x5E2C")]
		public SpriteRenderSkinResolver()
		{
		}
	}
}
