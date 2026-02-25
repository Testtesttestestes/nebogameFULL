using System;
using System.Threading;
using Core.Animations;
using Core.Gameplay.Managers.Skins;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.SkinsV2
{
	// Token: 0x02000183 RID: 387
	[Token(Token = "0x2000183")]
	[AddComponentMenu("SkinsV2/GameAnimationSkin (Skin Resolver)")]
	[DisallowMultipleComponent]
	public class GameAnimationSkinResolver : AbstractSkinResolver<IGameAnimation, MonoBehaviour>
	{
		// Token: 0x06000AF3 RID: 2803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x5E15", Offset = "0x5E15", VA = "0x5E15")]
		private void SetSkinApr(GameObject value)
		{
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x5E16", Offset = "0x5E16", VA = "0x5E16", Slot = "4")]
		protected override void GetDefaultContent(IGameAnimation component, out AbstractSkinResolver<IGameAnimation, MonoBehaviour>.ContentInfo content)
		{
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x5E17", Offset = "0x5E17", VA = "0x5E17", Slot = "5")]
		protected override void Rollback(IGameAnimation component, MonoBehaviour content)
		{
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00003A50 File Offset: 0x00001C50
		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x5E18", Offset = "0x5E18", VA = "0x5E18", Slot = "6")]
		protected override UniTask<bool> TryResolve(IGameAnimation component, Skin skin, CancellationToken cancellationToken)
		{
			return default(UniTask<bool>);
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x5E19", Offset = "0x5E19", VA = "0x5E19")]
		public GameAnimationSkinResolver()
		{
		}

		// Token: 0x040004E0 RID: 1248
		[Token(Token = "0x40004E0")]
		[FieldOffset(Offset = "0x20")]
		private GameObject _skinApr;
	}
}
