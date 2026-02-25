using System;
using System.Threading;
using Core.Gameplay.Managers.Skins;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI.SkinsV2
{
	// Token: 0x02000185 RID: 389
	[Token(Token = "0x2000185")]
	[AddComponentMenu("SkinsV2/ImageSkin (Skin Resolver)")]
	[DisallowMultipleComponent]
	public class ImageSkinResolver : AbstractSkinResolver<Image, Sprite>
	{
		// Token: 0x06000AFA RID: 2810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x5E1C", Offset = "0x5E1C", VA = "0x5E1C", Slot = "4")]
		protected override void GetDefaultContent(Image component, out AbstractSkinResolver<Image, Sprite>.ContentInfo content)
		{
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x5E1D", Offset = "0x5E1D", VA = "0x5E1D", Slot = "5")]
		protected override void Rollback(Image component, Sprite content)
		{
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x00003A68 File Offset: 0x00001C68
		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x5E1E", Offset = "0x5E1E", VA = "0x5E1E", Slot = "6")]
		protected override UniTask<bool> TryResolve(Image component, Skin skin, CancellationToken cancellationToken)
		{
			return default(UniTask<bool>);
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x5E1F", Offset = "0x5E1F", VA = "0x5E1F")]
		public ImageSkinResolver()
		{
		}
	}
}
