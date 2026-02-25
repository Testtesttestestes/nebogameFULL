using System;
using System.Threading;
using Animations;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Rewards.Renderers
{
	// Token: 0x020001A5 RID: 421
	[Token(Token = "0x20001A5")]
	public class ArtifactViewAnimationHandler
	{
		// Token: 0x06000B87 RID: 2951 RVA: 0x00003C48 File Offset: 0x00001E48
		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x5EA1", Offset = "0x5EA1", VA = "0x5EA1")]
		public UniTask HandleAnimation(IAnimationProvider provider, Transform target)
		{
			return default(UniTask);
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00003C60 File Offset: 0x00001E60
		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x5EA2", Offset = "0x5EA2", VA = "0x5EA2")]
		public UniTask HandleAnimation(IAnimationProvider provider, Transform target, CancellationToken token)
		{
			return default(UniTask);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x5EA3", Offset = "0x5EA3", VA = "0x5EA3")]
		public ArtifactViewAnimationHandler()
		{
		}
	}
}
