using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine.U2D;

namespace Core.GameResources
{
	// Token: 0x02000EDB RID: 3803
	[Token(Token = "0x2000EDB")]
	public class AbstractGameSpriteAtlasLoader : AbstractGameResourceLoader<GameResourcesManager.SpriteAtlasReadyDelegate>
	{
		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x06005C84 RID: 23684 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005C85 RID: 23685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012BA")]
		public SpriteAtlas Atlas
		{
			[Token(Token = "0x6005C84")]
			[Address(RVA = "0xA918", Offset = "0xA918", VA = "0xA918")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005C85")]
			[Address(RVA = "0xA919", Offset = "0xA919", VA = "0xA919")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005C86 RID: 23686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C86")]
		[Address(RVA = "0xA91A", Offset = "0xA91A", VA = "0xA91A", Slot = "5")]
		protected override void CheckIfReady()
		{
		}

		// Token: 0x06005C87 RID: 23687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C87")]
		[Address(RVA = "0xA91B", Offset = "0xA91B", VA = "0xA91B", Slot = "6")]
		protected override void OnAssetBundleReady()
		{
		}

		// Token: 0x06005C88 RID: 23688 RVA: 0x00010980 File Offset: 0x0000EB80
		[Token(Token = "0x6005C88")]
		[Address(RVA = "0xA91C", Offset = "0xA91C", VA = "0xA91C", Slot = "9")]
		protected virtual UniTaskVoid ProcessAssetBundle(CancellationToken cancellationToken)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06005C89 RID: 23689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C89")]
		[Address(RVA = "0xA91D", Offset = "0xA91D", VA = "0xA91D", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x06005C8A RID: 23690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C8A")]
		[Address(RVA = "0xA91E", Offset = "0xA91E", VA = "0xA91E", Slot = "8")]
		protected override void ReleaseAssetBundle()
		{
		}

		// Token: 0x06005C8B RID: 23691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C8B")]
		[Address(RVA = "0xA91F", Offset = "0xA91F", VA = "0xA91F")]
		public AbstractGameSpriteAtlasLoader()
		{
		}

		// Token: 0x04003275 RID: 12917
		[Token(Token = "0x4003275")]
		[FieldOffset(Offset = "0x30")]
		protected GameResourceCancellationToken _cancel;
	}
}
